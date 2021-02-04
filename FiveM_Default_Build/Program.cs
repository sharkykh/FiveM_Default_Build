using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            Application.Run(new MainForm());
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
