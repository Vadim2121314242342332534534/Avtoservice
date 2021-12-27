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
    public partial class Form12 : Form
    {
        public Form12()
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

        private void Form12_Load(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            foreach (var t in Form3.Clientss)
            {
                this.comboBox2.Items.Add(t.Name_Clients);
            }
            foreach (var t in Form3.CCars)
            {
                this.comboBox1.Items.Add(t.ID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                //Добавить автомобиль
                foreach (var t in Form3.Clientss)
                {
                    if (comboBox2.SelectedItem.ToString() == t.Name_Clients)
                    {
                        Form3.CCars.Add(new Form3.Cars() { ID = Form3.CCars.Count, Model = textBox3.Text, Colors = textBox2.Text, Proizvodytel = textBox1.Text, ID_Clients = t.ID, Name_Client = t.Name_Clients });
                        break;
                    }
                }
                using (StreamWriter sw = new StreamWriter("Cars.json"))
                {
                    sw.WriteLine(JsonConvert.SerializeObject(Form3.CCars));
                }
            }
            else
            {
                foreach (var t in Form3.CCars)
                {
                    if (this.comboBox1.SelectedItem.ToString() == t.ID.ToString())
                    {
                        Form3.CCars.Remove(t);
                        break;
                    }
                    //Удалить автомобиль

                }
                using (StreamWriter sw = new StreamWriter("Cars.json"))
                {
                    sw.WriteLine(JsonConvert.SerializeObject(Form3.CCars));
                }

            }
            this.Close();
        }
    }
}
