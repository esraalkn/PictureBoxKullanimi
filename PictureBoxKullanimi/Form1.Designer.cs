
namespace PictureBoxKullanimi
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
            this.lblvize1 = new System.Windows.Forms.Label();
            this.lblvize2 = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.txt1vize = new System.Windows.Forms.TextBox();
            this.txt2vize = new System.Windows.Forms.TextBox();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.picDurum = new System.Windows.Forms.PictureBox();
            this.lblort = new System.Windows.Forms.Label();
            this.rchOrtalama = new System.Windows.Forms.RichTextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDurum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblvize1
            // 
            this.lblvize1.AutoSize = true;
            this.lblvize1.Location = new System.Drawing.Point(138, 51);
            this.lblvize1.Name = "lblvize1";
            this.lblvize1.Size = new System.Drawing.Size(39, 13);
            this.lblvize1.TabIndex = 0;
            this.lblvize1.Text = "1.Vize:";
            // 
            // lblvize2
            // 
            this.lblvize2.AutoSize = true;
            this.lblvize2.Location = new System.Drawing.Point(138, 96);
            this.lblvize2.Name = "lblvize2";
            this.lblvize2.Size = new System.Drawing.Size(39, 13);
            this.lblvize2.TabIndex = 1;
            this.lblvize2.Text = "2.Vize:";
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(138, 143);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(32, 13);
            this.lblfinal.TabIndex = 2;
            this.lblfinal.Text = "Final:";
            // 
            // txt1vize
            // 
            this.txt1vize.Location = new System.Drawing.Point(215, 44);
            this.txt1vize.Name = "txt1vize";
            this.txt1vize.Size = new System.Drawing.Size(100, 20);
            this.txt1vize.TabIndex = 3;
            // 
            // txt2vize
            // 
            this.txt2vize.Location = new System.Drawing.Point(215, 89);
            this.txt2vize.Name = "txt2vize";
            this.txt2vize.Size = new System.Drawing.Size(100, 20);
            this.txt2vize.TabIndex = 4;
            // 
            // txtfinal
            // 
            this.txtfinal.Location = new System.Drawing.Point(215, 136);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(100, 20);
            this.txtfinal.TabIndex = 5;
            // 
            // picDurum
            // 
            this.picDurum.Location = new System.Drawing.Point(431, 44);
            this.picDurum.Name = "picDurum";
            this.picDurum.Size = new System.Drawing.Size(249, 214);
            this.picDurum.TabIndex = 6;
            this.picDurum.TabStop = false;
            // 
            // lblort
            // 
            this.lblort.AutoSize = true;
            this.lblort.Location = new System.Drawing.Point(77, 218);
            this.lblort.Name = "lblort";
            this.lblort.Size = new System.Drawing.Size(52, 13);
            this.lblort.TabIndex = 7;
            this.lblort.Text = "Ortalama:";
            // 
            // rchOrtalama
            // 
            this.rchOrtalama.Location = new System.Drawing.Point(141, 194);
            this.rchOrtalama.Name = "rchOrtalama";
            this.rchOrtalama.Size = new System.Drawing.Size(226, 96);
            this.rchOrtalama.TabIndex = 8;
            this.rchOrtalama.Text = "";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(345, 322);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(172, 23);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.rchOrtalama);
            this.Controls.Add(this.lblort);
            this.Controls.Add(this.picDurum);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.txt2vize);
            this.Controls.Add(this.txt1vize);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.lblvize2);
            this.Controls.Add(this.lblvize1);
            this.Name = "Form1";
            this.Text = "ORTALAMA HESAPLAMA PENCERESİ";
            ((System.ComponentModel.ISupportInitialize)(this.picDurum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvize1;
        private System.Windows.Forms.Label lblvize2;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.TextBox txt1vize;
        private System.Windows.Forms.TextBox txt2vize;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.PictureBox picDurum;
        private System.Windows.Forms.Label lblort;
        private System.Windows.Forms.RichTextBox rchOrtalama;
        private System.Windows.Forms.Button btnHesapla;
    }
}

