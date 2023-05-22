namespace user_interface
{
    partial class Issueform
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
            searchpanel = new Panel();
            dateTimePickerfirst = new DateTimePicker();
            enddate = new DateTimePicker();
            Bkid_txt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Issue_btn = new Button();
            userid_txt = new TextBox();
            label2 = new Label();
            Title_txt = new TextBox();
            label1 = new Label();
            searchpanel.SuspendLayout();
            SuspendLayout();
            // 
            // searchpanel
            // 
            searchpanel.Anchor = AnchorStyles.None;
            searchpanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchpanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            searchpanel.Controls.Add(dateTimePickerfirst);
            searchpanel.Controls.Add(enddate);
            searchpanel.Controls.Add(Bkid_txt);
            searchpanel.Controls.Add(label5);
            searchpanel.Controls.Add(label4);
            searchpanel.Controls.Add(label3);
            searchpanel.Controls.Add(Issue_btn);
            searchpanel.Controls.Add(userid_txt);
            searchpanel.Controls.Add(label2);
            searchpanel.Controls.Add(Title_txt);
            searchpanel.Controls.Add(label1);
            searchpanel.ForeColor = SystemColors.Control;
            searchpanel.Location = new Point(265, 100);
            searchpanel.Name = "searchpanel";
            searchpanel.Size = new Size(634, 380);
            searchpanel.TabIndex = 1;
            // 
            // dateTimePickerfirst
            // 
            dateTimePickerfirst.Checked = false;
            dateTimePickerfirst.CustomFormat = "yyyy-MM-dd";
            dateTimePickerfirst.Format = DateTimePickerFormat.Custom;
            dateTimePickerfirst.Location = new Point(205, 206);
            dateTimePickerfirst.Name = "dateTimePickerfirst";
            dateTimePickerfirst.Size = new Size(243, 27);
            dateTimePickerfirst.TabIndex = 11;
            dateTimePickerfirst.Value = new DateTime(2023, 5, 2, 0, 0, 0, 0);
            // 
            // enddate
            // 
            enddate.CustomFormat = "yyyy-MM-dd";
            enddate.Format = DateTimePickerFormat.Custom;
            enddate.Location = new Point(205, 266);
            enddate.Name = "enddate";
            enddate.Size = new Size(243, 27);
            enddate.TabIndex = 0;
            enddate.TabStop = false;
            enddate.Value = new DateTime(2023, 5, 11, 0, 0, 0, 0);
            // 
            // Bkid_txt
            // 
            Bkid_txt.Location = new Point(205, 92);
            Bkid_txt.Name = "Bkid_txt";
            Bkid_txt.Size = new Size(243, 27);
            Bkid_txt.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(89, 86);
            label5.Name = "label5";
            label5.Size = new Size(100, 31);
            label5.TabIndex = 9;
            label5.Text = "Book ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(79, 266);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 8;
            label4.Text = "End Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 206);
            label3.Name = "label3";
            label3.Size = new Size(117, 31);
            label3.TabIndex = 7;
            label3.Text = "First Date";
            label3.Click += label3_Click;
            // 
            // Issue_btn
            // 
            Issue_btn.BackColor = Color.PeachPuff;
            Issue_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Issue_btn.ForeColor = SystemColors.ControlText;
            Issue_btn.Location = new Point(465, 312);
            Issue_btn.Name = "Issue_btn";
            Issue_btn.Size = new Size(139, 44);
            Issue_btn.TabIndex = 4;
            Issue_btn.Text = "Issue";
            Issue_btn.UseVisualStyleBackColor = false;
            Issue_btn.Click += Issue_btn_Click;
            // 
            // userid_txt
            // 
            userid_txt.Location = new Point(205, 152);
            userid_txt.Name = "userid_txt";
            userid_txt.Size = new Size(243, 27);
            userid_txt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 146);
            label2.Name = "label2";
            label2.Size = new Size(92, 31);
            label2.TabIndex = 2;
            label2.Text = "User ID";
            // 
            // Title_txt
            // 
            Title_txt.Location = new Point(205, 32);
            Title_txt.Name = "Title_txt";
            Title_txt.Size = new Size(243, 27);
            Title_txt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 26);
            label1.Name = "label1";
            label1.Size = new Size(62, 31);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // Issueform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_04_28_at_06_11_33;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1165, 581);
            Controls.Add(searchpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Issueform";
            Text = "Issueform";
            searchpanel.ResumeLayout(false);
            searchpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel searchpanel;
        private Button Issue_btn;
        private TextBox userid_txt;
        private Label label2;
        private TextBox Title_txt;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox Bkid_txt;
        private Label label5;
        private DateTimePicker enddate;
        private DateTimePicker dateTimePickerfirst;
    }
}