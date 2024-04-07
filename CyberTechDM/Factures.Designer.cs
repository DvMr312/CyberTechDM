namespace CyberTechDM
{
    partial class Factures
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factures));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ArticlesListe = new Guna.UI.WinForms.GunaDataGridView();
            this.ImprimerBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.QntTb = new System.Windows.Forms.TextBox();
            this.PrixTb = new System.Windows.Forms.TextBox();
            this.NomTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VendeurLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DeconnLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StockTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FactureListe = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReinitialiserBtn = new System.Windows.Forms.Button();
            this.PrixTotalLbl = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesListe)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactureListe)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArticlesListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ArticlesListe.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ArticlesListe.DefaultCellStyle = dataGridViewCellStyle3;
            this.ArticlesListe.EnableHeadersVisualStyles = false;
            this.ArticlesListe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ArticlesListe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ArticlesListe.Location = new System.Drawing.Point(167, 365);
            this.ArticlesListe.Name = "ArticlesListe";
            this.ArticlesListe.RowHeadersVisible = false;
            this.ArticlesListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArticlesListe.Size = new System.Drawing.Size(617, 424);
            this.ArticlesListe.TabIndex = 68;
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
            this.ArticlesListe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.ArticlesListe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ArticlesListe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ArticlesListe.ThemeStyle.HeaderStyle.Height = 30;
            this.ArticlesListe.ThemeStyle.ReadOnly = false;
            this.ArticlesListe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ArticlesListe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ArticlesListe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.ArticlesListe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ArticlesListe.ThemeStyle.RowsStyle.Height = 22;
            this.ArticlesListe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ArticlesListe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ArticlesListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArticlesListe_CellContentClick);
            // 
            // ImprimerBtn
            // 
            this.ImprimerBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ImprimerBtn.FlatAppearance.BorderSize = 0;
            this.ImprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimerBtn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.ImprimerBtn.Location = new System.Drawing.Point(816, 697);
            this.ImprimerBtn.Name = "ImprimerBtn";
            this.ImprimerBtn.Size = new System.Drawing.Size(150, 36);
            this.ImprimerBtn.TabIndex = 67;
            this.ImprimerBtn.Text = "Imprimer";
            this.ImprimerBtn.UseVisualStyleBackColor = false;
            this.ImprimerBtn.Click += new System.EventHandler(this.ImprimerBtn_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModifierBtn.FlatAppearance.BorderSize = 0;
            this.ModifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierBtn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.ModifierBtn.Location = new System.Drawing.Point(180, 280);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(188, 36);
            this.ModifierBtn.TabIndex = 66;
            this.ModifierBtn.Text = "Ajt+ à la facture";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // QntTb
            // 
            this.QntTb.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.QntTb.Location = new System.Drawing.Point(390, 161);
            this.QntTb.Name = "QntTb";
            this.QntTb.Size = new System.Drawing.Size(191, 31);
            this.QntTb.TabIndex = 63;
            // 
            // PrixTb
            // 
            this.PrixTb.Enabled = false;
            this.PrixTb.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.PrixTb.Location = new System.Drawing.Point(602, 161);
            this.PrixTb.Name = "PrixTb";
            this.PrixTb.Size = new System.Drawing.Size(73, 31);
            this.PrixTb.TabIndex = 62;
            // 
            // NomTb
            // 
            this.NomTb.Enabled = false;
            this.NomTb.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.NomTb.Location = new System.Drawing.Point(177, 161);
            this.NomTb.Name = "NomTb";
            this.NomTb.Size = new System.Drawing.Size(191, 31);
            this.NomTb.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(999, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 26);
            this.label6.TabIndex = 60;
            this.label6.Text = "Facture du Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 59;
            this.label4.Text = "Quantité";
            // 
            // VendeurLbl
            // 
            this.VendeurLbl.AutoSize = true;
            this.VendeurLbl.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendeurLbl.Location = new System.Drawing.Point(1032, 77);
            this.VendeurLbl.Name = "VendeurLbl";
            this.VendeurLbl.Size = new System.Drawing.Size(432, 28);
            this.VendeurLbl.TabIndex = 58;
            this.VendeurLbl.Text = "................................................................................." +
    "...";
            this.VendeurLbl.Click += new System.EventHandler(this.VendeurLbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 28);
            this.label3.TabIndex = 57;
            this.label3.Text = "Prix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 56;
            this.label2.Text = "Article";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(148, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1195, 73);
            this.panel2.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion Des Factures";
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
            this.panel1.Size = new System.Drawing.Size(148, 799);
            this.panel1.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 28);
            this.label12.TabIndex = 52;
            this.label12.Text = "Facturation";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // DeconnLbl
            // 
            this.DeconnLbl.AutoSize = true;
            this.DeconnLbl.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeconnLbl.Location = new System.Drawing.Point(11, 761);
            this.DeconnLbl.Name = "DeconnLbl";
            this.DeconnLbl.Size = new System.Drawing.Size(126, 28);
            this.DeconnLbl.TabIndex = 51;
            this.DeconnLbl.Text = "Déconnexion";
            this.DeconnLbl.Click += new System.EventHandler(this.DeconnLbl_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 28);
            this.label10.TabIndex = 50;
            this.label10.Text = "Vendeurs";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 28);
            this.label9.TabIndex = 49;
            this.label9.Text = "Catégories";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 28);
            this.label8.TabIndex = 48;
            this.label8.Text = "Article";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // StockTb
            // 
            this.StockTb.Enabled = false;
            this.StockTb.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.StockTb.Location = new System.Drawing.Point(177, 226);
            this.StockTb.Name = "StockTb";
            this.StockTb.Size = new System.Drawing.Size(65, 31);
            this.StockTb.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 28);
            this.label5.TabIndex = 69;
            this.label5.Text = "Stock";
            // 
            // FactureListe
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.FactureListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.FactureListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FactureListe.BackgroundColor = System.Drawing.Color.Silver;
            this.FactureListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FactureListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FactureListe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FactureListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.FactureListe.ColumnHeadersHeight = 30;
            this.FactureListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FactureListe.DefaultCellStyle = dataGridViewCellStyle6;
            this.FactureListe.EnableHeadersVisualStyles = false;
            this.FactureListe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FactureListe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FactureListe.Location = new System.Drawing.Point(816, 161);
            this.FactureListe.Name = "FactureListe";
            this.FactureListe.RowHeadersVisible = false;
            this.FactureListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FactureListe.Size = new System.Drawing.Size(515, 524);
            this.FactureListe.TabIndex = 71;
            this.FactureListe.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.FactureListe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FactureListe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FactureListe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FactureListe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FactureListe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FactureListe.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.FactureListe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FactureListe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FactureListe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FactureListe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.FactureListe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FactureListe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FactureListe.ThemeStyle.HeaderStyle.Height = 30;
            this.FactureListe.ThemeStyle.ReadOnly = false;
            this.FactureListe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FactureListe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FactureListe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.FactureListe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FactureListe.ThemeStyle.RowsStyle.Height = 22;
            this.FactureListe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FactureListe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FactureListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FactureListe_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Article";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // ReinitialiserBtn
            // 
            this.ReinitialiserBtn.BackColor = System.Drawing.Color.Yellow;
            this.ReinitialiserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReinitialiserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReinitialiserBtn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.ReinitialiserBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReinitialiserBtn.Location = new System.Drawing.Point(390, 280);
            this.ReinitialiserBtn.Name = "ReinitialiserBtn";
            this.ReinitialiserBtn.Size = new System.Drawing.Size(162, 36);
            this.ReinitialiserBtn.TabIndex = 72;
            this.ReinitialiserBtn.Text = "Reinitialiser";
            this.ReinitialiserBtn.UseVisualStyleBackColor = false;
            this.ReinitialiserBtn.Click += new System.EventHandler(this.ReinitialiserBtn_Click);
            // 
            // PrixTotalLbl
            // 
            this.PrixTotalLbl.AutoSize = true;
            this.PrixTotalLbl.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixTotalLbl.Location = new System.Drawing.Point(1274, 701);
            this.PrixTotalLbl.Name = "PrixTotalLbl";
            this.PrixTotalLbl.Size = new System.Drawing.Size(57, 28);
            this.PrixTotalLbl.TabIndex = 73;
            this.PrixTotalLbl.Text = "Total";
            this.PrixTotalLbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.BackColor = System.Drawing.Color.Red;
            this.SupprimerBtn.FlatAppearance.BorderSize = 0;
            this.SupprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerBtn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold);
            this.SupprimerBtn.Location = new System.Drawing.Point(569, 280);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(150, 36);
            this.SupprimerBtn.TabIndex = 74;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = false;
            this.SupprimerBtn.Click += new System.EventHandler(this.SupprimerBtn_Click);
            // 
            // Factures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 799);
            this.Controls.Add(this.SupprimerBtn);
            this.Controls.Add(this.PrixTotalLbl);
            this.Controls.Add(this.ReinitialiserBtn);
            this.Controls.Add(this.FactureListe);
            this.Controls.Add(this.StockTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ArticlesListe);
            this.Controls.Add(this.ImprimerBtn);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.QntTb);
            this.Controls.Add(this.PrixTb);
            this.Controls.Add(this.NomTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VendeurLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Factures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factures";
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesListe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactureListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView ArticlesListe;
        private System.Windows.Forms.Button ImprimerBtn;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.TextBox QntTb;
        private System.Windows.Forms.TextBox PrixTb;
        private System.Windows.Forms.TextBox NomTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label VendeurLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label DeconnLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StockTb;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaDataGridView FactureListe;
        private System.Windows.Forms.Button ReinitialiserBtn;
        private System.Windows.Forms.Label PrixTotalLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button SupprimerBtn;
    }
}