namespace WindowsFormsApplication1
{
    partial class librarian_interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(librarian_interface));
            panel1 = new Panel();
            Log_out = new Button();
            button6 = new Button();
            show_books = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            add_book = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            main_panel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(151, 75, 0);
            panel1.Controls.Add(Log_out);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(show_books);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(add_book);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 629);
            panel1.TabIndex = 0;
            // 
            // Log_out
            // 
            Log_out.BackColor = Color.PeachPuff;
            Log_out.Dock = DockStyle.Top;
            Log_out.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Log_out.ForeColor = SystemColors.ControlText;
            Log_out.Image = user_interface.Properties.Resources.log_out;
            Log_out.ImageAlign = ContentAlignment.MiddleLeft;
            Log_out.Location = new Point(0, 516);
            Log_out.Margin = new Padding(4, 5, 4, 5);
            Log_out.Name = "Log_out";
            Log_out.Size = new Size(210, 63);
            Log_out.TabIndex = 7;
            Log_out.Text = "Log Out";
            Log_out.UseVisualStyleBackColor = false;
            Log_out.Click += Log_out_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PeachPuff;
            button6.Dock = DockStyle.Top;
            button6.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlText;
            button6.Image = user_interface.Properties.Resources.reading1;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 453);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(210, 63);
            button6.TabIndex = 6;
            button6.Text = "Show borrowed Books";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // show_books
            // 
            show_books.BackColor = Color.PeachPuff;
            show_books.Dock = DockStyle.Top;
            show_books.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            show_books.ForeColor = SystemColors.ControlText;
            show_books.Image = user_interface.Properties.Resources.book_1;
            show_books.ImageAlign = ContentAlignment.MiddleLeft;
            show_books.Location = new Point(0, 390);
            show_books.Margin = new Padding(4, 5, 4, 5);
            show_books.Name = "show_books";
            show_books.Size = new Size(210, 63);
            show_books.TabIndex = 5;
            show_books.Text = "Show books";
            show_books.UseVisualStyleBackColor = false;
            show_books.Click += show_books_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PeachPuff;
            button4.Dock = DockStyle.Top;
            button4.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.Image = user_interface.Properties.Resources._return;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 327);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(210, 63);
            button4.TabIndex = 4;
            button4.Text = "Return Book";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PeachPuff;
            button3.Dock = DockStyle.Top;
            button3.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Image = user_interface.Properties.Resources.search;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 264);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(210, 63);
            button3.TabIndex = 3;
            button3.Text = "Search Books";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PeachPuff;
            button2.Dock = DockStyle.Top;
            button2.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Image = user_interface.Properties.Resources.delete;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 201);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(210, 63);
            button2.TabIndex = 2;
            button2.Text = "Delete Books";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // add_book
            // 
            add_book.BackColor = Color.PeachPuff;
            add_book.Dock = DockStyle.Top;
            add_book.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            add_book.ForeColor = SystemColors.ControlText;
            add_book.Image = user_interface.Properties.Resources.ebook;
            add_book.ImageAlign = ContentAlignment.MiddleLeft;
            add_book.Location = new Point(0, 138);
            add_book.Margin = new Padding(4, 5, 4, 5);
            add_book.Name = "add_book";
            add_book.Size = new Size(210, 63);
            add_book.TabIndex = 1;
            add_book.Text = "Add Books";
            add_book.UseVisualStyleBackColor = false;
            add_book.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(151, 75, 0);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 138);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(151, 75, 0);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(210, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1360, 43);
            panel3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(151, 75, 0);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(210, 616);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(1360, 13);
            panel6.TabIndex = 4;
            // 
            // main_panel
            // 
            main_panel.BackgroundImage = user_interface.Properties.Resources.WhatsApp_Image_2023_04_28_at_06_11_33;
            main_panel.BackgroundImageLayout = ImageLayout.Stretch;
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(210, 43);
            main_panel.Margin = new Padding(4, 5, 4, 5);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1360, 586);
            main_panel.TabIndex = 2;
            // 
            // librarian_interface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 629);
            Controls.Add(panel6);
            Controls.Add(main_panel);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "librarian_interface";
            Text = "Librarian";
            Load += librarian_interface_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button show_books;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add_book;
        private Button Log_out;
    }
}