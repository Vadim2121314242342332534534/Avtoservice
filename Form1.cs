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
    public partial class Form1 : Form
    {
        public static object PPerson;
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Users> User = new List<Users>();
        private void button4_Click(object sender, EventArgs e)
        {

            if(textBox1.Text==""| textBox2.Text == "")
            {
                MessageBox.Show("Вы не ввели Логин или Пароль");
            }
            else
            {
                //List<Users> User = new List<Users>();
                using (StreamReader sr = new StreamReader("Users.json"))

                {
                    foreach (var t in JsonConvert.DeserializeObject<Users[]>(sr.ReadLine()))
                    {
                        if(t.Login==textBox1.Text && t.Parol==textBox2.Text)
                        {
                            
                            User.Add(t);
                            //PPerson = User;

                            Form Menu = new Form3();
                            Menu.Show();
                        }                       
                    }
                   
                     
                        

                }

            }
        }
       
       public class Users

        {
            public int ID;
            public string FIO;
            public string Login;
            public string Parol;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Registration=new Form2();
            Registration.Show();
        }
    }
}
