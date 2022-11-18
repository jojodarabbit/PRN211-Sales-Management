using BusinessObject;
using DataAccess.Repository;
using SalesWinApp;
using System.Text.Json;

namespace frmLogin
{
    public partial class frmLogin1 : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin1()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string memberData = File.ReadAllText("appsettings.json");
                MemberObject admin = JsonSerializer.Deserialize<MemberObject>(memberData);
                var members = memberRepository.GetListMember();
                if (txtEmail.Text.Equals(admin.Email) && txtPassword.Text.Equals(admin.Password))
                {
                    Hide();
                    frmMain frm = new frmMain();
                    frm.Show(); 
                }
                else
                {
                    var member = members.SingleOrDefault(o => (o.Email.Equals(txtEmail.Text) && (o.Password.Equals(txtPassword.Text))));
                    if (member != null)
                    {
                        Hide();
                        frmCustomer frm = new frmCustomer()
                        {
                            Text = $"Member #{member.MemberID}",
                            MemberInfor = member
                        };
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Email or Password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
            txtPassword.PasswordChar = '*';
        }
    }
}