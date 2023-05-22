namespace user_interface
{
    partial class adminform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminform));
            adminpanel = new Panel();
            sidepanel = new Panel();
            button1 = new Button();
            delete_lib = new Button();
            Add_lib = new Button();
            logopanel = new Panel();
            bottompanel = new Panel();
            headerpanel = new Panel();
            sidepanel.SuspendLayout();
            SuspendLayout();
            // 
            // adminpanel
            // 
            adminpanel.BackgroundImage = (Image)resources.GetObject("adminpanel.BackgroundImage");
            adminpanel.BackgroundImageLayout = ImageLayout.Stretch;
            adminpanel.Dock = DockStyle.Fill;
            adminpanel.Location = new Point(210, 43);
            adminpanel.Name = "adminpanel";
            adminpanel.Size = new Size(1055, 469);
            adminpanel.TabIndex = 11;
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.FromArgb(151, 75, 0);
            sidepanel.Controls.Add(button1);
            sidepanel.Controls.Add(delete_lib);
            sidepanel.Controls.Add(Add_lib);
            sidepanel.Controls.Add(logopanel);
            sidepanel.Dock = DockStyle.Left;
            sidepanel.Location = new Point(0, 43);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(210, 469);
            sidepanel.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.log_out;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 264);
            button1.Name = "button1";
            button1.Size = new Size(210, 63);
            button1.TabIndex = 9;
            button1.Text = " Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // delete_lib
            // 
            delete_lib.BackColor = Color.PeachPuff;
            delete_lib.Dock = DockStyle.Top;
            delete_lib.FlatAppearance.BorderColor = Color.White;
            delete_lib.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            delete_lib.Image = (Image)resources.GetObject("delete_lib.Image");
            delete_lib.ImageAlign = ContentAlignment.MiddleLeft;
            delete_lib.Location = new Point(0, 201);
            delete_lib.Name = "delete_lib";
            delete_lib.Size = new Size(210, 63);
            delete_lib.TabIndex = 6;
            delete_lib.Text = "Delete Librarian";
            delete_lib.TextImageRelation = TextImageRelation.ImageBeforeText;
            delete_lib.UseVisualStyleBackColor = false;
            delete_lib.Click += delete_lib_Click;
            // 
            // Add_lib
            // 
            Add_lib.BackColor = Color.PeachPuff;
            Add_lib.Dock = DockStyle.Top;
            Add_lib.FlatAppearance.BorderColor = Color.Black;
            Add_lib.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Add_lib.ForeColor = SystemColors.ControlText;
            Add_lib.Image = (Image)resources.GetObject("Add_lib.Image");
            Add_lib.ImageAlign = ContentAlignment.MiddleLeft;
            Add_lib.Location = new Point(0, 138);
            Add_lib.Name = "Add_lib";
            Add_lib.Size = new Size(210, 63);
            Add_lib.TabIndex = 5;
            Add_lib.Text = "ADD Librarian";
            Add_lib.TextImageRelation = TextImageRelation.ImageBeforeText;
            Add_lib.UseVisualStyleBackColor = false;
            Add_lib.Click += Add_lib_Click;
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
            // 
            // bottompanel
            // 
            bottompanel.BackColor = Color.FromArgb(151, 75, 0);
            bottompanel.Dock = DockStyle.Bottom;
            bottompanel.Location = new Point(0, 512);
            bottompanel.Name = "bottompanel";
            bottompanel.Size = new Size(1265, 43);
            bottompanel.TabIndex = 10;
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.FromArgb(151, 75, 0);
            headerpanel.Dock = DockStyle.Top;
            headerpanel.Location = new Point(0, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(1265, 43);
            headerpanel.TabIndex = 9;
            // 
            // adminform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 555);
            Controls.Add(adminpanel);
            Controls.Add(sidepanel);
            Controls.Add(bottompanel);
            Controls.Add(headerpanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "adminform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminform";
            sidepanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel adminpanel;
        private Panel sidepanel;
        private Button delete_lib;
        private Button Add_lib;
        private Panel logopanel;
        private Panel bottompanel;
        private Panel headerpanel;
        private Button button1;
    }
}