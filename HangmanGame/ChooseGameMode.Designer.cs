﻿namespace HangmanGame
{
    partial class ChooseGameMode
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseGameMode));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonVersusMode = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonSoloMode = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.buttonVersusMode, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonSoloMode, 0, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// buttonVersusMode
			// 
			resources.ApplyResources(this.buttonVersusMode, "buttonVersusMode");
			this.buttonVersusMode.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonVersusMode.Name = "buttonVersusMode";
			this.buttonVersusMode.UseVisualStyleBackColor = true;
			this.buttonVersusMode.Click += new System.EventHandler(this.buttonVersusMode_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
			this.label1.Name = "label1";
			// 
			// buttonSoloMode
			// 
			resources.ApplyResources(this.buttonSoloMode, "buttonSoloMode");
			this.buttonSoloMode.Name = "buttonSoloMode";
			this.buttonSoloMode.UseVisualStyleBackColor = true;
			this.buttonSoloMode.Click += new System.EventHandler(this.buttonSoloMode_Click);
			// 
			// ChooseGameMode
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ChooseGameMode";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonVersusMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSoloMode;
    }
}