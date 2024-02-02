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
using DataAccess.Repository;

namespace MyStoreWinApp
{

    public partial class frmMemberManagement : Form
    {
        private IMemberRepository memberRepository;
        public frmMemberManagement()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();
        }

        private void ClearText()
        {
            tbMemberId.Clear();
            tbMemberName.Clear();
            tbMemberPassword.Clear();
            tbMemberEmail.Clear();
            tbMemberCity.Clear();
            tbMemberCountry.Clear();
        }

        private void RefreshDataInForm(List<MemberObject> MemberList)
        {
            //re-load Member List in Data grid view 
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = MemberList;
            grMemberList.DataSource = bindingSource;
            //update Datasource in filter
            cbFilterCity.DataSource = MemberList.Select(q => q.City.ToUpper()).Distinct().ToList();
            cbFilterCountry.DataSource = MemberList.Select(q => q.Country.ToUpper()).Distinct().ToList();
            ClearText();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            var memberList = memberRepository.GetAllMembers();
            grMemberList.DataSource = memberList;
            grMemberList.Columns[0].HeaderText = "Id";
            grMemberList.Columns[1].HeaderText = "Name";
            grMemberList.Columns[2].HeaderText = "Email";
            grMemberList.Columns[3].HeaderText = "Password";
            grMemberList.Columns[4].HeaderText = "City";
            grMemberList.Columns[5].HeaderText = "Country";
            cbFilterCity.DataSource = memberList.Select(q => q.City.ToUpper()).Distinct().ToList();
            cbFilterCountry.DataSource = memberList.Select(q => q.Country.ToUpper()).Distinct().ToList();
            grMemberList.AllowUserToAddRows = false; // mất dòng tự tạo ở thuộc tính này , chỉnh về false để chỉ hiện ra data
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var searchId = tbSearchId.Text.ToUpper();
            var searchName = tbSearchName.Text.ToUpper();
            if (String.IsNullOrWhiteSpace(searchId) || String.IsNullOrEmpty(searchId) ||
                String.IsNullOrWhiteSpace(searchName) || String.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Please enter id and Name");
            }
            else
            {

                var member = memberRepository.getMemberByIdAndName(Convert.ToInt32(searchId), searchName);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = member;
                grMemberList.DataSource = bindingSource;
            }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            var city = cbFilterCity.SelectedItem.ToString().ToUpper();
            var country = cbFilterCountry.SelectedItem.ToString().ToUpper();
            if (String.IsNullOrWhiteSpace(city) || String.IsNullOrEmpty(city) ||
                String.IsNullOrWhiteSpace(country) || String.IsNullOrEmpty(country))
            {
                MessageBox.Show("Please select City and Country");
            }
            else
            {
                var filteredList = memberRepository.FilterListByCityAndCountry(city, country);
                grMemberList.DataSource = filteredList;
            }
        }

        private void btNewMember_Click(object sender, EventArgs e)
        {
            
            var MemberIdText = tbMemberId.Text;
            if (String.IsNullOrEmpty(MemberIdText) || String.IsNullOrWhiteSpace(MemberIdText))
            {
                MessageBox.Show("Please enter member ID");
            }
            else
            {
                var MemberId = Convert.ToInt32(tbMemberId.Text);
                var MemberName = tbMemberName.Text.ToUpper();
                var MemberPassword = tbMemberPassword.Text;
                var MemberEmail = tbMemberEmail.Text;
                var MemberCity = tbMemberCity.Text.ToUpper();
                var MemberCountry = tbMemberCountry.Text.ToUpper();
        
            try
            {
                MemberObject NewMember = new MemberObject { MemberId = MemberId, MemberName = MemberName, Password = MemberPassword, Email = MemberEmail, City = MemberCity, Country = MemberCountry };
                memberRepository.AddNewMember(NewMember);
                var MemberList = memberRepository.GetAllMembers();
                RefreshDataInForm(MemberList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }

        private void btDeleteMember_Click(object sender, EventArgs e)
        {
            try
            {
                string MemberIdText = tbMemberId.Text;
                if (String.IsNullOrEmpty(MemberIdText) || String.IsNullOrWhiteSpace(MemberIdText))
                {
                    MessageBox.Show("Please enter member ID");
                }
                else
                {
                    var MemberId = Convert.ToInt32(MemberIdText);
                    memberRepository.DeleteMember(MemberId);
                    RefreshDataInForm(memberRepository.GetAllMembers());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btUpdateMember_Click(object sender, EventArgs e)
        {
            try
            {
                var MemberIdText = tbMemberId.Text;
                if (String.IsNullOrEmpty(MemberIdText) || String.IsNullOrWhiteSpace(MemberIdText))
                {
                    MessageBox.Show("Please enter member ID");
                }
                else
                {
                    var MemberId = Convert.ToInt32(MemberIdText);
                    var MemberName = tbMemberName.Text.ToUpper() == "" ? null : tbMemberName.Text;
                    var MemberPassword = tbMemberPassword.Text == "" ? null : tbMemberPassword.Text;
                    var MemberEmail = tbMemberEmail.Text == "" ? null : tbMemberEmail.Text;
                    var MemberCity = tbMemberCity.Text.ToUpper() == "" ? null : tbMemberCity.Text.ToUpper();
                    var MemberCountry = tbMemberCountry.Text.ToUpper() == "" ? null : tbMemberCountry.Text.ToUpper();
                    memberRepository.UpdateMember(new MemberObject
                    {
                        MemberId = MemberId,
                        MemberName = MemberName,
                        Password = MemberPassword,
                        Email = MemberEmail,
                        City = MemberCity,
                        Country = MemberCountry
                    });
                    RefreshDataInForm(memberRepository.GetAllMembers());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void chbSort_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbSort_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbSort.Checked)
            {
                RefreshDataInForm(memberRepository.SortMemberListDescendingName());
            }
            else
            {
                RefreshDataInForm(memberRepository.GetAllMembers());
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
