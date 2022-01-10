namespace Kütüphanem
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
            this.components = new System.ComponentModel.Container();
            this.ll1 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rt1 = new System.Windows.Forms.RichTextBox();
            this.l6 = new System.Windows.Forms.Label();
            this.t5 = new System.Windows.Forms.TextBox();
            this.l5 = new System.Windows.Forms.Label();
            this.t4 = new System.Windows.Forms.TextBox();
            this.l4 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphanemDataSet = new Kütüphanem.KütüphanemDataSet();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.kitapTableAdapter = new Kütüphanem.KütüphanemDataSetTableAdapters.kitapTableAdapter();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphanemDataSet)).BeginInit();
            this.gb3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ll1
            // 
            this.ll1.AutoSize = true;
            this.ll1.BackColor = System.Drawing.Color.White;
            this.ll1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ll1.Location = new System.Drawing.Point(29, 21);
            this.ll1.Name = "ll1";
            this.ll1.Size = new System.Drawing.Size(99, 20);
            this.ll1.TabIndex = 0;
            this.ll1.Text = "Kitap Id:        ";
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Transparent;
            this.gb1.Controls.Add(this.rt1);
            this.gb1.Controls.Add(this.l6);
            this.gb1.Controls.Add(this.t5);
            this.gb1.Controls.Add(this.l5);
            this.gb1.Controls.Add(this.t4);
            this.gb1.Controls.Add(this.l4);
            this.gb1.Controls.Add(this.t3);
            this.gb1.Controls.Add(this.l3);
            this.gb1.Controls.Add(this.t2);
            this.gb1.Controls.Add(this.l2);
            this.gb1.Controls.Add(this.t1);
            this.gb1.Controls.Add(this.ll1);
            this.gb1.Location = new System.Drawing.Point(34, 23);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(545, 286);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "Kitap Kayıt";
            // 
            // rt1
            // 
            this.rt1.Location = new System.Drawing.Point(174, 220);
            this.rt1.Name = "rt1";
            this.rt1.Size = new System.Drawing.Size(342, 51);
            this.rt1.TabIndex = 12;
            this.rt1.Text = "";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.BackColor = System.Drawing.Color.White;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l6.Location = new System.Drawing.Point(29, 180);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(98, 20);
            this.l6.TabIndex = 11;
            this.l6.Text = "Puan:            ";
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(174, 182);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(342, 20);
            this.t5.TabIndex = 5;
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.BackColor = System.Drawing.Color.White;
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l5.Location = new System.Drawing.Point(29, 220);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(99, 20);
            this.l5.TabIndex = 9;
            this.l5.Text = "Konusu:        ";
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(174, 140);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(342, 20);
            this.t4.TabIndex = 4;
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.BackColor = System.Drawing.Color.White;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l4.Location = new System.Drawing.Point(29, 143);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(99, 20);
            this.l4.TabIndex = 7;
            this.l4.Text = "Sayfa Sayısı:";
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(174, 102);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(342, 20);
            this.t3.TabIndex = 3;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.White;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l3.Location = new System.Drawing.Point(28, 100);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(99, 20);
            this.l3.TabIndex = 5;
            this.l3.Text = "Yazar:           ";
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(174, 62);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(342, 20);
            this.t2.TabIndex = 2;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.White;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l2.Location = new System.Drawing.Point(29, 60);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(97, 20);
            this.l2.TabIndex = 3;
            this.l2.Text = "Kitap Ad:      ";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(174, 23);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(342, 20);
            this.t1.TabIndex = 0;
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.White;
            this.btnlistele.Location = new System.Drawing.Point(16, 21);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(87, 33);
            this.btnlistele.TabIndex = 3;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // gb2
            // 
            this.gb2.BackColor = System.Drawing.Color.Transparent;
            this.gb2.Controls.Add(this.btngüncelle);
            this.gb2.Controls.Add(this.btntemizle);
            this.gb2.Controls.Add(this.btnsil);
            this.gb2.Controls.Add(this.btnkaydet);
            this.gb2.Controls.Add(this.btnlistele);
            this.gb2.Location = new System.Drawing.Point(596, 23);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(117, 224);
            this.gb2.TabIndex = 4;
            this.gb2.TabStop = false;
            this.gb2.Text = "İslemler";
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.White;
            this.btngüncelle.Location = new System.Drawing.Point(16, 182);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(87, 33);
            this.btngüncelle.TabIndex = 7;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.White;
            this.btntemizle.Location = new System.Drawing.Point(16, 143);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(87, 33);
            this.btntemizle.TabIndex = 6;
            this.btntemizle.Text = "TEMİZLE";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(16, 100);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(87, 33);
            this.btnsil.TabIndex = 5;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.White;
            this.btnkaydet.Location = new System.Drawing.Point(16, 60);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(87, 33);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapidDataGridViewTextBoxColumn,
            this.kitapadDataGridViewTextBoxColumn,
            this.kitapyazarDataGridViewTextBoxColumn,
            this.sayfasayisiDataGridViewTextBoxColumn,
            this.konusuDataGridViewTextBoxColumn,
            this.puanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitapBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 144);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kitapidDataGridViewTextBoxColumn
            // 
            this.kitapidDataGridViewTextBoxColumn.DataPropertyName = "kitapid";
            this.kitapidDataGridViewTextBoxColumn.HeaderText = "kitapid";
            this.kitapidDataGridViewTextBoxColumn.Name = "kitapidDataGridViewTextBoxColumn";
            this.kitapidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapidDataGridViewTextBoxColumn.Width = 50;
            // 
            // kitapadDataGridViewTextBoxColumn
            // 
            this.kitapadDataGridViewTextBoxColumn.DataPropertyName = "kitapad";
            this.kitapadDataGridViewTextBoxColumn.HeaderText = "kitapad";
            this.kitapadDataGridViewTextBoxColumn.Name = "kitapadDataGridViewTextBoxColumn";
            this.kitapadDataGridViewTextBoxColumn.Width = 120;
            // 
            // kitapyazarDataGridViewTextBoxColumn
            // 
            this.kitapyazarDataGridViewTextBoxColumn.DataPropertyName = "kitapyazar";
            this.kitapyazarDataGridViewTextBoxColumn.HeaderText = "kitapyazar";
            this.kitapyazarDataGridViewTextBoxColumn.Name = "kitapyazarDataGridViewTextBoxColumn";
            this.kitapyazarDataGridViewTextBoxColumn.Width = 120;
            // 
            // sayfasayisiDataGridViewTextBoxColumn
            // 
            this.sayfasayisiDataGridViewTextBoxColumn.DataPropertyName = "sayfasayisi";
            this.sayfasayisiDataGridViewTextBoxColumn.HeaderText = "sayfasayisi";
            this.sayfasayisiDataGridViewTextBoxColumn.Name = "sayfasayisiDataGridViewTextBoxColumn";
            this.sayfasayisiDataGridViewTextBoxColumn.Width = 70;
            // 
            // konusuDataGridViewTextBoxColumn
            // 
            this.konusuDataGridViewTextBoxColumn.DataPropertyName = "konusu";
            this.konusuDataGridViewTextBoxColumn.HeaderText = "konusu";
            this.konusuDataGridViewTextBoxColumn.Name = "konusuDataGridViewTextBoxColumn";
            this.konusuDataGridViewTextBoxColumn.Width = 500;
            // 
            // puanDataGridViewTextBoxColumn
            // 
            this.puanDataGridViewTextBoxColumn.DataPropertyName = "puan";
            this.puanDataGridViewTextBoxColumn.HeaderText = "puan";
            this.puanDataGridViewTextBoxColumn.Name = "puanDataGridViewTextBoxColumn";
            this.puanDataGridViewTextBoxColumn.Width = 50;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "kitap";
            this.kitapBindingSource.DataSource = this.kütüphanemDataSet;
            // 
            // kütüphanemDataSet
            // 
            this.kütüphanemDataSet.DataSetName = "KütüphanemDataSet";
            this.kütüphanemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.dataGridView1);
            this.gb3.Location = new System.Drawing.Point(34, 315);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(674, 163);
            this.gb3.TabIndex = 6;
            this.gb3.TabStop = false;
            this.gb3.Text = "Liste";
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Kütüphanem.Properties.Resources.Free_stacked_book_background_Images_Pictures_and_Royalty_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(725, 482);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphanemDataSet)).EndInit();
            this.gb3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ll1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb3;
        private KütüphanemDataSet kütüphanemDataSet;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private KütüphanemDataSetTableAdapters.kitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.RichTextBox rt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puanDataGridViewTextBoxColumn;
    }
}

