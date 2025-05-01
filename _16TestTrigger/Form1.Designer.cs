namespace _16TestTrigger
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnekle = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.txtyayınevi = new System.Windows.Forms.TextBox();
            this.txttur = new System.Windows.Forms.TextBox();
            this.brnsil = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.brnsil);
            this.groupBox1.Controls.Add(this.txttur);
            this.groupBox1.Controls.Add(this.txtyayınevi);
            this.groupBox1.Controls.Add(this.txtsayfa);
            this.groupBox1.Controls.Add(this.txtyazar);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // btnekle
            // 
            this.btnekle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Appearance.Options.UseFont = true;
            this.btnekle.Location = new System.Drawing.Point(104, 268);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(81, 36);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "Ekle";
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yazar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sayfa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yayınevi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tür:";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(104, 58);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(169, 29);
            this.txtid.TabIndex = 7;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(104, 93);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(169, 29);
            this.txtad.TabIndex = 8;
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(104, 128);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(169, 29);
            this.txtyazar.TabIndex = 9;
            // 
            // txtsayfa
            // 
            this.txtsayfa.Location = new System.Drawing.Point(104, 163);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(169, 29);
            this.txtsayfa.TabIndex = 10;
            // 
            // txtyayınevi
            // 
            this.txtyayınevi.Location = new System.Drawing.Point(104, 198);
            this.txtyayınevi.Name = "txtyayınevi";
            this.txtyayınevi.Size = new System.Drawing.Size(169, 29);
            this.txtyayınevi.TabIndex = 11;
            // 
            // txttur
            // 
            this.txttur.Location = new System.Drawing.Point(104, 233);
            this.txttur.Name = "txttur";
            this.txttur.Size = new System.Drawing.Size(169, 29);
            this.txttur.TabIndex = 12;
            // 
            // brnsil
            // 
            this.brnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brnsil.Appearance.Options.UseFont = true;
            this.brnsil.Location = new System.Drawing.Point(191, 268);
            this.brnsil.Name = "brnsil";
            this.brnsil.Size = new System.Drawing.Size(81, 36);
            this.brnsil.TabIndex = 13;
            this.brnsil.Text = "Sil";
            this.brnsil.Click += new System.EventHandler(this.brnsil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(347, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 428);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kitap Adet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1052, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnekle;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton brnsil;
        private System.Windows.Forms.TextBox txttur;
        private System.Windows.Forms.TextBox txtyayınevi;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

