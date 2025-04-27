using System;
using System.Windows.Forms;

namespace pos
{
    public partial class SelectedProducts : UserControl
    {
        public Product _product;
        public event EventHandler QuantityChanged;


        public string ProductName => _product.Name;
        public int QuantityValue => _product.Quantity;
        public decimal TotalPrice => (_product.UnitPrice *(1- _product.Discount)) * _product.Quantity;

        public SelectedProducts(Product product)
        {
            InitializeComponent();
            SetProduct(product);

            AddUnit.Click += (s, e) => IncreaseQuantity();
            MinusUnit.Click += (s, e) => DecreaseQuantity();
        }

        public void SetProduct(Product product)
        {
            _product = product;
            ItemName.Text = product.Name;
            Quantity.Text = product.Quantity.ToString();
            Uprice.Text = product.UnitPrice.ToString("0.00");
            Dis.Text = product.Discount.ToString("0.00");
            Total.Text = TotalPrice.ToString("0.00");
        }

        public void IncreaseQuantity()
        {
            _product.Quantity++;
            UpdateDisplay();
        }

        public void DecreaseQuantity()
        {
            if (_product.Quantity > 1)
            {
                _product.Quantity--;
                UpdateDisplay();
            }
            else
            {
                this.Parent?.Controls.Remove(this);
                QuantityChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void UpdateDisplay()
        {
            Quantity.Text = _product.Quantity.ToString();
            Total.Text = TotalPrice.ToString("0.00");
            QuantityChanged?.Invoke(this, EventArgs.Empty);

        }
    }
}
