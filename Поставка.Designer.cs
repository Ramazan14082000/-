namespace Курс_3
{
    partial class Поставка
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Организацияtb = new System.Windows.Forms.ComboBox();
            this.DATEPOSTtb = new System.Windows.Forms.DateTimePicker();
            this.Товарcomb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ПоставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПродавцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.КассаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.КолComb = new System.Windows.Forms.TextBox();
            this.ЦенаЕд = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1308, 475);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Организацияtb
            // 
            this.Организацияtb.FormattingEnabled = true;
            this.Организацияtb.Location = new System.Drawing.Point(8, 58);
            this.Организацияtb.Name = "Организацияtb";
            this.Организацияtb.Size = new System.Drawing.Size(246, 21);
            this.Организацияtb.TabIndex = 1;
            this.Организацияtb.SelectedIndexChanged += new System.EventHandler(this.FIOVtb_SelectedIndexChanged);
            // 
            // DATEPOSTtb
            // 
            this.DATEPOSTtb.Location = new System.Drawing.Point(260, 59);
            this.DATEPOSTtb.Name = "DATEPOSTtb";
            this.DATEPOSTtb.Size = new System.Drawing.Size(170, 20);
            this.DATEPOSTtb.TabIndex = 4;
            // 
            // Товарcomb
            // 
            this.Товарcomb.DisplayMember = "Марка";
            this.Товарcomb.FormattingEnabled = true;
            this.Товарcomb.Location = new System.Drawing.Point(453, 57);
            this.Товарcomb.Name = "Товарcomb";
            this.Товарcomb.Size = new System.Drawing.Size(147, 21);
            this.Товарcomb.TabIndex = 6;
            this.Товарcomb.ValueMember = "Марка";
            this.Товарcomb.SelectedIndexChanged += new System.EventHandler(this.GRtb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Организация";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Дата поставки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1071, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 64);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ПоставщикиToolStripMenuItem
            // 
            this.ПоставщикиToolStripMenuItem.Name = "ПоставщикиToolStripMenuItem";
            this.ПоставщикиToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.ПоставщикиToolStripMenuItem.Text = "Поставщики";
            this.ПоставщикиToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // ПродавцыToolStripMenuItem
            // 
            this.ПродавцыToolStripMenuItem.Name = "ПродавцыToolStripMenuItem";
            this.ПродавцыToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ПродавцыToolStripMenuItem.Text = "Продавцы";
            this.ПродавцыToolStripMenuItem.Click += new System.EventHandler(this.водителиToolStripMenuItem_Click);
            // 
            // ТоварToolStripMenuItem
            // 
            this.ТоварToolStripMenuItem.Name = "ТоварToolStripMenuItem";
            this.ТоварToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ТоварToolStripMenuItem.Text = "Товар";
            this.ТоварToolStripMenuItem.Click += new System.EventHandler(this.грузовикиToolStripMenuItem_Click);
            // 
            // КассаToolStripMenuItem
            // 
            this.КассаToolStripMenuItem.Name = "КассаToolStripMenuItem";
            this.КассаToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.КассаToolStripMenuItem.Text = "Касса";
            this.КассаToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ПоставщикиToolStripMenuItem,
            this.ПродавцыToolStripMenuItem,
            this.ТоварToolStripMenuItem,
            this.КассаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1327, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Товар";
            // 
            // КолComb
            // 
            this.КолComb.Location = new System.Drawing.Point(154, 126);
            this.КолComb.Name = "КолComb";
            this.КолComb.Size = new System.Drawing.Size(100, 20);
            this.КолComb.TabIndex = 26;
            this.КолComb.TextChanged += new System.EventHandler(this.КолComb_TextChanged);
            // 
            // ЦенаЕд
            // 
            this.ЦенаЕд.Location = new System.Drawing.Point(12, 122);
            this.ЦенаЕд.Name = "ЦенаЕд";
            this.ЦенаЕд.Size = new System.Drawing.Size(100, 20);
            this.ЦенаЕд.TabIndex = 27;
            this.ЦенаЕд.TextChanged += new System.EventHandler(this.ЦенаЕд_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Цена за единицу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Количество";
            // 
            // Поставка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 639);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ЦенаЕд);
            this.Controls.Add(this.КолComb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Товарcomb);
            this.Controls.Add(this.DATEPOSTtb);
            this.Controls.Add(this.Организацияtb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Поставка";
            this.Text = "Завка на поставку";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Организацияtb;
        private System.Windows.Forms.DateTimePicker DATEPOSTtb;
        private System.Windows.Forms.ComboBox Товарcomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ПоставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПродавцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem КассаToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox КолComb;
        private System.Windows.Forms.TextBox ЦенаЕд;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

