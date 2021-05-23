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
    public partial class faturabilgi : Form
    {
        public faturabilgi()
        {
            InitializeComponent();
        }
        public static string kontrolad = "";
        private int faturaid = 0;
        private string tarih;
        private double tutar;
        connection connection = new connection();
            string fonk(string ad)
        {
            foreach (var urun in connection.urunler)
            {
                if (urun.urunID.ToString() == ad)
                {
                    ad = urun.urunAdi;
                }

            }
            return ad;
        }
        private void faturabilgi_Load(object sender, EventArgs e)
        {
            
            tutar = musteriOdeme.formtutar;
            tarih = musteriOdeme.formtarih;
            faturaid = musteriOdeme.formfaturaid;
            tutar_txt.Text += tutar.ToString();
            tarih_txt.Text += tarih;

            NewMethod();


        }
        connection cn = new connection();
        private void NewMethod()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            var q = from fatura in connection.satis
                    where fatura.faturaID == faturaid
                    select new
                    {
                        urunid = fatura.urunID.ToString(),
                        miktar = fatura.miktar,
                        tutar = fatura.tutar,
                    };



            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Ürün Adı";
            dataGridView1.Columns[1].Name = "Miktar";
            dataGridView1.Columns[2].Name = "Tutar";
           
            int i = 0;
            foreach (var deger in q.ToList())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = fonk(deger.urunid);
                dataGridView1.Rows[i].Cells[1].Value = deger.miktar;
                dataGridView1.Rows[i].Cells[2].Value = deger.tutar;
                i++;
            }
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = Microsoft.VisualBasic.Interaction.InputBox( girisForm.kullaniciAdi.ToUpper()+"\nYönetici Şifresini Giriniz.","Şifre Girişi");
            foreach (var satici in cn.satici)
            {
                if (satici.sifre == sifre)
                {
                    i++;
                }

            }
            if (i == 0)
            {
                MessageBox.Show("Kullanıcı adı yada şifre yanlış");
            }
            else
            {
                satis fatura = cn.satis.First(u => u.faturaID == faturaid);
                cn.satis.Remove(fatura);
                cn.SaveChanges();
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show( faturaid.ToString() + "' li fatura silinmiştir", "Başarılı İşlem", MessageBoxButtons.OK); ;
                if (dialog == DialogResult.OK)
                {
                    this.Close();
                }
         
            }

            
        }
         


    }
}
