using System.Data;
using System.Data.SqlClient;

namespace computerController
{
    public partial class roomManage : Form
    {

        string connectionString = @"Data Source=DESKTOP-DN9JI1P;Initial Catalog=room_management;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        private User _loggedInUser;
        public roomManage(User loggedInUsser)
        {
            InitializeComponent();
            _loggedInUser = loggedInUsser;
        }

        private void controller_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(Object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(" SELECT * FROM room", conn);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối đến máy chủ: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
