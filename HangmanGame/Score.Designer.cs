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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Score));
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
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
			this.splitContainer1.Panel1.Controls.Add(this.labelFinal);
			// 
			// splitContainer1.Panel2
			// 
			resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			// 
			// labelFinal
			// 
			resources.ApplyResources(this.labelFinal, "labelFinal");
			this.labelFinal.Name = "labelFinal";
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.buttonClose, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.pseudoLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonRestart, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.pseudoTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonSaveRestart, 0, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// buttonClose
			// 
			resources.ApplyResources(this.buttonClose, "buttonClose");
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// pseudoLabel
			// 
			resources.ApplyResources(this.pseudoLabel, "pseudoLabel");
			this.pseudoLabel.Name = "pseudoLabel";
			// 
			// buttonRestart
			// 
			resources.ApplyResources(this.buttonRestart, "buttonRestart");
			this.buttonRestart.Name = "buttonRestart";
			this.buttonRestart.UseVisualStyleBackColor = true;
			this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
			// 
			// pseudoTextBox
			// 
			resources.ApplyResources(this.pseudoTextBox, "pseudoTextBox");
			this.tableLayoutPanel1.SetColumnSpan(this.pseudoTextBox, 2);
			this.pseudoTextBox.Name = "pseudoTextBox";
			// 
			// buttonSaveRestart
			// 
			resources.ApplyResources(this.buttonSaveRestart, "buttonSaveRestart");
			this.buttonSaveRestart.Name = "buttonSaveRestart";
			this.buttonSaveRestart.UseVisualStyleBackColor = true;
			this.buttonSaveRestart.Click += new System.EventHandler(this.buttonSaveRestart_Click);
			// 
			// Score
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClose;
			this.ControlBox = false;
			this.Controls.Add(this.splitContainer1);
			this.Name = "Score";
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