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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            foreach(var t in Form3.Uslugg)
            {
                this.comboBox1.Items.Add(t.Usluga);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var t in Form3.Uslugg)
            {
                if(this.comboBox1.SelectedItem.ToString()==t.Usluga)
                {
                    Form3.Uslugg.Remove(t);
                    break;
                }
            }
            using (StreamWriter sw = new StreamWriter("Uslugi.json"))
                {
                    sw.WriteLine(JsonConvert.SerializeObject(Form3.Uslugg));
                }
                this.Close();

        }
    }
}
