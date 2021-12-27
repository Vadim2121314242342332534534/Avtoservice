using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace LR_10
{
    public partial class Form6 : Form
    {

        public Form6(object t)
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Form1.Users> T = new List<Form1.Users>();
            Form Menu = new Form3();
            Menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form Novaya_Zapis = new Form8();
            Novaya_Zapis.Show();

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Zapolnit_Table()
        {
             DataTable TABLITSA = new DataTable();
            TABLITSA.Columns.Add("ID", typeof(int));
            TABLITSA.Columns.Add("Пользователь", typeof(string));
            TABLITSA.Columns.Add("Услуга", typeof(string));
            TABLITSA.Columns.Add("Стоимость", typeof(int));
            TABLITSA.Columns.Add("Клиент",typeof(string));
            TABLITSA.Columns.Add("Дата", typeof(DateTime));

            for (int i = 0; i < Form3.Zapis.Count; i++)
            {
                TABLITSA.Rows.Add(Form3.Zapis[i].ID, Form3.Zapis[i].Person, Form3.Zapis[i].Usluga, Form3.Zapis[i].Price,Form3.Zapis[i].Client, Form3.Zapis[i].Date);
            }

            dataGridView1.DataSource = TABLITSA;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();
            Zapolnit_Table();

        }
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zapolnit_Table();

        }
    }
}

