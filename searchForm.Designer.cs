namespace user_interface
{
    partial class searchForm
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
            label3 = new Label();
            search_btn = new Button();
            book_idtxt = new TextBox();
            label2 = new Label();
            title_txt = new TextBox();
            label1 = new Label();
            search_result = new Panel();
            dataGridView_result = new DataGridView();
            searchpanel.SuspendLayout();
            search_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_result).BeginInit();
            SuspendLayout();
            // 
            // searchpanel
            // 
            searchpanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchpanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            searchpanel.Controls.Add(label3);
            searchpanel.Controls.Add(search_btn);
            searchpanel.Controls.Add(book_idtxt);
            searchpanel.Controls.Add(label2);
            searchpanel.Controls.Add(title_txt);
            searchpanel.Controls.Add(label1);
            searchpanel.Dock = DockStyle.Top;
            searchpanel.ForeColor = SystemColors.Control;
            searchpanel.Location = new Point(0, 0);
            searchpanel.Name = "searchpanel";
            searchpanel.Size = new Size(1060, 295);
            searchpanel.TabIndex = 0;
            searchpanel.Paint += searchpanel_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(553, 108);
            label3.Name = "label3";
            label3.Size = new Size(37, 31);
            label3.TabIndex = 5;
            label3.Text = "or";
            // 
            // search_btn
            // 
            search_btn.Anchor = AnchorStyles.None;
            search_btn.BackColor = Color.PeachPuff;
            search_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            search_btn.ForeColor = SystemColors.ControlText;
            search_btn.Location = new Point(502, 215);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(139, 44);
            search_btn.TabIndex = 4;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // book_idtxt
            // 
            book_idtxt.Anchor = AnchorStyles.None;
            book_idtxt.Location = new Point(456, 152);
            book_idtxt.Name = "book_idtxt";
            book_idtxt.Size = new Size(230, 27);
            book_idtxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(406, 152);
            label2.Name = "label2";
            label2.Size = new Size(38, 31);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // title_txt
            // 
            title_txt.Anchor = AnchorStyles.None;
            title_txt.Location = new Point(456, 69);
            title_txt.Name = "title_txt";
            title_txt.Size = new Size(230, 27);
            title_txt.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(394, 67);
            label1.Name = "label1";
            label1.Size = new Size(62, 31);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // search_result
            // 
            search_result.BackColor = Color.FromArgb(100, 0, 0, 0);
            search_result.Controls.Add(dataGridView_result);
            search_result.Dock = DockStyle.Fill;
            search_result.Location = new Point(0, 295);
            search_result.Name = "search_result";
            search_result.Size = new Size(1060, 232);
            search_result.TabIndex = 1;
            // 
            // dataGridView_result
            // 
            dataGridView_result.AllowUserToAddRows = false;
            dataGridView_result.AllowUserToDeleteRows = false;
            dataGridView_result.AllowUserToResizeColumns = false;
            dataGridView_result.AllowUserToResizeRows = false;
            dataGridView_result.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_result.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_result.Location = new Point(0, 0);
            dataGridView_result.Name = "dataGridView_result";
            dataGridView_result.RowHeadersWidth = 51;
            dataGridView_result.RowTemplate.Height = 29;
            dataGridView_result.Size = new Size(1060, 232);
            dataGridView_result.TabIndex = 0;
            dataGridView_result.CellContentClick += dataGridView1_CellContentClick;
            // 
            // searchForm
            // 
            AcceptButton = search_btn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_04_28_at_06_11_33;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1060, 527);
            Controls.Add(search_result);
            Controls.Add(searchpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "searchForm";
            Text = "searchForm";
            Load += searchForm_Load;
            searchpanel.ResumeLayout(false);
            searchpanel.PerformLayout();
            search_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_result).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel searchpanel;
        private TextBox book_idtxt;
        private Label label2;
        private TextBox title_txt;
        private Label label1;
        private Button search_btn;
        private Label label3;
        private Panel search_result;
        private DataGridView dataGridView_result;
    }
}