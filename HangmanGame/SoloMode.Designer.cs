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
            this.tableLayoutPanelGlobal = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxHangman = new System.Windows.Forms.PictureBox();
            this.textBoxWordToFind = new System.Windows.Forms.TextBox();
            this.buttonValidationWord = new System.Windows.Forms.Button();
            this.tableLayoutPanelInformations = new System.Windows.Forms.TableLayoutPanel();
            this.pseudoTextBox = new System.Windows.Forms.TextBox();
            this.pseudoLabel = new System.Windows.Forms.Label();
            this.labelRemainsTries1 = new System.Windows.Forms.Label();
            this.labelRemainsTries2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).BeginInit();
            this.tableLayoutPanelInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGlobal
            // 
            this.tableLayoutPanelGlobal.ColumnCount = 3;
            this.tableLayoutPanelGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanelGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanelGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGlobal.Controls.Add(this.pictureBoxHangman, 0, 0);
            this.tableLayoutPanelGlobal.Controls.Add(this.textBoxWordToFind, 0, 1);
            this.tableLayoutPanelGlobal.Controls.Add(this.buttonValidationWord, 2, 1);
            this.tableLayoutPanelGlobal.Controls.Add(this.tableLayoutPanelInformations, 2, 0);
            this.tableLayoutPanelGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGlobal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGlobal.Name = "tableLayoutPanelGlobal";
            this.tableLayoutPanelGlobal.RowCount = 2;
            this.tableLayoutPanelGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanelGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelGlobal.Size = new System.Drawing.Size(812, 493);
            this.tableLayoutPanelGlobal.TabIndex = 0;
            // 
            // pictureBoxHangman
            // 
            this.pictureBoxHangman.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanelGlobal.SetColumnSpan(this.pictureBoxHangman, 2);
            this.pictureBoxHangman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHangman.Image = global::HangmanGame.Properties.Resources.Hangman_0;
            this.pictureBoxHangman.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHangman.Name = "pictureBoxHangman";
            this.pictureBoxHangman.Size = new System.Drawing.Size(554, 444);
            this.pictureBoxHangman.TabIndex = 0;
            this.pictureBoxHangman.TabStop = false;
            // 
            // textBoxWordToFind
            // 
            this.textBoxWordToFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWordToFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanelGlobal.SetColumnSpan(this.textBoxWordToFind, 2);
            this.textBoxWordToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxWordToFind.Location = new System.Drawing.Point(3, 458);
            this.textBoxWordToFind.MaxLength = 47;
            this.textBoxWordToFind.Name = "textBoxWordToFind";
            this.textBoxWordToFind.Size = new System.Drawing.Size(554, 26);
            this.textBoxWordToFind.TabIndex = 1;
            this.textBoxWordToFind.TextChanged += new System.EventHandler(this.textBoxWordToFind_TextChanged);
            this.textBoxWordToFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWordToFind_KeyPress);
            // 
            // buttonValidationWord
            // 
            this.buttonValidationWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonValidationWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonValidationWord.Location = new System.Drawing.Point(563, 453);
            this.buttonValidationWord.Name = "buttonValidationWord";
            this.buttonValidationWord.Size = new System.Drawing.Size(246, 37);
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
            this.tableLayoutPanelInformations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInformations.Location = new System.Drawing.Point(563, 3);
            this.tableLayoutPanelInformations.Name = "tableLayoutPanelInformations";
            this.tableLayoutPanelInformations.RowCount = 5;
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelInformations.Size = new System.Drawing.Size(246, 444);
            this.tableLayoutPanelInformations.TabIndex = 3;
            // 
            // pseudoTextBox
            // 
            this.pseudoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pseudoTextBox.Location = new System.Drawing.Point(3, 33);
            this.pseudoTextBox.Name = "pseudoTextBox";
            this.pseudoTextBox.Size = new System.Drawing.Size(240, 24);
            this.pseudoTextBox.TabIndex = 0;
            this.pseudoTextBox.TextChanged += new System.EventHandler(this.pseudoTextBox_TextChanged);
            // 
            // pseudoLabel
            // 
            this.pseudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pseudoLabel.AutoSize = true;
            this.pseudoLabel.Location = new System.Drawing.Point(3, 6);
            this.pseudoLabel.Name = "pseudoLabel";
            this.pseudoLabel.Size = new System.Drawing.Size(240, 18);
            this.pseudoLabel.TabIndex = 1;
            this.pseudoLabel.Text = "Entrez votre pseudo ici :";
            this.pseudoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRemainsTries1
            // 
            this.labelRemainsTries1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRemainsTries1.AutoSize = true;
            this.labelRemainsTries1.Location = new System.Drawing.Point(3, 66);
            this.labelRemainsTries1.Name = "labelRemainsTries1";
            this.labelRemainsTries1.Size = new System.Drawing.Size(240, 18);
            this.labelRemainsTries1.TabIndex = 2;
            this.labelRemainsTries1.Text = "Nombre d\'essais restant : ";
            this.labelRemainsTries1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRemainsTries2
            // 
            this.labelRemainsTries2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRemainsTries2.AutoSize = true;
            this.labelRemainsTries2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelRemainsTries2.Location = new System.Drawing.Point(3, 97);
            this.labelRemainsTries2.Name = "labelRemainsTries2";
            this.labelRemainsTries2.Size = new System.Drawing.Size(240, 36);
            this.labelRemainsTries2.TabIndex = 3;
            this.labelRemainsTries2.Text = "9";
            this.labelRemainsTries2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SoloMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 493);
            this.Controls.Add(this.tableLayoutPanelGlobal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(830, 540);
            this.Name = "SoloMode";
            this.Text = "HangMan";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoloMode_FormClosing);
            this.tableLayoutPanelGlobal.ResumeLayout(false);
            this.tableLayoutPanelGlobal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).EndInit();
            this.tableLayoutPanelInformations.ResumeLayout(false);
            this.tableLayoutPanelInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGlobal;
        private System.Windows.Forms.PictureBox pictureBoxHangman;
        private System.Windows.Forms.TextBox textBoxWordToFind;
        private System.Windows.Forms.Button buttonValidationWord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInformations;
        private System.Windows.Forms.TextBox pseudoTextBox;
        private System.Windows.Forms.Label pseudoLabel;
        private System.Windows.Forms.Label labelRemainsTries1;
        private System.Windows.Forms.Label labelRemainsTries2;
    }
}

