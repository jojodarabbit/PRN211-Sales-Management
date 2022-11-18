using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMembers()
        {
            InitializeComponent();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            txtMemberId.Enabled = false;
            txtEmail.Enabled = false;
            LoadMemberList();
        }

        private void dgvMemberData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frm = new frmMemberDetail
            {
                Text = "Update a member",
                memberRepository = memberRepository,
                MemberInfor = GetMemberObject(),
                InsertOrUpdate = true
            };
            /*if (frm.ShowDialog() == DialogResult.OK)
            {*/
            frm.ShowDialog();
            LoadMemberList();
            //}
        }

        public void ClearText()
        {
            txtMemberId.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        public void LoadMemberList()
        {
            var members = memberRepository.GetListMember();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberId.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "MemberID");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemberData.DataSource = null;
                dgvMemberData.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list.");
            }
        }

        public MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject
                {
                    MemberID = int.Parse(txtMemberId.Text),
                    CompanyName = txtCompanyName.Text,
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member.");
            }
            return member;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                frmMemberDetail frm = new frmMemberDetail
                {
                    Text = "Add a new member",
                    memberRepository = memberRepository,
                    InsertOrUpdate = false,
                };
                frm.ShowDialog();
                LoadMemberList();
                source.Position = source.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new member.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog;
                var member = GetMemberObject();
                dialog = MessageBox.Show("Do you really want to delete or not?", "Manager Member - Delete Member", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (dialog == DialogResult.OK)
                {
                    memberRepository.DeleteMember(member.MemberID);
                }
                if (memberRepository.GetListMember().Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                LoadMemberList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove a member.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var members = memberRepository.GetListMember();
            try
            {
                source = new BindingSource();
                var memberSearch = members.Where(m => m.Email.Contains(txtSearch.Text.Trim())).ToList();
                /*foreach (var item in members)
                {
                    if (item.MemberID.ToString().Contains(txtSearch.Text))
                    {
                        memberSearch.Add(item);
                    }
                }*/
                source.DataSource = memberSearch;
                dgvMemberData.DataSource = null;
                dgvMemberData.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Member.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
