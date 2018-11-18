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
namespace CRMApp
{
    public partial class Form1 : Form
    {
        musteriEntities db = new musteriEntities();
        
        
        public Form1()
        {
            InitializeComponent();
        }
        public static int idOtur;


        private void btnAra_Click(object sender, EventArgs e)
        {
            //Firma adina gore firma aramak
            dgvAra.Rows.Clear();
            if (!string.IsNullOrEmpty(txtAra.Text)){
                var musteri = db.liste.Where(m => m.Ad.Contains(txtAra.Text));
                

                foreach (liste ad in musteri){
                    dgvAra.Rows.Add(         ad.id,
                                              ad.Ad,
                                              ad.Telefon,
                                              ad.Adres,
                                              ad.Sexs);

                }
            }
        }
             
        private void btnGoster_Click(object sender, EventArgs e)
        {
            // DGV de secilen firmanin sag tarafta gosterilmesi
            int firmid = (int)dgvAra.SelectedCells[0].Value;
            var idTut = dgvAra.SelectedCells[2].Value.ToString();
            var bilgi = db.liste.Where(m => m.Telefon.Contains(idTut));
            foreach (liste liste in bilgi)
            {
                txtFirmaAd.Text = liste.Ad;
                txtFirmaAdres.Text = liste.Adres;
                txtFirmaTelefon.Text = liste.Telefon;
                txtFirmaSexs.Text = liste.Sexs;
               // txtFirmaBorc.Text = liste.Borc;
                richTextBox1.Text = liste.Rey;
            }
            checkedListBox1.Items.Clear();
            var mytodolist = db.ToDoList.Where(m => m.FirmaId == firmid);
            //ToDoList mytodolist = db.ToDoList.Find(firmid);
            foreach(ToDoList toDoList in mytodolist)
            {
                checkedListBox1.Items.Add(toDoList.id +" " +toDoList.ToDo);
            }

        }
                   
        private void btnAddFirma_Click(object sender, EventArgs e)
        {
            //Firma Ekleme penceresi
            AddFirma addFirma = new AddFirma();
            addFirma.ShowDialog();
        }

       

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            //Duzelt butonuna bastiktan sonra duzeltmenin acilmasi
            btnSave.Visible = true;
            txtFirmaAd.ReadOnly = false;
            txtFirmaAdres.ReadOnly = false;
            txtFirmaBorc.ReadOnly = false;
            txtFirmaSexs.ReadOnly = false;
            txtFirmaTelefon.ReadOnly = false;
            richTextBox1.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Firma profilinde yapilan degisikliklerin kaydedilmesi
            if (string.IsNullOrEmpty(txtFirmaAd.Text) || string.IsNullOrEmpty(txtFirmaAdres.Text) || string.IsNullOrEmpty(txtFirmaSexs.Text) || string.IsNullOrEmpty(txtFirmaTelefon.Text))
            {
                MessageBox.Show("XANALARI TAM DOLDURUN!");
                return;
            }
            else
            {
                int id = (int)dgvAra.SelectedCells[0].Value;
                liste mylist = db.liste.Find(id);
                               
                mylist.Ad = txtFirmaAd.Text;
                mylist.Adres = txtFirmaAdres.Text;
                mylist.Telefon = txtFirmaTelefon.Text;
                mylist.Sexs = txtFirmaSexs.Text;
                mylist.Rey = richTextBox1.Text;
                               
                db.SaveChanges();
            }
        }

        private void btnIsEkle_Click(object sender, EventArgs e)
        {
            //ToDoList e gorulecek isin eklenmesi
            idOtur = (int)dgvAra.SelectedCells[0].Value;
            AddToDo formadtodo = new AddToDo();
            formadtodo.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {


            //int count = checkedListBox1.Items.Count;
            //int y = 0;
            //for (int index = count; index > 0; index--)

            //{
            //    if (checkedListBox1.CheckedItems.Contains(checkedListBox1.Items[index - 1]))
            //    {
            //        string k = checkedListBox1.Text.ToString();
            //        string[] s = k.Split(' ');

            //        MessageBox.Show(s[y].ToString());
            //        checkedListBox1.Items.RemoveAt(index - 1);
            //        y++;
            //    }

            //}
            //int y = 0;
            //for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            //{

            //   // string id = checkedListBox1.Text.ToString().Substring(0,1);

            //   // MessageBox.Show(id);
            //    checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[y]);
            //    y++;

            //    //int checkedid = (Int32)id;
            //    //var checkeditems = db.ToDoList.Where(m => m.ToDo == (int)id);
            //}
        }
    }
}
