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
    public partial class anaForm : Form
    {
        public string saticiAdi = girisForm.kullaniciAdi;
        
        public anaForm()
        {
            

            InitializeComponent();
        }


       

        private void Form2_Load(object sender, EventArgs e)
        {
                
            this.label1.Text ="Hoşgeldiniz :" + saticiAdi;
        
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
 
                Application.Exit();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            satisForm satisForm = new satisForm();
            satisForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            urunlerForm urunlerForm = new urunlerForm();
            urunlerForm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            musterilerForm musterilerForm = new musterilerForm();
            musterilerForm.Show();
        }

        private void anaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Çıkış yapılmadı");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musteriOdeme odemeForm = new musteriOdeme();
            odemeForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            raporForm raporForm = new raporForm();
            raporForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tedarikciOdemeForm form = new tedarikciOdemeForm();
            form.Show();
        }
    }
}
