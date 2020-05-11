using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace Курс_3
{
    public partial class Касса : Form
    {
        private static readonly string kkk = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Directory.GetCurrentDirectory() + @"\Database1.mdf;Integrated Security=True";
        private readonly SqlConnection connection = new SqlConnection(@kkk);
        public Касса()
        {
            InitializeComponent();
        }
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet DataSet = null;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NewO_Load(object sender, EventArgs e)
        {
        
          //TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Поставка". При необходимости она может быть перемещена или удалена.
            this.поставкаTableAdapter.Fill(this.dataSet1.Поставка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Поставка". При необходимости она может быть перемещена или удалена.
            this.поставкаTableAdapter.Fill(this.dataSet1.Поставка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.dataSet1.Товар);
            updLabl();
            LoadDB();

        }
        

       

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Поставка newZ = new Поставка();
            newZ.Show();
            Hide();
           
        }

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Продавцы newV = new Продавцы();
            newV.Show();
            Hide();
        }

        private void грузовикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Товар form4 = new Товар();
            form4.Show();
            Hide();
        }

        private void товарBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == 4)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                    if (task == "Delete")
                    {

                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            DataSet.Tables["Проданные"].Rows[rowIndex].Delete();
                            SqlDataAdapter.Update(DataSet, "Проданные");

                        }

                    }


                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
            finally
            {
                Reload();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            korz();
           
            updLabl();
            Reload();


        }
        private void Reload()
        {
            try
            {
                connection.Open();

                DataSet.Tables["Проданные"].Clear();
                SqlDataAdapter.Fill(DataSet, "Проданные");
                dataGridView1.DataSource = DataSet.Tables["Проданные"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[4, i] = linkCell;


                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void LoadDB()
        {
            try
            {
                connection.Open();

                SqlDataAdapter = new SqlDataAdapter("SELECT *,'Delete' AS [Delete] FROM [Проданные]", connection);
                sqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
                sqlCommandBuilder.GetDeleteCommand();

                DataSet = new DataSet();
                SqlDataAdapter.Fill(DataSet, "Проданные");
                dataGridView1.DataSource = DataSet.Tables["Проданные"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[4, i] = linkCell;


                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        void korz()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [Проданные]([Название],[Цена],[Дата])VALUES(@Название,@Цена,@Дата)", connection);
            command.Parameters.AddWithValue("Название", названиеLabel1.Text);
            command.Parameters.AddWithValue("Цена",decimal.Parse( стоимостьLabel1.Text));
            command.Parameters.AddWithValue("Дата", dateTimePicker1.Value);

            command.ExecuteNonQuery();
            connection.Close();


        }
        void kolminus()
        {
            
            SqlCommand command1 = new SqlCommand("UPDATE Поставка SET Количество = Количество - 1 WHERE Поставка.[Код Товара] IN(SELECT[Код Товара] FROM[Товар] WHERE[Код Товара] = @r)", connection);
            command1.Parameters.AddWithValue("r", код_ТовараLabel1.Text);
            command1.ExecuteNonQuery();
            
            


        }
        void updLabl()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT [Количество] FROM [Поставка] WHERE [Код товара]=@g", connection);
            command.Parameters.AddWithValue("g", код_ТовараLabel1.Text);
            
            string txt= command.ExecuteScalar().ToString();
            if (Convert.ToInt32(txt) >= 0)
            {
                label1.Text = txt.ToString();
                kolminus();
            }
            else
            {
                MessageBox.Show("Товар кончился");
            
            }
            
            connection.Close();



        }
        private void код_ТовараLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void названиеLabel1_Click(object sender, EventArgs e)
        {

        }

        private void товарBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void товарBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void товарBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
      
        }

        private void поставкаBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void количествоLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ПоставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Поставщики поставщики = new Поставщики();
            поставщики.Show();
            Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
