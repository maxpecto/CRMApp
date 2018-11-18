using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMApp.Models;

namespace CRMApp.Models
{
    
    public partial class AddFirma : Form
    {
        musteriEntities db = new musteriEntities();
        public AddFirma()
        {
            InitializeComponent();
        }

        private void btnElave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtAddAd.Text) || string.IsNullOrEmpty(txtAddAdres.Text) || string.IsNullOrEmpty(txtAddSexs.Text) || string.IsNullOrEmpty(txtAddTelefon.Text)){
                MessageBox.Show("XANALARI TAM DOLDURUN!");
                return;
            }
            if(db.liste.FirstOrDefault(l => l.Telefon == txtAddTelefon.Text) == null)
            {
                liste liste = new liste
                {
                    Ad = txtAddAd.Text,
                    Adres = txtAddAdres.Text,
                    Telefon = txtAddTelefon.Text,
                    Sexs = txtAddTelefon.Text
                };
                db.liste.Add(liste);
                db.SaveChanges();
                MessageBox.Show("FIRMA ELAVE OLUNDU");
            }
        }
    }
}
