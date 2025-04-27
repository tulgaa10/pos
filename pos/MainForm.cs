using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace pos
{
    public partial class MainForm : Form
    {
        private string _username;
        private string _role;

        public MainForm(string username, string role)
        {
            InitializeComponent();
            _username = username;
            _role = role;
            LoadProductButtons();
            LoadCategoryButtons();
            if (_role == "Manager")
            {
                Button manageBtn = new Button();
                manageBtn.Text = "Manage Products";
                manageBtn.Width = 150;
                manageBtn.Height = 40;
                manageBtn.Click += ManageBtn_Click;
                this.Controls.Add(manageBtn);
                manageBtn.Location = new Point(20, 20);
                ManagerPanel.Controls.Add(manageBtn);

            }
            UName.Text = $"Welcome, {_username} - Role: {_role}";

        }
        private void ManageBtn_Click(object sender, EventArgs e)
        {
            var form = new ProductManagementForm();
            form.FormClosed += (s, args) => LoadProductButtons(); 
            form.ShowDialog();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var product = btn.Tag as Product;

            AddProductToCart(product);
        }

        private void AddProductToCart(Product product)
        {
            foreach (SelectedProducts item in flowLayoutPanel1.Controls)
            {
                if (item.ProductName == product.Name)
                {
                    item.IncreaseQuantity();
                    UpdateTotalPrice();
                    return;
                }
            }

            var productControl = new SelectedProducts(product);
            productControl.QuantityChanged += (s, e) => UpdateTotalPrice();
            flowLayoutPanel1.Controls.Add(productControl);
            UpdateTotalPrice();
        }

        private void LoadProductButtons(string category = null)
        {
            flowLayoutPanel2.Controls.Clear();

            using (var conn = new SQLiteConnection("Data Source=pos.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT Id, Name, Price, Discount, CategoryId FROM Products";
                if (!string.IsNullOrEmpty(category))
                {
                    query = @"
                SELECT p.Id, p.Name, p.Price, p.Discount, p.CategoryId
                FROM Products p
                JOIN Categories c ON p.CategoryId = c.Id
                WHERE c.Name = @CategoryName";
                }

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(category))
                        cmd.Parameters.AddWithValue("@CategoryName", category);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            decimal price = (decimal)reader.GetDouble(2);
                            decimal discount = (decimal)reader.GetDouble(3);
                            int categoryId = reader.GetInt32(4);

                            var product = new Product
                            {
                                Id = id,
                                Name = name,
                                UnitPrice = price,
                                Discount = discount,
                                Quantity = 1
                            };

                            Button btn = new Button
                            {
                                Text = name,
                                Width = 60,
                                Height = 60,
                                Margin = new Padding(5),
                                Tag = product
                            };
                            btn.Click += ProductButton_Click;
                            flowLayoutPanel2.Controls.Add(btn);
                        }
                    }
                }
            }
        }


        private void LoadCategoryButtons()
        {
            categoryPanel.Controls.Clear();
            var allButton = new Button
            {
                Text = "All",
                AutoSize = true
            };
            allButton.Click += (s, e) => LoadProductButtons();
            categoryPanel.Controls.Add(allButton);

            using (var conn = new SQLiteConnection("Data Source=pos.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT DISTINCT CategoryId FROM Products";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int categoryId = reader.GetInt32(0); 
                        Button btn = new Button
                        {
                            Text = $"Category {categoryId}", 
                            AutoSize = true
                        };
                        btn.Click += (s, e) => LoadProductButtons(categoryId.ToString());
                        categoryPanel.Controls.Add(btn);
                    }
                }
            }
        }


        private void Pay_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            string receipt = "Receipt\n----------------------\n";
            decimal total = 0;

            foreach (SelectedProducts item in flowLayoutPanel1.Controls)
            {
                receipt += $"{item.ProductName} x {item.QuantityValue} = ${item.TotalPrice:F2}\n";
                total += item.TotalPrice;
            }

            receipt += "----------------------\n";
            receipt += $"Total: ${total:F2}";

            MessageBox.Show(receipt, "Payment Complete");

            flowLayoutPanel1.Controls.Clear();
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal total = 0;

            foreach (SelectedProducts item in flowLayoutPanel1.Controls)
            {
                total += item.TotalPrice;
            }

            TotalPrice.Text = $"TotalPrice: ${total:F2}";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string input = searchBox.Text.Trim();

            if (int.TryParse(input, out int searchValue))
            {
                LoadProductButtonSearch(searchValue.ToString());
            }
        }

        private void LoadProductButtonSearch(string searchTerm = null)
        {
            flowLayoutPanel2.Controls.Clear();

            using (var conn = new SQLiteConnection("Data Source=pos.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT * FROM Products";

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " WHERE Id = @search OR Barcode = @search";
                }

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        cmd.Parameters.AddWithValue("@search", searchTerm);
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            decimal price = (decimal)reader.GetDouble(2);
                            decimal discount = (decimal)reader.GetDouble(3);

                            var product = new Product
                            {
                                Id = id,
                                Name = name,
                                UnitPrice = price,
                                Discount = discount,
                                Quantity = 1
                            };

                            Button btn = new Button();
                            btn.Text = name;
                            btn.Tag = product;
                            btn.Width = 60;
                            btn.Height = 60;
                            btn.Margin = new Padding(5);
                            btn.Click += ProductButton_Click;

                            flowLayoutPanel2.Controls.Add(btn);
                        }
                    }
                }
            }
        }


    }
}
