namespace _23_List_Yapısı_ve_List_ile_Öğrenci_Bilgileri_Kaydetme_Uygulaması
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
            this.btnlistele2 = new System.Windows.Forms.Button();
            this.btnlistele1 = new System.Windows.Forms.Button();
            this.btnlistele3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.btnlistele4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlistele2
            // 
            this.btnlistele2.Location = new System.Drawing.Point(265, 368);
            this.btnlistele2.Name = "btnlistele2";
            this.btnlistele2.Size = new System.Drawing.Size(247, 37);
            this.btnlistele2.TabIndex = 0;
            this.btnlistele2.Text = "Listele 2";
            this.btnlistele2.UseVisualStyleBackColor = true;
            this.btnlistele2.Click += new System.EventHandler(this.btnlistele2_Click);
            // 
            // btnlistele1
            // 
            this.btnlistele1.Location = new System.Drawing.Point(12, 368);
            this.btnlistele1.Name = "btnlistele1";
            this.btnlistele1.Size = new System.Drawing.Size(247, 37);
            this.btnlistele1.TabIndex = 1;
            this.btnlistele1.Text = "Listele 1";
            this.btnlistele1.UseVisualStyleBackColor = true;
            this.btnlistele1.Click += new System.EventHandler(this.btnlistele1_Click);
            // 
            // btnlistele3
            // 
            this.btnlistele3.Location = new System.Drawing.Point(518, 368);
            this.btnlistele3.Name = "btnlistele3";
            this.btnlistele3.Size = new System.Drawing.Size(247, 37);
            this.btnlistele3.TabIndex = 2;
            this.btnlistele3.Text = "Listele 3";
            this.btnlistele3.UseVisualStyleBackColor = true;
            this.btnlistele3.Click += new System.EventHandler(this.btnlistele3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(12, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 349);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 23;
            this.listBox2.Location = new System.Drawing.Point(265, 1);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(247, 280);
            this.listBox2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 23;
            this.listBox3.Location = new System.Drawing.Point(518, 1);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(247, 349);
            this.listBox3.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 29);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sayı Arama:";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 23;
            this.listBox4.Location = new System.Drawing.Point(771, 1);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(247, 349);
            this.listBox4.TabIndex = 9;
            // 
            // btnlistele4
            // 
            this.btnlistele4.Location = new System.Drawing.Point(771, 368);
            this.btnlistele4.Name = "btnlistele4";
            this.btnlistele4.Size = new System.Drawing.Size(247, 37);
            this.btnlistele4.TabIndex = 8;
            this.btnlistele4.Text = "Listele 4";
            this.btnlistele4.UseVisualStyleBackColor = true;
            this.btnlistele4.Click += new System.EventHandler(this.btnlistele4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 428);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.btnlistele4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnlistele3);
            this.Controls.Add(this.btnlistele1);
            this.Controls.Add(this.btnlistele2);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlistele2;
        private System.Windows.Forms.Button btnlistele1;
        private System.Windows.Forms.Button btnlistele3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button btnlistele4;
    }
}

