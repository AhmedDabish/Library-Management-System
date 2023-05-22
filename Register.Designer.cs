namespace WindowsFormsApplication1
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
            label1 = new Label();
            label2 = new Label();
            user_txt = new TextBox();
            label4 = new Label();
            email_txt = new TextBox();
            label5 = new Label();
            pass_txt = new TextBox();
            label6 = new Label();
            phone_txt = new TextBox();
            label7 = new Label();
            adr_txt = new TextBox();
            typ_txt = new ComboBox();
            label8 = new Label();
            signup_btn = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(879, 130);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 29);
            label1.TabIndex = 18;
            label1.Text = "Create an account";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(801, 270);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 19;
            label2.Text = "Username:";
            // 
            // user_txt
            // 
            user_txt.Anchor = AnchorStyles.None;
            user_txt.Location = new Point(916, 270);
            user_txt.Margin = new Padding(4, 5, 4, 5);
            user_txt.Name = "user_txt";
            user_txt.Size = new Size(192, 27);
            user_txt.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(835, 342);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 23;
            label4.Text = "Email :";
            // 
            // email_txt
            // 
            email_txt.Anchor = AnchorStyles.None;
            email_txt.Location = new Point(916, 343);
            email_txt.Margin = new Padding(4, 5, 4, 5);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(192, 27);
            email_txt.TabIndex = 24;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(801, 420);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 25;
            label5.Text = "Password :";
            // 
            // pass_txt
            // 
            pass_txt.Anchor = AnchorStyles.None;
            pass_txt.Location = new Point(916, 420);
            pass_txt.Margin = new Padding(4, 5, 4, 5);
            pass_txt.Name = "pass_txt";
            pass_txt.PasswordChar = '*';
            pass_txt.Size = new Size(192, 27);
            pass_txt.TabIndex = 26;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(824, 497);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 27;
            label6.Text = "Phone :";
            // 
            // phone_txt
            // 
            phone_txt.Anchor = AnchorStyles.None;
            phone_txt.Location = new Point(916, 497);
            phone_txt.Margin = new Padding(4, 5, 4, 5);
            phone_txt.Name = "phone_txt";
            phone_txt.Size = new Size(192, 27);
            phone_txt.TabIndex = 28;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(809, 571);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 23);
            label7.TabIndex = 29;
            label7.Text = "Address :";
            // 
            // adr_txt
            // 
            adr_txt.Anchor = AnchorStyles.None;
            adr_txt.Location = new Point(916, 572);
            adr_txt.Margin = new Padding(4, 5, 4, 5);
            adr_txt.Name = "adr_txt";
            adr_txt.Size = new Size(192, 27);
            adr_txt.TabIndex = 30;
            // 
            // typ_txt
            // 
            typ_txt.Anchor = AnchorStyles.None;
            typ_txt.FormattingEnabled = true;
            typ_txt.Items.AddRange(new object[] { "User", "Librarian" });
            typ_txt.Location = new Point(916, 648);
            typ_txt.Margin = new Padding(4, 5, 4, 5);
            typ_txt.Name = "typ_txt";
            typ_txt.Size = new Size(192, 28);
            typ_txt.TabIndex = 31;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(835, 648);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 23);
            label8.TabIndex = 32;
            label8.Text = "Type :";
            // 
            // signup_btn
            // 
            signup_btn.Anchor = AnchorStyles.None;
            signup_btn.BackColor = Color.BurlyWood;
            signup_btn.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            signup_btn.Location = new Point(1047, 726);
            signup_btn.Margin = new Padding(4, 5, 4, 5);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(100, 35);
            signup_btn.TabIndex = 33;
            signup_btn.Text = "Sign Up";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.BurlyWood;
            button2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(839, 726);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 34;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = user_interface.Properties.Resources.IMG_٢٠٢٣٠٤٢٤_١٨٥٢٢٢;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(225, 100);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 723);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(740, 100);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(516, 723);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(1372, 937);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(signup_btn);
            Controls.Add(label8);
            Controls.Add(typ_txt);
            Controls.Add(adr_txt);
            Controls.Add(label7);
            Controls.Add(phone_txt);
            Controls.Add(label6);
            Controls.Add(pass_txt);
            Controls.Add(label5);
            Controls.Add(email_txt);
            Controls.Add(label4);
            Controls.Add(user_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Register";
            Text = "Sign Up";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TextBox user_txt;
        private TextBox email_txt;
        private TextBox pass_txt;
        private TextBox phone_txt;
        private TextBox adr_txt;
        private ComboBox typ_txt;
        private Button signup_btn;
    }
}