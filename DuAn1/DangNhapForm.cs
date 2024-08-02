using BUS.Services;
using DAL.Models;

namespace DuAn1
{
    public partial class DangNhapForm : Form
    {
        public DangNhapForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public class GetDataUser
        {
            static public string acccountname;
            static public string idaccount;
            static public int accountlevel;
            static public bool accStatus;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViewPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không được để trống !");
                }
                else
                {
                    LoginBLL ql = new LoginBLL();
                    Account tg = ql.TimkiemTK(txtUserName.Text);
                    if (tg != null && tg.AccountStatus==true)
                    {
                        if (tg.PassAccount == txtPass.Text)
                        {
                            FormMenu a = new FormMenu();
                            GetDataUser.acccountname = tg.AccountName;
                            GetDataUser.idaccount = tg.Idaccount;
                            GetDataUser.accountlevel = tg.AccountLevel;
                            MessageBox.Show("Đăng nhập thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            this.Hide();
                            a.FormClosed += FormMenu_FormClosed;
                            a.Show();
                            a.BringToFront();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác hãy nhập lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hiện không có tài khoản nào giống như quý khách đã cung cấp hoặc tài khoản không họat động !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Đóng form đăng nhập khi form bán hàng đóng
            this.Close();
        }
        private void DangNhapForm_Load(object sender, EventArgs e)
        {
            txtUserName.Padding = new Padding(10);
            txtPass.Padding = new Padding(10);
        }

        private void DangNhapForm_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}

