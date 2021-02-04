using System;
using System.Linq;
using System.Windows.Forms;

namespace FiveM_Default_Build
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string currentBuild = Program.GetCurrentBuild();

            foreach (RadioButton rb in Controls.OfType<RadioButton>())
            {
                rb.Checked = ((string)rb.Tag == currentBuild);
            }
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            string build = (string)Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Tag;

            if (build != null)
            {
                Program.SetDefaultBuild(build);
                MessageBox.Show($"FiveM build version set to {build}!", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Build version not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
