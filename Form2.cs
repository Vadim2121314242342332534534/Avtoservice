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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadUsersJSON AllBus = new ReadUsersJSON();
            AllBus.Read();
            List<Form1.Users> AddUser = AllBus.UUsers;

            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Введите необходимые данные для регистрации");
            }
            else
            {

                List<Form1.Users> User = new List<Form1.Users>();
                AddUser.Add(new Form1.Users() { ID = AddUser.Count + 1, FIO = textBox1.Text, Login = textBox3.Text, Parol = textBox4.Text });

                using (StreamWriter sw = new StreamWriter("Users.json"))
                {
                  sw.WriteLine(JsonConvert.SerializeObject(AddUser));
                  //  sw.Close();
                }

                this.Close();

                }
            }
        class ReadUsersJSON

        {
            public List<Form1.Users> UUsers = new List<Form1.Users>();

            public void Read()

            {
                using (StreamReader sr = new StreamReader("Users.json"))

                {
                    //if (JsonConvert.DeserializeObject<Form1.Users[]>(sr.ReadLine())!= null)
                   // {
                        foreach (var t in JsonConvert.DeserializeObject<Form1.Users[]>(sr.ReadLine()))
                        {
                            UUsers.Add(t);
                        }
                   // }
                }
            }
        }
    }
}

