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
    public partial class musteriOdeme : Form
    {
        public musteriOdeme()
        {
            InitializeComponent();
        }
        connection connec = new connection();
        private int musteriID;
        private double genelToplam = 0;

        private void sorgu_btn_Click(object sender, EventArgs e)
        {
            musteriID = 0;
            isimbox.Text = "";
            foreach (var musteri in connec.musteriler)
            {
                if (musteri.telNO == telefonNo_box.Text)
                {
                    musteriID = musteri.musteriID; 
                    isimbox.Text = musteri.isimSoyisim;


                }

            }
            foreach (var deger in connec.musteriOzet)
            {
                if (deger.musteriID == musteriID)
                {
                    genelToplam += deger.tutar.Value;
                }
            }
            borcbox.Text = genelToplam.ToString();



            if (musteriID != 0)
            {

                this.Width = 1100;
                this.Height = 440;
            }
            if (isimbox.Text == "")
            {
                MessageBox.Show("böyle bir müşteri bulunamadı");
                this.Width = 340;
                this.Height = 175;
            }
            NewMethod();

        }

        private void NewMethod()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            var q = from musteri in connec.musteriOzet
                    where musteri.musteriID == musteriID
                    orderby musteri.tarih descending
                    select new
                    {
                        faturaID = musteri.faturaID,
                        tarih = musteri.tarih.ToString(),
                        tutar = musteri.tutar,
                    };



            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Bilgi";
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Name = "ID";
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Name = "Tarih";
            dataGridView1.Columns[3].Name = "Tutar";
            DataGridViewButtonColumn btnIptal = new DataGridViewButtonColumn();
            btnIptal.UseColumnTextForButtonValue = true;
            btnIptal.HeaderText = "Ayrıntı";
            btnIptal.Text = "Ayrıntılar";
            btnIptal.Width = 100;
            dataGridView1.Columns.Add(btnIptal);
            int i = 0;
            foreach (var deger in q.ToList())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = 35;
                if (deger.faturaID.HasValue)
                {
                    dataGridView1.Rows[i].Cells[0].Value = "FaturaID : ";
                    dataGridView1.Rows[i].Cells[1].Value = deger.faturaID;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[0].Value = "Borç Ödeme";
                    dataGridView1.Rows[i].Cells[1].Value = deger.faturaID;
                }
                
                dataGridView1.Rows[i].Cells[2].Value = deger.tarih;
                dataGridView1.Rows[i].Cells[3].Value = deger.tutar;
                i++;
            }
        }


        private void odemeForm_Load(object sender, EventArgs e)
        {
            this.Width = 340;
            this.Height = 175;
        }
        musteriOzet musteriOzet = new musteriOzet();
        private void button1_Click(object sender, EventArgs e)
        {
            double odemetutar = Convert.ToDouble(odeme_txt.Text) ;
            if(odemetutar > Convert.ToDouble(borcbox.Text))
            {
                double a = odemetutar - Convert.ToDouble(borcbox.Text);
                MessageBox.Show("Borç sıfırlanmıştır. \n" + a.ToString() + "Para üstü veriniz.");
                odemetutar = Convert.ToDouble(borcbox.Text);

            }

            musteriOzet.musteriID = musteriID;
            musteriOzet.tutar = odemetutar * -1;
            musteriOzet.tarih = DateTime.Now;
            connec.musteriOzet.Add(musteriOzet);
            connec.SaveChanges();
            NewMethod();
            borcbox.Text = "0";
            
        }
        public static double formtutar = 0;
        public static int formfaturaid = 0;
        public static string formtarih;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                if (e.ColumnIndex == 4)
                {
                    int? a = 0;
                    a = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                    if (a>0)
                    {
                        formtarih = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value).ToString();
                        formtutar = Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                        formfaturaid = a.Value;
                        faturabilgi form = new faturabilgi();
                        form.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Borç ödemenin Ayrıntılarını göremezsiniz.");
                    }

                }
            }
        }
    }
    
}
