namespace pos
{
    public class Product
    {
        public int Id { get; set; }  

        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public string Barcode { get; set; } 


        public decimal Total => ((UnitPrice * (1-Discount)) * Quantity);
    }
}
