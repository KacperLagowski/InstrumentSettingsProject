﻿namespace InstrumentSettingsProject
{
    partial class Form1
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
            this.instrumentSettingsControl1 = new InstrumentSettingsProject.InstrumentSettingsControl();
            this.SuspendLayout();
            // 
            // instrumentSettingsControl1
            // 
            this.instrumentSettingsControl1.Location = new System.Drawing.Point(3, 12);
            this.instrumentSettingsControl1.Name = "instrumentSettingsControl1";
            this.instrumentSettingsControl1.Size = new System.Drawing.Size(969, 880);
            this.instrumentSettingsControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 894);
            this.Controls.Add(this.instrumentSettingsControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private InstrumentSettingsControl instrumentSettingsControl1;
    }
}

