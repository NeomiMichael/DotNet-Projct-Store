﻿namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            manager = new Button();
            banker = new Button();
            SuspendLayout();
            // 
            // manager
            // 
            manager.Location = new Point(65, 104);
            manager.Name = "manager";
            manager.Size = new Size(278, 130);
            manager.TabIndex = 0;
            manager.Text = "מנהל";
            manager.UseVisualStyleBackColor = true;
            manager.Click += button1_Click;
            // 
            // banker
            // 
            banker.Location = new Point(473, 104);
            banker.Name = "banker";
            banker.Size = new Size(278, 130);
            banker.TabIndex = 1;
            banker.Text = "קופאי";
            banker.UseVisualStyleBackColor = true;
            banker.Click += banker_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(banker);
            Controls.Add(manager);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button manager;
        private Button banker;
    }
}
