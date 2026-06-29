using Microsoft.Data.SqlClient;
namespace ENROLLMENTSYSTEM
{
    public partial class FeesForm : UserControl
    {
        SqlConnection connect = new SqlConnection(DatabaseConnect._connect);
        string _aycode;
        public static string _id;
        public FeesForm()
        {
            InitializeComponent();
            loaDataReadecordsfeeslist();
        }
        public void getAY()
        {
            SqlDataReader DataRead;
            using (SqlCommand command = new SqlCommand("Select aycode from tblay where status = 'Open'", connect))
            {
                connect.Open();
                DataRead = command.ExecuteReader();
                if (DataRead.Read())
                {
                    _aycode = DataRead["aycode"].ToString();
                }
                DataRead.Close();
                connect.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save this fees?", "ENROLLMENT SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlCommand command = new SqlCommand("insert into tblfees (id, fees, amount)values(@id, @fees, @amount)", connect))
                    {
                        connect.Open();
                        command.Parameters.AddWithValue("@id", txtID.Text);
                        command.Parameters.AddWithValue("@fees", txtDesc.Text);
                        command.Parameters.AddWithValue("@amount", double.Parse(txtAmount.Text));
                        command.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("New fees has been successfully saved!", "ENROLLMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button3_Click(sender, e);
                        loaDataReadecordsfeeslist();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ENROLLMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to update this fees?", "ENROLLMENT SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlCommand command = new SqlCommand("update tblfees set fees=@fees, amount= @amount where id = @id", connect))
                    {
                        connect.Open();
                        command.Parameters.AddWithValue("@fees", txtDesc.Text);
                        command.Parameters.AddWithValue("@amount", double.Parse(txtAmount.Text));
                        command.Parameters.AddWithValue("@id", txtID.Text);
                        command.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("New fees has been successfully saved!", "ENROLLMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaDataReadecordsfeeslist();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ENROLLMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtDesc.Clear();
            txtID.Clear();
            txtDesc.Focus();
        }
        public void loaDataReadecordsfeeslist()
        {
            try
            {
                dataGridView3.Rows.Clear();
                using (SqlCommand command = new SqlCommand("select * from tblfees", connect))
                {
                    SqlDataReader DataRead;
                    connect.Open();
                    DataRead = command.ExecuteReader();
                    while (DataRead.Read())
                    {
                        dataGridView3.Rows.Add(DataRead[0].ToString(), DataRead[1].ToString(), DataRead[2].ToString());
                    }
                    DataRead.Close();
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ENROLLMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string _column = dataGridView3.Columns[e.ColumnIndex].Name;
            if (_column == "colEdit")
            {
                txtID.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDesc.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAmount.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else if (_column == "colDelete")
            {
                if (MessageBox.Show("Do you want to delete this record?", "ENROLLMENT SYSTEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlCommand command = new SqlCommand("delete from tblfees where id = @id", connect))
                    {
                        connect.Open();
                        command.Parameters.AddWithValue("@id", dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
                        command.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Record has been successfully deleted!", "ENROLLMENT SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaDataReadecordsfeeslist();

                    }
                }
            }
        }
    }
}




