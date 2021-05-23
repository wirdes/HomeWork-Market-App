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
    public partial class grafikform : Form
    {
        public grafikform()
        {
            InitializeComponent();
        }
        connection connection = new connection();
        private void grafikform_Load(object sender, EventArgs e)
        {
            chart1.Visible = false;
            groupBox2.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;

            foreach(var i in connection.urunler)
            {
                comboBox1.Items.Add(i.urunAdi);
            }
            
        }

        private int getpesin(String adi)
        {
            int id = -1;
            int miktar = 0;
            foreach(var deger in connection.urunler)
            {
                if(deger.urunAdi == adi)
                {
                    id = deger.urunID;
                }
            }
            foreach(var deger in connection.satis)
            {
                if(id == deger.urunID && deger.satisTipi == "Peşin")
                {
                    miktar += deger.miktar.Value;
                }
            }
            return miktar;
        }
        private int getcari(String adi)
        {
            int id = -1;
            int miktar = 0;
            foreach (var deger in connection.urunler)
            {
                if (deger.urunAdi == adi)
                {
                    id = deger.urunID;
                }
            }
            foreach (var deger in connection.satis)
            {
                if (id == deger.urunID && deger.satisTipi == "Cari")
                {
                    miktar += deger.miktar.Value;
                }
            }

            return miktar;

        }
        private double getcariTutar( )
        {
           
            double miktar = 0;

            foreach (var deger in connection.satis)
            {
                if (deger.satisTipi == "Cari")
                {
                    miktar += deger.tutar.Value;
                }
            }
            return miktar;
        }
        private int getcariMiktar( )
        {
            
            int miktar = 0;

            foreach (var deger in connection.satis)
            {
                if (deger.satisTipi == "Cari")
                {
                    miktar += deger.miktar.Value;
                }
            }
            return miktar;
        }
        private double getPesinTutar( )
        {
           
            double miktar = 0;

            foreach (var deger in connection.satis)
            {
                if (deger.satisTipi == "Peşin")
                {
                    miktar += deger.tutar.Value;
                }
            }
            return miktar;
        }
        private int getPesinMiktar()
        {
            
            int miktar = 0;

            foreach (var deger in connection.satis)
            {
                if (deger.satisTipi == "Peşin")
                {
                    miktar += deger.miktar.Value;
                }
            }
            return miktar;
        }

        private double getfiyat(String adi)
        {
            double fiyat = 0.0;
            foreach(var i in connection.urunler)
            {
                if ( adi == i.urunAdi)
                {
                    fiyat = i.birimFiyati.Value + (i.birimFiyati.Value * 20 / 100);
                }
            }

            return fiyat;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            String urunAdi = comboBox1.Text;
            chart1.Series.Add(urunAdi);
            chart1.Series[urunAdi].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series[urunAdi].Points.Add(getcari(urunAdi));
            chart1.Series[urunAdi].Points.Add(getpesin(urunAdi));
            chart1.Series[urunAdi].Points[0].AxisLabel = ("Cari " + getcari(urunAdi) + " Adet");
            chart1.Series[urunAdi].Points[1].AxisLabel = ("Peşin " + getpesin(urunAdi) + " Adet");
            chart1.Series[urunAdi].Points[0].Color = Color.Aqua;
            chart1.Series[urunAdi].Points[1].Color = Color.Chocolate;
            double durum = (getfiyat(urunAdi) * (Convert.ToDouble(getpesin(urunAdi))) - ((getfiyat(urunAdi) * Convert.ToDouble(getcari(urunAdi)))));
            textBox1.Text = durum.ToString();
            if (durum > 0)
            {
                label1.Text = "TL KAR";
            }
            else
            {
                durum *= -1;
                label1.Text = "TL ZARAR";
            }

        }

        private void NewMethod()
        {
            chart1.Series.Clear();
            String urunAdi = comboBox1.Text;
            chart1.Series.Add("Toplam");
            chart1.Series["Toplam"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series["Toplam"].Points.Add(getcariTutar());
            chart1.Series["Toplam"].Points.Add(getPesinTutar());
            chart1.Series["Toplam"].Points[0].AxisLabel = ("Cari " + getcariMiktar() + " Adet");
            chart1.Series["Toplam"].Points[1].AxisLabel = ("Peşin " + getPesinMiktar() + " Adet");
            chart1.Series["Toplam"].Points[0].Color = Color.Aqua;
            chart1.Series["Toplam"].Points[1].Color = Color.Chocolate;

            double durum = getPesinTutar() - getcariTutar();
            textBox1.Text = durum.ToString();
            if (durum > 0)
            {
                label1.Text = "TL KAR";
            }
            else
            {
                durum *= -1;
                label1.Text = "TL ZARAR";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == false)
            {
                chart1.Visible = true;
                groupBox2.Visible = true;
                label1.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                chart1.Visible = true;
                label1.Visible = true;
                textBox1.Visible = true;
                NewMethod();
                groupBox2.Visible = false;

            }
        }


    }
}
