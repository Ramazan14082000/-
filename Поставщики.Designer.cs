namespace Курс_3
{
    partial class Поставщики
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ПродавцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПоставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.КассаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FIOtb = new System.Windows.Forms.TextBox();
            this.ADRtb = new System.Windows.Forms.TextBox();
            this.Mailtb = new System.Windows.Forms.TextBox();
            this.Teltb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ПродавцыToolStripMenuItem,
            this.ПоставкаToolStripMenuItem,
            this.ТоварToolStripMenuItem,
            this.КассаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ПродавцыToolStripMenuItem
            // 
            this.ПродавцыToolStripMenuItem.Name = "ПродавцыToolStripMenuItem";
            this.ПродавцыToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ПродавцыToolStripMenuItem.Text = "Продавцы";
            this.ПродавцыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // ПоставкаToolStripMenuItem
            // 
            this.ПоставкаToolStripMenuItem.Name = "ПоставкаToolStripMenuItem";
            this.ПоставкаToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ПоставкаToolStripMenuItem.Text = "Поставка";
            this.ПоставкаToolStripMenuItem.Click += new System.EventHandler(this.водителиToolStripMenuItem_Click);
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
            // FIOtb
            // 
            this.FIOtb.Location = new System.Drawing.Point(12, 52);
            this.FIOtb.Name = "FIOtb";
            this.FIOtb.Size = new System.Drawing.Size(206, 20);
            this.FIOtb.TabIndex = 27;
            // 
            // ADRtb
            // 
            this.ADRtb.Location = new System.Drawing.Point(12, 98);
            this.ADRtb.Name = "ADRtb";
            this.ADRtb.Size = new System.Drawing.Size(206, 20);
            this.ADRtb.TabIndex = 28;
            // 
            // Mailtb
            // 
            this.Mailtb.Location = new System.Drawing.Point(224, 98);
            this.Mailtb.Name = "Mailtb";
            this.Mailtb.Size = new System.Drawing.Size(192, 20);
            this.Mailtb.TabIndex = 29;
            // 
            // Teltb
            // 
            this.Teltb.Location = new System.Drawing.Point(224, 52);
            this.Teltb.Name = "Teltb";
            this.Teltb.Size = new System.Drawing.Size(192, 20);
            this.Teltb.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Организация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Электронная почта";
            // 
            // Поставщики
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Teltb);
            this.Controls.Add(this.Mailtb);
            this.Controls.Add(this.ADRtb);
            this.Controls.Add(this.FIOtb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Поставщики";
            this.Text = "Поставщик";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewK_FormClosed);
            this.Load += new System.EventHandler(this.NewK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ПродавцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПоставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem КассаToolStripMenuItem;
        private System.Windows.Forms.TextBox FIOtb;
        private System.Windows.Forms.TextBox ADRtb;
        private System.Windows.Forms.TextBox Mailtb;
        private System.Windows.Forms.TextBox Teltb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}