namespace CyberTechDM
{
    partial class Connexion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NomTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MPasseTb = new System.Windows.Forms.TextBox();
            this.ConBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 451);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "CyberTechDM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NomTb
            // 
            this.NomTb.Location = new System.Drawing.Point(255, 147);
            this.NomTb.Name = "NomTb";
            this.NomTb.Size = new System.Drawing.Size(268, 31);
            this.NomTb.TabIndex = 2;
            this.NomTb.TextChanged += new System.EventHandler(this.NomTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pseudo de connexion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mot de passe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MPasseTb
            // 
            this.MPasseTb.Location = new System.Drawing.Point(255, 241);
            this.MPasseTb.Name = "MPasseTb";
            this.MPasseTb.Size = new System.Drawing.Size(268, 31);
            this.MPasseTb.TabIndex = 4;
            // 
            // ConBtn
            // 
            this.ConBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ConBtn.FlatAppearance.BorderSize = 0;
            this.ConBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConBtn.Location = new System.Drawing.Point(255, 313);
            this.ConBtn.Name = "ConBtn";
            this.ConBtn.Size = new System.Drawing.Size(150, 33);
            this.ConBtn.TabIndex = 6;
            this.ConBtn.Text = "Connexion";
            this.ConBtn.UseVisualStyleBackColor = false;
            this.ConBtn.Click += new System.EventHandler(this.ConBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(12, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 451);
            this.Controls.Add(this.ConBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MPasseTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MPasseTb;
        private System.Windows.Forms.Button ConBtn;
        private System.Windows.Forms.Button button1;
    }
}

