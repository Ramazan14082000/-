namespace Курс_3
{
    partial class Товар
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ПоставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПродавцыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПоставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.КассаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Название = new System.Windows.Forms.TextBox();
            this.Стоимость = new System.Windows.Forms.TextBox();
            this.СрокГодности = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ПоставщикиToolStripMenuItem,
            this.ПродавцыToolStripMenuItem,
            this.ПоставкаToolStripMenuItem,
            this.КассаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
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
            // ПоставкаToolStripMenuItem
            // 
            this.ПоставкаToolStripMenuItem.Name = "ПоставкаToolStripMenuItem";
            this.ПоставкаToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ПоставкаToolStripMenuItem.Text = "Поставка";
            this.ПоставкаToolStripMenuItem.Click += new System.EventHandler(this.грузовикиToolStripMenuItem_Click);
            // 
            // КассаToolStripMenuItem
            // 
            this.КассаToolStripMenuItem.Name = "КассаToolStripMenuItem";
            this.КассаToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.КассаToolStripMenuItem.Text = "Касса";
            this.КассаToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // Название
            // 
            this.Название.Location = new System.Drawing.Point(12, 52);
            this.Название.Name = "Название";
            this.Название.Size = new System.Drawing.Size(219, 20);
            this.Название.TabIndex = 26;
            // 
            // Стоимость
            // 
            this.Стоимость.Location = new System.Drawing.Point(237, 52);
            this.Стоимость.Name = "Стоимость";
            this.Стоимость.Size = new System.Drawing.Size(200, 20);
            this.Стоимость.TabIndex = 27;
            // 
            // СрокГодности
            // 
            this.СрокГодности.Location = new System.Drawing.Point(15, 113);
            this.СрокГодности.Name = "СрокГодности";
            this.СрокГодности.Size = new System.Drawing.Size(216, 20);
            this.СрокГодности.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Срок годности";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(575, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 119);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Товар
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.СрокГодности);
            this.Controls.Add(this.Стоимость);
            this.Controls.Add(this.Название);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Товар";
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ПоставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПродавцыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПоставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem КассаToolStripMenuItem;
        private System.Windows.Forms.TextBox Название;
        private System.Windows.Forms.TextBox Стоимость;
        private System.Windows.Forms.DateTimePicker СрокГодности;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}