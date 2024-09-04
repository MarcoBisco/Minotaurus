namespace Minotaurus
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Match1Btn = new System.Windows.Forms.Button();
            this.Match2Btn = new System.Windows.Forms.Button();
            this.Match3Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateTB = new System.Windows.Forms.TextBox();
            this.PlayersNumberTB = new System.Windows.Forms.TextBox();
            this.MatchDisplay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Match1Btn
            // 
            this.Match1Btn.BackColor = System.Drawing.Color.Olive;
            this.Match1Btn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Match1Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Match1Btn.Location = new System.Drawing.Point(495, 124);
            this.Match1Btn.Name = "Match1Btn";
            this.Match1Btn.Size = new System.Drawing.Size(293, 48);
            this.Match1Btn.TabIndex = 2;
            this.Match1Btn.Text = "NUOVA PARTITA";
            this.Match1Btn.UseVisualStyleBackColor = false;
            this.Match1Btn.Click += new System.EventHandler(this.Match1Btn_Click);
            // 
            // Match2Btn
            // 
            this.Match2Btn.BackColor = System.Drawing.Color.Olive;
            this.Match2Btn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Match2Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Match2Btn.Location = new System.Drawing.Point(495, 202);
            this.Match2Btn.Name = "Match2Btn";
            this.Match2Btn.Size = new System.Drawing.Size(293, 48);
            this.Match2Btn.TabIndex = 3;
            this.Match2Btn.Text = "NUOVA PARTITA";
            this.Match2Btn.UseVisualStyleBackColor = false;
            this.Match2Btn.Click += new System.EventHandler(this.Match2Btn_Click);
            // 
            // Match3Btn
            // 
            this.Match3Btn.BackColor = System.Drawing.Color.Olive;
            this.Match3Btn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Match3Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Match3Btn.Location = new System.Drawing.Point(495, 275);
            this.Match3Btn.Name = "Match3Btn";
            this.Match3Btn.Size = new System.Drawing.Size(293, 48);
            this.Match3Btn.TabIndex = 4;
            this.Match3Btn.Text = "NUOVA PARTITA";
            this.Match3Btn.UseVisualStyleBackColor = false;
            this.Match3Btn.Click += new System.EventHandler(this.Match3Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 71);
            this.label1.TabIndex = 5;
            this.label1.Text = "MINOTAURUS";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(12, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(293, 120);
            this.button4.TabIndex = 6;
            this.button4.Text = "Seleziona la partita che vuoi avviare";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Olive;
            this.groupBox1.Controls.Add(this.DateTB);
            this.groupBox1.Controls.Add(this.PlayersNumberTB);
            this.groupBox1.Controls.Add(this.MatchDisplay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Controls.Add(this.PlayBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 76);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // DateTB
            // 
            this.DateTB.Enabled = false;
            this.DateTB.Location = new System.Drawing.Point(380, 42);
            this.DateTB.Name = "DateTB";
            this.DateTB.Size = new System.Drawing.Size(113, 20);
            this.DateTB.TabIndex = 11;
            // 
            // PlayersNumberTB
            // 
            this.PlayersNumberTB.Enabled = false;
            this.PlayersNumberTB.Location = new System.Drawing.Point(380, 16);
            this.PlayersNumberTB.Name = "PlayersNumberTB";
            this.PlayersNumberTB.Size = new System.Drawing.Size(19, 20);
            this.PlayersNumberTB.TabIndex = 10;
            // 
            // MatchDisplay
            // 
            this.MatchDisplay.BackColor = System.Drawing.Color.Olive;
            this.MatchDisplay.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MatchDisplay.Location = new System.Drawing.Point(6, 16);
            this.MatchDisplay.Name = "MatchDisplay";
            this.MatchDisplay.Size = new System.Drawing.Size(181, 48);
            this.MatchDisplay.TabIndex = 8;
            this.MatchDisplay.Text = "PARTITA 1";
            this.MatchDisplay.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(193, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "DATA CREAZIONE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(193, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "GIOCATORI";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Olive;
            this.DeleteBtn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteBtn.Location = new System.Drawing.Point(633, 14);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(137, 48);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "ELIMINA";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Olive;
            this.PlayBtn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayBtn.Location = new System.Drawing.Point(506, 14);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(121, 48);
            this.PlayBtn.TabIndex = 3;
            this.PlayBtn.Text = "AVVIA";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Olive;
            this.BackBtn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BackBtn.Location = new System.Drawing.Point(12, 84);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(144, 48);
            this.BackBtn.TabIndex = 8;
            this.BackBtn.Text = "INDIETRO";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Match3Btn);
            this.Controls.Add(this.Match2Btn);
            this.Controls.Add(this.Match1Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "MINOTAUROS";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Match1Btn;
        private System.Windows.Forms.Button Match2Btn;
        private System.Windows.Forms.Button Match3Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DateTB;
        private System.Windows.Forms.TextBox PlayersNumberTB;
        private System.Windows.Forms.Button MatchDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}