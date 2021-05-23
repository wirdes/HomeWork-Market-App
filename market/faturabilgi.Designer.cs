
namespace market
{
    partial class faturabilgi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tarih_txt = new System.Windows.Forms.Label();
            this.tutar_txt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 443);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.label1.Location = new System.Drawing.Point(38, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "FATURA AYRINTILARI";
            // 
            // tarih_txt
            // 
            this.tarih_txt.AutoSize = true;
            this.tarih_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tarih_txt.Location = new System.Drawing.Point(284, 61);
            this.tarih_txt.Name = "tarih_txt";
            this.tarih_txt.Size = new System.Drawing.Size(69, 20);
            this.tarih_txt.TabIndex = 2;
            this.tarih_txt.Text = "TARİH :";
            // 
            // tutar_txt
            // 
            this.tutar_txt.AutoSize = true;
            this.tutar_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tutar_txt.Location = new System.Drawing.Point(252, 542);
            this.tutar_txt.Name = "tutar_txt";
            this.tutar_txt.Size = new System.Drawing.Size(110, 29);
            this.tutar_txt.TabIndex = 3;
            this.tutar_txt.Text = "TUTAR :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fatura İptal Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // faturabilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tutar_txt);
            this.Controls.Add(this.tarih_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "faturabilgi";
            this.Load += new System.EventHandler(this.faturabilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tarih_txt;
        private System.Windows.Forms.Label tutar_txt;
        private System.Windows.Forms.Button button1;
    }
}