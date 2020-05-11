
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Курс_3
{
    public partial class Товар : Form
    {
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet DataSet = null;
        private static readonly string kkk = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Directory.GetCurrentDirectory() + @"\Database1.mdf;Integrated Security=True";
        private readonly SqlConnection connection = new SqlConnection(@kkk);
        public Товар()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadDB();
        }
        private void Reload()
        {
            try
            {
                connection.Open();

                DataSet.Tables["Товар"].Clear();
                SqlDataAdapter.Fill(DataSet, "Товар");
                dataGridView1.DataSource = DataSet.Tables["Товар"];

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                            DataSet.Tables["Товар"].Rows[rowIndex].Delete();
                            SqlDataAdapter.Update(DataSet, "Товар");

                        }

                    }


                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
        }
        private void LoadDB()
        {
            try
            {
                connection.Open();

                SqlDataAdapter = new SqlDataAdapter("SELECT *,'Delete' AS [Delete] FROM [Товар]", connection);
                sqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
                sqlCommandBuilder.GetDeleteCommand();


                DataSet = new DataSet();
                SqlDataAdapter.Fill(DataSet, "Товар");
                dataGridView1.DataSource = DataSet.Tables["Товар"];

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
            Поставка newZ = new Поставка();
            newZ.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Название.Text.Length != 0) & (Стоимость.Text.Length != 0))
                {
                    connection.Open();
                    string sqlcom = "INSERT INTO [Товар]([Название],[Срок годности],[Стоимость])VALUES(@Название,@Год,@Стоимость)";

                    SqlCommand command = new SqlCommand(sqlcom, connection);
                    command.Parameters.AddWithValue("Название", Название.Text);
                    command.Parameters.AddWithValue("Год", СрокГодности.Value);
                    command.Parameters.AddWithValue("Стоимость",decimal.Parse( Стоимость.Text));

                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Заполните все поля");

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

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Касса newO = new Касса();
            newO.Show();
            Hide();
        }


    }
}
