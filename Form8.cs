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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            foreach(var t in Form3.Uslugg)
            {
                this.comboBox1.Items.Add(t.Usluga);
            }

            foreach(var t in Form3.Clientss)
            {
                this.comboBox2.Items.Add(t.Name_Clients);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var t in Form3.Uslugg)
            {
                if (this.comboBox1.SelectedItem.ToString()==t.Usluga)
                {
                    Form3.Zapis.Add(new Form3.Journall() { ID = Form3.Zapis.Count+ 1, Usluga =t.Usluga, Price =t.price , Person = Form1.User[0].FIO ,Date=this.dateTimePicker1.Value,Client=this.comboBox2.SelectedItem.ToString()});
                    break;
                }
            }


            using (StreamWriter sw = new StreamWriter("Journal.json"))
            {
                sw.WriteLine(JsonConvert.SerializeObject(Form3.Zapis));
            }
            this.Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
