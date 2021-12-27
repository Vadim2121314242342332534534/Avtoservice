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
    public partial class Form3 : Form
    {
        public class Journall
        {
            public int ID;
            public string Usluga;
            public int Price;
            public string Person;
            public string Client;
            public DateTime Date;
        }

        public class Uslugi
        {
            public int ID;
            public string Usluga;
            public int price;
            public string polzovatel;

        }

        public class Clients
        {
            public int ID;
            public string Name_Clients;
            public string Phone_Number;
        }

        public class Cars
        {
            public int ID;
            public string Proizvodytel;
            public string Model;
            public string Colors;
            public string Name_Client;
            public int ID_Clients;
        }


        public static List<Form3.Journall> Zapis = new List<Form3.Journall>();
        public static List<Form3.Uslugi> Uslugg = new List<Form3.Uslugi>();
        public static List<Form3.Clients> Clientss = new List<Form3.Clients>();
        public static List<Form3.Cars> CCars = new List<Form3.Cars>();

        public void read()
        {
            if (Zapis.Count == 0 | Uslugg.Count == 0|Clientss.Count==0)
            {
                using (StreamReader sr = new StreamReader("Cars.json"))
                {

                    foreach (var t in JsonConvert.DeserializeObject<Cars[]>(sr.ReadLine()))
                    {
                        CCars.Add(t);
                    }

                }
                using (StreamReader sr = new StreamReader("Journal.json"))
                {

                    foreach (var t in JsonConvert.DeserializeObject<Journall[]>(sr.ReadLine()))
                    {
                        Zapis.Add(t);
                    }

                }
                using (StreamReader sr = new StreamReader("Uslugi.json"))
                {
                    foreach (var t in JsonConvert.DeserializeObject<Uslugi[]>(sr.ReadLine()))
                    {
                        Uslugg.Add(t);
                    }
                }

                using (StreamReader sr = new StreamReader("Clients.json"))
                {
                    foreach (var t in JsonConvert.DeserializeObject<Clients[]>(sr.ReadLine()))
                    {
                        Clientss.Add(t);
                    }
                }

            }
        }
        


        public static object polz;
        public Form3()
        {
            InitializeComponent();

          //  persss.Add(User[0]);

             this.label1.Text = "Пользователь: " +Form1.User[0].FIO;
            
           // polz = Polzovatel;
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form Uslugi = new Form4();      //Услуги
            Uslugi.Show();
            this.Close();
            //Управление услугами автосервиса. С указанием автомобиля клиента, оказываемой
            //услуги / услуг, мастера, даты, стоимости и пр.

            //Пользователи,Журнал записи,список услуг,список клиентов,
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Clients = new Form5();
            Clients.Show();
            this.Close();
            //Клиенты
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Object t = 1;
            Form List = new Form6(t);
            List.Show();
            this.Close();
            //Журнал записей
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 Cars = new Form7();
            Cars.Show();
            this.Close();
            //Автомобили
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            read();

        }
    }
}
