
namespace PresentationLayer
{
    partial class PL_HomePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dogum_Tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kimlik_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kan_Grubu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uyelik_Durumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_Posta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.soyadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.üyelikDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.kanGrubuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.şehirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.tümüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelAidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyelerinAidatDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.Soyad,
            this.Cinsiyet,
            this.Dogum_Tarihi,
            this.Kimlik_No,
            this.Kan_Grubu,
            this.Uyelik_Durumu,
            this.E_Posta,
            this.Sehir});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 523);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 6;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            this.Ad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Soyad
            // 
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.MinimumWidth = 6;
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            this.Soyad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.MinimumWidth = 6;
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.ReadOnly = true;
            this.Cinsiyet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dogum_Tarihi
            // 
            this.Dogum_Tarihi.HeaderText = "Doğum Tarihi";
            this.Dogum_Tarihi.MinimumWidth = 6;
            this.Dogum_Tarihi.Name = "Dogum_Tarihi";
            this.Dogum_Tarihi.ReadOnly = true;
            this.Dogum_Tarihi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Kimlik_No
            // 
            this.Kimlik_No.HeaderText = "Kimlik No";
            this.Kimlik_No.MinimumWidth = 6;
            this.Kimlik_No.Name = "Kimlik_No";
            this.Kimlik_No.ReadOnly = true;
            this.Kimlik_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Kan_Grubu
            // 
            this.Kan_Grubu.HeaderText = "Kan Grubu";
            this.Kan_Grubu.MinimumWidth = 6;
            this.Kan_Grubu.Name = "Kan_Grubu";
            this.Kan_Grubu.ReadOnly = true;
            this.Kan_Grubu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Uyelik_Durumu
            // 
            this.Uyelik_Durumu.HeaderText = "Üyelik Durumu";
            this.Uyelik_Durumu.MinimumWidth = 6;
            this.Uyelik_Durumu.Name = "Uyelik_Durumu";
            this.Uyelik_Durumu.ReadOnly = true;
            this.Uyelik_Durumu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // E_Posta
            // 
            this.E_Posta.HeaderText = "E-Posta";
            this.E_Posta.MinimumWidth = 6;
            this.E_Posta.Name = "E_Posta";
            this.E_Posta.ReadOnly = true;
            this.E_Posta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sehir
            // 
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.MinimumWidth = 6;
            this.Sehir.Name = "Sehir";
            this.Sehir.ReadOnly = true;
            this.Sehir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeEkleToolStripMenuItem,
            this.üyeListeleToolStripMenuItem,
            this.aidatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // üyeEkleToolStripMenuItem
            // 
            this.üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            this.üyeEkleToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.üyeEkleToolStripMenuItem.Text = "Üye Ekle";
            this.üyeEkleToolStripMenuItem.Click += new System.EventHandler(this.üyeEkleToolStripMenuItem_Click);
            // 
            // üyeListeleToolStripMenuItem
            // 
            this.üyeListeleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adToolStripMenuItem,
            this.soyadToolStripMenuItem,
            this.üyelikDurumuToolStripMenuItem,
            this.kanGrubuToolStripMenuItem,
            this.şehirToolStripMenuItem,
            this.tümüToolStripMenuItem});
            this.üyeListeleToolStripMenuItem.Name = "üyeListeleToolStripMenuItem";
            this.üyeListeleToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.üyeListeleToolStripMenuItem.Text = "Üye Listele";
            this.üyeListeleToolStripMenuItem.DropDownClosed += new System.EventHandler(this.üyeListeleToolStripMenuItem_DropDownClosed);
            // 
            // adToolStripMenuItem
            // 
            this.adToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.adToolStripMenuItem.Name = "adToolStripMenuItem";
            this.adToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adToolStripMenuItem.Text = "Ad";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // soyadToolStripMenuItem
            // 
            this.soyadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.soyadToolStripMenuItem.Name = "soyadToolStripMenuItem";
            this.soyadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.soyadToolStripMenuItem.Text = "Soyad";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox2_KeyDown);
            // 
            // üyelikDurumuToolStripMenuItem
            // 
            this.üyelikDurumuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.üyelikDurumuToolStripMenuItem.Name = "üyelikDurumuToolStripMenuItem";
            this.üyelikDurumuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.üyelikDurumuToolStripMenuItem.Text = "Üyelik Durumu";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // kanGrubuToolStripMenuItem
            // 
            this.kanGrubuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.kanGrubuToolStripMenuItem.Name = "kanGrubuToolStripMenuItem";
            this.kanGrubuToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.kanGrubuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kanGrubuToolStripMenuItem.Text = "Kan Grubu";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "0+\t",
            "0-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.toolStripComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.toolStripComboBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "0+\t",
            "0-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            // 
            // şehirToolStripMenuItem
            // 
            this.şehirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox4});
            this.şehirToolStripMenuItem.Name = "şehirToolStripMenuItem";
            this.şehirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.şehirToolStripMenuItem.Text = "Şehir";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.AutoCompleteCustomSource.AddRange(new string[] {
            "ADANA",
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "ISPARTA",
            "MERSİN",
            "İSTANBUL",
            "İZMİR",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KOCAELİ (İZMİT)",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "KAHRAMANMARAŞ",
            "MARDİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "RİZE",
            "SAKARYA (ADAPAZARI)",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "ŞANLIURFA",
            "UŞAK",
            "VAN",
            "YOZGAT",
            "ZONGULDAK",
            "AKSARAY",
            "BAYBURT",
            "KARAMAN",
            "KIRIKKALE",
            "BATMAN",
            "ŞIRNAK",
            "BARTIN",
            "ARDAHAN",
            "IĞDIR",
            "YALOVA",
            "KARABÜK",
            "KİLİS",
            "OSMANİYE",
            "DÜZCE"});
            this.toolStripTextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTextBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toolStripTextBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.toolStripTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox4_KeyDown);
            // 
            // tümüToolStripMenuItem
            // 
            this.tümüToolStripMenuItem.Name = "tümüToolStripMenuItem";
            this.tümüToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tümüToolStripMenuItem.Text = "Tümü";
            this.tümüToolStripMenuItem.Click += new System.EventHandler(this.tümüToolStripMenuItem_Click);
            // 
            // aidatToolStripMenuItem
            // 
            this.aidatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelAidatToolStripMenuItem,
            this.üyelerinAidatDurumuToolStripMenuItem});
            this.aidatToolStripMenuItem.Name = "aidatToolStripMenuItem";
            this.aidatToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.aidatToolStripMenuItem.Text = "Aidat";
            // 
            // güncelAidatToolStripMenuItem
            // 
            this.güncelAidatToolStripMenuItem.Name = "güncelAidatToolStripMenuItem";
            this.güncelAidatToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.güncelAidatToolStripMenuItem.Text = "Güncel Aidat ";
            this.güncelAidatToolStripMenuItem.Click += new System.EventHandler(this.güncelAidatToolStripMenuItem_Click);
            // 
            // üyelerinAidatDurumuToolStripMenuItem
            // 
            this.üyelerinAidatDurumuToolStripMenuItem.Name = "üyelerinAidatDurumuToolStripMenuItem";
            this.üyelerinAidatDurumuToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.üyelerinAidatDurumuToolStripMenuItem.Text = "Üyelerin Aidat Durumu";
            this.üyelerinAidatDurumuToolStripMenuItem.Click += new System.EventHandler(this.üyelerinAidatDurumuToolStripMenuItem_Click);
            // 
            // PL_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PL_HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üyeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem soyadToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem üyelikDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem tümüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanGrubuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şehirToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dogum_Tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kimlik_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kan_Grubu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uyelik_Durumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_Posta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.ToolStripMenuItem aidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelAidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyelerinAidatDurumuToolStripMenuItem;
    }
}

