namespace HangmanGame
{
    partial class SoloMode
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoloMode));
			this.tableLayoutPanelGlobal = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBoxHangman = new System.Windows.Forms.PictureBox();
			this.textBoxCharacterToVerify = new System.Windows.Forms.TextBox();
			this.buttonValidationWord = new System.Windows.Forms.Button();
			this.tableLayoutPanelInformations = new System.Windows.Forms.TableLayoutPanel();
			this.labelRemainsTries1 = new System.Windows.Forms.Label();
			this.labelRemainsTries2 = new System.Windows.Forms.Label();
			this.dataGridViewWrongLetters = new System.Windows.Forms.DataGridView();
			this.Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labelWordToFindLength = new System.Windows.Forms.Label();
			this.labelElapsedTime = new System.Windows.Forms.Label();
			this.labelWordToFind = new System.Windows.Forms.Label();
			this.timerRefreshElapsedTime = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanelGlobal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).BeginInit();
			this.tableLayoutPanelInformations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewWrongLetters)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanelGlobal
			// 
			resources.ApplyResources(this.tableLayoutPanelGlobal, "tableLayoutPanelGlobal");
			this.tableLayoutPanelGlobal.Controls.Add(this.pictureBoxHangman, 0, 0);
			this.tableLayoutPanelGlobal.Controls.Add(this.textBoxCharacterToVerify, 0, 1);
			this.tableLayoutPanelGlobal.Controls.Add(this.buttonValidationWord, 2, 1);
			this.tableLayoutPanelGlobal.Controls.Add(this.tableLayoutPanelInformations, 2, 0);
			this.tableLayoutPanelGlobal.Controls.Add(this.labelElapsedTime, 0, 2);
			this.tableLayoutPanelGlobal.Controls.Add(this.labelWordToFind, 1, 1);
			this.tableLayoutPanelGlobal.Name = "tableLayoutPanelGlobal";
			// 
			// pictureBoxHangman
			// 
			resources.ApplyResources(this.pictureBoxHangman, "pictureBoxHangman");
			this.pictureBoxHangman.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.tableLayoutPanelGlobal.SetColumnSpan(this.pictureBoxHangman, 2);
			this.pictureBoxHangman.Image = global::HangmanGame.Properties.Resources.Hangman0;
			this.pictureBoxHangman.Name = "pictureBoxHangman";
			this.pictureBoxHangman.TabStop = false;
			// 
			// textBoxCharacterToVerify
			// 
			resources.ApplyResources(this.textBoxCharacterToVerify, "textBoxCharacterToVerify");
			this.textBoxCharacterToVerify.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBoxCharacterToVerify.Name = "textBoxCharacterToVerify";
			this.textBoxCharacterToVerify.TextChanged += new System.EventHandler(this.textBoxWordToFind_TextChanged);
			this.textBoxCharacterToVerify.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWordToFind_KeyPress);
			// 
			// buttonValidationWord
			// 
			resources.ApplyResources(this.buttonValidationWord, "buttonValidationWord");
			this.buttonValidationWord.Name = "buttonValidationWord";
			this.tableLayoutPanelGlobal.SetRowSpan(this.buttonValidationWord, 2);
			this.buttonValidationWord.UseVisualStyleBackColor = true;
			this.buttonValidationWord.Click += new System.EventHandler(this.buttonValidationWord_Click);
			// 
			// tableLayoutPanelInformations
			// 
			resources.ApplyResources(this.tableLayoutPanelInformations, "tableLayoutPanelInformations");
			this.tableLayoutPanelInformations.Controls.Add(this.dataGridViewWrongLetters, 0, 2);
			this.tableLayoutPanelInformations.Controls.Add(this.labelWordToFindLength, 0, 5);
			this.tableLayoutPanelInformations.Controls.Add(this.labelRemainsTries1, 0, 0);
			this.tableLayoutPanelInformations.Controls.Add(this.labelRemainsTries2, 0, 1);
			this.tableLayoutPanelInformations.Name = "tableLayoutPanelInformations";
			// 
			// labelRemainsTries1
			// 
			resources.ApplyResources(this.labelRemainsTries1, "labelRemainsTries1");
			this.labelRemainsTries1.Name = "labelRemainsTries1";
			// 
			// labelRemainsTries2
			// 
			resources.ApplyResources(this.labelRemainsTries2, "labelRemainsTries2");
			this.labelRemainsTries2.Name = "labelRemainsTries2";
			// 
			// dataGridViewWrongLetters
			// 
			resources.ApplyResources(this.dataGridViewWrongLetters, "dataGridViewWrongLetters");
			this.dataGridViewWrongLetters.AllowUserToDeleteRows = false;
			this.dataGridViewWrongLetters.AllowUserToOrderColumns = true;
			this.dataGridViewWrongLetters.BackgroundColor = System.Drawing.Color.Green;
			this.dataGridViewWrongLetters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewWrongLetters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Letter});
			this.dataGridViewWrongLetters.Name = "dataGridViewWrongLetters";
			this.dataGridViewWrongLetters.ReadOnly = true;
			this.tableLayoutPanelInformations.SetRowSpan(this.dataGridViewWrongLetters, 3);
			this.dataGridViewWrongLetters.RowTemplate.Height = 24;
			// 
			// Letter
			// 
			this.Letter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			resources.ApplyResources(this.Letter, "Letter");
			this.Letter.Name = "Letter";
			this.Letter.ReadOnly = true;
			// 
			// labelWordToFindLength
			// 
			resources.ApplyResources(this.labelWordToFindLength, "labelWordToFindLength");
			this.labelWordToFindLength.Name = "labelWordToFindLength";
			// 
			// labelElapsedTime
			// 
			resources.ApplyResources(this.labelElapsedTime, "labelElapsedTime");
			this.tableLayoutPanelGlobal.SetColumnSpan(this.labelElapsedTime, 2);
			this.labelElapsedTime.Name = "labelElapsedTime";
			// 
			// labelWordToFind
			// 
			resources.ApplyResources(this.labelWordToFind, "labelWordToFind");
			this.labelWordToFind.Name = "labelWordToFind";
			// 
			// timerRefreshElapsedTime
			// 
			this.timerRefreshElapsedTime.Enabled = true;
			this.timerRefreshElapsedTime.Interval = 1000;
			this.timerRefreshElapsedTime.Tick += new System.EventHandler(this.timerRefreshElapsedTime_Tick);
			// 
			// SoloMode
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelGlobal);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "SoloMode";
			this.TransparencyKey = System.Drawing.Color.DarkRed;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoloMode_FormClosing);
			this.tableLayoutPanelGlobal.ResumeLayout(false);
			this.tableLayoutPanelGlobal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).EndInit();
			this.tableLayoutPanelInformations.ResumeLayout(false);
			this.tableLayoutPanelInformations.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewWrongLetters)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGlobal;
        private System.Windows.Forms.PictureBox pictureBoxHangman;
        private System.Windows.Forms.TextBox textBoxCharacterToVerify;
        private System.Windows.Forms.Button buttonValidationWord;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInformations;
        private System.Windows.Forms.Label labelRemainsTries1;
        private System.Windows.Forms.Label labelRemainsTries2;
        private System.Windows.Forms.DataGridView dataGridViewWrongLetters;
        private System.Windows.Forms.Label labelWordToFindLength;
		private System.Windows.Forms.DataGridViewTextBoxColumn Letter;
		private System.Windows.Forms.Label labelElapsedTime;
		private System.Windows.Forms.Timer timerRefreshElapsedTime;
        private System.Windows.Forms.Label labelWordToFind;
    }
}

