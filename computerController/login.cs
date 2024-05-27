using System.Data.SqlClient;



namespace computerController
{
    public partial class login : Form
    {
        string connectionString = @"Data Source=DESKTOP-DN9JI1P;Initial Catalog=room_management;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string userName = txtUsername.Text;
                    string password = txtPassword.Text;

                    // Use parameterized queries to prevent SQL injection
                    string sql = "SELECT * FROM [user] WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Add parameters to the SQL command
                        cmd.Parameters.AddWithValue("@username", userName);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                string roleId = rdr["role_id"].ToString()!;
                                string address = rdr["address"].ToString()!;
                                string email = rdr["email"].ToString()!;
                                string phoneNumber = rdr["phone_number"].ToString()!;
                                string className = rdr["class_name"].ToString()!;
                                User loggedInUser = new User
                                {
                                    userName = userName,
                                    roleID = roleId,
                                    address = address,
                                    email = email,
                                    phoneNumber = phoneNumber,
                                    className = className,

                                };
                                roomManage roomManager = new roomManage(loggedInUser);
                                roomManager.Show();
                                this.Hide();
                                MessageBox.Show("Đăng nhập thành công");
                            }
                            else
                            {
                                MessageBox.Show("Đăng nhập thất bại");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối đến máy chủ: " + ex.Message);
                }
            }
        }
    }
}
