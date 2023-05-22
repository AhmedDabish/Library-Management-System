namespace user_interface
{
    partial class deleteformcs
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
            delete_btn = new Button();
            deletelib_txt = new TextBox();
            label2 = new Label();
            searchpanel.SuspendLayout();
            SuspendLayout();
            // 
            // searchpanel
            // 
            searchpanel.Anchor = AnchorStyles.None;
            searchpanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchpanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            searchpanel.Controls.Add(delete_btn);
            searchpanel.Controls.Add(deletelib_txt);
            searchpanel.Controls.Add(label2);
            searchpanel.ForeColor = SystemColors.Control;
            searchpanel.Location = new Point(193, 104);
            searchpanel.Name = "searchpanel";
            searchpanel.Size = new Size(634, 380);
            searchpanel.TabIndex = 1;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.PeachPuff;
            delete_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            delete_btn.ForeColor = SystemColors.ControlText;
            delete_btn.Location = new Point(246, 245);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(139, 44);
            delete_btn.TabIndex = 4;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // deletelib_txt
            // 
            deletelib_txt.Location = new Point(232, 139);
            deletelib_txt.Name = "deletelib_txt";
            deletelib_txt.Size = new Size(230, 27);
            deletelib_txt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(68, 137);
            label2.Name = "label2";
            label2.Size = new Size(140, 31);
            label2.TabIndex = 2;
            label2.Text = "Librarian ID";
            // 
            // deleteformcs
            // 
            AcceptButton = delete_btn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_04_28_at_06_11_33;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 589);
            Controls.Add(searchpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "deleteformcs";
            StartPosition = FormStartPosition.Manual;
            Text = "deleteformcs";
            searchpanel.ResumeLayout(false);
            searchpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel searchpanel;
        private Button delete_btn;
        private TextBox deletelib_txt;
        private Label label2;
    }
}