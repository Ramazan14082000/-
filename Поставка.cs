using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Курс_3
{
    public partial class Поставка : Form
    {
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet DataSet = null;
        private static readonly string kkk = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Directory.GetCurrentDirectory() + @"\Database1.mdf;Integrated Security=True";
        private readonly SqlConnection connection = new SqlConnection(@kkk);
        public Поставка()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == 9)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

                    if (task == "Delete")
                    {

                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            DataSet.Tables["Поставка"].Rows[rowIndex].Delete();
                            SqlDataAdapter.Update(DataSet, "Поставка");

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
        private void Reload()
        {
            try
            {
                connection.Open();

                DataSet.Tables["Поставка"].Clear();
                SqlDataAdapter.Fill(DataSet, "Поставка");
                dataGridView1.DataSource = DataSet.Tables["Поставка"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[9, i] = linkCell;


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

                SqlDataAdapter = new SqlDataAdapter("SELECT *,'Delete' AS [Delete] FROM [Поставка]", connection);
                sqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
                sqlCommandBuilder.GetDeleteCommand();

                DataSet = new DataSet();
                SqlDataAdapter.Fill(DataSet, "Поставка");
                dataGridView1.DataSource = DataSet.Tables["Поставка"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[9, i] = linkCell;


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
        private void Views2()
        {
            try
            {
                connection.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT [Организация],[Код Поставщика] FROM [Поставщик]", connection);
                DataTable table1 = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd1);
                sqlData.Fill(table1);
                Организацияtb.DataSource = table1;
                Организацияtb.DisplayMember = "Организация";
                Организацияtb.ValueMember = "Код Поставщика";
                Организацияtb.SelectedValue = "Код Поставщика";
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
       
        private void Views1()
        {
            try
            {
                connection.Open();
                SqlCommand cmd3 = new SqlCommand("SELECT [Название],[Код Товара] FROM [Товар]", connection);
                DataTable table3 = new DataTable();
                SqlDataAdapter sqlData3 = new SqlDataAdapter(cmd3);
                sqlData3.Fill(table3);
                Товарcomb.DataSource = table3;
                Товарcomb.DisplayMember = "Название";
                Товарcomb.ValueMember = "Код Товара";
                Товарcomb.SelectedValue = "Код Товара";
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
        private void Form1_Load(object sender, EventArgs e)
        {
            Views2();
         
            Views1();
            LoadDB();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Поставщики newK = new Поставщики();
            newK.Show();
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Организацияtb.Text.Length!=0)& (Товарcomb.Text.Length != 0) &(ЦенаЕд.Text.Length != 0)&(КолComb.Text.Length != 0))
                {
                    connection.Open();
                    string sqlcom = "INSERT INTO [Поставка]([Организация Поставщика],[Код Поставщика],[Товар],[Код Товара],[Дата Поставки],[Стоимость за единицу],[Количество],Стоимость)" +
                        "VALUES(@Организация,@КодПоставщика,@Товар,@КодТовара,@ДатаПоставки,@Стоимостьзаединицу,@Количество,@Стоимость)";
                   

                    SqlCommand command = new SqlCommand(sqlcom, connection);
                    command.Parameters.AddWithValue("Организация", Организацияtb.Text);
                    command.Parameters.AddWithValue("КодПоставщика", Организацияtb.SelectedValue);
                    command.Parameters.AddWithValue("Товар", Товарcomb.Text);
                    command.Parameters.AddWithValue("КодТовара", Товарcomb.SelectedValue);
                    command.Parameters.AddWithValue("ДатаПоставки", DATEPOSTtb.Value);
                    command.Parameters.AddWithValue("Стоимостьзаединицу", decimal.Parse(ЦенаЕд.Text ));

                    command.Parameters.AddWithValue("Количество", decimal.Parse(КолComb.Text));

                    command.Parameters.AddWithValue("Стоимость", decimal.Parse(КолComb.Text)* decimal.Parse(ЦенаЕд.Text));

                    command.ExecuteNonQuery();
           
                    
                }
                else
                {
                    MessageBox.Show("Запоните все поля");


                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
            finally
            {
                connection.Close();
                Reload();


            }



        }

        private void FIOVtb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GRtb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CLIENTtb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void STOPL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Касса newO = new Касса();
            newO.Show();
            Hide();
        }

        private void ЦенаЕд_TextChanged(object sender, EventArgs e)
        {

        }

        private void КолComb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
