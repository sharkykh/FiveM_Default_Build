using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using IniParser;
using IniParser.Model;
using Microsoft.Win32;

namespace FiveM_Default_Build
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            Application.Run(new SavedBuildNumberForm());
        }

        static readonly string fivemPath = @"SOFTWARE\CitizenFX\FiveM";

        private static string CitizenFXINIPath()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(fivemPath, false))
            {
                string path = (string)key.GetValue("Last Run Location");

                return Path.Combine(path, "CitizenFX.ini");
            }
        }

        public static string GetSavedBuild()
        {
            string path = CitizenFXINIPath();
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(path);

            var value = data["Game"]["SavedBuildNumber"];
            if (value == null)
            {
                return "Unset";
            }
            return value;
        }

        public static void SetSavedBuild(string build)
        {
            if (!(build == "Unset" || build == "1604" || build == "2060" || build == "2189"))
            {
                return;
            }

            string path = CitizenFXINIPath();
            var parser = new FileIniDataParser();
            parser.Parser.Configuration.AssigmentSpacer = "";
            IniData data = parser.ReadFile(path);

            if (build == "Unset")
            {
                data["Game"].RemoveKey("SavedBuildNumber");
            }
            else
            {
                data["Game"]["SavedBuildNumber"] = build;
            }

            parser.WriteFile(path, data);
        }

        static readonly string protocolPath = @"SOFTWARE\Classes\FiveM.ProtocolHandler\shell\open\command";

        static readonly Regex buildSwitchRegex = new Regex(@" -b(\d+)", RegexOptions.Compiled);

        public static string GetCurrentBuild()
        {

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(protocolPath, false))
            {
                string value = (string)key.GetValue(null);
                Match match = buildSwitchRegex.Match(value);

                if (!match.Success)
                    return "Default";

                return match.Groups[1].Value;
            }
        }

        public static void SetDefaultBuild(string build)
        {
            if (!(build == "Default" || build == "2060" || build == "2189"))
            {
                return;
            }

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(protocolPath, true))
            {
                string currentValue = (string)key.GetValue(null);
                string newValue;

                Match match = buildSwitchRegex.Match(currentValue);

                string repl = (build == "Default") ? "" : $" -b{build}";

                if (match.Success)
                {
                    newValue = buildSwitchRegex.Replace(currentValue, repl);
                }
                else
                {
                    newValue = currentValue + repl;
                }

                key.SetValue(null, newValue);
            }
        }
    }
}
