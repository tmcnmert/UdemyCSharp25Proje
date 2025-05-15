namespace _19ResimTest
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
            this.btnrenkseç = new System.Windows.Forms.Button();
            this.btnresimseç = new System.Windows.Forms.Button();
            this.btnyazdır = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmetin = new System.Windows.Forms.TextBox();
            this.txtboyut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrenkseç
            // 
            this.btnrenkseç.Location = new System.Drawing.Point(12, 56);
            this.btnrenkseç.Name = "btnrenkseç";
            this.btnrenkseç.Size = new System.Drawing.Size(213, 38);
            this.btnrenkseç.TabIndex = 1;
            this.btnrenkseç.Text = "Renk Seç";
            this.btnrenkseç.UseVisualStyleBackColor = true;
            this.btnrenkseç.Click += new System.EventHandler(this.btnrenkseç_Click);
            // 
            // btnresimseç
            // 
            this.btnresimseç.Location = new System.Drawing.Point(12, 12);
            this.btnresimseç.Name = "btnresimseç";
            this.btnresimseç.Size = new System.Drawing.Size(213, 38);
            this.btnresimseç.TabIndex = 0;
            this.btnresimseç.Text = "Resim Seç";
            this.btnresimseç.UseVisualStyleBackColor = true;
            this.btnresimseç.Click += new System.EventHandler(this.btnresimseç_Click);
            // 
            // btnyazdır
            // 
            this.btnyazdır.Location = new System.Drawing.Point(12, 100);
            this.btnyazdır.Name = "btnyazdır";
            this.btnyazdır.Size = new System.Drawing.Size(213, 38);
            this.btnyazdır.TabIndex = 2;
            this.btnyazdır.Text = "Yazdır";
            this.btnyazdır.UseVisualStyleBackColor = true;
            this.btnyazdır.Click += new System.EventHandler(this.btnyazdır_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnkaydet.Location = new System.Drawing.Point(12, 144);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(213, 38);
            this.btnkaydet.TabIndex = 3;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metin:";
            // 
            // txtmetin
            // 
            this.txtmetin.Location = new System.Drawing.Point(81, 198);
            this.txtmetin.Name = "txtmetin";
            this.txtmetin.Size = new System.Drawing.Size(144, 29);
            this.txtmetin.TabIndex = 5;
            // 
            // txtboyut
            // 
            this.txtboyut.Location = new System.Drawing.Point(81, 233);
            this.txtboyut.Name = "txtboyut";
            this.txtboyut.Size = new System.Drawing.Size(144, 29);
            this.txtboyut.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Boyut:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(249, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnkaydet;
            this.ClientSize = new System.Drawing.Size(885, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtboyut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmetin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnyazdır);
            this.Controls.Add(this.btnresimseç);
            this.Controls.Add(this.btnrenkseç);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrenkseç;
        private System.Windows.Forms.Button btnresimseç;
        private System.Windows.Forms.Button btnyazdır;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmetin;
        private System.Windows.Forms.TextBox txtboyut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

