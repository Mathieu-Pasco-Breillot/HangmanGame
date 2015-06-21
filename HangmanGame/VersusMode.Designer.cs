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
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonValidateWordToFind, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxWordToFind, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonValidateWordToFind
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonValidateWordToFind, 2);
            this.buttonValidateWordToFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonValidateWordToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonValidateWordToFind.Location = new System.Drawing.Point(3, 135);
            this.buttonValidateWordToFind.Name = "buttonValidateWordToFind";
            this.buttonValidateWordToFind.Size = new System.Drawing.Size(293, 62);
            this.buttonValidateWordToFind.TabIndex = 5;
            this.buttonValidateWordToFind.Text = "Valider";
            this.buttonValidateWordToFind.UseVisualStyleBackColor = true;
            this.buttonValidateWordToFind.Click += new System.EventHandler(this.buttonValidateWordToFind_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.maskedTextBox1, 2);
            this.maskedTextBox1.Location = new System.Drawing.Point(3, 104);
            this.maskedTextBox1.Mask = "09";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(293, 22);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.Text = "5";
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxWordToFind_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entrez le nombre d\'essais autorisé :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entré le mot à trouver :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBoxWordToFind
            // 
            this.maskedTextBoxWordToFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.maskedTextBoxWordToFind, 2);
            this.maskedTextBoxWordToFind.Location = new System.Drawing.Point(3, 38);
            this.maskedTextBoxWordToFind.Mask = ">?L?L?L?L?L?L?L?L?L?L?L?L?L?L?L?L";
            this.maskedTextBoxWordToFind.Name = "maskedTextBoxWordToFind";
            this.maskedTextBoxWordToFind.Size = new System.Drawing.Size(293, 22);
            this.maskedTextBoxWordToFind.TabIndex = 1;
            this.maskedTextBoxWordToFind.TextChanged += new System.EventHandler(this.maskedTextBoxWordToFind_TextChanged);
            this.maskedTextBoxWordToFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxWordToFind_KeyPress);
            // 
            // VersusMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 200);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VersusMode";
            this.Text = "VersusMode";
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