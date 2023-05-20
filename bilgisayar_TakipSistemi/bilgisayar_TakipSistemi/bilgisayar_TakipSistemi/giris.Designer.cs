namespace bilgisayar_TakipSistemi
{
    partial class giris
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
            this.perplexTheme1 = new PerplexTheme();
            this.perplexControlBox1 = new PerplexControlBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.perplexButton1 = new PerplexButton();
            this.perplexLabel2 = new PerplexLabel();
            this.perplexLabel1 = new PerplexLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.perplexTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // perplexTheme1
            // 
            this.perplexTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.perplexTheme1.Controls.Add(this.linkLabel3);
            this.perplexTheme1.Controls.Add(this.perplexControlBox1);
            this.perplexTheme1.Controls.Add(this.linkLabel2);
            this.perplexTheme1.Controls.Add(this.linkLabel1);
            this.perplexTheme1.Controls.Add(this.perplexButton1);
            this.perplexTheme1.Controls.Add(this.perplexLabel2);
            this.perplexTheme1.Controls.Add(this.perplexLabel1);
            this.perplexTheme1.Controls.Add(this.textBox2);
            this.perplexTheme1.Controls.Add(this.textBox1);
            this.perplexTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.perplexTheme1.Location = new System.Drawing.Point(0, 0);
            this.perplexTheme1.Name = "perplexTheme1";
            this.perplexTheme1.Size = new System.Drawing.Size(252, 364);
            this.perplexTheme1.TabIndex = 0;
            this.perplexTheme1.Text = "Parça Bilgi Sistemleri";
            // 
            // perplexControlBox1
            // 
            this.perplexControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.perplexControlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.perplexControlBox1.Location = new System.Drawing.Point(192, 3);
            this.perplexControlBox1.Name = "perplexControlBox1";
            this.perplexControlBox1.Size = new System.Drawing.Size(75, 23);
            this.perplexControlBox1.TabIndex = 7;
            this.perplexControlBox1.Text = "perplexControlBox1";
            this.perplexControlBox1.Click += new System.EventHandler(this.perplexControlBox1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(47, 332);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(39, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Üye Ol";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(73, 287);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // perplexButton1
            // 
            this.perplexButton1.BackColor = System.Drawing.Color.Transparent;
            this.perplexButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.perplexButton1.Location = new System.Drawing.Point(50, 234);
            this.perplexButton1.Name = "perplexButton1";
            this.perplexButton1.Size = new System.Drawing.Size(119, 31);
            this.perplexButton1.TabIndex = 4;
            this.perplexButton1.Text = "Giriş";
            this.perplexButton1.Click += new System.EventHandler(this.giris_Click);
            // 
            // perplexLabel2
            // 
            this.perplexLabel2.BackColor = System.Drawing.Color.Transparent;
            this.perplexLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.perplexLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.perplexLabel2.Location = new System.Drawing.Point(19, 196);
            this.perplexLabel2.Name = "perplexLabel2";
            this.perplexLabel2.Size = new System.Drawing.Size(75, 23);
            this.perplexLabel2.TabIndex = 3;
            this.perplexLabel2.Text = "Şifre";
            // 
            // perplexLabel1
            // 
            this.perplexLabel1.BackColor = System.Drawing.Color.Transparent;
            this.perplexLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.perplexLabel1.Location = new System.Drawing.Point(19, 133);
            this.perplexLabel1.Name = "perplexLabel1";
            this.perplexLabel1.Size = new System.Drawing.Size(75, 23);
            this.perplexLabel1.TabIndex = 2;
            this.perplexLabel1.Text = "ID";
            this.perplexLabel1.Click += new System.EventHandler(this.perplexLabel1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(145, 332);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(36, 13);
            this.linkLabel3.TabIndex = 8;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Admin";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 364);
            this.Controls.Add(this.perplexTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giris";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.giris_Load);
            this.perplexTheme1.ResumeLayout(false);
            this.perplexTheme1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PerplexTheme perplexTheme1;
        private PerplexLabel perplexLabel2;
        private PerplexLabel perplexLabel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private PerplexButton perplexButton1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private PerplexControlBox perplexControlBox1;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}

