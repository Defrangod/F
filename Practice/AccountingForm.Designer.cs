namespace Practice
{
    partial class AccountingForm
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
            this.AccountingDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.EzComboBox = new System.Windows.Forms.ComboBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.DivisionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PartModelBox = new System.Windows.Forms.TextBox();
            this.KolvoBox = new System.Windows.Forms.TextBox();
            this.InvBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNmodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccountingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountingDataGridView
            // 
            this.AccountingDataGridView.AllowUserToAddRows = false;
            this.AccountingDataGridView.AllowUserToDeleteRows = false;
            this.AccountingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Category,
            this.equipment,
            this.zip,
            this.PartNmodel,
            this.kolvo,
            this.InvNumber,
            this.Namez,
            this.Division,
            this.Status,
            this.Comment,
            this.DatePost,
            this.DateEdit,
            this.FIO});
            this.AccountingDataGridView.Location = new System.Drawing.Point(0, 0);
            this.AccountingDataGridView.Name = "AccountingDataGridView";
            this.AccountingDataGridView.ReadOnly = true;
            this.AccountingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountingDataGridView.Size = new System.Drawing.Size(1304, 150);
            this.AccountingDataGridView.TabIndex = 0;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(140, 156);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(177, 21);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // EzComboBox
            // 
            this.EzComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EzComboBox.FormattingEnabled = true;
            this.EzComboBox.Location = new System.Drawing.Point(139, 210);
            this.EzComboBox.Name = "EzComboBox";
            this.EzComboBox.Size = new System.Drawing.Size(177, 21);
            this.EzComboBox.TabIndex = 2;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(437, 264);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(177, 21);
            this.StatusComboBox.TabIndex = 4;
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.Location = new System.Drawing.Point(437, 156);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(177, 21);
            this.SupplierComboBox.TabIndex = 5;
            // 
            // DivisionComboBox
            // 
            this.DivisionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivisionComboBox.FormattingEnabled = true;
            this.DivisionComboBox.Location = new System.Drawing.Point(437, 210);
            this.DivisionComboBox.Name = "DivisionComboBox";
            this.DivisionComboBox.Size = new System.Drawing.Size(177, 21);
            this.DivisionComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Оборудование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ПартНомер / Модель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Инвентарный номер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Поставщик";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Подразделение";
            // 
            // PartModelBox
            // 
            this.PartModelBox.Location = new System.Drawing.Point(140, 264);
            this.PartModelBox.Name = "PartModelBox";
            this.PartModelBox.Size = new System.Drawing.Size(176, 20);
            this.PartModelBox.TabIndex = 15;
            this.PartModelBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartModelBox_KeyPress);
            // 
            // KolvoBox
            // 
            this.KolvoBox.Location = new System.Drawing.Point(140, 322);
            this.KolvoBox.Name = "KolvoBox";
            this.KolvoBox.Size = new System.Drawing.Size(176, 20);
            this.KolvoBox.TabIndex = 16;
            this.KolvoBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KolvoBox_KeyPress);
            // 
            // InvBox
            // 
            this.InvBox.Location = new System.Drawing.Point(139, 365);
            this.InvBox.Name = "InvBox";
            this.InvBox.Size = new System.Drawing.Size(176, 20);
            this.InvBox.TabIndex = 17;
            this.InvBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartModelBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Статус";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Коментарий";
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(437, 318);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(177, 67);
            this.CommentBox.TabIndex = 20;
            this.CommentBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CommentBox_KeyPress);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(651, 264);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(104, 29);
            this.DeleteButton.TabIndex = 25;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(651, 210);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(104, 29);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(651, 156);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(104, 29);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(651, 210);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(104, 29);
            this.EditButton.TabIndex = 22;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(651, 156);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 29);
            this.AddButton.TabIndex = 21;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // equipment
            // 
            this.equipment.DataPropertyName = "equipment";
            this.equipment.HeaderText = "Оборудование";
            this.equipment.Name = "equipment";
            this.equipment.ReadOnly = true;
            // 
            // zip
            // 
            this.zip.DataPropertyName = "zip";
            this.zip.HeaderText = "ЗИП";
            this.zip.Name = "zip";
            this.zip.ReadOnly = true;
            // 
            // PartNmodel
            // 
            this.PartNmodel.DataPropertyName = "PartNmodel";
            this.PartNmodel.HeaderText = "Парт номер / модель";
            this.PartNmodel.Name = "PartNmodel";
            this.PartNmodel.ReadOnly = true;
            // 
            // kolvo
            // 
            this.kolvo.DataPropertyName = "kolvo";
            this.kolvo.HeaderText = "Количество";
            this.kolvo.Name = "kolvo";
            this.kolvo.ReadOnly = true;
            // 
            // InvNumber
            // 
            this.InvNumber.DataPropertyName = "InvNumber";
            this.InvNumber.HeaderText = "Инвентарный номер";
            this.InvNumber.Name = "InvNumber";
            this.InvNumber.ReadOnly = true;
            // 
            // Namez
            // 
            this.Namez.DataPropertyName = "Name";
            this.Namez.HeaderText = "Поставщик";
            this.Namez.Name = "Namez";
            this.Namez.ReadOnly = true;
            // 
            // Division
            // 
            this.Division.DataPropertyName = "division";
            this.Division.HeaderText = "Подразделение";
            this.Division.Name = "Division";
            this.Division.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "comment";
            this.Comment.HeaderText = "Коментарий";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // DatePost
            // 
            this.DatePost.DataPropertyName = "DatePost";
            this.DatePost.HeaderText = "Дата создания";
            this.DatePost.Name = "DatePost";
            this.DatePost.ReadOnly = true;
            // 
            // DateEdit
            // 
            this.DateEdit.DataPropertyName = "DateEdit";
            this.DateEdit.HeaderText = "Дата изменения";
            this.DateEdit.Name = "DateEdit";
            this.DateEdit.ReadOnly = true;
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "ФИО сотрудника";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(651, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 46);
            this.button1.TabIndex = 26;
            this.button1.Text = "История изменений";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1304, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InvBox);
            this.Controls.Add(this.KolvoBox);
            this.Controls.Add(this.PartModelBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DivisionComboBox);
            this.Controls.Add(this.SupplierComboBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.EzComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.AccountingDataGridView);
            this.Name = "AccountingForm";
            this.Text = "Учёт запасных частей и оборудования ИТ-отдела";
            this.Load += new System.EventHandler(this.AccountingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountingDataGridView;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox EzComboBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.ComboBox DivisionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PartModelBox;
        private System.Windows.Forms.TextBox KolvoBox;
        private System.Windows.Forms.TextBox InvBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNmodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namez;
        private System.Windows.Forms.DataGridViewTextBoxColumn Division;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePost;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.Button button1;
    }
}