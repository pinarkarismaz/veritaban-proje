
namespace kafe
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblurun = new System.Windows.Forms.Label();
            this.lbladet = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblpersonel = new System.Windows.Forms.Label();
            this.txtpersonelid = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstokid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnlistele2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsiparisid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(637, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(856, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "MASA 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 86);
            this.button2.TabIndex = 2;
            this.button2.Text = "MASA 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 86);
            this.button3.TabIndex = 3;
            this.button3.Text = "MASA 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(190, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 86);
            this.button4.TabIndex = 4;
            this.button4.Text = "MASA 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Çay",
            "Latte",
            "Mocha",
            "Türk Kahvesi",
            "Filtre Kahve"});
            this.comboBox1.Location = new System.Drawing.Point(461, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Tag = "";
            // 
            // lblurun
            // 
            this.lblurun.AutoSize = true;
            this.lblurun.Location = new System.Drawing.Point(324, 99);
            this.lblurun.Name = "lblurun";
            this.lblurun.Size = new System.Drawing.Size(39, 17);
            this.lblurun.TabIndex = 6;
            this.lblurun.Text = "Ürün";
            // 
            // lbladet
            // 
            this.lbladet.AutoSize = true;
            this.lbladet.Location = new System.Drawing.Point(324, 138);
            this.lbladet.Name = "lbladet";
            this.lbladet.Size = new System.Drawing.Size(37, 17);
            this.lbladet.TabIndex = 7;
            this.lbladet.Text = "Adet";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox2.Location = new System.Drawing.Point(461, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // lblpersonel
            // 
            this.lblpersonel.AutoSize = true;
            this.lblpersonel.Location = new System.Drawing.Point(324, 177);
            this.lblpersonel.Name = "lblpersonel";
            this.lblpersonel.Size = new System.Drawing.Size(64, 17);
            this.lblpersonel.TabIndex = 9;
            this.lblpersonel.Text = "Personel";
            // 
            // txtpersonelid
            // 
            this.txtpersonelid.Location = new System.Drawing.Point(461, 172);
            this.txtpersonelid.Name = "txtpersonelid";
            this.txtpersonelid.Size = new System.Drawing.Size(121, 22);
            this.txtpersonelid.TabIndex = 10;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(461, 236);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(121, 23);
            this.btnekle.TabIndex = 11;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(72, 340);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(161, 23);
            this.btniptal.TabIndex = 12;
            this.btniptal.Text = "SİPARİŞ İPTALİ";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(1298, 261);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(195, 23);
            this.btnlistele.TabIndex = 13;
            this.btnlistele.Text = "SİPARİŞLERİ LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(282, 340);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ÜRÜN ID";
            // 
            // txtstokid
            // 
            this.txtstokid.Location = new System.Drawing.Point(732, 345);
            this.txtstokid.Name = "txtstokid";
            this.txtstokid.Size = new System.Drawing.Size(100, 22);
            this.txtstokid.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "YENİ STOK";
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(732, 383);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(100, 22);
            this.txtstok.TabIndex = 18;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(873, 381);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(126, 23);
            this.btnguncelle.TabIndex = 19;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnlistele2
            // 
            this.btnlistele2.Location = new System.Drawing.Point(1298, 299);
            this.btnlistele2.Name = "btnlistele2";
            this.btnlistele2.Size = new System.Drawing.Size(195, 23);
            this.btnlistele2.TabIndex = 20;
            this.btnlistele2.Text = "ÜRÜNLERİ LİSTELE";
            this.btnlistele2.UseVisualStyleBackColor = true;
            this.btnlistele2.Click += new System.EventHandler(this.btnlistele2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Siparis id";
            // 
            // txtsiparisid
            // 
            this.txtsiparisid.Location = new System.Drawing.Point(461, 50);
            this.txtsiparisid.Name = "txtsiparisid";
            this.txtsiparisid.Size = new System.Drawing.Size(121, 22);
            this.txtsiparisid.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 444);
            this.Controls.Add(this.txtsiparisid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnlistele2);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstokid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtpersonelid);
            this.Controls.Add(this.lblpersonel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lbladet);
            this.Controls.Add(this.lblurun);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblurun;
        private System.Windows.Forms.Label lbladet;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblpersonel;
        private System.Windows.Forms.TextBox txtpersonelid;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstokid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnlistele2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsiparisid;
    }
}

