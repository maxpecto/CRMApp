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
    
    public partial class AddToDo : Form
    {
        musteriEntities db = new musteriEntities();
        public AddToDo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)Form1.idOtur;
            
            ToDoList mytodolist = new ToDoList
            {
                ToDo = richTextBox1.Text,
                FirmaId = id,
                Status = true

            };


            db.ToDoList.Add(mytodolist);
            db.SaveChanges();
            MessageBox.Show("GORULECEK IS ELAVE OLUNDU");
        }
    }
    
}
