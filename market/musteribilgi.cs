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
    public partial class musteribilgi : Form
    {
        public musteribilgi()
        {
            InitializeComponent();
        }

        connection connec = new connection();
        double toplamTutar(int id,int urunId)
        {
            double toplamSatis = 0;
            foreach (var musteri in connec.satis)
            {
                if (musteri.musteriID == id && musteri.urunID == urunId)
                {
                    toplamSatis += musteri.tutar.Value;
                }
            }
            return toplamSatis;
        }
        int toplamMiktar(int id, int urunId)
        {
            int toplamMiktar = 0;
            foreach (var musteri in connec.satis)
            {
                if (musteri.musteriID == id && musteri.urunID == urunId)
                {
                    toplamMiktar += musteri.miktar.Value;
                }
            }
            return toplamMiktar;
        }

        string urunAdi(int id)
        {
            string ad = "";
            foreach (var musteri in connec.urunler)
            {
                if ( musteri.urunID == id)
                {
                    ad =  musteri.urunAdi;
                }
            }
            return ad;
        }
        private void musteribilgi_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].Name = "Ürün Adı";
            dataGridView1.Columns[2].Name = "Toplam Satış Miktarı";
            dataGridView1.Columns[3].Name = "Toplam Tutar";
            var q = from p in connec.satis
                    orderby p.miktar descending
                    group p by p.urunID into g
                    
                    select new
                    {
                       UrunıD=g.Key
                    };

            int i = 0;
            foreach (var deger in q.ToList())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = deger.UrunıD;
                dataGridView1.Rows[i].Cells[1].Value = urunAdi(deger.UrunıD.Value);
                dataGridView1.Rows[i].Cells[2].Value = toplamMiktar(raporForm.id, deger.UrunıD.Value);
                dataGridView1.Rows[i].Cells[3].Value = toplamTutar(raporForm.id, deger.UrunıD.Value);

                i++;
            }

            i = 0;



        }
    }
}
