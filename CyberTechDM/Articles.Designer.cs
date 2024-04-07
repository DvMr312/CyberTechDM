namespace CyberTechDM
{
    partial class Articles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articles));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DeconnLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrixTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StockTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.ExpTb = new System.Windows.Forms.DateTimePicker();
            this.AjouterBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.FiltrerCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ActualiserBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.ArticlesListe = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesListe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.DeconnLbl);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 798);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 28);
            this.label12.TabIndex = 58;
            this.label12.Text = "Facturation";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // DeconnLbl
            // 
            this.DeconnLbl.AutoSize = true;
            this.DeconnLbl.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeconnLbl.Location = new System.Drawing.Point(11, 760);
            this.DeconnLbl.Name = "DeconnLbl";
            this.DeconnLbl.Size = new System.Drawing.Size(126, 28);
            this.DeconnLbl.TabIndex = 57;
            this.DeconnLbl.Text = "Déconnexion";
            this.DeconnLbl.Click += new System.EventHandler(this.DeconnLbl_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 28);
            this.label10.TabIndex = 56;
            this.label10.Text = "Vendeurs";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 28);
            this.label9.TabIndex = 55;
            this.label9.Text = "Catégories";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 28);
            this.label8.TabIndex = 54;
            this.label8.Text = "Article";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(148, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1211, 73);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(470, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion Des Articles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prix de l\'article";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PrixTb
            // 
            this.PrixTb.Location = new System.Drawing.Point(477, 158);
            this.PrixTb.Name = "PrixTb";
            this.PrixTb.Size = new System.Drawing.Size(268, 31);
            this.PrixTb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nom de l\'article";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NomTb
            // 
            this.NomTb.Location = new System.Drawing.Point(177, 158);
            this.NomTb.Name = "NomTb";
            this.NomTb.Size = new System.Drawing.Size(268, 31);
            this.NomTb.TabIndex = 6;
            this.NomTb.TextChanged += new System.EventHandler(this.NomTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(771, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stock";
            // 
            // StockTb
            // 
            this.StockTb.Location = new System.Drawing.Point(764, 158);
            this.StockTb.Name = "StockTb";
            this.StockTb.Size = new System.Drawing.Size(195, 31);
            this.StockTb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(993, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Catégorie";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Location = new System.Drawing.Point(998, 153);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(121, 36);
            this.CatCb.TabIndex = 14;
            // 
            // ExpTb
            // 
            this.ExpTb.CalendarFont = new System.Drawing.Font("AGA Arabesque", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ExpTb.Location = new System.Drawing.Point(1147, 158);
            this.ExpTb.Name = "ExpTb";
            this.ExpTb.Size = new System.Drawing.Size(200, 31);
            this.ExpTb.TabIndex = 15;
            this.ExpTb.Value = new System.DateTime(2024, 1, 5, 16, 36, 1, 0);
            this.ExpTb.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AjouterBtn
            // 
            this.AjouterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AjouterBtn.FlatAppearance.BorderSize = 0;
            this.AjouterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterBtn.Location = new System.Drawing.Point(177, 220);
            this.AjouterBtn.Name = "AjouterBtn";
            this.AjouterBtn.Size = new System.Drawing.Size(150, 36);
            this.AjouterBtn.TabIndex = 16;
            this.AjouterBtn.Text = "Ajouter +";
            this.AjouterBtn.UseVisualStyleBackColor = false;
            this.AjouterBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ModifierBtn.FlatAppearance.BorderSize = 0;
            this.ModifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierBtn.Location = new System.Drawing.Point(333, 220);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(150, 36);
            this.ModifierBtn.TabIndex = 17;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.BackColor = System.Drawing.Color.Red;
            this.SupprimerBtn.FlatAppearance.BorderSize = 0;
            this.SupprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerBtn.Location = new System.Drawing.Point(489, 220);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(150, 36);
            this.SupprimerBtn.TabIndex = 18;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = false;
            this.SupprimerBtn.Click += new System.EventHandler(this.SupprimerBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(666, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 48);
            this.label6.TabIndex = 20;
            this.label6.Text = "Liste des articles";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FiltrerCb
            // 
            this.FiltrerCb.FormattingEnabled = true;
            this.FiltrerCb.Location = new System.Drawing.Point(683, 309);
            this.FiltrerCb.Name = "FiltrerCb";
            this.FiltrerCb.Size = new System.Drawing.Size(210, 36);
            this.FiltrerCb.TabIndex = 21;
            this.FiltrerCb.SelectedIndexChanged += new System.EventHandler(this.FiltrerCb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(627, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "Filtre\r\n";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ActualiserBtn
            // 
            this.ActualiserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ActualiserBtn.FlatAppearance.BorderSize = 0;
            this.ActualiserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualiserBtn.Location = new System.Drawing.Point(899, 309);
            this.ActualiserBtn.Name = "ActualiserBtn";
            this.ActualiserBtn.Size = new System.Drawing.Size(150, 36);
            this.ActualiserBtn.TabIndex = 23;
            this.ActualiserBtn.Text = "Search";
            this.ActualiserBtn.UseVisualStyleBackColor = false;
            this.ActualiserBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1155, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 28);
            this.label13.TabIndex = 24;
            this.label13.Text = "Date d\'expiration";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // ArticlesListe
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ArticlesListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ArticlesListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ArticlesListe.BackgroundColor = System.Drawing.Color.DimGray;
            this.ArticlesListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArticlesListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ArticlesListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArticlesListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ArticlesListe.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ArticlesListe.DefaultCellStyle = dataGridViewCellStyle3;
            this.ArticlesListe.EnableHeadersVisualStyles = false;
            this.ArticlesListe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ArticlesListe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ArticlesListe.Location = new System.Drawing.Point(210, 367);
            this.ArticlesListe.Name = "ArticlesListe";
            this.ArticlesListe.RowHeadersVisible = false;
            this.ArticlesListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArticlesListe.Size = new System.Drawing.Size(1084, 93);
            this.ArticlesListe.TabIndex = 43;
            this.ArticlesListe.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ArticlesListe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ArticlesListe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ArticlesListe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ArticlesListe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ArticlesListe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ArticlesListe.ThemeStyle.BackColor = System.Drawing.Color.DimGray;
            this.ArticlesListe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ArticlesListe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ArticlesListe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ArticlesListe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticlesListe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ArticlesListe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ArticlesListe.ThemeStyle.HeaderStyle.Height = 30;
            this.ArticlesListe.ThemeStyle.ReadOnly = false;
            this.ArticlesListe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ArticlesListe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ArticlesListe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticlesListe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ArticlesListe.ThemeStyle.RowsStyle.Height = 22;
            this.ArticlesListe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ArticlesListe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ArticlesListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArticlesListe_CellContentClick);
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 798);
            this.Controls.Add(this.ArticlesListe);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ActualiserBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FiltrerCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SupprimerBtn);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.AjouterBtn);
            this.Controls.Add(this.ExpTb);
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StockTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrixTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Articles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrixTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StockTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.DateTimePicker ExpTb;
        private System.Windows.Forms.Button AjouterBtn;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FiltrerCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ActualiserBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label DeconnLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaDataGridView ArticlesListe;
    }
}