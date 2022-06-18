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
using AppNet.Infrastructer.Persistence;

namespace AppNet.WinFormUI
{


    public partial class Settings : Form
    {

        
        
      

        public Settings()
        {
            //datalar dosyası yoksa label2.yaz
            //datalar varsa 
            //*forma yazdır
            //* connectinstrig oluştur VT Bağlanmayı dene bağlanamassan label2 yazdır


            InitializeComponent();

            var settings = DbSettings.Load();

            if (settings != null)
            {
                textBox1.Text = settings.Server;
                textBox2.Text = settings.Username;
                textBox3.Text = settings.Password;
                textBox4.Text = settings.Database;
            }
            else
            {
              label2.Text = "Forumu doldurun!";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            DbSettings dbsettings = new DbSettings();
            dbsettings.Server=textBox1.Text;
            dbsettings.Username = textBox2.Text;
            dbsettings.Password = textBox3.Text;
            dbsettings.Database = textBox4.Text;
            dbsettings.Save();
            var context = new ErpDbContext();
            context.Database.EnsureCreated();
            MessageBox.Show("baglandi");
          
        }

        
    }
}
