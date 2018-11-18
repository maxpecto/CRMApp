namespace CRMApp.Models
{
    partial class AddFirma
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
            this.txtAddAd = new System.Windows.Forms.TextBox();
            this.lblFirma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddSexs = new System.Windows.Forms.TextBox();
            this.btnElave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddAd
            // 
            this.txtAddAd.Location = new System.Drawing.Point(85, 8);
            this.txtAddAd.Name = "txtAddAd";
            this.txtAddAd.Size = new System.Drawing.Size(227, 20);
            this.txtAddAd.TabIndex = 0;
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(12, 15);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(50, 13);
            this.lblFirma.TabIndex = 1;
            this.lblFirma.Text = "Firma Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon";
            // 
            // txtAddTelefon
            // 
            this.txtAddTelefon.Location = new System.Drawing.Point(85, 34);
            this.txtAddTelefon.Name = "txtAddTelefon";
            this.txtAddTelefon.Size = new System.Drawing.Size(227, 20);
            this.txtAddTelefon.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adres";
            // 
            // txtAddAdres
            // 
            this.txtAddAdres.Location = new System.Drawing.Point(85, 60);
            this.txtAddAdres.Name = "txtAddAdres";
            this.txtAddAdres.Size = new System.Drawing.Size(227, 20);
            this.txtAddAdres.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mehsul Sexs";
            // 
            // txtAddSexs
            // 
            this.txtAddSexs.Location = new System.Drawing.Point(85, 86);
            this.txtAddSexs.Name = "txtAddSexs";
            this.txtAddSexs.Size = new System.Drawing.Size(227, 20);
            this.txtAddSexs.TabIndex = 6;
            // 
            // btnElave
            // 
            this.btnElave.Location = new System.Drawing.Point(132, 169);
            this.btnElave.Name = "btnElave";
            this.btnElave.Size = new System.Drawing.Size(75, 23);
            this.btnElave.TabIndex = 10;
            this.btnElave.Text = "ELAVE ET";
            this.btnElave.UseVisualStyleBackColor = true;
            this.btnElave.Click += new System.EventHandler(this.btnElave_Click);
            // 
            // AddFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 204);
            this.Controls.Add(this.btnElave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddSexs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddTelefon);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.txtAddAd);
            this.Name = "AddFirma";
            this.Text = "AddFirma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddSexs;
        private System.Windows.Forms.TextBox txtAddAd;
        private System.Windows.Forms.Button btnElave;
    }
}