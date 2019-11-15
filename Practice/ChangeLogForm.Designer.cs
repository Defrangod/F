namespace Practice
{
    partial class ChangeLogForm
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
            this.ChangeLogDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeLogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeLogDataGridView
            // 
            this.ChangeLogDataGridView.AllowUserToAddRows = false;
            this.ChangeLogDataGridView.AllowUserToDeleteRows = false;
            this.ChangeLogDataGridView.AllowUserToResizeColumns = false;
            this.ChangeLogDataGridView.AllowUserToResizeRows = false;
            this.ChangeLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChangeLogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Accounting,
            this.Date});
            this.ChangeLogDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ChangeLogDataGridView.Name = "ChangeLogDataGridView";
            this.ChangeLogDataGridView.Size = new System.Drawing.Size(262, 422);
            this.ChangeLogDataGridView.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Accounting
            // 
            this.Accounting.DataPropertyName = "Accounting";
            this.Accounting.HeaderText = "ID учёта";
            this.Accounting.Name = "Accounting";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Дата изменения";
            this.Date.Name = "Date";
            // 
            // ChangeLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 423);
            this.Controls.Add(this.ChangeLogDataGridView);
            this.Name = "ChangeLogForm";
            this.Text = "История измнений";
            this.Load += new System.EventHandler(this.ChangeLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeLogDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ChangeLogDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounting;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}