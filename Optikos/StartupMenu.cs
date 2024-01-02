using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Optikos
{
    public partial class StartupMenu : Form
    {
        public StartupMenu()
        {
            InitializeComponent();
            InitializeUI('UIMode');
        }

        private void InitializeUI(string key)
        {
            try
            {
                var uiMode = ConfigurationManager.AppSettings[key];
                if (uiMode == "dark")
                {
                    this.ForeColor.FromArgb(47 ,54, 64)
                    this.BackColor.FromArgb(245, 246, 250)
                }
            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        private void mlModelsButton_Click(object sender, EventArgs e)
        {
            mlModelsButton.ForeColor = Color.Purple;
        }

        private void voiceAssistantButton_Click(object sender, EventArgs e)
        {

        }

        private void pythonGamesButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
