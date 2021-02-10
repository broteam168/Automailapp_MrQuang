
namespace Automailapp_MrQuang
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonSettingLogin = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.PassFb = new System.Windows.Forms.TextBox();
            this.UserFb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListGroup = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NumberPost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegPostnum = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Keybox = new System.Windows.Forms.TextBox();
            this.Runbutton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PassMail = new System.Windows.Forms.TextBox();
            this.Usermail = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonSettingLogin);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.CheckButton);
            this.groupBox1.Controls.Add(this.PassFb);
            this.groupBox1.Controls.Add(this.UserFb);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài khoản ";
            // 
            // ButtonSettingLogin
            // 
            this.ButtonSettingLogin.Location = new System.Drawing.Point(828, 30);
            this.ButtonSettingLogin.Name = "ButtonSettingLogin";
            this.ButtonSettingLogin.Size = new System.Drawing.Size(43, 30);
            this.ButtonSettingLogin.TabIndex = 4;
            this.ButtonSettingLogin.Text = "CĐ";
            this.ButtonSettingLogin.UseVisualStyleBackColor = true;
            this.ButtonSettingLogin.Click += new System.EventHandler(this.ButtonSettingLogin_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(646, 30);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(160, 30);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Ghi";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(463, 30);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(160, 30);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Kiểm tra đăng nhập";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // PassFb
            // 
            this.PassFb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassFb.Location = new System.Drawing.Point(244, 30);
            this.PassFb.Name = "PassFb";
            this.PassFb.PasswordChar = '*';
            this.PassFb.Size = new System.Drawing.Size(176, 30);
            this.PassFb.TabIndex = 1;
            this.PassFb.UseSystemPasswordChar = true;
            // 
            // UserFb
            // 
            this.UserFb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFb.Location = new System.Drawing.Point(12, 30);
            this.UserFb.Name = "UserFb";
            this.UserFb.Size = new System.Drawing.Size(176, 30);
            this.UserFb.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListGroup);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(890, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhóm ";
            // 
            // ListGroup
            // 
            this.ListGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListGroup.Location = new System.Drawing.Point(16, 21);
            this.ListGroup.Multiline = true;
            this.ListGroup.Name = "ListGroup";
            this.ListGroup.PasswordChar = '*';
            this.ListGroup.Size = new System.Drawing.Size(586, 117);
            this.ListGroup.TabIndex = 10;
            this.ListGroup.UseSystemPasswordChar = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NumberPost);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.RegPostnum);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(624, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 128);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Số bài";
            // 
            // NumberPost
            // 
            this.NumberPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberPost.Location = new System.Drawing.Point(49, 46);
            this.NumberPost.Name = "NumberPost";
            this.NumberPost.Size = new System.Drawing.Size(160, 30);
            this.NumberPost.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số bài cần lấy";
            this.label1.UseWaitCursor = true;
            // 
            // RegPostnum
            // 
            this.RegPostnum.Location = new System.Drawing.Point(43, 82);
            this.RegPostnum.Name = "RegPostnum";
            this.RegPostnum.Size = new System.Drawing.Size(176, 30);
            this.RegPostnum.TabIndex = 6;
            this.RegPostnum.Text = "Ghi";
            this.RegPostnum.UseVisualStyleBackColor = true;
            this.RegPostnum.Click += new System.EventHandler(this.RegPostnum_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Keybox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(890, 155);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Từ khóa (mỗi từ trên một dòng)";
            // 
            // Keybox
            // 
            this.Keybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keybox.Location = new System.Drawing.Point(12, 21);
            this.Keybox.Multiline = true;
            this.Keybox.Name = "Keybox";
            this.Keybox.PasswordChar = '*';
            this.Keybox.Size = new System.Drawing.Size(859, 128);
            this.Keybox.TabIndex = 3;
            this.Keybox.UseSystemPasswordChar = true;
            // 
            // Runbutton
            // 
            this.Runbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Runbutton.Location = new System.Drawing.Point(201, 602);
            this.Runbutton.Name = "Runbutton";
            this.Runbutton.Size = new System.Drawing.Size(480, 73);
            this.Runbutton.TabIndex = 2;
            this.Runbutton.Text = "Chạy ";
            this.Runbutton.UseVisualStyleBackColor = true;
            this.Runbutton.Click += new System.EventHandler(this.Runbutton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.PassMail);
            this.groupBox5.Controls.Add(this.Usermail);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 391);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(890, 205);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gmail";
            // 
            // PassMail
            // 
            this.PassMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassMail.Location = new System.Drawing.Point(244, 36);
            this.PassMail.Name = "PassMail";
            this.PassMail.PasswordChar = '*';
            this.PassMail.Size = new System.Drawing.Size(176, 30);
            this.PassMail.TabIndex = 3;
            this.PassMail.UseSystemPasswordChar = true;
            // 
            // Usermail
            // 
            this.Usermail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usermail.Location = new System.Drawing.Point(16, 36);
            this.Usermail.Name = "Usermail";
            this.Usermail.Size = new System.Drawing.Size(176, 30);
            this.Usermail.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(424, 107);
            this.textBox1.TabIndex = 4;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(447, 92);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(424, 107);
            this.textBox2.TabIndex = 5;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 687);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Runbutton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Phần mềm AutoMail by Broteam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox PassFb;
        private System.Windows.Forms.TextBox UserFb;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ButtonSettingLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RegPostnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberPost;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Runbutton;
        private System.Windows.Forms.TextBox Keybox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox PassMail;
        private System.Windows.Forms.TextBox Usermail;
        private System.Windows.Forms.TextBox ListGroup;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

