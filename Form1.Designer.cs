namespace ProiectPAW
{
    partial class Form1
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
            this.titlu = new System.Windows.Forms.TextBox();
            this.Meniu = new System.Windows.Forms.TabControl();
            this.CitTab = new System.Windows.Forms.TabPage();
            this.stergCit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbIdCit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbCitPren = new System.Windows.Forms.TextBox();
            this.tbCitTlf = new System.Windows.Forms.TextBox();
            this.tbCitNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeC = new System.Windows.Forms.Label();
            this.modifCit = new System.Windows.Forms.Button();
            this.AdCi = new System.Windows.Forms.Button();
            this.gvCititori = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartiTab = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.IdCart = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEdit = new System.Windows.Forms.TextBox();
            this.tbAn = new System.Windows.Forms.TextBox();
            this.tbTitlu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ModifCarti = new System.Windows.Forms.Button();
            this.stergCarti = new System.Windows.Forms.Button();
            this.AdCarti = new System.Windows.Forms.Button();
            this.gvCarti = new System.Windows.Forms.DataGridView();
            this.ImprTab = new System.Windows.Forms.TabPage();
            this.dtImpr = new System.Windows.Forms.DateTimePicker();
            this.dtRetur = new System.Windows.Forms.DateTimePicker();
            this.dtScad = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCarteImp = new System.Windows.Forms.TextBox();
            this.tbCitImp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btStgImpr = new System.Windows.Forms.Button();
            this.adImpr = new System.Windows.Forms.Button();
            this.gvImprumuturi = new System.Windows.Forms.DataGridView();
            this.idCititor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarteI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataImpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataScad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titlul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.An = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AfisCarti = new System.Windows.Forms.Button();
            this.AfisCit = new System.Windows.Forms.Button();
            this.AfiseazaGR = new System.Windows.Forms.Button();
            this.Meniu.SuspendLayout();
            this.CitTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCititori)).BeginInit();
            this.CartiTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCarti)).BeginInit();
            this.ImprTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvImprumuturi)).BeginInit();
            this.SuspendLayout();
            // 
            // titlu
            // 
            this.titlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.titlu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titlu.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.titlu.Location = new System.Drawing.Point(0, 0);
            this.titlu.Name = "titlu";
            this.titlu.ReadOnly = true;
            this.titlu.Size = new System.Drawing.Size(1092, 27);
            this.titlu.TabIndex = 0;
            this.titlu.TabStop = false;
            this.titlu.Text = "Evidența cărților, a cititorilor și a împrumuturilor";
            this.titlu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Meniu
            // 
            this.Meniu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Meniu.Controls.Add(this.CitTab);
            this.Meniu.Controls.Add(this.CartiTab);
            this.Meniu.Controls.Add(this.ImprTab);
            this.Meniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meniu.Location = new System.Drawing.Point(0, 58);
            this.Meniu.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Meniu.Name = "Meniu";
            this.Meniu.SelectedIndex = 0;
            this.Meniu.Size = new System.Drawing.Size(1093, 497);
            this.Meniu.TabIndex = 1;
            this.Meniu.Tag = "M";
            // 
            // CitTab
            // 
            this.CitTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CitTab.Controls.Add(this.AfisCit);
            this.CitTab.Controls.Add(this.stergCit);
            this.CitTab.Controls.Add(this.label14);
            this.CitTab.Controls.Add(this.tbIdCit);
            this.CitTab.Controls.Add(this.label12);
            this.CitTab.Controls.Add(this.tbEmail);
            this.CitTab.Controls.Add(this.tbCitPren);
            this.CitTab.Controls.Add(this.tbCitTlf);
            this.CitTab.Controls.Add(this.tbCitNume);
            this.CitTab.Controls.Add(this.label1);
            this.CitTab.Controls.Add(this.label2);
            this.CitTab.Controls.Add(this.numeC);
            this.CitTab.Controls.Add(this.modifCit);
            this.CitTab.Controls.Add(this.AdCi);
            this.CitTab.Controls.Add(this.gvCititori);
            this.CitTab.Location = new System.Drawing.Point(4, 25);
            this.CitTab.Name = "CitTab";
            this.CitTab.Padding = new System.Windows.Forms.Padding(3);
            this.CitTab.Size = new System.Drawing.Size(1085, 468);
            this.CitTab.TabIndex = 0;
            this.CitTab.Tag = "CI";
            this.CitTab.Text = "Cititori";
            // 
            // stergCit
            // 
            this.stergCit.BackColor = System.Drawing.Color.Purple;
            this.stergCit.Location = new System.Drawing.Point(580, 158);
            this.stergCit.Name = "stergCit";
            this.stergCit.Size = new System.Drawing.Size(173, 31);
            this.stergCit.TabIndex = 17;
            this.stergCit.Text = "Sterge";
            this.stergCit.UseVisualStyleBackColor = false;
            this.stergCit.Click += new System.EventHandler(this.stergCit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(569, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(275, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "ID cititor (pentru modificare sau stergere): ";
            // 
            // tbIdCit
            // 
            this.tbIdCit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbIdCit.Location = new System.Drawing.Point(850, 35);
            this.tbIdCit.Name = "tbIdCit";
            this.tbIdCit.Size = new System.Drawing.Size(172, 23);
            this.tbIdCit.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(123, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbEmail.Location = new System.Drawing.Point(175, 113);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(320, 23);
            this.tbEmail.TabIndex = 13;
            // 
            // tbCitPren
            // 
            this.tbCitPren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbCitPren.Location = new System.Drawing.Point(175, 55);
            this.tbCitPren.Name = "tbCitPren";
            this.tbCitPren.Size = new System.Drawing.Size(320, 23);
            this.tbCitPren.TabIndex = 12;
            // 
            // tbCitTlf
            // 
            this.tbCitTlf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbCitTlf.Location = new System.Drawing.Point(175, 84);
            this.tbCitTlf.Name = "tbCitTlf";
            this.tbCitTlf.Size = new System.Drawing.Size(320, 23);
            this.tbCitTlf.TabIndex = 11;
            // 
            // tbCitNume
            // 
            this.tbCitNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbCitNume.Location = new System.Drawing.Point(175, 26);
            this.tbCitNume.Name = "tbCitNume";
            this.tbCitNume.Size = new System.Drawing.Size(320, 23);
            this.tbCitNume.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenume cititor:";
            // 
            // numeC
            // 
            this.numeC.AutoSize = true;
            this.numeC.Location = new System.Drawing.Point(78, 32);
            this.numeC.Name = "numeC";
            this.numeC.Size = new System.Drawing.Size(91, 17);
            this.numeC.TabIndex = 7;
            this.numeC.Text = "Nume cititor: ";
            // 
            // modifCit
            // 
            this.modifCit.BackColor = System.Drawing.Color.Purple;
            this.modifCit.Location = new System.Drawing.Point(329, 158);
            this.modifCit.Margin = new System.Windows.Forms.Padding(3, 3, 80, 3);
            this.modifCit.Name = "modifCit";
            this.modifCit.Size = new System.Drawing.Size(173, 31);
            this.modifCit.TabIndex = 6;
            this.modifCit.Text = "Modifica";
            this.modifCit.UseVisualStyleBackColor = false;
            this.modifCit.Click += new System.EventHandler(this.modifCit_Click);
            // 
            // AdCi
            // 
            this.AdCi.BackColor = System.Drawing.Color.Purple;
            this.AdCi.Location = new System.Drawing.Point(78, 158);
            this.AdCi.Margin = new System.Windows.Forms.Padding(49, 3, 80, 3);
            this.AdCi.Name = "AdCi";
            this.AdCi.Size = new System.Drawing.Size(173, 31);
            this.AdCi.TabIndex = 4;
            this.AdCi.Text = "Adauga";
            this.AdCi.UseVisualStyleBackColor = false;
            this.AdCi.Click += new System.EventHandler(this.AdCi_Click);
            // 
            // gvCititori
            // 
            this.gvCititori.AllowUserToAddRows = false;
            this.gvCititori.AllowUserToDeleteRows = false;
            this.gvCititori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCititori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCititori.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvCititori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCititori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nume,
            this.Prenume,
            this.Telefon,
            this.Email});
            this.gvCititori.Location = new System.Drawing.Point(0, 210);
            this.gvCititori.Name = "gvCititori";
            this.gvCititori.ReadOnly = true;
            this.gvCititori.RowHeadersWidth = 51;
            this.gvCititori.RowTemplate.Height = 24;
            this.gvCititori.Size = new System.Drawing.Size(1085, 258);
            this.gvCititori.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.MinimumWidth = 6;
            this.Nume.Name = "Nume";
            this.Nume.ReadOnly = true;
            // 
            // Prenume
            // 
            this.Prenume.HeaderText = "Prenume";
            this.Prenume.MinimumWidth = 6;
            this.Prenume.Name = "Prenume";
            this.Prenume.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // CartiTab
            // 
            this.CartiTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CartiTab.Controls.Add(this.AfisCarti);
            this.CartiTab.Controls.Add(this.label15);
            this.CartiTab.Controls.Add(this.IdCart);
            this.CartiTab.Controls.Add(this.label11);
            this.CartiTab.Controls.Add(this.tbAutor);
            this.CartiTab.Controls.Add(this.tbCod);
            this.CartiTab.Controls.Add(this.label6);
            this.CartiTab.Controls.Add(this.tbEdit);
            this.CartiTab.Controls.Add(this.tbAn);
            this.CartiTab.Controls.Add(this.tbTitlu);
            this.CartiTab.Controls.Add(this.label3);
            this.CartiTab.Controls.Add(this.label4);
            this.CartiTab.Controls.Add(this.label5);
            this.CartiTab.Controls.Add(this.ModifCarti);
            this.CartiTab.Controls.Add(this.stergCarti);
            this.CartiTab.Controls.Add(this.AdCarti);
            this.CartiTab.Controls.Add(this.gvCarti);
            this.CartiTab.Location = new System.Drawing.Point(4, 25);
            this.CartiTab.Name = "CartiTab";
            this.CartiTab.Padding = new System.Windows.Forms.Padding(3);
            this.CartiTab.Size = new System.Drawing.Size(1085, 468);
            this.CartiTab.TabIndex = 1;
            this.CartiTab.Tag = "CA";
            this.CartiTab.Text = "Carti";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(511, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = "ID (stergere/modificare):";
            // 
            // IdCart
            // 
            this.IdCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.IdCart.Location = new System.Drawing.Point(678, 90);
            this.IdCart.Name = "IdCart";
            this.IdCart.Size = new System.Drawing.Size(320, 23);
            this.IdCart.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(586, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Autor carte: ";
            // 
            // tbAutor
            // 
            this.tbAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbAutor.Location = new System.Drawing.Point(678, 26);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(320, 23);
            this.tbAutor.TabIndex = 21;
            // 
            // tbCod
            // 
            this.tbCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbCod.Location = new System.Drawing.Point(678, 58);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(320, 23);
            this.tbCod.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cota:";
            // 
            // tbEdit
            // 
            this.tbEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbEdit.Location = new System.Drawing.Point(172, 55);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(320, 23);
            this.tbEdit.TabIndex = 18;
            // 
            // tbAn
            // 
            this.tbAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbAn.Location = new System.Drawing.Point(172, 84);
            this.tbAn.Name = "tbAn";
            this.tbAn.Size = new System.Drawing.Size(320, 23);
            this.tbAn.TabIndex = 17;
            // 
            // tbTitlu
            // 
            this.tbTitlu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbTitlu.Location = new System.Drawing.Point(172, 26);
            this.tbTitlu.Name = "tbTitlu";
            this.tbTitlu.Size = new System.Drawing.Size(320, 23);
            this.tbTitlu.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "An aparitie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Editura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Titlu carte: ";
            // 
            // ModifCarti
            // 
            this.ModifCarti.BackColor = System.Drawing.Color.Purple;
            this.ModifCarti.Location = new System.Drawing.Point(329, 158);
            this.ModifCarti.Name = "ModifCarti";
            this.ModifCarti.Size = new System.Drawing.Size(173, 31);
            this.ModifCarti.TabIndex = 3;
            this.ModifCarti.Text = "Modifica";
            this.ModifCarti.UseVisualStyleBackColor = false;
            this.ModifCarti.Click += new System.EventHandler(this.ModifCarti_Click);
            // 
            // stergCarti
            // 
            this.stergCarti.BackColor = System.Drawing.Color.Purple;
            this.stergCarti.Location = new System.Drawing.Point(580, 158);
            this.stergCarti.Name = "stergCarti";
            this.stergCarti.Size = new System.Drawing.Size(173, 31);
            this.stergCarti.TabIndex = 2;
            this.stergCarti.Text = "Sterge";
            this.stergCarti.UseVisualStyleBackColor = false;
            this.stergCarti.Click += new System.EventHandler(this.stergCarti_Click);
            // 
            // AdCarti
            // 
            this.AdCarti.BackColor = System.Drawing.Color.Purple;
            this.AdCarti.Location = new System.Drawing.Point(78, 158);
            this.AdCarti.Name = "AdCarti";
            this.AdCarti.Size = new System.Drawing.Size(173, 31);
            this.AdCarti.TabIndex = 1;
            this.AdCarti.Text = "Adauga";
            this.AdCarti.UseVisualStyleBackColor = false;
            this.AdCarti.Click += new System.EventHandler(this.AdCarti_Click_1);
            // 
            // gvCarti
            // 
            this.gvCarti.AllowUserToAddRows = false;
            this.gvCarti.AllowUserToDeleteRows = false;
            this.gvCarti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCarti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCarti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvCarti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCarti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCarte,
            this.Titlul,
            this.Autor,
            this.Editura,
            this.An,
            this.Cota});
            this.gvCarti.Location = new System.Drawing.Point(0, 210);
            this.gvCarti.Name = "gvCarti";
            this.gvCarti.ReadOnly = true;
            this.gvCarti.RowHeadersWidth = 51;
            this.gvCarti.RowTemplate.Height = 24;
            this.gvCarti.Size = new System.Drawing.Size(1085, 258);
            this.gvCarti.TabIndex = 0;
            // 
            // ImprTab
            // 
            this.ImprTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ImprTab.Controls.Add(this.AfiseazaGR);
            this.ImprTab.Controls.Add(this.dtImpr);
            this.ImprTab.Controls.Add(this.dtRetur);
            this.ImprTab.Controls.Add(this.dtScad);
            this.ImprTab.Controls.Add(this.label13);
            this.ImprTab.Controls.Add(this.label7);
            this.ImprTab.Controls.Add(this.tbCarteImp);
            this.ImprTab.Controls.Add(this.tbCitImp);
            this.ImprTab.Controls.Add(this.label8);
            this.ImprTab.Controls.Add(this.label9);
            this.ImprTab.Controls.Add(this.label10);
            this.ImprTab.Controls.Add(this.button1);
            this.ImprTab.Controls.Add(this.btStgImpr);
            this.ImprTab.Controls.Add(this.adImpr);
            this.ImprTab.Controls.Add(this.gvImprumuturi);
            this.ImprTab.Location = new System.Drawing.Point(4, 25);
            this.ImprTab.Name = "ImprTab";
            this.ImprTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImprTab.Size = new System.Drawing.Size(1085, 468);
            this.ImprTab.TabIndex = 2;
            this.ImprTab.Tag = "I";
            this.ImprTab.Text = "Imprumuturi";
            // 
            // dtImpr
            // 
            this.dtImpr.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtImpr.Location = new System.Drawing.Point(440, 70);
            this.dtImpr.Name = "dtImpr";
            this.dtImpr.Size = new System.Drawing.Size(320, 23);
            this.dtImpr.TabIndex = 33;
            // 
            // dtRetur
            // 
            this.dtRetur.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtRetur.Location = new System.Drawing.Point(440, 129);
            this.dtRetur.Name = "dtRetur";
            this.dtRetur.Size = new System.Drawing.Size(320, 23);
            this.dtRetur.TabIndex = 32;
            // 
            // dtScad
            // 
            this.dtScad.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtScad.Location = new System.Drawing.Point(440, 99);
            this.dtScad.Name = "dtScad";
            this.dtScad.Size = new System.Drawing.Size(320, 23);
            this.dtScad.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Data Returnare:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Data Scadenta:";
            // 
            // tbCarteImp
            // 
            this.tbCarteImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbCarteImp.Location = new System.Drawing.Point(440, 41);
            this.tbCarteImp.Name = "tbCarteImp";
            this.tbCarteImp.Size = new System.Drawing.Size(320, 23);
            this.tbCarteImp.TabIndex = 26;
            // 
            // tbCitImp
            // 
            this.tbCitImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbCitImp.Location = new System.Drawing.Point(440, 12);
            this.tbCitImp.Name = "tbCitImp";
            this.tbCitImp.Size = new System.Drawing.Size(320, 23);
            this.tbCitImp.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Data imprumut:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "ID carte: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "ID Cititor: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(329, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Modifica";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btStgImpr
            // 
            this.btStgImpr.BackColor = System.Drawing.Color.Purple;
            this.btStgImpr.Location = new System.Drawing.Point(580, 158);
            this.btStgImpr.Name = "btStgImpr";
            this.btStgImpr.Size = new System.Drawing.Size(173, 31);
            this.btStgImpr.TabIndex = 9;
            this.btStgImpr.Text = "Sterge";
            this.btStgImpr.UseVisualStyleBackColor = false;
            this.btStgImpr.Click += new System.EventHandler(this.btStgImpr_Click);
            // 
            // adImpr
            // 
            this.adImpr.BackColor = System.Drawing.Color.Purple;
            this.adImpr.Location = new System.Drawing.Point(78, 158);
            this.adImpr.Name = "adImpr";
            this.adImpr.Size = new System.Drawing.Size(173, 31);
            this.adImpr.TabIndex = 8;
            this.adImpr.Text = "Adauga";
            this.adImpr.UseVisualStyleBackColor = false;
            this.adImpr.Click += new System.EventHandler(this.button3_Click);
            // 
            // gvImprumuturi
            // 
            this.gvImprumuturi.AllowUserToAddRows = false;
            this.gvImprumuturi.AllowUserToDeleteRows = false;
            this.gvImprumuturi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvImprumuturi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvImprumuturi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvImprumuturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvImprumuturi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCititor,
            this.idCarteI,
            this.dataImpr,
            this.dataScad,
            this.returnare});
            this.gvImprumuturi.Location = new System.Drawing.Point(0, 210);
            this.gvImprumuturi.Name = "gvImprumuturi";
            this.gvImprumuturi.ReadOnly = true;
            this.gvImprumuturi.RowHeadersWidth = 51;
            this.gvImprumuturi.RowTemplate.Height = 24;
            this.gvImprumuturi.Size = new System.Drawing.Size(1085, 258);
            this.gvImprumuturi.TabIndex = 7;
            // 
            // idCititor
            // 
            this.idCititor.HeaderText = "ID Cititor";
            this.idCititor.MinimumWidth = 6;
            this.idCititor.Name = "idCititor";
            this.idCititor.ReadOnly = true;
            // 
            // idCarteI
            // 
            this.idCarteI.HeaderText = "ID Carte";
            this.idCarteI.MinimumWidth = 6;
            this.idCarteI.Name = "idCarteI";
            this.idCarteI.ReadOnly = true;
            // 
            // dataImpr
            // 
            this.dataImpr.HeaderText = "Data Imprumut";
            this.dataImpr.MinimumWidth = 6;
            this.dataImpr.Name = "dataImpr";
            this.dataImpr.ReadOnly = true;
            // 
            // dataScad
            // 
            this.dataScad.HeaderText = "Data Scadenta";
            this.dataScad.MinimumWidth = 6;
            this.dataScad.Name = "dataScad";
            this.dataScad.ReadOnly = true;
            // 
            // returnare
            // 
            this.returnare.HeaderText = "Data Returnare";
            this.returnare.MinimumWidth = 6;
            this.returnare.Name = "returnare";
            this.returnare.ReadOnly = true;
            // 
            // IDCarte
            // 
            this.IDCarte.HeaderText = "ID";
            this.IDCarte.MinimumWidth = 6;
            this.IDCarte.Name = "IDCarte";
            this.IDCarte.ReadOnly = true;
            // 
            // Titlul
            // 
            this.Titlul.HeaderText = "Titlu";
            this.Titlul.MinimumWidth = 6;
            this.Titlul.Name = "Titlul";
            this.Titlul.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Editura
            // 
            this.Editura.HeaderText = "Editura";
            this.Editura.MinimumWidth = 6;
            this.Editura.Name = "Editura";
            this.Editura.ReadOnly = true;
            // 
            // An
            // 
            this.An.HeaderText = "An aparitie";
            this.An.MinimumWidth = 6;
            this.An.Name = "An";
            this.An.ReadOnly = true;
            // 
            // Cota
            // 
            this.Cota.HeaderText = "Cota";
            this.Cota.MinimumWidth = 6;
            this.Cota.Name = "Cota";
            this.Cota.ReadOnly = true;
            // 
            // AfisCarti
            // 
            this.AfisCarti.BackColor = System.Drawing.Color.Purple;
            this.AfisCarti.Location = new System.Drawing.Point(831, 158);
            this.AfisCarti.Name = "AfisCarti";
            this.AfisCarti.Size = new System.Drawing.Size(173, 31);
            this.AfisCarti.TabIndex = 25;
            this.AfisCarti.Text = "Afiseaza din fisier";
            this.AfisCarti.UseVisualStyleBackColor = false;
            this.AfisCarti.Click += new System.EventHandler(this.AfisCarti_Click);
            // 
            // AfisCit
            // 
            this.AfisCit.BackColor = System.Drawing.Color.Purple;
            this.AfisCit.Location = new System.Drawing.Point(831, 158);
            this.AfisCit.Name = "AfisCit";
            this.AfisCit.Size = new System.Drawing.Size(173, 31);
            this.AfisCit.TabIndex = 18;
            this.AfisCit.Text = "Afiseaza din fisier";
            this.AfisCit.UseVisualStyleBackColor = false;
            this.AfisCit.Click += new System.EventHandler(this.AfisCit_Click);
            // 
            // AfiseazaGR
            // 
            this.AfiseazaGR.BackColor = System.Drawing.Color.Purple;
            this.AfiseazaGR.Location = new System.Drawing.Point(831, 158);
            this.AfiseazaGR.Name = "AfiseazaGR";
            this.AfiseazaGR.Size = new System.Drawing.Size(173, 31);
            this.AfiseazaGR.TabIndex = 34;
            this.AfiseazaGR.Text = "Afiseaza grafic";
            this.AfiseazaGR.UseVisualStyleBackColor = false;
            this.AfiseazaGR.Click += new System.EventHandler(this.AfiseazaGR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1092, 564);
            this.Controls.Add(this.Meniu);
            this.Controls.Add(this.titlu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Meniu.ResumeLayout(false);
            this.CitTab.ResumeLayout(false);
            this.CitTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCititori)).EndInit();
            this.CartiTab.ResumeLayout(false);
            this.CartiTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCarti)).EndInit();
            this.ImprTab.ResumeLayout(false);
            this.ImprTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvImprumuturi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titlu;
        private System.Windows.Forms.TabControl Meniu;
        private System.Windows.Forms.TabPage CitTab;
        private System.Windows.Forms.TabPage CartiTab;
        private System.Windows.Forms.TabPage ImprTab;
        private System.Windows.Forms.DataGridView gvCititori;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridView gvCarti;
        private System.Windows.Forms.Button AdCarti;
        private System.Windows.Forms.Button ModifCarti;
        private System.Windows.Forms.Button stergCarti;
        private System.Windows.Forms.Button modifCit;
        private System.Windows.Forms.Button AdCi;
        private System.Windows.Forms.TextBox tbCitPren;
        private System.Windows.Forms.TextBox tbCitTlf;
        private System.Windows.Forms.TextBox tbCitNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numeC;
        private System.Windows.Forms.TextBox tbEdit;
        private System.Windows.Forms.TextBox tbAn;
        private System.Windows.Forms.TextBox tbTitlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvImprumuturi;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btStgImpr;
        private System.Windows.Forms.Button adImpr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCarteImp;
        private System.Windows.Forms.TextBox tbCitImp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCititor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarteI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataImpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataScad;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnare;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtImpr;
        private System.Windows.Forms.DateTimePicker dtRetur;
        private System.Windows.Forms.DateTimePicker dtScad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbIdCit;
        private System.Windows.Forms.Button stergCit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox IdCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titlul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editura;
        private System.Windows.Forms.DataGridViewTextBoxColumn An;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cota;
        private System.Windows.Forms.Button AfisCarti;
        private System.Windows.Forms.Button AfisCit;
        private System.Windows.Forms.Button AfiseazaGR;
    }
}

