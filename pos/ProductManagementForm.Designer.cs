namespace pos
{
    partial class ProductManagementForm
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtDiscount = new TextBox();
            txtCategory = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtBarcode = new TextBox();
            searchBtn = new Button();
            searchBox = new TextBox();
            cmbCategory = new ComboBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(44, 135);
            listView1.Name = "listView1";
            listView1.Size = new Size(395, 610);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Tag = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Tag = "Name";
            // 
            // columnHeader3
            // 
            columnHeader3.Tag = "Price";
            // 
            // columnHeader4
            // 
            columnHeader4.Tag = "Discount";
            // 
            // columnHeader5
            // 
            columnHeader5.Tag = "Category";
            // 
            // columnHeader6
            // 
            columnHeader6.Tag = "Barcode";
            // 
            // txtName
            // 
            txtName.Location = new Point(526, 84);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(284, 39);
            txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(526, 167);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(284, 39);
            txtPrice.TabIndex = 2;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(526, 242);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.PlaceholderText = "Discount";
            txtDiscount.Size = new Size(284, 39);
            txtDiscount.TabIndex = 3;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(526, 317);
            txtCategory.Name = "txtCategory";
            txtCategory.PlaceholderText = "Category";
            txtCategory.Size = new Size(284, 39);
            txtCategory.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(492, 479);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 129);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(639, 479);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(141, 129);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(786, 479);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 129);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(526, 385);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.PlaceholderText = "Barcode";
            txtBarcode.Size = new Size(284, 39);
            txtBarcode.TabIndex = 8;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(345, 48);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 75);
            searchBtn.TabIndex = 9;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(112, 70);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(200, 39);
            searchBox.TabIndex = 10;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(492, 655);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(237, 40);
            cmbCategory.TabIndex = 11;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 906);
            Controls.Add(cmbCategory);
            Controls.Add(searchBox);
            Controls.Add(searchBtn);
            Controls.Add(txtBarcode);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtCategory);
            Controls.Add(txtDiscount);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(listView1);
            Name = "ProductManagementForm";
            Text = "AddProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtDiscount;
        private TextBox txtCategory;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TextBox txtBarcode;
        private ColumnHeader columnHeader6;
        private Button searchBtn;
        private TextBox searchBox;
        private ComboBox cmbCategory;
    }
}