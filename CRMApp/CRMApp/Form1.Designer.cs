namespace CRMApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFirmaBorc = new System.Windows.Forms.TextBox();
            this.txtFirmaSexs = new System.Windows.Forms.TextBox();
            this.txtFirmaTelefon = new System.Windows.Forms.TextBox();
            this.txtFirmaAdres = new System.Windows.Forms.TextBox();
            this.txtFirmaAd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAra = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddFirma = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnIsEkle = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAra)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "ISLER GORULDU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Location = new System.Drawing.Point(274, 15);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(75, 23);
            this.btnDuzelt.TabIndex = 11;
            this.btnDuzelt.Text = "DUZELT";
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "TO-DO LIST";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 352);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(349, 94);
            this.checkedListBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "QEYDLER";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 191);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(349, 142);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "BORC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Məhsul şəxs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Firma Telefonu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firma Adresi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Firma Adi:";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(3, 47);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(349, 23);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Axtar";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(3, 21);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(349, 20);
            this.txtAra.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIsEkle);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtFirmaBorc);
            this.panel2.Controls.Add(this.txtFirmaSexs);
            this.panel2.Controls.Add(this.txtFirmaTelefon);
            this.panel2.Controls.Add(this.txtFirmaAdres);
            this.panel2.Controls.Add(this.txtFirmaAd);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnDuzelt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.checkedListBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(466, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 504);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "GORULMUS ISLER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(274, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFirmaBorc
            // 
            this.txtFirmaBorc.Location = new System.Drawing.Point(112, 126);
            this.txtFirmaBorc.Name = "txtFirmaBorc";
            this.txtFirmaBorc.ReadOnly = true;
            this.txtFirmaBorc.Size = new System.Drawing.Size(156, 20);
            this.txtFirmaBorc.TabIndex = 17;
            // 
            // txtFirmaSexs
            // 
            this.txtFirmaSexs.Location = new System.Drawing.Point(112, 96);
            this.txtFirmaSexs.Name = "txtFirmaSexs";
            this.txtFirmaSexs.ReadOnly = true;
            this.txtFirmaSexs.Size = new System.Drawing.Size(156, 20);
            this.txtFirmaSexs.TabIndex = 16;
            // 
            // txtFirmaTelefon
            // 
            this.txtFirmaTelefon.Location = new System.Drawing.Point(112, 70);
            this.txtFirmaTelefon.Name = "txtFirmaTelefon";
            this.txtFirmaTelefon.ReadOnly = true;
            this.txtFirmaTelefon.Size = new System.Drawing.Size(156, 20);
            this.txtFirmaTelefon.TabIndex = 15;
            // 
            // txtFirmaAdres
            // 
            this.txtFirmaAdres.Location = new System.Drawing.Point(112, 44);
            this.txtFirmaAdres.Name = "txtFirmaAdres";
            this.txtFirmaAdres.ReadOnly = true;
            this.txtFirmaAdres.Size = new System.Drawing.Size(156, 20);
            this.txtFirmaAdres.TabIndex = 14;
            // 
            // txtFirmaAd
            // 
            this.txtFirmaAd.Location = new System.Drawing.Point(112, 18);
            this.txtFirmaAd.Name = "txtFirmaAd";
            this.txtFirmaAd.ReadOnly = true;
            this.txtFirmaAd.Size = new System.Drawing.Size(156, 20);
            this.txtFirmaAd.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAra);
            this.panel1.Controls.Add(this.btnAddFirma);
            this.panel1.Controls.Add(this.btnGoster);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.txtAra);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 504);
            this.panel1.TabIndex = 2;
            // 
            // dgvAra
            // 
            this.dgvAra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvAra.Location = new System.Drawing.Point(3, 74);
            this.dgvAra.Name = "dgvAra";
            this.dgvAra.Size = new System.Drawing.Size(452, 189);
            this.dgvAra.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FIRMA ADI";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TELEFON";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ADRES";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "MEHSUL SEXS";
            this.Column5.Name = "Column5";
            // 
            // btnAddFirma
            // 
            this.btnAddFirma.Location = new System.Drawing.Point(313, 408);
            this.btnAddFirma.Name = "btnAddFirma";
            this.btnAddFirma.Size = new System.Drawing.Size(142, 23);
            this.btnAddFirma.TabIndex = 5;
            this.btnAddFirma.Text = "Firma Elave Et";
            this.btnAddFirma.UseVisualStyleBackColor = true;
            this.btnAddFirma.Click += new System.EventHandler(this.btnAddFirma_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(358, 21);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(97, 49);
            this.btnGoster.TabIndex = 4;
            this.btnGoster.Text = "GOSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 269);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(452, 108);
            this.listBox2.TabIndex = 2;
            // 
            // btnIsEkle
            // 
            this.btnIsEkle.Location = new System.Drawing.Point(5, 452);
            this.btnIsEkle.Name = "btnIsEkle";
            this.btnIsEkle.Size = new System.Drawing.Size(75, 23);
            this.btnIsEkle.TabIndex = 7;
            this.btnIsEkle.Text = "IS EKLE";
            this.btnIsEkle.UseVisualStyleBackColor = true;
            this.btnIsEkle.Click += new System.EventHandler(this.btnIsEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDuzelt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnAddFirma;
        private System.Windows.Forms.DataGridView dgvAra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtFirmaBorc;
        private System.Windows.Forms.TextBox txtFirmaSexs;
        private System.Windows.Forms.TextBox txtFirmaTelefon;
        private System.Windows.Forms.TextBox txtFirmaAdres;
        private System.Windows.Forms.TextBox txtFirmaAd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIsEkle;
    }
}

