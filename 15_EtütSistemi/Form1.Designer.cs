namespace _15_EtütSistemi
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnetutolustur = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbogr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbders = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtogrid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnetütver = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtders = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.btnogrekle = new System.Windows.Forms.Button();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsınıf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnogretmenekle = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbogretmenbrans = new System.Windows.Forms.ComboBox();
            this.txtogretmensoyad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtogretmenad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnetutolustur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.msksaat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbogr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.msktarih);
            this.groupBox1.Controls.Add(this.cmbders);
            this.groupBox1.Location = new System.Drawing.Point(2, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnetutolustur
            // 
            this.btnetutolustur.Location = new System.Drawing.Point(168, 200);
            this.btnetutolustur.Name = "btnetutolustur";
            this.btnetutolustur.Size = new System.Drawing.Size(132, 37);
            this.btnetutolustur.TabIndex = 9;
            this.btnetutolustur.Text = "Etüt Oluştur";
            this.btnetutolustur.UseVisualStyleBackColor = true;
            this.btnetutolustur.Click += new System.EventHandler(this.btnetutolustur_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saat:";
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(151, 156);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(193, 29);
            this.msksaat.TabIndex = 7;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tarih:";
            // 
            // cmbogr
            // 
            this.cmbogr.FormattingEnabled = true;
            this.cmbogr.Location = new System.Drawing.Point(151, 66);
            this.cmbogr.Name = "cmbogr";
            this.cmbogr.Size = new System.Drawing.Size(193, 31);
            this.cmbogr.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğretmen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ders:";
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(151, 112);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(193, 29);
            this.msktarih.TabIndex = 3;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbders
            // 
            this.cmbders.FormattingEnabled = true;
            this.cmbders.Location = new System.Drawing.Point(151, 19);
            this.cmbders.Name = "cmbders";
            this.cmbders.Size = new System.Drawing.Size(193, 31);
            this.cmbders.TabIndex = 2;
            this.cmbders.SelectedIndexChanged += new System.EventHandler(this.cmbders_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtogrid);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnetütver);
            this.groupBox2.Location = new System.Drawing.Point(475, -9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 140);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(450, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(454, 141);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(135, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 29);
            this.textBox1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Etüt Id:";
            // 
            // txtogrid
            // 
            this.txtogrid.Location = new System.Drawing.Point(135, 60);
            this.txtogrid.Name = "txtogrid";
            this.txtogrid.Size = new System.Drawing.Size(152, 29);
            this.txtogrid.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Öğrenci:";
            // 
            // btnetütver
            // 
            this.btnetütver.Location = new System.Drawing.Point(135, 95);
            this.btnetütver.Name = "btnetütver";
            this.btnetütver.Size = new System.Drawing.Size(132, 37);
            this.btnetütver.TabIndex = 12;
            this.btnetütver.Text = "Etüt Ver";
            this.btnetütver.UseVisualStyleBackColor = true;
            this.btnetütver.Click += new System.EventHandler(this.btnetütver_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(2, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1200, 248);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1194, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.txtders);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(475, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(454, 141);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Ders Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtders
            // 
            this.txtders.Location = new System.Drawing.Point(158, 22);
            this.txtders.Name = "txtders";
            this.txtders.Size = new System.Drawing.Size(152, 29);
            this.txtders.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Ders Adı:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.msktel);
            this.groupBox6.Controls.Add(this.btnogrekle);
            this.groupBox6.Controls.Add(this.txtmail);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txtsınıf);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtsoyad);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txtad);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(935, -4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(267, 275);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(99, 124);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(152, 29);
            this.msktel.TabIndex = 28;
            // 
            // btnogrekle
            // 
            this.btnogrekle.Location = new System.Drawing.Point(69, 211);
            this.btnogrekle.Name = "btnogrekle";
            this.btnogrekle.Size = new System.Drawing.Size(132, 37);
            this.btnogrekle.TabIndex = 27;
            this.btnogrekle.Text = "Öğrenci Ekle";
            this.btnogrekle.UseVisualStyleBackColor = true;
            this.btnogrekle.Click += new System.EventHandler(this.btnogrekle_Click);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(99, 159);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(152, 29);
            this.txtmail.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Telefon:";
            // 
            // txtsınıf
            // 
            this.txtsınıf.Location = new System.Drawing.Point(99, 89);
            this.txtsınıf.Name = "txtsınıf";
            this.txtsınıf.Size = new System.Drawing.Size(152, 29);
            this.txtsınıf.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sınıf:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(99, 54);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(152, 29);
            this.txtsoyad.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Soyad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(99, 20);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(152, 29);
            this.txtad.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ad:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Location = new System.Drawing.Point(1208, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(271, 244);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 31);
            this.button2.TabIndex = 28;
            this.button2.Text = "Fotoğraf Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnogretmenekle);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.cmbogretmenbrans);
            this.groupBox8.Controls.Add(this.txtogretmensoyad);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.txtogretmenad);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Location = new System.Drawing.Point(1208, 250);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(271, 258);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            // 
            // btnogretmenekle
            // 
            this.btnogretmenekle.Location = new System.Drawing.Point(52, 153);
            this.btnogretmenekle.Name = "btnogretmenekle";
            this.btnogretmenekle.Size = new System.Drawing.Size(170, 42);
            this.btnogretmenekle.TabIndex = 29;
            this.btnogretmenekle.Text = "Öğretmen Ekle";
            this.btnogretmenekle.UseVisualStyleBackColor = true;
            this.btnogretmenekle.Click += new System.EventHandler(this.btnogretmenekle_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 23);
            this.label15.TabIndex = 25;
            this.label15.Text = "Ders:";
            // 
            // cmbogretmenbrans
            // 
            this.cmbogretmenbrans.FormattingEnabled = true;
            this.cmbogretmenbrans.Location = new System.Drawing.Point(94, 88);
            this.cmbogretmenbrans.Name = "cmbogretmenbrans";
            this.cmbogretmenbrans.Size = new System.Drawing.Size(152, 31);
            this.cmbogretmenbrans.TabIndex = 26;
            this.cmbogretmenbrans.SelectedIndexChanged += new System.EventHandler(this.cmbogretmenbrans_SelectedIndexChanged);
            // 
            // txtogretmensoyad
            // 
            this.txtogretmensoyad.Location = new System.Drawing.Point(94, 53);
            this.txtogretmensoyad.Name = "txtogretmensoyad";
            this.txtogretmensoyad.Size = new System.Drawing.Size(152, 29);
            this.txtogretmensoyad.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = "Soyad:";
            // 
            // txtogretmenad
            // 
            this.txtogretmenad.Location = new System.Drawing.Point(94, 19);
            this.txtogretmenad.Name = "txtogretmenad";
            this.txtogretmenad.Size = new System.Drawing.Size(152, 29);
            this.txtogretmenad.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 23);
            this.label14.TabIndex = 21;
            this.label14.Text = "Ad:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1484, 513);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnetutolustur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbogr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.ComboBox cmbders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnetütver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtogrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnogrekle;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsınıf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtders;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnogretmenekle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbogretmenbrans;
        private System.Windows.Forms.TextBox txtogretmensoyad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtogretmenad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

