namespace ybrahim
{
    partial class AdminForm
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
            panel2 = new Panel();
            btnsearch = new Button();
            textBox2 = new TextBox();
            label10 = new Label();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            btnUpdate = new Button();
            btnLogout = new Button();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            label9 = new Label();
            txtpassword = new TextBox();
            chShowpass = new CheckBox();
            label8 = new Label();
            txtStudentNo = new TextBox();
            cmbSection = new ComboBox();
            label7 = new Label();
            txtFirstname = new TextBox();
            cmbCourse = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            birthdate = new DateTimePicker();
            label4 = new Label();
            txtMiddlename = new TextBox();
            txtLastname = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnsearch);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtpassword);
            panel2.Controls.Add(chShowpass);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtStudentNo);
            panel2.Controls.Add(cmbSection);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtFirstname);
            panel2.Controls.Add(cmbCourse);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(birthdate);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtMiddlename);
            panel2.Controls.Add(txtLastname);
            panel2.Location = new Point(22, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(1391, 930);
            panel2.TabIndex = 35;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(901, 75);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(179, 29);
            btnsearch.TabIndex = 34;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(475, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(399, 27);
            textBox2.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 458);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 31;
            label10.Text = "BIrthday";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(24, 882);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(285, 41);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "DELETE RECORD";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(366, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1007, 734);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.HotTrack;
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(23, 834);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(285, 41);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "UPDATE RECORD";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.HotTrack;
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(1166, 42);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(207, 41);
            btnLogout.TabIndex = 28;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(366, 29);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 27;
            label2.Text = "Welcome";
            // 
            // txtId
            // 
            txtId.Location = new Point(24, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(287, 27);
            txtId.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 23;
            label1.Text = "ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 736);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 22;
            label9.Text = "Password";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(25, 763);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(287, 27);
            txtpassword.TabIndex = 15;
            // 
            // chShowpass
            // 
            chShowpass.AutoSize = true;
            chShowpass.Location = new Point(165, 801);
            chShowpass.Name = "chShowpass";
            chShowpass.Size = new Size(132, 24);
            chShowpass.TabIndex = 7;
            chShowpass.Text = "Show Password";
            chShowpass.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 642);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 21;
            label8.Text = "Section";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(23, 133);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(287, 27);
            txtStudentNo.TabIndex = 5;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(23, 668);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(287, 28);
            cmbSection.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 553);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 20;
            label7.Text = "Course";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(23, 221);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(287, 27);
            txtFirstname.TabIndex = 6;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "ACT", "HM", "BSOA" });
            cmbCourse.Location = new Point(24, 580);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(287, 28);
            cmbCourse.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 382);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 18;
            label5.Text = "Lastname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 295);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 19;
            label6.Text = "Middle name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 106);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 3;
            label3.Text = "Username/Student Number";
            // 
            // birthdate
            // 
            birthdate.Location = new Point(23, 484);
            birthdate.Name = "birthdate";
            birthdate.RightToLeftLayout = true;
            birthdate.Size = new Size(285, 27);
            birthdate.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 194);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Firstname";
            // 
            // txtMiddlename
            // 
            txtMiddlename.Location = new Point(23, 321);
            txtMiddlename.Name = "txtMiddlename";
            txtMiddlename.Size = new Size(287, 27);
            txtMiddlename.TabIndex = 14;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(25, 409);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(287, 27);
            txtLastname.TabIndex = 11;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 977);
            Controls.Add(panel2);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnsearch;
        private TextBox textBox2;
        private Label label10;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Button btnLogout;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private Label label9;
        private TextBox txtpassword;
        private CheckBox chShowpass;
        private Label label8;
        private TextBox txtStudentNo;
        private ComboBox cmbSection;
        private Label label7;
        private TextBox txtFirstname;
        private ComboBox cmbCourse;
        private Label label5;
        private Label label6;
        private Label label3;
        private DateTimePicker birthdate;
        private Label label4;
        private TextBox txtMiddlename;
        private TextBox txtLastname;
    }
}