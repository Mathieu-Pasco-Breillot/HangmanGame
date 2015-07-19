namespace HangmanGame
{
    partial class VersusMode
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersusMode));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonValidateWordToFind = new System.Windows.Forms.Button();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.maskedTextBoxWordToFind = new System.Windows.Forms.MaskedTextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.buttonValidateWordToFind, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.maskedTextBox1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxWordToFind, 0, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// buttonValidateWordToFind
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.buttonValidateWordToFind, 2);
			resources.ApplyResources(this.buttonValidateWordToFind, "buttonValidateWordToFind");
			this.buttonValidateWordToFind.Name = "buttonValidateWordToFind";
			this.buttonValidateWordToFind.UseVisualStyleBackColor = true;
			this.buttonValidateWordToFind.Click += new System.EventHandler(this.buttonValidateWordToFind_Click);
			// 
			// maskedTextBox1
			// 
			resources.ApplyResources(this.maskedTextBox1, "maskedTextBox1");
			this.tableLayoutPanel1.SetColumnSpan(this.maskedTextBox1, 2);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxWordToFind_KeyPress);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
			this.label2.Name = "label2";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
			this.label1.Name = "label1";
			// 
			// maskedTextBoxWordToFind
			// 
			resources.ApplyResources(this.maskedTextBoxWordToFind, "maskedTextBoxWordToFind");
			this.tableLayoutPanel1.SetColumnSpan(this.maskedTextBoxWordToFind, 2);
			this.maskedTextBoxWordToFind.Name = "maskedTextBoxWordToFind";
			this.maskedTextBoxWordToFind.TextChanged += new System.EventHandler(this.maskedTextBoxWordToFind_TextChanged);
			this.maskedTextBoxWordToFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxWordToFind_KeyPress);
			// 
			// VersusMode
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "VersusMode";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VersusMode_FormClosing);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWordToFind;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonValidateWordToFind;
    }
}