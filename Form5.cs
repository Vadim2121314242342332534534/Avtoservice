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
    public partial class Form5 : Form
    {
        public Form5()
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


        public void Zapolnit_Table()
        {
            DataTable TABLITSA = new DataTable();
            TABLITSA.Columns.Add("ID", typeof(int));
            TABLITSA.Columns.Add("Имя клиента", typeof(string));
            TABLITSA.Columns.Add("Номер телефона", typeof(string));

            for (int i = 0; i < Form3.Clientss.Count; i++)
            {
                TABLITSA.Rows.Add(Form3.Clientss[i].ID, Form3.Clientss[i].Name_Clients, Form3.Clientss[i].Phone_Number) ;
            }

            dataGridView1.DataSource = TABLITSA;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Zapolnit_Table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form FF = new Form11();
            FF.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zapolnit_Table();
        }
    }
}
