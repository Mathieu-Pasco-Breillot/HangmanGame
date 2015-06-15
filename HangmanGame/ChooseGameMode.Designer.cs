namespace HangmanGame
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSoloMode = new System.Windows.Forms.Button();
            this.buttonVersusMode = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonVersusMode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSoloMode, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 133);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veuillez choisir votre mode de jeu.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSoloMode
            // 
            this.buttonSoloMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSoloMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSoloMode.Location = new System.Drawing.Point(3, 69);
            this.buttonSoloMode.Name = "buttonSoloMode";
            this.buttonSoloMode.Size = new System.Drawing.Size(165, 61);
            this.buttonSoloMode.TabIndex = 1;
            this.buttonSoloMode.Text = "Solo";
            this.buttonSoloMode.UseVisualStyleBackColor = true;
            this.buttonSoloMode.Click += new System.EventHandler(this.buttonSoloMode_Click);
            // 
            // buttonVersusMode
            // 
            this.buttonVersusMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonVersusMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonVersusMode.Location = new System.Drawing.Point(174, 69);
            this.buttonVersusMode.Name = "buttonVersusMode";
            this.buttonVersusMode.Size = new System.Drawing.Size(165, 61);
            this.buttonVersusMode.TabIndex = 2;
            this.buttonVersusMode.Text = "Versus\r\n(local)";
            this.buttonVersusMode.UseVisualStyleBackColor = true;
            this.buttonVersusMode.Click += new System.EventHandler(this.buttonVersusMode_Click);
            // 
            // ChooseGameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 133);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(360, 180);
            this.MinimumSize = new System.Drawing.Size(360, 180);
            this.Name = "ChooseGameMode";
            this.Text = "ChooseGameMode";
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