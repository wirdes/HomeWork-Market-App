using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace market
{
    public partial class girisForm : Form
    {
        public static int saticiID = 0;
        public static string kullaniciAdi;
        public static connection cn = new connection();
        public girisForm()
        {   
            InitializeComponent();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (var satici in cn.satici)
            {   
                if(satici.kullaniciAdi == textBox1.Text && satici.sifre == textBox2.Text)
                {
                    saticiID = satici.saticiID;
                    kullaniciAdi = satici.kullaniciAdi;
                    anaForm form = new anaForm();
                    this.Hide();
                    form.Show();

                }

            }
            if (saticiID == 0)
            {
                MessageBox.Show("Kullanıcı adı yada şifre yanlış");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
