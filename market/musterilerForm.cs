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
    public partial class musterilerForm : Form
    {
        musteriler musteri = new musteriler();
        public static int saticiID = 0;
        public static string kullaniciAdi;
        public static connection cn = new connection();
        public musterilerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saticiID = 0;
            if (!(maskedTextBox1.Text == "(   )    -" && textBox1.Text == "")) { 
                foreach (var musteri in cn.musteriler)
                {
                    if (musteri.telNO == maskedTextBox1.Text)
                    {
                        saticiID = musteri.musteriID;
                        kullaniciAdi = musteri.isimSoyisim;
                    }

                }
                if (saticiID != 0)
                {
                    MessageBox.Show("Telefon numarası "+kullaniciAdi+" tarafından kullanılıyor.Lütfen farklı numara giriniz.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }else
                {

                    musteri.isimSoyisim = textBox1.Text;
                    musteri.telNO = maskedTextBox1.Text;
                    cn.musteriler.Add(musteri);
                    cn.SaveChanges();
                    MessageBox.Show(textBox1.Text + " Başarıyla Eklenmiştir.");
                    textBox1.Clear();
                    maskedTextBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz.");
            }

            NewMethod();

        }

        private void musterilerForm_Load(object sender, EventArgs e)
        {
            NewMethod();
        }
        

        private  void NewMethod()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            var q = from musteri in cn.musteriler
                    select new
                    {
                        id = musteri.musteriID,
                        isim = musteri.isimSoyisim,
                        tel = musteri.telNO,
                    };



            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "İsim Soyisim";
            dataGridView1.Columns[2].Name = "Telefon Numarası";
            DataGridViewButtonColumn btnIptal = new DataGridViewButtonColumn();
            btnIptal.UseColumnTextForButtonValue = true;
            btnIptal.HeaderText = "Sil";
            btnIptal.Text = "Sil";
            btnIptal.Width = 75;
            dataGridView1.Columns.Add(btnIptal);
            int i = 0;
            foreach (var deger in q.ToList())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[1].Value = deger.isim;
                dataGridView1.Rows[i].Cells[2].Value = deger.tel;
                dataGridView1.Rows[i].Cells[0].Value = deger.id;

                i++;
            }

            i = 0;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                if (e.ColumnIndex == 3)
                {
                    int? a = 0;
                     a = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                    if (a != 0)
                    {
                        musteriler musteriler = cn.musteriler.First(u => u.musteriID == a);

                        cn.musteriler.Remove(musteriler);
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                        dataGridView1.Refresh();
                        cn.SaveChanges();
                        NewMethod();

                    }
                    else
                    {
                        MessageBox.Show("Bu alani silemezsiniz..");
                    }

                }
            }
        }
    }
}
