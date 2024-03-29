﻿using System;
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
        }


        private void mlModelsButton_Click(object sender, EventArgs e)
        {
            MachineLearningModelsViewer machineLearningModelsViewer = new MachineLearningModelsViewer();
            machineLearningModelsViewer.Show();
        }

        private void voiceAssistantButton_Click(object sender, EventArgs e)
        {
           VoiceAssistantLauncher voiceAssistantLauncher = new VoiceAssistantLauncher();
           voiceAssistantLauncher.Show();
        }

        private void pythonGamesButton_Click(object sender, EventArgs e)
        {
            PythonGamesLauncher pythonGamesLauncher = new PythonGamesLauncher();
            pythonGamesLauncher.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
