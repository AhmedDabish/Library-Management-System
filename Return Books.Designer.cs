namespace WindowsFormsApplication1
{
    partial class Return_Books
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
            Label label2;
            panel1 = new Panel();
            return_btn = new Button();
            IDBook_txt = new TextBox();
            iduser_txt = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
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
            label1.Location = new Point(231, 178);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 0;
            label1.Text = "ID User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(226, 264);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 16;
            label2.Text = "ID Book";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(return_btn);
            panel1.Controls.Add(IDBook_txt);
            panel1.Controls.Add(iduser_txt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(120, 41);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 585);
            panel1.TabIndex = 1;
            // 
            // return_btn
            // 
            return_btn.BackColor = Color.PeachPuff;
            return_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            return_btn.ForeColor = SystemColors.ControlText;
            return_btn.Location = new Point(706, 541);
            return_btn.Margin = new Padding(4, 5, 4, 5);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(139, 44);
            return_btn.TabIndex = 15;
            return_btn.Text = "Return";
            return_btn.UseVisualStyleBackColor = false;
            return_btn.Click += return_btn_Click;
            // 
            // IDBook_txt
            // 
            IDBook_txt.Location = new Point(353, 266);
            IDBook_txt.Margin = new Padding(4, 5, 4, 5);
            IDBook_txt.Name = "IDBook_txt";
            IDBook_txt.Size = new Size(207, 27);
            IDBook_txt.TabIndex = 10;
            // 
            // iduser_txt
            // 
            iduser_txt.Location = new Point(353, 185);
            iduser_txt.Margin = new Padding(4, 5, 4, 5);
            iduser_txt.Name = "iduser_txt";
            iduser_txt.Size = new Size(207, 27);
            iduser_txt.TabIndex = 6;
            // 
            // Return_Books
            // 
            AcceptButton = return_btn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = user_interface.Properties.Resources.WhatsApp_Image_2023_04_28_at_06_11_33;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1085, 668);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Return_Books";
            Text = "Return_Books";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.TextBox IDBook_txt;
        private System.Windows.Forms.TextBox iduser_txt;
    }
}