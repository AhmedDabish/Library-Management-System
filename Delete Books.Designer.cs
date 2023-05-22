namespace WindowsFormsApplication1
{
    partial class Delete_Books
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
            Label label4;
            Label label1;
            panel1 = new Panel();
            delte_txt = new Button();
            IDbk_txt = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(163, 128);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 32);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Controls.Add(delte_txt);
            panel1.Controls.Add(IDbk_txt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(175, 76);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 384);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // delte_txt
            // 
            delte_txt.BackColor = Color.PeachPuff;
            delte_txt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            delte_txt.ForeColor = SystemColors.ControlText;
            delte_txt.Location = new Point(253, 241);
            delte_txt.Margin = new Padding(4, 5, 4, 5);
            delte_txt.Name = "delte_txt";
            delte_txt.Size = new Size(139, 44);
            delte_txt.TabIndex = 15;
            delte_txt.Text = "Delete";
            delte_txt.UseVisualStyleBackColor = false;
            delte_txt.Click += delte_txt_Click;
            // 
            // IDbk_txt
            // 
            IDbk_txt.Location = new Point(219, 128);
            IDbk_txt.Margin = new Padding(4, 5, 4, 5);
            IDbk_txt.Name = "IDbk_txt";
            IDbk_txt.Size = new Size(227, 27);
            IDbk_txt.TabIndex = 6;
            // 
            // Delete_Books
            // 
            AcceptButton = delte_txt;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = user_interface.Properties.Resources.WhatsApp_Image_2023_04_28_at_06_11_33;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1060, 527);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Delete_Books";
            Text = "Delete_Books";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delte_txt;
        private System.Windows.Forms.TextBox IDbk_txt;
    }
}