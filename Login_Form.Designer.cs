namespace WindowsFormsApplication1
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            type_box = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            login_btn = new Button();
            sign_up_btn = new Button();
            password_txt = new TextBox();
            user_txt = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(-415, 626);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-128, 278);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-380, 391);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-380, 522);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(-249, 391);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(-215, 511);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 27);
            textBox3.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(type_box);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(sign_up_btn);
            panel1.Controls.Add(password_txt);
            panel1.Controls.Add(user_txt);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(451, 226);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 592);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(91, 389);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 29);
            label7.TabIndex = 27;
            label7.Text = "Type :";
            // 
            // type_box
            // 
            type_box.FormattingEnabled = true;
            type_box.Items.AddRange(new object[] { "Librarian", "Admin", "User" });
            type_box.Location = new Point(228, 389);
            type_box.Margin = new Padding(4, 5, 4, 5);
            type_box.Name = "type_box";
            type_box.Size = new Size(160, 28);
            type_box.TabIndex = 26;
            type_box.Text = "Select";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(55, 297);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(144, 29);
            label6.TabIndex = 25;
            label6.Text = "Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(51, 185);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(149, 29);
            label5.TabIndex = 24;
            label5.Text = "Username :";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Peru;
            login_btn.FlatStyle = FlatStyle.Popup;
            login_btn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            login_btn.ForeColor = Color.Black;
            login_btn.Location = new Point(131, 477);
            login_btn.Margin = new Padding(4, 5, 4, 5);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(100, 35);
            login_btn.TabIndex = 23;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // sign_up_btn
            // 
            sign_up_btn.BackColor = Color.Peru;
            sign_up_btn.FlatStyle = FlatStyle.Popup;
            sign_up_btn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            sign_up_btn.ForeColor = Color.Black;
            sign_up_btn.Location = new Point(356, 477);
            sign_up_btn.Margin = new Padding(4, 5, 4, 5);
            sign_up_btn.Name = "sign_up_btn";
            sign_up_btn.Size = new Size(100, 35);
            sign_up_btn.TabIndex = 22;
            sign_up_btn.Text = "SignUp";
            sign_up_btn.UseVisualStyleBackColor = false;
            sign_up_btn.Click += sign_up_btn_Click;
            // 
            // password_txt
            // 
            password_txt.ImeMode = ImeMode.NoControl;
            password_txt.Location = new Point(228, 302);
            password_txt.Margin = new Padding(4, 5, 4, 5);
            password_txt.Multiline = true;
            password_txt.Name = "password_txt";
            password_txt.PasswordChar = '*';
            password_txt.Size = new Size(227, 29);
            password_txt.TabIndex = 21;
            password_txt.Tag = "";
            // 
            // user_txt
            // 
            user_txt.Location = new Point(228, 185);
            user_txt.Margin = new Padding(4, 5, 4, 5);
            user_txt.Name = "user_txt";
            user_txt.Size = new Size(227, 27);
            user_txt.TabIndex = 20;
            user_txt.TextChanged += user_txt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Akhbar MT", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(168, 78);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(202, 52);
            label4.TabIndex = 19;
            label4.Text = "Login Form";
            // 
            // Login_Form
            // 
            AcceptButton = login_btn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = user_interface.Properties.Resources._5920231913954591030_121;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1372, 937);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login ";
            Load += Login_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button sign_up_btn;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label4;
        public TextBox user_txt;
    }
}

