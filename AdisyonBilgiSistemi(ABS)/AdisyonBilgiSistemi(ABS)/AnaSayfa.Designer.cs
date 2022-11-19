namespace AdisyonBilgiSistemi_ABS_
{
    partial class AnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnkasa = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnmasa5 = new System.Windows.Forms.Button();
            this.btnmasa4 = new System.Windows.Forms.Button();
            this.btnmasa3 = new System.Windows.Forms.Button();
            this.btnmasa2 = new System.Windows.Forms.Button();
            this.btnmasa1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adisyon Bilgi Sistemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "(ABS)";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "png-transparent-black-arrow-inside-box-logo-computer-icons-scalable-graphics-desk" +
        "top-exit-icon-close-miscellaneous-angle-text.png");
            this.ımageList1.Images.SetKeyName(1, "png-transparent-calculator-icon-square-area-text-symbol-calculator-text-rectangle" +
        "-orange.png");
            this.ımageList1.Images.SetKeyName(2, "png-transparent-restaurant-drawing-coloring-book-menu-food-menu-food-text-logo.pn" +
        "g");
            this.ımageList1.Images.SetKeyName(3, "png-transparent-table-furniture-logo-computer-icons-table-angle-emblem-furniture." +
        "png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.btncikis);
            this.panel1.Controls.Add(this.btnkasa);
            this.panel1.Controls.Add(this.btnmenu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(295, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 419);
            this.panel1.TabIndex = 7;
            // 
            // btncikis
            // 
            this.btncikis.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncikis.ImageKey = "png-transparent-black-arrow-inside-box-logo-computer-icons-scalable-graphics-desk" +
    "top-exit-icon-close-miscellaneous-angle-text.png";
            this.btncikis.ImageList = this.ımageList1;
            this.btncikis.Location = new System.Drawing.Point(3, 325);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(148, 45);
            this.btncikis.TabIndex = 2;
            this.btncikis.Text = "Çıkış";
            this.btncikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnkasa
            // 
            this.btnkasa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkasa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkasa.ImageKey = "png-transparent-calculator-icon-square-area-text-symbol-calculator-text-rectangle" +
    "-orange.png";
            this.btnkasa.ImageList = this.ımageList1;
            this.btnkasa.Location = new System.Drawing.Point(3, 137);
            this.btnkasa.Name = "btnkasa";
            this.btnkasa.Size = new System.Drawing.Size(148, 45);
            this.btnkasa.TabIndex = 1;
            this.btnkasa.Text = "İşlemler";
            this.btnkasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkasa.UseVisualStyleBackColor = true;
            this.btnkasa.Click += new System.EventHandler(this.btnkasa_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmenu.ImageKey = "png-transparent-restaurant-drawing-coloring-book-menu-food-menu-food-text-logo.pn" +
    "g";
            this.btnmenu.ImageList = this.ımageList1;
            this.btnmenu.Location = new System.Drawing.Point(3, 77);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(148, 45);
            this.btnmenu.TabIndex = 0;
            this.btnmenu.Text = "Menü";
            this.btnmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(94, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Masalar";
            // 
            // btnmasa5
            // 
            this.btnmasa5.BackColor = System.Drawing.Color.Chocolate;
            this.btnmasa5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmasa5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmasa5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmasa5.ImageKey = "png-transparent-table-furniture-logo-computer-icons-table-angle-emblem-furniture." +
    "png";
            this.btnmasa5.ImageList = this.ımageList1;
            this.btnmasa5.Location = new System.Drawing.Point(54, 321);
            this.btnmasa5.Name = "btnmasa5";
            this.btnmasa5.Size = new System.Drawing.Size(165, 48);
            this.btnmasa5.TabIndex = 6;
            this.btnmasa5.Text = "Masa 5";
            this.btnmasa5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmasa5.UseVisualStyleBackColor = false;
            this.btnmasa5.Click += new System.EventHandler(this.btnmasa5_Click);
            // 
            // btnmasa4
            // 
            this.btnmasa4.BackColor = System.Drawing.Color.Chocolate;
            this.btnmasa4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmasa4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmasa4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmasa4.ImageKey = "png-transparent-table-furniture-logo-computer-icons-table-angle-emblem-furniture." +
    "png";
            this.btnmasa4.ImageList = this.ımageList1;
            this.btnmasa4.Location = new System.Drawing.Point(54, 256);
            this.btnmasa4.Name = "btnmasa4";
            this.btnmasa4.Size = new System.Drawing.Size(165, 48);
            this.btnmasa4.TabIndex = 5;
            this.btnmasa4.Text = "Masa 4";
            this.btnmasa4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmasa4.UseVisualStyleBackColor = false;
            this.btnmasa4.Click += new System.EventHandler(this.btnmasa4_Click);
            // 
            // btnmasa3
            // 
            this.btnmasa3.BackColor = System.Drawing.Color.Chocolate;
            this.btnmasa3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmasa3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmasa3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmasa3.ImageKey = "png-transparent-table-furniture-logo-computer-icons-table-angle-emblem-furniture." +
    "png";
            this.btnmasa3.ImageList = this.ımageList1;
            this.btnmasa3.Location = new System.Drawing.Point(54, 196);
            this.btnmasa3.Name = "btnmasa3";
            this.btnmasa3.Size = new System.Drawing.Size(165, 48);
            this.btnmasa3.TabIndex = 4;
            this.btnmasa3.Text = "Masa 3";
            this.btnmasa3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmasa3.UseVisualStyleBackColor = false;
            this.btnmasa3.Click += new System.EventHandler(this.btnmasa3_Click);
            // 
            // btnmasa2
            // 
            this.btnmasa2.BackColor = System.Drawing.Color.Chocolate;
            this.btnmasa2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmasa2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmasa2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmasa2.ImageKey = "png-transparent-table-furniture-logo-computer-icons-table-angle-emblem-furniture." +
    "png";
            this.btnmasa2.ImageList = this.ımageList1;
            this.btnmasa2.Location = new System.Drawing.Point(54, 136);
            this.btnmasa2.Name = "btnmasa2";
            this.btnmasa2.Size = new System.Drawing.Size(165, 48);
            this.btnmasa2.TabIndex = 3;
            this.btnmasa2.Text = "Masa 2";
            this.btnmasa2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmasa2.UseVisualStyleBackColor = false;
            this.btnmasa2.Click += new System.EventHandler(this.btnmasa2_Click);
            // 
            // btnmasa1
            // 
            this.btnmasa1.BackColor = System.Drawing.Color.Chocolate;
            this.btnmasa1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmasa1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmasa1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmasa1.ImageKey = "png-transparent-table-furniture-logo-computer-icons-table-angle-emblem-furniture." +
    "png";
            this.btnmasa1.ImageList = this.ımageList1;
            this.btnmasa1.Location = new System.Drawing.Point(54, 76);
            this.btnmasa1.Name = "btnmasa1";
            this.btnmasa1.Size = new System.Drawing.Size(165, 48);
            this.btnmasa1.TabIndex = 2;
            this.btnmasa1.Text = "Masa 1";
            this.btnmasa1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmasa1.UseVisualStyleBackColor = false;
            this.btnmasa1.Click += new System.EventHandler(this.btnmasa1_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(450, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnmasa5);
            this.Controls.Add(this.btnmasa4);
            this.Controls.Add(this.btnmasa3);
            this.Controls.Add(this.btnmasa2);
            this.Controls.Add(this.btnmasa1);
            this.Name = "AnaSayfa";
            this.Text = "Adisyon Bilgi Sistemi (ABS)";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmasa1;
        private System.Windows.Forms.Button btnmasa2;
        private System.Windows.Forms.Button btnmasa3;
        private System.Windows.Forms.Button btnmasa4;
        private System.Windows.Forms.Button btnmasa5;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnkasa;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Label label3;
    }
}

