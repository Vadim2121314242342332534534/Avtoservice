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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Menu = new Form3();
            Menu.Show();
            this.Close();
        }


            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void button3_Click(object sender, EventArgs e)
            {

            }

        public void read()
        {
            DataTable TABLITSA = new DataTable();
            TABLITSA.Columns.Add("ID", typeof(int));
            TABLITSA.Columns.Add("Пользователь", typeof(string));
            TABLITSA.Columns.Add("Услуга", typeof(string));
            TABLITSA.Columns.Add("Стоимость", typeof(int));
            dataGridView1.DataSource = Form3.Uslugg;

            for (int i = 0; i < Form3.Uslugg.Count; i++)
            {
                TABLITSA.Rows.Add(Form3.Uslugg[i].ID, Form3.Uslugg[i].polzovatel, Form3.Uslugg[i].Usluga, Form3.Uslugg[i].price);
            }

            dataGridView1.DataSource = TABLITSA;
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            read();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ADD = new Form9();
            ADD.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            read();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Delete = new Form10();
            Delete.Show();
        }
    }
}
