namespace WindowsFormsApplication1
{
    partial class Add_books
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
            Label label1;
            Label label2;
            Label label3;
            Label label4;
            Label label5;
            Label label6;
            Label label7;
            Label label8;
            panel1 = new Panel();
            Add_to = new Button();
            price_txt = new TextBox();
            qnt_txt = new TextBox();
            Title_txt = new TextBox();
            author_txt = new TextBox();
            section_txt = new TextBox();
            edition_txt = new TextBox();
            ID_text = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(129, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 32);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 416);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 1;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(101, 341);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 32);
            label3.TabIndex = 2;
            label3.Text = "Edition";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(160, 228);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(101, 191);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 32);
            label5.TabIndex = 4;
            label5.Text = "Author";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(117, 116);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 32);
            label6.TabIndex = 5;
            label6.Text = "Title";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(113, 491);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 32);
            label7.TabIndex = 13;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(101, 266);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(96, 32);
            label8.TabIndex = 14;
            label8.Text = "section";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Controls.Add(Add_to);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(price_txt);
            panel1.Controls.Add(qnt_txt);
            panel1.Controls.Add(Title_txt);
            panel1.Controls.Add(author_txt);
            panel1.Controls.Add(section_txt);
            panel1.Controls.Add(edition_txt);
            panel1.Controls.Add(ID_text);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(165, 60);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 585);
            panel1.TabIndex = 0;
            // 
            // Add_to
            // 
            Add_to.BackColor = Color.PeachPuff;
            Add_to.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Add_to.ForeColor = Color.Black;
            Add_to.Location = new Point(706, 541);
            Add_to.Margin = new Padding(4, 5, 4, 5);
            Add_to.Name = "Add_to";
            Add_to.Size = new Size(139, 44);
            Add_to.TabIndex = 15;
            Add_to.Text = "Add ";
            Add_to.UseVisualStyleBackColor = false;
            Add_to.Click += Add_to_Click;
            // 
            // price_txt
            // 
            price_txt.Location = new Point(241, 491);
            price_txt.Margin = new Padding(4, 5, 4, 5);
            price_txt.Name = "price_txt";
            price_txt.Size = new Size(330, 27);
            price_txt.TabIndex = 12;
            // 
            // qnt_txt
            // 
            qnt_txt.Location = new Point(241, 416);
            qnt_txt.Margin = new Padding(4, 5, 4, 5);
            qnt_txt.Name = "qnt_txt";
            qnt_txt.Size = new Size(330, 27);
            qnt_txt.TabIndex = 11;
            // 
            // Title_txt
            // 
            Title_txt.Location = new Point(241, 116);
            Title_txt.Margin = new Padding(4, 5, 4, 5);
            Title_txt.Name = "Title_txt";
            Title_txt.Size = new Size(330, 27);
            Title_txt.TabIndex = 10;
            // 
            // author_txt
            // 
            author_txt.Location = new Point(241, 191);
            author_txt.Margin = new Padding(4, 5, 4, 5);
            author_txt.Name = "author_txt";
            author_txt.Size = new Size(330, 27);
            author_txt.TabIndex = 9;
            // 
            // section_txt
            // 
            section_txt.Location = new Point(241, 266);
            section_txt.Margin = new Padding(4, 5, 4, 5);
            section_txt.Name = "section_txt";
            section_txt.Size = new Size(330, 27);
            section_txt.TabIndex = 8;
            // 
            // edition_txt
            // 
            edition_txt.Location = new Point(241, 341);
            edition_txt.Margin = new Padding(4, 5, 4, 5);
            edition_txt.Name = "edition_txt";
            edition_txt.Size = new Size(330, 27);
            edition_txt.TabIndex = 7;
            // 
            // ID_text
            // 
            ID_text.Location = new Point(241, 41);
            ID_text.Margin = new Padding(4, 5, 4, 5);
            ID_text.Name = "ID_text";
            ID_text.Size = new Size(330, 27);
            ID_text.TabIndex = 6;
            // 
            // Add_books
            // 
            AcceptButton = Add_to;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = user_interface.Properties.Resources.WhatsApp_Image_2023_04_28_at_06_11_33;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1085, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Add_books";
            Text = "Add_books";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Add_to;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TextBox qnt_txt;
        private System.Windows.Forms.TextBox Title_txt;
        private System.Windows.Forms.TextBox author_txt;
        private System.Windows.Forms.TextBox section_txt;
        private System.Windows.Forms.TextBox edition_txt;
        private System.Windows.Forms.TextBox ID_text;
    }
}