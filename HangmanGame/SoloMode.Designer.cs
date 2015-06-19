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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxHangman = new System.Windows.Forms.PictureBox();
            this.textBoxWordToFind = new System.Windows.Forms.TextBox();
            this.buttonValidationWord = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxHangman, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxWordToFind, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonValidationWord, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 495);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxHangman
            // 
            this.pictureBoxHangman.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxHangman, 3);
            this.pictureBoxHangman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHangman.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHangman.Name = "pictureBoxHangman";
            this.pictureBoxHangman.Size = new System.Drawing.Size(474, 450);
            this.pictureBoxHangman.TabIndex = 0;
            this.pictureBoxHangman.TabStop = false;
            // 
            // textBoxWordToFind
            // 
            this.textBoxWordToFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWordToFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxWordToFind, 2);
            this.textBoxWordToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxWordToFind.Location = new System.Drawing.Point(3, 462);
            this.textBoxWordToFind.MaxLength = 47;
            this.textBoxWordToFind.Name = "textBoxWordToFind";
            this.textBoxWordToFind.Size = new System.Drawing.Size(374, 26);
            this.textBoxWordToFind.TabIndex = 1;
            this.textBoxWordToFind.TextChanged += new System.EventHandler(this.textBoxWordToFind_TextChanged);
            this.textBoxWordToFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWordToFind_KeyPress);
            // 
            // buttonValidationWord
            // 
            this.buttonValidationWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonValidationWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonValidationWord.Location = new System.Drawing.Point(383, 459);
            this.buttonValidationWord.Name = "buttonValidationWord";
            this.buttonValidationWord.Size = new System.Drawing.Size(94, 33);
            this.buttonValidationWord.TabIndex = 2;
            this.buttonValidationWord.Text = "Valider";
            this.buttonValidationWord.UseVisualStyleBackColor = true;
            this.buttonValidationWord.Click += new System.EventHandler(this.buttonValidationWord_Click);
            // 
            // SoloMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SoloMode";
            this.Text = "HangMan";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoloMode_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxHangman;
        private System.Windows.Forms.TextBox textBoxWordToFind;
        private System.Windows.Forms.Button buttonValidationWord;
    }
}

