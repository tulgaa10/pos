using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace pos
{
    public partial class ProductManagementForm : Form
    {
        public ProductManagementForm()
        {
            InitializeComponent();
            LoadProductsEdit();
            LoadCategories();
        }

        private void LoadProductsEdit()
        {
            listView1.Items.Clear();
            using (var conn = new SQLiteConnection("Data Source=pos.db;Version=3;"))
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"
            SELECT p.Id, p.Name, p.Price, p.Discount, c.NameC AS CategoryName, p.Barcode 
            FROM Products p
            JOIN Categories c ON p.CategoryId = c.Id", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var item = new ListViewItem(reader["Id"].ToString());
                    item.SubItems.Add(reader["Name"].ToString());
                    item.SubItems.Add(reader["Price"].ToString());
                    item.SubItems.Add(reader["Discount"].ToString());
                    item.SubItems.Add(reader["CategoryName"].ToString());  
                    item.SubItems.Add(reader["Barcode"].ToString());

                    listView1.Items.Add(item);
                }
            }
        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection("Data Source=pos.db;Version=3;"))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Products (Name, Price, Discount, CategoryId,Barcode) VALUES (@name, @price, @discount, @categoryId,@barcode)", conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@discount", decimal.Parse(txtDiscount.Text));
                cmd.Parameters.AddWithValue("@categoryId", txtCategory.Text);
                cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text);

                cmd.ExecuteNonQuery();
            }
            LoadProductsEdit();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var id = listView1.SelectedItems[0].Text;

            using (var conn = new SQLiteConnection("Data Source=pos.db;Version=3;"))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Products SET Name=@name, Price=@price, Discount=@discount, CategoryId=@categoryId,Barcode=@barcode WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@discount", decimal.Parse(txtDiscount.Text));
                cmd.Parameters.AddWithValue("@categoryId", txtCategory.Text);
                cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text);

                cmd.ExecuteNonQuery();
            }
            LoadProductsEdit();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            var id = listView1.SelectedItems[0].Text;

            using (var conn = new SQLiteConnection("Data Source=pos.db;Version=3;"))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Products WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            LoadProductsEdit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var item = listView1.SelectedItems[0];
            txtName.Text = item.SubItems[1].Text;
            txtPrice.Text = item.SubItems[2].Text;
            txtDiscount.Text = item.SubItems[3].Text;
            txtCategory.Text = item.SubItems[4].Text;
            txtBarcode.Text = item.SubItems[5].Text;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string input = searchBox.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                LoadProducts(input);
            }
            else
            {
                LoadProducts();
            }
        }
        private void LoadProducts(string input)
        {
            listView1.Items.Clear();
            using (var conn = new SQLiteConnection("Data Source=pos.db;Version=3;"))
            {
                conn.Open();
                string query = @"
            SELECT p.Id, p.Name, p.Price, p.Discount, p.Barcode, c.NameC AS CategoryName
            FROM Products p
            JOIN Categories c ON p.CategoryId = c.Id
            WHERE p.Id = @input OR p.Barcode = @input";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@input", input);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ListViewItem(reader["Id"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());
                            item.SubItems.Add(reader["Price"].ToString());
                            item.SubItems.Add(reader["Discount"].ToString());
                            item.SubItems.Add(reader["CategoryName"].ToString()); 
                            item.SubItems.Add(reader["Barcode"].ToString());

                            listView1.Items.Add(item);
                        }
                    }
                }
            }
        }


        private void LoadProducts()
        {
            LoadProductsEdit();
        }
        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            using (var conn = new SQLiteConnection("Data Source=pos.db;Version=3;"))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT Id, NameC FROM Categories", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbCategory.Items.Add(new { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                }
            }
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }



    }
}
