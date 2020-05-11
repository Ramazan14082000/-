using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Курс_3
{
    public partial class Продавцы : Form
    {
        private SqlCommandBuilder sqlCommandBuilder = null;
        private SqlDataAdapter SqlDataAdapter = null;
        private DataSet DataSet = null;
        private static readonly string kkk = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @Directory.GetCurrentDirectory() + @"\Database1.mdf;Integrated Security=True";
        private readonly SqlConnection connection = new SqlConnection(@kkk);
        public Продавцы()
        {
            InitializeComponent();
        }
        private void Reload()
        {
            try
            {
                connection.Open();

                DataSet.Tables["Продавец"].Clear();
                SqlDataAdapter.Fill(DataSet, "Продавец");
                dataGridView1.DataSource = DataSet.Tables["Продавец"];

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
                            DataSet.Tables["Продавец"].Rows[rowIndex].Delete();
                            SqlDataAdapter.Update(DataSet, "Продавец");

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
        private void LoadDB()
        {
            try
            {
                connection.Open();

                SqlDataAdapter = new SqlDataAdapter("SELECT *,'Delete' AS [Delete] FROM [Продавец]", connection);
                sqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
                sqlCommandBuilder.GetDeleteCommand();
                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();

                DataSet = new DataSet();
                SqlDataAdapter.Fill(DataSet, "Продавец");
                dataGridView1.DataSource = DataSet.Tables["Продавец"];

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



        private void NewV_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Поставщики newK = new Поставщики();
            newK.Show();
            Hide();
        }

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Поставка newZ = new Поставка();
            newZ.Show();
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
                if ((FIOtb.Text.Length != 0) & (TABNtb.Text.Length != 0) & (Adrtb.Text.Length != 0) & (NOMtb.Text.Length != 0) & (PASStb.Text.Length != 0) & (ZARtb.Text.Length != 0))
                {
                    connection.Open();
                    string sqlcom = "INSERT INTO [Водители]([ФИО],[Табельный номер],[Паспортные данные],[Адрес],[Телефон],[Дата рождения],[Дата приема],[Зарплата])VALUES(@ФИО,@Табельный,@Паспортные,@Адрес,@Телефон,@рождения,@приема,@Зарплата)";

                    SqlCommand command = new SqlCommand(sqlcom, connection);
                    command.Parameters.AddWithValue("ФИО", FIOtb.Text);
                    command.Parameters.AddWithValue("Табельный", int.Parse(TABNtb.Text));
                    command.Parameters.AddWithValue("Адрес", Adrtb.Text);
                    command.Parameters.AddWithValue("Телефон", NOMtb.Text);
                    command.Parameters.AddWithValue("Паспортные", int.Parse(PASStb.Text));
                    command.Parameters.AddWithValue("рождения", DATERO.Value);
                    command.Parameters.AddWithValue("приема", DATEPR.Value);
                    command.Parameters.AddWithValue("Зарплата", decimal.Parse(ZARtb.Text));

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
