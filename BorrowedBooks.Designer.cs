namespace user_interface
{
    partial class BorrowedBooks
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
            dataGridViewBorrow = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrow).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBorrow
            // 
            dataGridViewBorrow.AllowUserToAddRows = false;
            dataGridViewBorrow.AllowUserToDeleteRows = false;
            dataGridViewBorrow.AllowUserToResizeColumns = false;
            dataGridViewBorrow.AllowUserToResizeRows = false;
            dataGridViewBorrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBorrow.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBorrow.Dock = DockStyle.Fill;
            dataGridViewBorrow.GridColor = SystemColors.ButtonHighlight;
            dataGridViewBorrow.Location = new Point(0, 0);
            dataGridViewBorrow.Name = "dataGridViewBorrow";
            dataGridViewBorrow.ReadOnly = true;
            dataGridViewBorrow.RowHeadersWidth = 51;
            dataGridViewBorrow.RowTemplate.Height = 29;
            dataGridViewBorrow.Size = new Size(800, 450);
            dataGridViewBorrow.TabIndex = 0;
            // 
            // BorrowedBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewBorrow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrowedBooks";
            Text = "BorrowedBooks";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBorrow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewBorrow;
    }
}