using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMemberDetail : Form
    {
        public IMemberRepository memberRepository { get; set; }
        public bool InsertOrUpdate { get; set; } //Insert = false, Update = true
        public MemberObject MemberInfor { get; set; }
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            /*btnSave.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;*/
            if (InsertOrUpdate)
            {
                txtMemberId.Text = MemberInfor.MemberID.ToString();
                txtCompanyName.Text = MemberInfor.CompanyName;
                txtEmail.Text = MemberInfor.Email;
                txtCity.Text = MemberInfor.City;
                txtCountry.Text = MemberInfor.Country;
                txtPassword.Text = MemberInfor.Password;

                txtMemberId.Enabled = false;
            }
            else
            {
                int count = memberRepository.GetListMember().Count() + 1;
                txtMemberId.Text = count.ToString();
                txtMemberId.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtCity.Text.Trim() == "" || txtCompanyName.Text.Trim() == "" || txtCountry.Text.Trim() == ""
                    || txtEmail.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please fill in all fields before submitting");
                }
                else
                {
                    /**/
                    MemberObject member = new MemberObject
                    {
                        MemberID = int.Parse(txtMemberId.Text),
                        CompanyName = txtCompanyName.Text,
                        Email = txtEmail.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text,
                        Password = txtPassword.Text,
                    };
                    if (InsertOrUpdate)
                    {
                        memberRepository.UpdateMember(member);
                        Close();
                    }
                    else
                    {
                        var findEmail = memberRepository
                        .GetListMember()
                        .FirstOrDefault(m => m.Email.Equals(txtEmail.Text));
                        if (findEmail == null)
                        {
                            memberRepository.AddMember(member);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Email is exist!");
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate ? "Update a member" : "Add a new member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();


        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = "^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+\\.)+[a-z]{2,5}$";
            if (txtEmail.Text.Length != 0)
            {
                if (!Regex.Match(txtEmail.Text, pattern).Success)
                {
                    MessageBox.Show("Email is incorrect pattern.");
                    txtEmail.Focus();
                }
            }
        }
    }
}
