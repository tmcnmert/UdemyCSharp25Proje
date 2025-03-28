namespace _07Kelime_Ogren
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txting = new System.Windows.Forms.TextBox();
            this.txttr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsüre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblkemlime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe:";
            // 
            // txting
            // 
            this.txting.Location = new System.Drawing.Point(142, 30);
            this.txting.Name = "txting";
            this.txting.Size = new System.Drawing.Size(193, 29);
            this.txting.TabIndex = 2;
            // 
            // txttr
            // 
            this.txttr.Location = new System.Drawing.Point(142, 73);
            this.txttr.Name = "txttr";
            this.txttr.Size = new System.Drawing.Size(193, 29);
            this.txttr.TabIndex = 3;
            this.txttr.TextChanged += new System.EventHandler(this.txttr_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre:";
            // 
            // lblsüre
            // 
            this.lblsüre.AutoSize = true;
            this.lblsüre.Location = new System.Drawing.Point(413, 9);
            this.lblsüre.Name = "lblsüre";
            this.lblsüre.Size = new System.Drawing.Size(33, 23);
            this.lblsüre.TabIndex = 5;
            this.lblsüre.Text = "90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kelime:";
            // 
            // lblkemlime
            // 
            this.lblkemlime.AutoSize = true;
            this.lblkemlime.Location = new System.Drawing.Point(419, 36);
            this.lblkemlime.Name = "lblkemlime";
            this.lblkemlime.Size = new System.Drawing.Size(22, 23);
            this.lblkemlime.TabIndex = 7;
            this.lblkemlime.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 170);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblkemlime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsüre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttr);
            this.Controls.Add(this.txting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txting;
        private System.Windows.Forms.TextBox txttr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsüre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblkemlime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

