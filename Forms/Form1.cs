using GreenLife_Organic_Store.Forms.Admin;
using MySql.Data.MySqlClient;

namespace GreenLife_Organic_Store
{
    public partial class frmFirst : Form
    {
        string connectionString = "Server=localhost; Port=3306;Database=greenlife_organic_store;Uid=root;Pwd=root;";
        public frmFirst()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabCustomer_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void tabAdmin_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputUsername = txtAdminUsername.Text.Trim();
            string inputPassword = txtAdminPassword.Text.Trim();

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"SELECT user_id 
                                     FROM users 
                                     WHERE username = @username 
                                     AND password = @password
                                     LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", inputUsername);
                        cmd.Parameters.AddWithValue("@password", inputPassword);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int userId = Convert.ToInt32(result);

                            frmAdminDashboardForm frm = new frmAdminDashboardForm(userId);
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Incorrect Username or Password",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Something went wrong. Please try again later",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
