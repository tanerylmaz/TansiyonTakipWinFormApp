namespace TansiyonTakip
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
            this.lbDataList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddData = new System.Windows.Forms.Button();
            this.lblYuksekTansiyon = new System.Windows.Forms.Label();
            this.lbAnormalData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbDataList
            // 
            this.lbDataList.FormattingEnabled = true;
            this.lbDataList.Location = new System.Drawing.Point(12, 30);
            this.lbDataList.Name = "lbDataList";
            this.lbDataList.Size = new System.Drawing.Size(336, 407);
            this.lbDataList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tansiyon Verileriniz";
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(12, 443);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(336, 23);
            this.btnAddData.TabIndex = 2;
            this.btnAddData.Text = "Tansiyon Verisi Ekle";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // lblYuksekTansiyon
            // 
            this.lblYuksekTansiyon.AutoSize = true;
            this.lblYuksekTansiyon.Location = new System.Drawing.Point(351, 11);
            this.lblYuksekTansiyon.Name = "lblYuksekTansiyon";
            this.lblYuksekTansiyon.Size = new System.Drawing.Size(125, 13);
            this.lblYuksekTansiyon.TabIndex = 3;
            this.lblYuksekTansiyon.Text = "Anormal Tansiyon Verileri";
            // 
            // lbAnormalData
            // 
            this.lbAnormalData.FormattingEnabled = true;
            this.lbAnormalData.Location = new System.Drawing.Point(354, 30);
            this.lbAnormalData.Name = "lbAnormalData";
            this.lbAnormalData.Size = new System.Drawing.Size(722, 407);
            this.lbAnormalData.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 472);
            this.Controls.Add(this.lblYuksekTansiyon);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAnormalData);
            this.Controls.Add(this.lbDataList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDataList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Label lblYuksekTansiyon;
        private System.Windows.Forms.ListBox lbAnormalData;
    }
}

