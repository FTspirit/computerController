using System.Data.SqlClient;

namespace computerController
{
    public partial class addRoomModal : Form
    {
        string connectionString = @"Data Source=DESKTOP-DN9JI1P;Initial Catalog=room_management;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public addRoomModal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string roomNameString = roomName.Text;
                    string roomAddressString = roomAddress.Text;

                    // Use parameterized queries to prevent SQL injection
                    string sql = "SELECT * FROM [user] WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối đến máy chủ: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
