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
            this.tableLayoutPanelGlobal = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxHangman = new System.Windows.Forms.PictureBox();
            this.textBoxCharacterToVerify = new System.Windows.Forms.TextBox();
            this.buttonValidationWord = new System.Windows.Forms.Button();
            this.tableLayoutPanelInformations = new System.Windows.Forms.TableLayoutPanel();
            this.pseudoTextBox = new System.Windows.Forms.TextBox();
            this.pseudoLabel = new System.Windows.Forms.Label();
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
            this.tableLayoutPanelGlobal.ColumnCount = 3;
            this.tableLayoutPanelGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanelGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanelGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGlobal.Controls.Add(this.pictureBoxHangman, 0, 0);
            this.tableLayoutPanelGlobal.Controls.Add(this.textBoxCharacterToVerify, 0, 1);
            this.tableLayoutPanelGlobal.Controls.Add(this.buttonValidationWord, 2, 1);
            this.tableLayoutPanelGlobal.Controls.Add(this.tableLayoutPanelInformations, 2, 0);
            this.tableLayoutPanelGlobal.Controls.Add(this.labelElapsedTime, 0, 2);
            this.tableLayoutPanelGlobal.Controls.Add(this.labelWordToFind, 1, 1);
            this.tableLayoutPanelGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGlobal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGlobal.Name = "tableLayoutPanelGlobal";
            this.tableLayoutPanelGlobal.RowCount = 3;
            this.tableLayoutPanelGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanelGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelGlobal.Size = new System.Drawing.Size(812, 523);
            this.tableLayoutPanelGlobal.TabIndex = 0;
            // 
            // pictureBoxHangman
            // 
            this.pictureBoxHangman.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanelGlobal.SetColumnSpan(this.pictureBoxHangman, 2);
            this.pictureBoxHangman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHangman.Image = global::HangmanGame.Properties.Resources.Hangman0;
            this.pictureBoxHangman.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHangman.Name = "pictureBoxHangman";
            this.pictureBoxHangman.Size = new System.Drawing.Size(554, 444);
            this.pictureBoxHangman.TabIndex = 0;
            this.pictureBoxHangman.TabStop = false;
            // 
            // textBoxCharacterToVerify
            // 
            this.textBoxCharacterToVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCharacterToVerify.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCharacterToVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCharacterToVerify.Location = new System.Drawing.Point(3, 458);
            this.textBoxCharacterToVerify.MaxLength = 1;
            this.textBoxCharacterToVerify.Name = "textBoxCharacterToVerify";
            this.textBoxCharacterToVerify.Size = new System.Drawing.Size(274, 23);
            this.textBoxCharacterToVerify.TabIndex = 1;
            this.textBoxCharacterToVerify.TextChanged += new System.EventHandler(this.textBoxWordToFind_TextChanged);
            this.textBoxCharacterToVerify.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWordToFind_KeyPress);
            // 
            // buttonValidationWord
            // 
            this.buttonValidationWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonValidationWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonValidationWord.Location = new System.Drawing.Point(563, 453);
            this.buttonValidationWord.Name = "buttonValidationWord";
            this.tableLayoutPanelGlobal.SetRowSpan(this.buttonValidationWord, 2);
            this.buttonValidationWord.Size = new System.Drawing.Size(246, 67);
            this.buttonValidationWord.TabIndex = 2;
            this.buttonValidationWord.Text = "Valider";
            this.buttonValidationWord.UseVisualStyleBackColor = true;
            this.buttonValidationWord.Click += new System.EventHandler(this.buttonValidationWord_Click);
            // 
            // tableLayoutPanelInformations
            // 
            this.tableLayoutPanelInformations.ColumnCount = 1;
            this.tableLayoutPanelInformations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInformations.Controls.Add(this.pseudoTextBox, 0, 1);
            this.tableLayoutPanelInformations.Controls.Add(this.pseudoLabel, 0, 0);
            this.tableLayoutPanelInformations.Controls.Add(this.labelRemainsTries1, 0, 2);
            this.tableLayoutPanelInformations.Controls.Add(this.labelRemainsTries2, 0, 3);
            this.tableLayoutPanelInformations.Controls.Add(this.dataGridViewWrongLetters, 0, 4);
            this.tableLayoutPanelInformations.Controls.Add(this.labelWordToFindLength, 0, 5);
            this.tableLayoutPanelInformations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInformations.Location = new System.Drawing.Point(563, 3);
            this.tableLayoutPanelInformations.Name = "tableLayoutPanelInformations";
            this.tableLayoutPanelInformations.RowCount = 6;
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelInformations.Size = new System.Drawing.Size(246, 444);
            this.tableLayoutPanelInformations.TabIndex = 3;
            // 
            // pseudoTextBox
            // 
            this.pseudoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pseudoTextBox.Location = new System.Drawing.Point(3, 33);
            this.pseudoTextBox.Name = "pseudoTextBox";
            this.pseudoTextBox.Size = new System.Drawing.Size(240, 21);
            this.pseudoTextBox.TabIndex = 0;
            this.pseudoTextBox.TextChanged += new System.EventHandler(this.pseudoTextBox_TextChanged);
            // 
            // pseudoLabel
            // 
            this.pseudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pseudoLabel.AutoSize = true;
            this.pseudoLabel.Location = new System.Drawing.Point(3, 7);
            this.pseudoLabel.Name = "pseudoLabel";
            this.pseudoLabel.Size = new System.Drawing.Size(240, 15);
            this.pseudoLabel.TabIndex = 1;
            this.pseudoLabel.Text = "Entrez votre pseudo ici :";
            this.pseudoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRemainsTries1
            // 
            this.labelRemainsTries1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRemainsTries1.AutoSize = true;
            this.labelRemainsTries1.Location = new System.Drawing.Point(3, 67);
            this.labelRemainsTries1.Name = "labelRemainsTries1";
            this.labelRemainsTries1.Size = new System.Drawing.Size(240, 15);
            this.labelRemainsTries1.TabIndex = 2;
            this.labelRemainsTries1.Text = "Nombre d\'essais restant : ";
            this.labelRemainsTries1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRemainsTries2
            // 
            this.labelRemainsTries2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRemainsTries2.AutoSize = true;
            this.labelRemainsTries2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelRemainsTries2.Location = new System.Drawing.Point(3, 100);
            this.labelRemainsTries2.Name = "labelRemainsTries2";
            this.labelRemainsTries2.Size = new System.Drawing.Size(240, 29);
            this.labelRemainsTries2.TabIndex = 3;
            this.labelRemainsTries2.Text = "8";
            this.labelRemainsTries2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewWrongLetters
            // 
            this.dataGridViewWrongLetters.AllowUserToDeleteRows = false;
            this.dataGridViewWrongLetters.AllowUserToOrderColumns = true;
            this.dataGridViewWrongLetters.BackgroundColor = System.Drawing.Color.Green;
            this.dataGridViewWrongLetters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWrongLetters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Letter});
            this.dataGridViewWrongLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWrongLetters.Location = new System.Drawing.Point(3, 143);
            this.dataGridViewWrongLetters.Name = "dataGridViewWrongLetters";
            this.dataGridViewWrongLetters.ReadOnly = true;
            this.dataGridViewWrongLetters.RowTemplate.Height = 24;
            this.dataGridViewWrongLetters.Size = new System.Drawing.Size(240, 268);
            this.dataGridViewWrongLetters.TabIndex = 4;
            // 
            // Letter
            // 
            this.Letter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Letter.HeaderText = "Lettres";
            this.Letter.Name = "Letter";
            this.Letter.ReadOnly = true;
            this.Letter.ToolTipText = "Chaque caractères déjà essayé est affiché ici.";
            // 
            // labelWordToFindLength
            // 
            this.labelWordToFindLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWordToFindLength.AutoSize = true;
            this.labelWordToFindLength.Location = new System.Drawing.Point(3, 421);
            this.labelWordToFindLength.Name = "labelWordToFindLength";
            this.labelWordToFindLength.Size = new System.Drawing.Size(240, 15);
            this.labelWordToFindLength.TabIndex = 5;
            this.labelWordToFindLength.Text = "Longueur du mot : ";
            // 
            // labelElapsedTime
            // 
            this.labelElapsedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelElapsedTime.AutoSize = true;
            this.tableLayoutPanelGlobal.SetColumnSpan(this.labelElapsedTime, 2);
            this.labelElapsedTime.Location = new System.Drawing.Point(3, 499);
            this.labelElapsedTime.Name = "labelElapsedTime";
            this.labelElapsedTime.Size = new System.Drawing.Size(554, 15);
            this.labelElapsedTime.TabIndex = 5;
            this.labelElapsedTime.Text = "Temps écoulé : ";
            this.labelElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWordToFind
            // 
            this.labelWordToFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWordToFind.AutoSize = true;
            this.labelWordToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelWordToFind.Location = new System.Drawing.Point(283, 460);
            this.labelWordToFind.Name = "labelWordToFind";
            this.labelWordToFind.Size = new System.Drawing.Size(274, 20);
            this.labelWordToFind.TabIndex = 6;
            // 
            // timerRefreshElapsedTime
            // 
            this.timerRefreshElapsedTime.Enabled = true;
            this.timerRefreshElapsedTime.Interval = 1000;
            this.timerRefreshElapsedTime.Tick += new System.EventHandler(this.timerRefreshElapsedTime_Tick);
            // 
            // SoloMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 523);
            this.Controls.Add(this.tableLayoutPanelGlobal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(830, 570);
            this.Name = "SoloMode";
            this.Text = "HangMan";
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
        private System.Windows.Forms.TextBox pseudoTextBox;
        private System.Windows.Forms.Label pseudoLabel;
        private System.Windows.Forms.Label labelRemainsTries1;
        private System.Windows.Forms.Label labelRemainsTries2;
        private System.Windows.Forms.DataGridView dataGridViewWrongLetters;
        private System.Windows.Forms.BindingSource pendudatabaseDataSetBindingSource;
        private System.Windows.Forms.Label labelWordToFindLength;
		private System.Windows.Forms.DataGridViewTextBoxColumn Letter;
		private System.Windows.Forms.Label labelElapsedTime;
		private System.Windows.Forms.Timer timerRefreshElapsedTime;
        private System.Windows.Forms.Label labelWordToFind;
    }
}

