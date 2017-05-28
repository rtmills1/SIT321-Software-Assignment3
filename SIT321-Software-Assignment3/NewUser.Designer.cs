namespace SIT321_Software_Assignment3
{
    partial class NewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewUser_firstname = new System.Windows.Forms.TextBox();
            this.NewUser_secondname = new System.Windows.Forms.TextBox();
            this.NewUser_username = new System.Windows.Forms.TextBox();
            this.NewUser_password = new System.Windows.Forms.TextBox();
            this.NewUser_Type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_NewUser_exit = new System.Windows.Forms.Button();
            this.btn_NewUser_create = new System.Windows.Forms.Button();
            this.NewUser_unit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter account details ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewUser_firstname
            // 
            this.NewUser_firstname.Location = new System.Drawing.Point(76, 67);
            this.NewUser_firstname.Name = "NewUser_firstname";
            this.NewUser_firstname.Size = new System.Drawing.Size(139, 20);
            this.NewUser_firstname.TabIndex = 1;
            // 
            // NewUser_secondname
            // 
            this.NewUser_secondname.Location = new System.Drawing.Point(76, 114);
            this.NewUser_secondname.Name = "NewUser_secondname";
            this.NewUser_secondname.Size = new System.Drawing.Size(139, 20);
            this.NewUser_secondname.TabIndex = 2;
            // 
            // NewUser_username
            // 
            this.NewUser_username.Location = new System.Drawing.Point(76, 163);
            this.NewUser_username.Name = "NewUser_username";
            this.NewUser_username.Size = new System.Drawing.Size(139, 20);
            this.NewUser_username.TabIndex = 3;
            this.NewUser_username.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // NewUser_password
            // 
            this.NewUser_password.Location = new System.Drawing.Point(76, 214);
            this.NewUser_password.Name = "NewUser_password";
            this.NewUser_password.Size = new System.Drawing.Size(139, 20);
            this.NewUser_password.TabIndex = 4;
            // 
            // NewUser_Type
            // 
            this.NewUser_Type.FormattingEnabled = true;
            this.NewUser_Type.Items.AddRange(new object[] {
            "Student",
            "Lecturer",
            "Admin "});
            this.NewUser_Type.Location = new System.Drawing.Point(76, 269);
            this.NewUser_Type.Name = "NewUser_Type";
            this.NewUser_Type.Size = new System.Drawing.Size(139, 21);
            this.NewUser_Type.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(42, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Second Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(42, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(42, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(42, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account Type:";
            // 
            // btn_NewUser_exit
            // 
            this.btn_NewUser_exit.Location = new System.Drawing.Point(166, 343);
            this.btn_NewUser_exit.Name = "btn_NewUser_exit";
            this.btn_NewUser_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_NewUser_exit.TabIndex = 12;
            this.btn_NewUser_exit.Text = "Exit";
            this.btn_NewUser_exit.UseVisualStyleBackColor = true;
            this.btn_NewUser_exit.Click += new System.EventHandler(this.btn_NewUser_exit_Click);
            // 
            // btn_NewUser_create
            // 
            this.btn_NewUser_create.Location = new System.Drawing.Point(44, 343);
            this.btn_NewUser_create.Name = "btn_NewUser_create";
            this.btn_NewUser_create.Size = new System.Drawing.Size(75, 23);
            this.btn_NewUser_create.TabIndex = 13;
            this.btn_NewUser_create.Text = "Create";
            this.btn_NewUser_create.UseVisualStyleBackColor = true;
            this.btn_NewUser_create.Click += new System.EventHandler(this.btn_NewUser_create_Click);
            // 
            // NewUser_unit
            // 
            this.NewUser_unit.Location = new System.Drawing.Point(76, 317);
            this.NewUser_unit.Name = "NewUser_unit";
            this.NewUser_unit.Size = new System.Drawing.Size(139, 20);
            this.NewUser_unit.TabIndex = 14;
            this.NewUser_unit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(43, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Unit:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 378);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NewUser_unit);
            this.Controls.Add(this.btn_NewUser_create);
            this.Controls.Add(this.btn_NewUser_exit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewUser_Type);
            this.Controls.Add(this.NewUser_password);
            this.Controls.Add(this.NewUser_username);
            this.Controls.Add(this.NewUser_secondname);
            this.Controls.Add(this.NewUser_firstname);
            this.Controls.Add(this.label1);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewUser_firstname;
        private System.Windows.Forms.TextBox NewUser_secondname;
        private System.Windows.Forms.TextBox NewUser_username;
        private System.Windows.Forms.TextBox NewUser_password;
        private System.Windows.Forms.ComboBox NewUser_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_NewUser_exit;
        private System.Windows.Forms.Button btn_NewUser_create;
        private System.Windows.Forms.TextBox NewUser_unit;
        private System.Windows.Forms.Label label7;
    }
}