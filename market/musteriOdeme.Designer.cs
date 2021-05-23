
namespace market
{
    partial class musteriOdeme
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
            this.cariGroup = new System.Windows.Forms.GroupBox();
            this.telefonNo_box = new System.Windows.Forms.MaskedTextBox();
            this.sorgu_btn = new System.Windows.Forms.Button();
            this.musteriID_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.borcbox = new System.Windows.Forms.TextBox();
            this.isim_text = new System.Windows.Forms.Label();
            this.isimbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.odeme_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cariGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cariGroup
            // 
            this.cariGroup.Controls.Add(this.telefonNo_box);
            this.cariGroup.Controls.Add(this.sorgu_btn);
            this.cariGroup.Controls.Add(this.musteriID_text);
            this.cariGroup.Location = new System.Drawing.Point(21, 24);
            this.cariGroup.Name = "cariGroup";
            this.cariGroup.Size = new System.Drawing.Size(277, 95);
            this.cariGroup.TabIndex = 46;
            this.cariGroup.TabStop = false;
            this.cariGroup.Text = "Sorgu";
            // 
            // telefonNo_box
            // 
            this.telefonNo_box.Location = new System.Drawing.Point(8, 39);
            this.telefonNo_box.Mask = "(999) 000-0000";
            this.telefonNo_box.Name = "telefonNo_box";
            this.telefonNo_box.Size = new System.Drawing.Size(150, 20);
            this.telefonNo_box.TabIndex = 49;
            // 
            // sorgu_btn
            // 
            this.sorgu_btn.Location = new System.Drawing.Point(184, 37);
            this.sorgu_btn.Name = "sorgu_btn";
            this.sorgu_btn.Size = new System.Drawing.Size(75, 23);
            this.sorgu_btn.TabIndex = 46;
            this.sorgu_btn.Text = "Sorgu";
            this.sorgu_btn.UseVisualStyleBackColor = true;
            this.sorgu_btn.Click += new System.EventHandler(this.sorgu_btn_Click);
            // 
            // musteriID_text
            // 
            this.musteriID_text.AutoSize = true;
            this.musteriID_text.Location = new System.Drawing.Point(5, 16);
            this.musteriID_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.musteriID_text.Name = "musteriID_text";
            this.musteriID_text.Size = new System.Drawing.Size(90, 13);
            this.musteriID_text.TabIndex = 45;
            this.musteriID_text.Text = "Telefon Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Müşteri Adı-Soyadı";
            // 
            // borcbox
            // 
            this.borcbox.Enabled = false;
            this.borcbox.Location = new System.Drawing.Point(36, 128);
            this.borcbox.Margin = new System.Windows.Forms.Padding(2);
            this.borcbox.Name = "borcbox";
            this.borcbox.Size = new System.Drawing.Size(150, 20);
            this.borcbox.TabIndex = 51;
            // 
            // isim_text
            // 
            this.isim_text.AutoSize = true;
            this.isim_text.Location = new System.Drawing.Point(33, 105);
            this.isim_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isim_text.Name = "isim_text";
            this.isim_text.Size = new System.Drawing.Size(85, 13);
            this.isim_text.TabIndex = 52;
            this.isim_text.Text = "Borc Miktarı (TL)";
            // 
            // isimbox
            // 
            this.isimbox.Enabled = false;
            this.isimbox.Location = new System.Drawing.Point(36, 75);
            this.isimbox.Margin = new System.Windows.Forms.Padding(2);
            this.isimbox.Name = "isimbox";
            this.isimbox.Size = new System.Drawing.Size(150, 20);
            this.isimbox.TabIndex = 53;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isimbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.isim_text);
            this.groupBox1.Controls.Add(this.borcbox);
            this.groupBox1.Location = new System.Drawing.Point(21, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 209);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.odeme_txt);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox2.Location = new System.Drawing.Point(335, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 353);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ödeme Tutarı :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ödeme Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // odeme_txt
            // 
            this.odeme_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.odeme_txt.Location = new System.Drawing.Point(560, 54);
            this.odeme_txt.Name = "odeme_txt";
            this.odeme_txt.Size = new System.Drawing.Size(128, 26);
            this.odeme_txt.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // musteriOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1081, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cariGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "musteriOdeme";
            this.Load += new System.EventHandler(this.odemeForm_Load);
            this.cariGroup.ResumeLayout(false);
            this.cariGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cariGroup;
        private System.Windows.Forms.MaskedTextBox telefonNo_box;
        private System.Windows.Forms.Button sorgu_btn;
        private System.Windows.Forms.Label musteriID_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox borcbox;
        private System.Windows.Forms.Label isim_text;
        private System.Windows.Forms.TextBox isimbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox odeme_txt;
        private System.Windows.Forms.Label label2;
    }
}