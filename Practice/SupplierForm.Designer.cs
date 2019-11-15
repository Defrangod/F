namespace Practice
{
    partial class SupplierForm
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
            this.SupplierDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_sz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Site_sz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.InnBox = new System.Windows.Forms.TextBox();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.PastNameBox = new System.Windows.Forms.TextBox();
            this.SiteBox = new System.Windows.Forms.TextBox();
            this.ContactBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.NameSButton = new System.Windows.Forms.Button();
            this.InnSButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SupplierDataGridView
            // 
            this.SupplierDataGridView.AllowUserToAddRows = false;
            this.SupplierDataGridView.AllowUserToDeleteRows = false;
            this.SupplierDataGridView.AllowUserToResizeColumns = false;
            this.SupplierDataGridView.AllowUserToResizeRows = false;
            this.SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name_sz,
            this.INN,
            this.Adress,
            this.PastName,
            this.Site_sz,
            this.ContractPerson});
            this.SupplierDataGridView.Location = new System.Drawing.Point(0, 0);
            this.SupplierDataGridView.Name = "SupplierDataGridView";
            this.SupplierDataGridView.ReadOnly = true;
            this.SupplierDataGridView.Size = new System.Drawing.Size(857, 195);
            this.SupplierDataGridView.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Name_sz
            // 
            this.Name_sz.DataPropertyName = "Name";
            this.Name_sz.HeaderText = "Наименование";
            this.Name_sz.Name = "Name_sz";
            this.Name_sz.ReadOnly = true;
            this.Name_sz.Width = 160;
            // 
            // INN
            // 
            this.INN.DataPropertyName = "INN";
            this.INN.HeaderText = "ИНН";
            this.INN.Name = "INN";
            this.INN.ReadOnly = true;
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Adress";
            this.Adress.HeaderText = "Адрес";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 175;
            // 
            // PastName
            // 
            this.PastName.DataPropertyName = "PastName";
            this.PastName.HeaderText = "Прошлое наименование";
            this.PastName.Name = "PastName";
            this.PastName.ReadOnly = true;
            this.PastName.Width = 160;
            // 
            // Site_sz
            // 
            this.Site_sz.DataPropertyName = "Site";
            this.Site_sz.HeaderText = "Сайт";
            this.Site_sz.Name = "Site_sz";
            this.Site_sz.ReadOnly = true;
            // 
            // ContractPerson
            // 
            this.ContractPerson.DataPropertyName = "ContractPerson";
            this.ContractPerson.HeaderText = "Контактное лицо";
            this.ContractPerson.Name = "ContractPerson";
            this.ContractPerson.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ИНН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Прошлое наименование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Сайт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Контактное лицо";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(13, 238);
            this.NameBox.MaxLength = 40;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(185, 20);
            this.NameBox.TabIndex = 7;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // InnBox
            // 
            this.InnBox.Location = new System.Drawing.Point(242, 238);
            this.InnBox.MaxLength = 12;
            this.InnBox.Name = "InnBox";
            this.InnBox.Size = new System.Drawing.Size(161, 20);
            this.InnBox.TabIndex = 8;
            this.InnBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InnBox_KeyPress);
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(15, 383);
            this.AdressBox.MaxLength = 70;
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(183, 20);
            this.AdressBox.TabIndex = 9;
            this.AdressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // PastNameBox
            // 
            this.PastNameBox.Location = new System.Drawing.Point(15, 307);
            this.PastNameBox.MaxLength = 40;
            this.PastNameBox.Name = "PastNameBox";
            this.PastNameBox.Size = new System.Drawing.Size(183, 20);
            this.PastNameBox.TabIndex = 10;
            this.PastNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // SiteBox
            // 
            this.SiteBox.Location = new System.Drawing.Point(242, 307);
            this.SiteBox.MaxLength = 40;
            this.SiteBox.Name = "SiteBox";
            this.SiteBox.Size = new System.Drawing.Size(161, 20);
            this.SiteBox.TabIndex = 11;
            this.SiteBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SiteBox_KeyPress);
            // 
            // ContactBox
            // 
            this.ContactBox.Location = new System.Drawing.Point(242, 383);
            this.ContactBox.MaxLength = 70;
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(161, 20);
            this.ContactBox.TabIndex = 12;
            this.ContactBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(731, 210);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(86, 29);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(604, 210);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(86, 29);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(473, 210);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(86, 29);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(604, 210);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(86, 29);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(473, 210);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(86, 29);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NameSButton
            // 
            this.NameSButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameSButton.Location = new System.Drawing.Point(604, 352);
            this.NameSButton.Name = "NameSButton";
            this.NameSButton.Size = new System.Drawing.Size(125, 51);
            this.NameSButton.TabIndex = 18;
            this.NameSButton.Text = "Поиск по Наименованию";
            this.NameSButton.UseVisualStyleBackColor = true;
            this.NameSButton.Click += new System.EventHandler(this.NameSButton_Click);
            // 
            // InnSButton
            // 
            this.InnSButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InnSButton.Location = new System.Drawing.Point(458, 361);
            this.InnSButton.Name = "InnSButton";
            this.InnSButton.Size = new System.Drawing.Size(86, 42);
            this.InnSButton.TabIndex = 19;
            this.InnSButton.Text = "Поиск по ИНН";
            this.InnSButton.UseVisualStyleBackColor = true;
            this.InnSButton.Click += new System.EventHandler(this.InnSButton_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.InnSButton);
            this.Controls.Add(this.NameSButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.SiteBox);
            this.Controls.Add(this.PastNameBox);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.InnBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupplierDataGridView);
            this.Name = "SupplierForm";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SupplierDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox InnBox;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.TextBox PastNameBox;
        private System.Windows.Forms.TextBox SiteBox;
        private System.Windows.Forms.TextBox ContactBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_sz;
        private System.Windows.Forms.DataGridViewTextBoxColumn INN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Site_sz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractPerson;
        private System.Windows.Forms.Button NameSButton;
        private System.Windows.Forms.Button InnSButton;
    }
}