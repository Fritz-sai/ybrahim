namespace ybrahim
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            panel3 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cmbCourse = new ComboBox();
            cmbSection = new ComboBox();
            txtpassword = new TextBox();
            txtMiddlename = new TextBox();
            birthday = new DateTimePicker();
            txtLastname = new TextBox();
            btnclose = new Button();
            btnregister = new Button();
            btnlogin = new Button();
            chShowpass = new CheckBox();
            txtFirstname = new TextBox();
            txtusername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1331, 706);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cmbCourse);
            panel3.Controls.Add(cmbSection);
            panel3.Controls.Add(txtpassword);
            panel3.Controls.Add(txtMiddlename);
            panel3.Controls.Add(birthday);
            panel3.Controls.Add(txtLastname);
            panel3.Controls.Add(btnclose);
            panel3.Controls.Add(btnregister);
            panel3.Controls.Add(btnlogin);
            panel3.Controls.Add(chShowpass);
            panel3.Controls.Add(txtFirstname);
            panel3.Controls.Add(txtusername);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(494, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(737, 526);
            panel3.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(389, 155);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 23;
            label10.Text = "Birthday";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(389, 311);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 22;
            label9.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 311);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 21;
            label8.Text = "Section";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(387, 239);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 20;
            label7.Text = "Course";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 239);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 19;
            label6.Text = "Middle name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 84);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 18;
            label5.Text = "Lastname";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "ACT", "HM", "BSOA" });
            cmbCourse.Location = new Point(387, 265);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(256, 28);
            cmbCourse.TabIndex = 17;
            cmbCourse.SelectedIndexChanged += cmbCourse_SelectedIndexChanged;
            cmbCourse.KeyPress += cmbCourse_KeyPress;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(48, 334);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(256, 28);
            cmbSection.TabIndex = 16;
            cmbSection.KeyPress += cmbSection_KeyPress;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(387, 334);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(256, 27);
            txtpassword.TabIndex = 15;
            // 
            // txtMiddlename
            // 
            txtMiddlename.Location = new Point(48, 262);
            txtMiddlename.Name = "txtMiddlename";
            txtMiddlename.Size = new Size(256, 27);
            txtMiddlename.TabIndex = 14;
            // 
            // birthday
            // 
            birthday.Location = new Point(389, 178);
            birthday.Name = "birthday";
            birthday.Size = new Size(254, 27);
            birthday.TabIndex = 12;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(387, 107);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(256, 27);
            txtLastname.TabIndex = 11;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(670, 3);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(54, 29);
            btnclose.TabIndex = 3;
            btnclose.Text = "x";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // btnregister
            // 
            btnregister.BackColor = SystemColors.ButtonFace;
            btnregister.FlatStyle = FlatStyle.Flat;
            btnregister.ForeColor = SystemColors.ActiveCaptionText;
            btnregister.Location = new Point(48, 409);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(595, 42);
            btnregister.TabIndex = 9;
            btnregister.Text = "Register Account";
            btnregister.UseVisualStyleBackColor = false;
            btnregister.Click += btnregister_Click;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.Highlight;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = SystemColors.ButtonFace;
            btnlogin.Location = new Point(48, 460);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(595, 47);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // chShowpass
            // 
            chShowpass.AutoSize = true;
            chShowpass.Location = new Point(387, 367);
            chShowpass.Name = "chShowpass";
            chShowpass.Size = new Size(132, 24);
            chShowpass.TabIndex = 7;
            chShowpass.Text = "Show Password";
            chShowpass.UseVisualStyleBackColor = true;
            chShowpass.CheckedChanged += chShowpass_CheckedChanged;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(48, 180);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(256, 27);
            txtFirstname.TabIndex = 6;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(48, 107);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(256, 27);
            txtusername.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 157);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 4;
            label4.Text = "Firstname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 84);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 3;
            label3.Text = "Student Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(295, 20);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 2;
            label2.Text = "Registration";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(99, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 529);
            panel2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(126, 268);
            label1.Name = "label1";
            label1.Size = new Size(152, 160);
            label1.TabIndex = 5;
            label1.Text = "Welcome to the \r\nCLARK COLLEGE\r\nStudent Management\r\nSystem\r\n\r\n\r\n\r\n\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(107, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 182);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 752);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox cmbCourse;
        private ComboBox cmbSection;
        private TextBox txtpassword;
        private TextBox txtMiddlename;
        private DateTimePicker birthday;
        private TextBox txtLastname;
        private Button btnclose;
        private Button btnregister;
        private Button btnlogin;
        private CheckBox chShowpass;
        private TextBox txtFirstname;
        private TextBox txtusername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}