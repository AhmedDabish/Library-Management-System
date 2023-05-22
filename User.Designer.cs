namespace user_interface
{
    partial class User
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            sidepanel = new Panel();
            log_out = new Button();
            show_id = new Button();
            issu_book = new Button();
            show_books = new Button();
            search_book = new Button();
            logopanel = new Panel();
            headerpanel = new Panel();
            bottompanel = new Panel();
            mainpanel = new Panel();
            sidepanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.FromArgb(151, 75, 0);
            sidepanel.Controls.Add(log_out);
            sidepanel.Controls.Add(show_id);
            sidepanel.Controls.Add(issu_book);
            sidepanel.Controls.Add(show_books);
            sidepanel.Controls.Add(search_book);
            sidepanel.Controls.Add(logopanel);
            sidepanel.Dock = DockStyle.Left;
            sidepanel.Location = new Point(0, 0);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(210, 612);
            sidepanel.TabIndex = 4;
            sidepanel.Paint += panel2_Paint;
            // 
            // log_out
            // 
            log_out.BackColor = Color.PeachPuff;
            log_out.Dock = DockStyle.Top;
            log_out.FlatAppearance.BorderColor = Color.White;
            log_out.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            log_out.Image = Properties.Resources.log_out;
            log_out.ImageAlign = ContentAlignment.MiddleLeft;
            log_out.Location = new Point(0, 390);
            log_out.Name = "log_out";
            log_out.Size = new Size(210, 63);
            log_out.TabIndex = 9;
            log_out.Text = " Log out";
            log_out.UseVisualStyleBackColor = false;
            log_out.Click += log_out_Click;
            // 
            // show_id
            // 
            show_id.BackColor = Color.PeachPuff;
            show_id.Dock = DockStyle.Top;
            show_id.FlatAppearance.BorderColor = Color.White;
            show_id.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            show_id.Image = Properties.Resources.id_card;
            show_id.ImageAlign = ContentAlignment.MiddleLeft;
            show_id.Location = new Point(0, 327);
            show_id.Name = "show_id";
            show_id.Size = new Size(210, 63);
            show_id.TabIndex = 8;
            show_id.Text = "Show ID";
            show_id.UseVisualStyleBackColor = false;
            show_id.Click += show_id_Click;
            // 
            // issu_book
            // 
            issu_book.BackColor = Color.PeachPuff;
            issu_book.Dock = DockStyle.Top;
            issu_book.FlatAppearance.BorderColor = Color.White;
            issu_book.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            issu_book.Image = (Image)resources.GetObject("issu_book.Image");
            issu_book.ImageAlign = ContentAlignment.MiddleLeft;
            issu_book.Location = new Point(0, 264);
            issu_book.Name = "issu_book";
            issu_book.Size = new Size(210, 63);
            issu_book.TabIndex = 7;
            issu_book.Text = " Issue Book";
            issu_book.UseVisualStyleBackColor = false;
            issu_book.Click += issu_book_Click;
            // 
            // show_books
            // 
            show_books.BackColor = Color.PeachPuff;
            show_books.Dock = DockStyle.Top;
            show_books.FlatAppearance.BorderColor = Color.White;
            show_books.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            show_books.Image = (Image)resources.GetObject("show_books.Image");
            show_books.ImageAlign = ContentAlignment.MiddleLeft;
            show_books.Location = new Point(0, 201);
            show_books.Name = "show_books";
            show_books.Size = new Size(210, 63);
            show_books.TabIndex = 6;
            show_books.Text = " Show Books";
            show_books.UseVisualStyleBackColor = false;
            show_books.Click += show_books_Click;
            // 
            // search_book
            // 
            search_book.BackColor = Color.PeachPuff;
            search_book.Dock = DockStyle.Top;
            search_book.FlatAppearance.BorderColor = Color.Black;
            search_book.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            search_book.ForeColor = SystemColors.ControlText;
            search_book.Image = (Image)resources.GetObject("search_book.Image");
            search_book.ImageAlign = ContentAlignment.MiddleLeft;
            search_book.Location = new Point(0, 138);
            search_book.Name = "search_book";
            search_book.Size = new Size(210, 63);
            search_book.TabIndex = 5;
            search_book.Text = " Search Book";
            search_book.UseVisualStyleBackColor = false;
            search_book.Click += search_book_Click;
            // 
            // logopanel
            // 
            logopanel.BackColor = Color.FromArgb(151, 75, 0);
            logopanel.BackgroundImage = (Image)resources.GetObject("logopanel.BackgroundImage");
            logopanel.BackgroundImageLayout = ImageLayout.Center;
            logopanel.Dock = DockStyle.Top;
            logopanel.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            logopanel.Location = new Point(0, 0);
            logopanel.Name = "logopanel";
            logopanel.Size = new Size(210, 138);
            logopanel.TabIndex = 5;
            logopanel.Paint += logopanel_Paint;
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.FromArgb(151, 75, 0);
            headerpanel.Dock = DockStyle.Top;
            headerpanel.Location = new Point(210, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(1127, 43);
            headerpanel.TabIndex = 5;
            headerpanel.Paint += headerpanel_Paint;
            // 
            // bottompanel
            // 
            bottompanel.BackColor = Color.FromArgb(151, 75, 0);
            bottompanel.Dock = DockStyle.Bottom;
            bottompanel.Location = new Point(210, 569);
            bottompanel.Name = "bottompanel";
            bottompanel.Size = new Size(1127, 43);
            bottompanel.TabIndex = 6;
            bottompanel.Paint += bottompanel_Paint;
            // 
            // mainpanel
            // 
            mainpanel.BackgroundImage = (Image)resources.GetObject("mainpanel.BackgroundImage");
            mainpanel.BackgroundImageLayout = ImageLayout.Stretch;
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(210, 43);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1127, 526);
            mainpanel.TabIndex = 7;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_04_28_at_06_11_33;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1337, 612);
            Controls.Add(mainpanel);
            Controls.Add(bottompanel);
            Controls.Add(headerpanel);
            Controls.Add(sidepanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += Form1_Load;
            sidepanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel sidepanel;
        private Button search_book;
        private Panel logopanel;
        private Panel headerpanel;
        private Panel bottompanel;
        private Button show_books;
        private Button issu_book;
        private Panel mainpanel;
        private Button show_id;
        private Button log_out;
    }
}