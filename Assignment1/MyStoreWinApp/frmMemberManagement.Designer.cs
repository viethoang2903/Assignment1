namespace MyStoreWinApp
{
    partial class frmMemberManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            btFilter = new System.Windows.Forms.Button();
            cbFilterCountry = new System.Windows.Forms.ComboBox();
            cbFilterCity = new System.Windows.Forms.ComboBox();
            lbFIlterCountry = new System.Windows.Forms.Label();
            lbFilterCity = new System.Windows.Forms.Label();
            lbFilter = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            btSearch = new System.Windows.Forms.Button();
            tbSearchName = new System.Windows.Forms.TextBox();
            chbSort = new System.Windows.Forms.CheckBox();
            tbSearchId = new System.Windows.Forms.TextBox();
            lbSearch = new System.Windows.Forms.Label();
            lbSearchName = new System.Windows.Forms.Label();
            lbSearchId = new System.Windows.Forms.Label();
            tbMemberCountry = new System.Windows.Forms.TextBox();
            tbMemberCity = new System.Windows.Forms.TextBox();
            tbMemberEmail = new System.Windows.Forms.TextBox();
            tbMemberName = new System.Windows.Forms.TextBox();
            tbMemberPassword = new System.Windows.Forms.TextBox();
            tbMemberId = new System.Windows.Forms.TextBox();
            lbCountry = new System.Windows.Forms.Label();
            lbCity = new System.Windows.Forms.Label();
            lbMemberEmail = new System.Windows.Forms.Label();
            lbMemberName = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbMemberID = new System.Windows.Forms.Label();
            btClose = new System.Windows.Forms.Button();
            btDeleteMember = new System.Windows.Forms.Button();
            btUpdateMember = new System.Windows.Forms.Button();
            btNewMember = new System.Windows.Forms.Button();
            grMemberList = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grMemberList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tbMemberCountry);
            panel1.Controls.Add(tbMemberCity);
            panel1.Controls.Add(tbMemberEmail);
            panel1.Controls.Add(tbMemberName);
            panel1.Controls.Add(tbMemberPassword);
            panel1.Controls.Add(tbMemberId);
            panel1.Controls.Add(lbCountry);
            panel1.Controls.Add(lbCity);
            panel1.Controls.Add(lbMemberEmail);
            panel1.Controls.Add(lbMemberName);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(lbMemberID);
            panel1.Location = new System.Drawing.Point(5, 54);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1402, 220);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(3, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 23);
            label3.TabIndex = 6;
            label3.Text = "Manage System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(2, 21);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(291, 20);
            label2.TabIndex = 15;
            label2.Text = "You must enter Member ID before using";
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel3.Controls.Add(btFilter);
            panel3.Controls.Add(cbFilterCountry);
            panel3.Controls.Add(cbFilterCity);
            panel3.Controls.Add(lbFIlterCountry);
            panel3.Controls.Add(lbFilterCity);
            panel3.Controls.Add(lbFilter);
            panel3.Location = new System.Drawing.Point(644, 106);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(743, 112);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // btFilter
            // 
            btFilter.BackColor = System.Drawing.Color.Thistle;
            btFilter.Location = new System.Drawing.Point(307, 60);
            btFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btFilter.Name = "btFilter";
            btFilter.Size = new System.Drawing.Size(120, 39);
            btFilter.TabIndex = 6;
            btFilter.Text = "Filter";
            btFilter.UseVisualStyleBackColor = false;
            btFilter.Click += btFilter_Click;
            // 
            // cbFilterCountry
            // 
            cbFilterCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFilterCountry.FormattingEnabled = true;
            cbFilterCountry.Location = new System.Drawing.Point(373, 21);
            cbFilterCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbFilterCountry.Name = "cbFilterCountry";
            cbFilterCountry.Size = new System.Drawing.Size(202, 28);
            cbFilterCountry.TabIndex = 8;
            // 
            // cbFilterCity
            // 
            cbFilterCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFilterCity.FormattingEnabled = true;
            cbFilterCity.Location = new System.Drawing.Point(71, 21);
            cbFilterCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbFilterCity.Name = "cbFilterCity";
            cbFilterCity.Size = new System.Drawing.Size(202, 28);
            cbFilterCity.TabIndex = 7;
            // 
            // lbFIlterCountry
            // 
            lbFIlterCountry.AutoSize = true;
            lbFIlterCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbFIlterCountry.Location = new System.Drawing.Point(292, 0);
            lbFIlterCountry.Name = "lbFIlterCountry";
            lbFIlterCountry.Size = new System.Drawing.Size(75, 23);
            lbFIlterCountry.TabIndex = 6;
            lbFIlterCountry.Text = "Country";
            // 
            // lbFilterCity
            // 
            lbFilterCity.AutoSize = true;
            lbFilterCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbFilterCity.Location = new System.Drawing.Point(6, 27);
            lbFilterCity.Name = "lbFilterCity";
            lbFilterCity.Size = new System.Drawing.Size(42, 23);
            lbFilterCity.TabIndex = 6;
            lbFilterCity.Text = "City";
            // 
            // lbFilter
            // 
            lbFilter.AutoSize = true;
            lbFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbFilter.Location = new System.Drawing.Point(6, -4);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new System.Drawing.Size(50, 23);
            lbFilter.TabIndex = 1;
            lbFilter.Text = "Filter";
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(btSearch);
            panel2.Controls.Add(tbSearchName);
            panel2.Controls.Add(chbSort);
            panel2.Controls.Add(tbSearchId);
            panel2.Controls.Add(lbSearch);
            panel2.Controls.Add(lbSearchName);
            panel2.Controls.Add(lbSearchId);
            panel2.Location = new System.Drawing.Point(644, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(743, 106);
            panel2.TabIndex = 1;
            // 
            // btSearch
            // 
            btSearch.BackColor = System.Drawing.Color.Violet;
            btSearch.Location = new System.Drawing.Point(373, 2);
            btSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btSearch.Name = "btSearch";
            btSearch.Size = new System.Drawing.Size(201, 36);
            btSearch.TabIndex = 5;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = false;
            btSearch.Click += btSearch_Click;
            // 
            // tbSearchName
            // 
            tbSearchName.Location = new System.Drawing.Point(71, 66);
            tbSearchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbSearchName.Name = "tbSearchName";
            tbSearchName.Size = new System.Drawing.Size(246, 27);
            tbSearchName.TabIndex = 4;
            // 
            // chbSort
            // 
            chbSort.AutoSize = true;
            chbSort.Location = new System.Drawing.Point(373, 62);
            chbSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            chbSort.Name = "chbSort";
            chbSort.Size = new System.Drawing.Size(204, 24);
            chbSort.TabIndex = 4;
            chbSort.Text = "Sort By Descending Name";
            chbSort.UseVisualStyleBackColor = true;
            chbSort.CheckedChanged += chbSort_CheckedChanged;
            chbSort.CheckStateChanged += chbSort_CheckStateChanged;
            // 
            // tbSearchId
            // 
            tbSearchId.Location = new System.Drawing.Point(71, 16);
            tbSearchId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbSearchId.Name = "tbSearchId";
            tbSearchId.Size = new System.Drawing.Size(246, 27);
            tbSearchId.TabIndex = 3;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbSearch.Location = new System.Drawing.Point(3, -4);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(62, 23);
            lbSearch.TabIndex = 0;
            lbSearch.Text = "Search";
            // 
            // lbSearchName
            // 
            lbSearchName.AutoSize = true;
            lbSearchName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbSearchName.Location = new System.Drawing.Point(6, 66);
            lbSearchName.Name = "lbSearchName";
            lbSearchName.Size = new System.Drawing.Size(57, 23);
            lbSearchName.TabIndex = 2;
            lbSearchName.Text = "Name";
            // 
            // lbSearchId
            // 
            lbSearchId.AutoSize = true;
            lbSearchId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbSearchId.Location = new System.Drawing.Point(6, 18);
            lbSearchId.Name = "lbSearchId";
            lbSearchId.Size = new System.Drawing.Size(26, 23);
            lbSearchId.TabIndex = 1;
            lbSearchId.Text = "Id";
            // 
            // tbMemberCountry
            // 
            tbMemberCountry.Location = new System.Drawing.Point(447, 180);
            tbMemberCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbMemberCountry.Name = "tbMemberCountry";
            tbMemberCountry.Size = new System.Drawing.Size(172, 27);
            tbMemberCountry.TabIndex = 11;
            // 
            // tbMemberCity
            // 
            tbMemberCity.Location = new System.Drawing.Point(446, 116);
            tbMemberCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbMemberCity.Name = "tbMemberCity";
            tbMemberCity.Size = new System.Drawing.Size(173, 27);
            tbMemberCity.TabIndex = 10;
            // 
            // tbMemberEmail
            // 
            tbMemberEmail.Location = new System.Drawing.Point(446, 82);
            tbMemberEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbMemberEmail.Name = "tbMemberEmail";
            tbMemberEmail.Size = new System.Drawing.Size(173, 27);
            tbMemberEmail.TabIndex = 9;
            // 
            // tbMemberName
            // 
            tbMemberName.Location = new System.Drawing.Point(447, 149);
            tbMemberName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbMemberName.Name = "tbMemberName";
            tbMemberName.Size = new System.Drawing.Size(172, 27);
            tbMemberName.TabIndex = 8;
            // 
            // tbMemberPassword
            // 
            tbMemberPassword.Location = new System.Drawing.Point(446, 49);
            tbMemberPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbMemberPassword.Name = "tbMemberPassword";
            tbMemberPassword.Size = new System.Drawing.Size(173, 27);
            tbMemberPassword.TabIndex = 7;
            // 
            // tbMemberId
            // 
            tbMemberId.Location = new System.Drawing.Point(446, 16);
            tbMemberId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbMemberId.Name = "tbMemberId";
            tbMemberId.Size = new System.Drawing.Size(173, 27);
            tbMemberId.TabIndex = 6;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(305, 185);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(305, 119);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbMemberEmail
            // 
            lbMemberEmail.AutoSize = true;
            lbMemberEmail.Location = new System.Drawing.Point(305, 86);
            lbMemberEmail.Name = "lbMemberEmail";
            lbMemberEmail.Size = new System.Drawing.Size(46, 20);
            lbMemberEmail.TabIndex = 3;
            lbMemberEmail.Text = "Email";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(305, 152);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(109, 20);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Member Name";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(305, 54);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(305, 21);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(84, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // btClose
            // 
            btClose.BackColor = System.Drawing.Color.Violet;
            btClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btClose.ForeColor = System.Drawing.SystemColors.ControlText;
            btClose.Location = new System.Drawing.Point(24, 528);
            btClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btClose.Name = "btClose";
            btClose.Size = new System.Drawing.Size(146, 32);
            btClose.TabIndex = 9;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btDeleteMember
            // 
            btDeleteMember.BackColor = System.Drawing.Color.Violet;
            btDeleteMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btDeleteMember.Location = new System.Drawing.Point(49, 464);
            btDeleteMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btDeleteMember.Name = "btDeleteMember";
            btDeleteMember.Size = new System.Drawing.Size(94, 40);
            btDeleteMember.TabIndex = 14;
            btDeleteMember.Text = "Delete";
            btDeleteMember.UseVisualStyleBackColor = false;
            btDeleteMember.Click += btDeleteMember_Click;
            // 
            // btUpdateMember
            // 
            btUpdateMember.BackColor = System.Drawing.Color.Violet;
            btUpdateMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btUpdateMember.Location = new System.Drawing.Point(49, 392);
            btUpdateMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btUpdateMember.Name = "btUpdateMember";
            btUpdateMember.Size = new System.Drawing.Size(94, 40);
            btUpdateMember.TabIndex = 13;
            btUpdateMember.Text = "Update";
            btUpdateMember.UseVisualStyleBackColor = false;
            btUpdateMember.Click += btUpdateMember_Click;
            // 
            // btNewMember
            // 
            btNewMember.BackColor = System.Drawing.Color.Violet;
            btNewMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btNewMember.Location = new System.Drawing.Point(49, 320);
            btNewMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btNewMember.Name = "btNewMember";
            btNewMember.Size = new System.Drawing.Size(94, 40);
            btNewMember.TabIndex = 12;
            btNewMember.Text = "New";
            btNewMember.UseVisualStyleBackColor = false;
            btNewMember.Click += btNewMember_Click;
            // 
            // grMemberList
            // 
            grMemberList.BackgroundColor = System.Drawing.Color.Violet;
            grMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grMemberList.GridColor = System.Drawing.Color.White;
            grMemberList.Location = new System.Drawing.Point(263, 305);
            grMemberList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grMemberList.Name = "grMemberList";
            grMemberList.RowHeadersWidth = 62;
            grMemberList.RowTemplate.Height = 25;
            grMemberList.Size = new System.Drawing.Size(1131, 247);
            grMemberList.TabIndex = 3;
            grMemberList.CellContentClick += grMemberList_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(527, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(376, 46);
            label1.TabIndex = 15;
            label1.Text = "Member Management";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(263, 278);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 23);
            label4.TabIndex = 6;
            label4.Text = "List";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1394, 573);
            Controls.Add(label4);
            Controls.Add(btClose);
            Controls.Add(label1);
            Controls.Add(grMemberList);
            Controls.Add(panel1);
            Controls.Add(btDeleteMember);
            Controls.Add(btNewMember);
            Controls.Add(btUpdateMember);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMemberCountry;
        private System.Windows.Forms.TextBox tbMemberCity;
        private System.Windows.Forms.TextBox tbMemberEmail;
        private System.Windows.Forms.TextBox tbMemberName;
        private System.Windows.Forms.TextBox tbMemberPassword;
        private System.Windows.Forms.TextBox tbMemberId;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbMemberEmail;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Button btDeleteMember;
        private System.Windows.Forms.Button btUpdateMember;
        private System.Windows.Forms.Button btNewMember;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbSearchName;
        private System.Windows.Forms.Label lbSearchId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.TextBox tbSearchId;
        private System.Windows.Forms.ComboBox cbFilterCountry;
        private System.Windows.Forms.ComboBox cbFilterCity;
        private System.Windows.Forms.Label lbFIlterCountry;
        private System.Windows.Forms.Label lbFilterCity;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.DataGridView grMemberList;
        private System.Windows.Forms.CheckBox chbSort;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }

    
}