namespace user_interface
{
    partial class search_result
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
            dataGridViewr_result = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewr_result).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewr_result
            // 
            dataGridViewr_result.AllowUserToAddRows = false;
            dataGridViewr_result.AllowUserToDeleteRows = false;
            dataGridViewr_result.AllowUserToOrderColumns = true;
            dataGridViewr_result.AllowUserToResizeColumns = false;
            dataGridViewr_result.AllowUserToResizeRows = false;
            dataGridViewr_result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewr_result.Dock = DockStyle.Fill;
            dataGridViewr_result.Location = new Point(0, 0);
            dataGridViewr_result.Name = "dataGridViewr_result";
            dataGridViewr_result.ReadOnly = true;
            dataGridViewr_result.RowHeadersWidth = 51;
            dataGridViewr_result.RowTemplate.Height = 29;
            dataGridViewr_result.Size = new Size(800, 450);
            dataGridViewr_result.TabIndex = 0;
            dataGridViewr_result.CellContentClick += dataGridView1_CellContentClick;
            // 
            // search_result
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewr_result);
            FormBorderStyle = FormBorderStyle.None;
            Name = "search_result";
            Text = "search_result";
            ((System.ComponentModel.ISupportInitialize)dataGridViewr_result).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridViewr_result;
    }
}