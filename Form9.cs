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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3.Uslugg.Add(new Form3.Uslugi() { ID = Form3.Clientss.Count + 1, Usluga = this.textBox1.Text, price =int.Parse(this.textBox2.Text), polzovatel = Form1.User[0].FIO });
            using (StreamWriter sw = new StreamWriter("Uslugi.json"))
            {
                sw.WriteLine(JsonConvert.SerializeObject(Form3.Uslugg));
            }
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!(Char.IsDigit(e.KeyChar))&&e.KeyChar!=8) 
             {
                e.Handled = true;
             } 
        
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
