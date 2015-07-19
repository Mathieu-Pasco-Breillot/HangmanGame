namespace HangmanGame
{
	partial class Score
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.labelFinal = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.pseudoLabel = new System.Windows.Forms.Label();
			this.buttonRestart = new System.Windows.Forms.Button();
			this.pseudoTextBox = new System.Windows.Forms.TextBox();
			this.buttonSaveRestart = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.labelFinal);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(443, 182);
			this.splitContainer1.SplitterDistance = 60;
			this.splitContainer1.TabIndex = 0;
			// 
			// labelFinal
			// 
			this.labelFinal.AutoSize = true;
			this.labelFinal.Location = new System.Drawing.Point(144, 9);
			this.labelFinal.Name = "labelFinal";
			this.labelFinal.Size = new System.Drawing.Size(127, 26);
			this.labelFinal.TabIndex = 0;
			this.labelFinal.Text = "Vous avez trouvé le mot !\r\nVotre score : \t\r\n";
			this.labelFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
			this.tableLayoutPanel1.Controls.Add(this.buttonClose, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.pseudoLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonRestart, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.pseudoTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonSaveRestart, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 118);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(337, 77);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(103, 23);
			this.buttonClose.TabIndex = 11;
			this.buttonClose.Text = "Quitter";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// pseudoLabel
			// 
			this.pseudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.pseudoLabel.AutoSize = true;
			this.pseudoLabel.Location = new System.Drawing.Point(3, 23);
			this.pseudoLabel.Name = "pseudoLabel";
			this.pseudoLabel.Size = new System.Drawing.Size(161, 13);
			this.pseudoLabel.TabIndex = 8;
			this.pseudoLabel.Text = "Entrez votre pseudo ici :";
			this.pseudoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonRestart
			// 
			this.buttonRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRestart.Location = new System.Drawing.Point(170, 77);
			this.buttonRestart.Name = "buttonRestart";
			this.buttonRestart.Size = new System.Drawing.Size(161, 23);
			this.buttonRestart.TabIndex = 10;
			this.buttonRestart.Text = "Recommencer";
			this.buttonRestart.UseVisualStyleBackColor = true;
			this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
			// 
			// pseudoTextBox
			// 
			this.pseudoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.pseudoTextBox, 2);
			this.pseudoTextBox.Location = new System.Drawing.Point(170, 19);
			this.pseudoTextBox.MaxLength = 100;
			this.pseudoTextBox.Name = "pseudoTextBox";
			this.pseudoTextBox.Size = new System.Drawing.Size(270, 20);
			this.pseudoTextBox.TabIndex = 7;
			// 
			// buttonSaveRestart
			// 
			this.buttonSaveRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSaveRestart.Location = new System.Drawing.Point(3, 76);
			this.buttonSaveRestart.Name = "buttonSaveRestart";
			this.buttonSaveRestart.Size = new System.Drawing.Size(161, 24);
			this.buttonSaveRestart.TabIndex = 9;
			this.buttonSaveRestart.Text = "Valider et Recommencer";
			this.buttonSaveRestart.UseVisualStyleBackColor = true;
			this.buttonSaveRestart.Click += new System.EventHandler(this.buttonSaveRestart_Click);
			// 
			// Score
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 182);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Score";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Score";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label labelFinal;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Label pseudoLabel;
		private System.Windows.Forms.Button buttonRestart;
		private System.Windows.Forms.TextBox pseudoTextBox;
		private System.Windows.Forms.Button buttonSaveRestart;
	}
}