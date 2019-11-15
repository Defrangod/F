namespace Practice
{
    partial class EquipmentForm
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
            this.EquipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EquipmentBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EquipmentDataGridView
            // 
            this.EquipmentDataGridView.AllowUserToAddRows = false;
            this.EquipmentDataGridView.AllowUserToDeleteRows = false;
            this.EquipmentDataGridView.AllowUserToResizeColumns = false;
            this.EquipmentDataGridView.AllowUserToResizeRows = false;
            this.EquipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Equipment});
            this.EquipmentDataGridView.Location = new System.Drawing.Point(12, 12);
            this.EquipmentDataGridView.Name = "EquipmentDataGridView";
            this.EquipmentDataGridView.ReadOnly = true;
            this.EquipmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EquipmentDataGridView.Size = new System.Drawing.Size(315, 150);
            this.EquipmentDataGridView.TabIndex = 20;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Equipment
            // 
            this.Equipment.DataPropertyName = "Equipment";
            this.Equipment.HeaderText = "Вид Оборудования";
            this.Equipment.Name = "Equipment";
            this.Equipment.ReadOnly = true;
            this.Equipment.Width = 250;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(167, 198);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(159, 34);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(12, 198);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(149, 34);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EquipmentBox
            // 
            this.EquipmentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EquipmentBox.Location = new System.Drawing.Point(150, 169);
            this.EquipmentBox.MaxLength = 40;
            this.EquipmentBox.Name = "EquipmentBox";
            this.EquipmentBox.Size = new System.Drawing.Size(176, 23);
            this.EquipmentBox.TabIndex = 17;
            this.EquipmentBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EquipmentBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Вид оборудования";
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(336, 240);
            this.Controls.Add(this.EquipmentDataGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EquipmentBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(352, 278);
            this.MinimumSize = new System.Drawing.Size(352, 278);
            this.Name = "EquipmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquipmentForm";
            this.Load += new System.EventHandler(this.EquipmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EquipmentDataGridView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox EquipmentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment;
    }
}