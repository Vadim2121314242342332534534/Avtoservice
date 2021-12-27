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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.groupBox1.Visible == true)
            {
                this.groupBox1.Visible = false;
            }
            else
            {
                this.groupBox1.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.groupBox2.Visible == true)
            {
                this.groupBox2.Visible = false;
            }
            else
            {
                this.groupBox2.Visible = true;
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            foreach(var t in Form3.Clientss)
            {
                comboBox1.Items.Add(t.Name_Clients);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                  Form3.Clientss.Add(new Form3.Clients() { ID = Form3.Clientss.Count+1,Name_Clients=textBox1.Text,Phone_Number=textBox3.Text});
                using (StreamWriter sw = new StreamWriter("Clients.json"))
                {
                    sw.WriteLine(JsonConvert.SerializeObject(Form3.Clientss));
                }
            }
            if(radioButton2.Checked == true)
            {
                foreach (var t in Form3.Clientss)
                {
                    if(comboBox1.SelectedItem.ToString() == t.Name_Clients)
                    {
                        Form3.Clientss.Remove(t);
                        break;
                    }
                }
                using (StreamWriter sw = new StreamWriter("Clients.json"))
                {
                    sw.WriteLine(JsonConvert.SerializeObject(Form3.Clientss));
                }
            }
           
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
