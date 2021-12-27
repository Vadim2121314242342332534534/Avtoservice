using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_10
{
    public partial class Form7 : Form
    {
        public Form7()
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
            Form New_Car = new Form12();
            New_Car.Show();
        }

        public void Zapolnit_Table()
        {
            DataTable TABLITSA = new DataTable();
            TABLITSA.Columns.Add("ID", typeof(int));
            TABLITSA.Columns.Add("Производитель", typeof(string));
            TABLITSA.Columns.Add("Модель", typeof(string));
            TABLITSA.Columns.Add("Цвет", typeof(string));
            TABLITSA.Columns.Add("Имя клиента", typeof(string));
            TABLITSA.Columns.Add("ID Клиента", typeof(int));

            for (int i = 0; i < Form3.CCars.Count; i++)
            {
                TABLITSA.Rows.Add(Form3.CCars[i].ID, Form3.CCars[i].Proizvodytel, Form3.CCars[i].Model, Form3.CCars[i].Colors, Form3.CCars[i].Name_Client, Form3.CCars[i].ID_Clients);
            }

            dataGridView1.DataSource = TABLITSA;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zapolnit_Table();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Zapolnit_Table();
        }
    }
}
