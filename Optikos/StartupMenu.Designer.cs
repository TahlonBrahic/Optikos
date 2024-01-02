namespace Optikos
{
    partial class StartupMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupMenu));
            this.mlModelsButton = new System.Windows.Forms.Button();
            this.voiceAssistantButton = new System.Windows.Forms.Button();
            this.pythonGamesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mlModelsButton
            // 
            this.mlModelsButton.Location = new System.Drawing.Point(243, 324);
            this.mlModelsButton.Name = "mlModelsButton";
            this.mlModelsButton.Size = new System.Drawing.Size(267, 66);
            this.mlModelsButton.TabIndex = 0;
            this.mlModelsButton.Text = "View ML Models";
            this.mlModelsButton.UseVisualStyleBackColor = true;
            this.mlModelsButton.Click += new System.EventHandler(this.mlModelsButton_Click);
            // 
            // voiceAssistantButton
            // 
            this.voiceAssistantButton.Location = new System.Drawing.Point(813, 324);
            this.voiceAssistantButton.Name = "voiceAssistantButton";
            this.voiceAssistantButton.Size = new System.Drawing.Size(267, 66);
            this.voiceAssistantButton.TabIndex = 1;
            this.voiceAssistantButton.Text = "Launch Voice Assistant";
            this.voiceAssistantButton.UseVisualStyleBackColor = true;
            this.voiceAssistantButton.Click += new System.EventHandler(this.voiceAssistantButton_Click);
            // 
            // pythonGamesButton
            // 
            this.pythonGamesButton.Location = new System.Drawing.Point(1365, 324);
            this.pythonGamesButton.Name = "pythonGamesButton";
            this.pythonGamesButton.Size = new System.Drawing.Size(267, 66);
            this.pythonGamesButton.TabIndex = 2;
            this.pythonGamesButton.Text = "View Python Games";
            this.pythonGamesButton.UseVisualStyleBackColor = true;
            this.pythonGamesButton.Click += new System.EventHandler(this.pythonGamesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.pythonGamesButton);
            this.Controls.Add(this.voiceAssistantButton);
            this.Controls.Add(this.mlModelsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Optikos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mlModelsButton;
        private System.Windows.Forms.Button voiceAssistantButton;
        private System.Windows.Forms.Button pythonGamesButton;
    }
}

