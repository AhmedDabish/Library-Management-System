namespace user_interface
{
    partial class showform
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
            dataGridViewbooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewbooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewbooks
            // 
            dataGridViewbooks.AllowUserToAddRows = false;
            dataGridViewbooks.AllowUserToDeleteRows = false;
            dataGridViewbooks.AllowUserToResizeColumns = false;
            dataGridViewbooks.AllowUserToResizeRows = false;
            dataGridViewbooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewbooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewbooks.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridViewbooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewbooks.Dock = DockStyle.Fill;
            dataGridViewbooks.Location = new Point(0, 0);
            dataGridViewbooks.Name = "dataGridViewbooks";
            dataGridViewbooks.ReadOnly = true;
            dataGridViewbooks.RowHeadersWidth = 51;
            dataGridViewbooks.RowTemplate.Height = 29;
            dataGridViewbooks.Size = new Size(996, 517);
            dataGridViewbooks.TabIndex = 0;
            // 
            // showform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2023_04_28_at_06_11_33;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(996, 517);
            Controls.Add(dataGridViewbooks);
            FormBorderStyle = FormBorderStyle.None;
            Name = "showform";
            Text = "showform";
            Load += showform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewbooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewbooks;
    }
}