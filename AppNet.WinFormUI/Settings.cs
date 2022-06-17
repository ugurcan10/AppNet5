using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;
using Microsoft.Graph;
using JsonSerializer = System.Text.Json.JsonSerializer;
using File = System.IO.File;
using Newtonsoft.Json.Linq;

namespace AppNet.WinFormUI
{
    public class Item
    {
        public string VTServer;
        public string VTUser;
        public string VTPass;
        public string VTTable;



    }

    public partial class Settings : Form
    {
        
        private const string dosyaYolu = "datalarrrrr.txt";
        public static void Yaz(string data)
        {  
            
            File.WriteAllText(dosyaYolu, data);
            
           
        }
        public Settings()
        {
            InitializeComponent();
            if (!File.Exists(dosyaYolu)) { label2.Text = "Veritabanı Ayarlı Değil"; label2.ForeColor = Color.Red; }
            else
            {
                string jsonData = File.ReadAllText(dosyaYolu);
                dynamic data = JObject.Parse(jsonData);

                textBox1.Text = data.VTServer;
                textBox2.Text = data.VTUser;
                textBox3.Text = data.VTPass;
                textBox4.Text = data.VTTable;


                 //veritabanına bağlan
                  //onuculabele yaz



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            var dictionary = new Dictionary<string, string>()
               {
                      { "VTServer", textBox1.Text },
                      { "VTUser",textBox2.Text },
                      { "VTPass",textBox3.Text},
                      {"VTTable",textBox4.Text}
                };

            var json = JsonSerializer.Serialize(dictionary);

            Yaz(json);
           
            




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
