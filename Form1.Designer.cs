namespace Minotaurus
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.RulesBtn = new System.Windows.Forms.Button();
            this.SoundBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.label1.TabIndex = 0;
            this.label1.Text = "MINOTAURUS";
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Olive;
            this.PlayBtn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayBtn.Location = new System.Drawing.Point(41, 217);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(184, 48);
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.Text = "GIOCA";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // RulesBtn
            // 
            this.RulesBtn.BackColor = System.Drawing.Color.Olive;
            this.RulesBtn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RulesBtn.Location = new System.Drawing.Point(41, 295);
            this.RulesBtn.Name = "RulesBtn";
            this.RulesBtn.Size = new System.Drawing.Size(184, 48);
            this.RulesBtn.TabIndex = 2;
            this.RulesBtn.Text = "REGOLE";
            this.RulesBtn.UseVisualStyleBackColor = false;
            this.RulesBtn.Click += new System.EventHandler(this.RulesBtn_Click);
            // 
            // SoundBtn
            // 
            this.SoundBtn.BackColor = System.Drawing.Color.Olive;
            this.SoundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SoundBtn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoundBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SoundBtn.Location = new System.Drawing.Point(712, 365);
            this.SoundBtn.Name = "SoundBtn";
            this.SoundBtn.Size = new System.Drawing.Size(76, 73);
            this.SoundBtn.TabIndex = 3;
            this.SoundBtn.UseVisualStyleBackColor = false;
            this.SoundBtn.Click += new System.EventHandler(this.SoundBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.Olive;
            this.QuitBtn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.QuitBtn.Location = new System.Drawing.Point(41, 377);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(184, 48);
            this.QuitBtn.TabIndex = 4;
            this.QuitBtn.Text = "ESCI";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.SoundBtn);
            this.Controls.Add(this.RulesBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MINOTAUROS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button RulesBtn;
        private System.Windows.Forms.Button SoundBtn;
        private System.Windows.Forms.Button QuitBtn;
    }
}

