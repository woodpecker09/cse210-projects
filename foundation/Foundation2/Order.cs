public class Order
    {
        private List<Product> _products;
         
        private Customer _customers;
        
        public Order(Customer customer)
            {
                _products = new List<Product>();
                _customers = customer;
            }
        public void AddProducts(Product product)
            {
                _products.Add(product);
            }
        public double CalculateOrder()
            {
                double totalPrice = 0;
                foreach(Product product in _products)
                    {
                        totalPrice += product.TotalPrice();
                    }
                if (_customers.LiveInUSA())
                    {
                        totalPrice += 5;
                    }
                else
                    {
                        totalPrice += 35;
                    }
                return totalPrice;
            }
        public string AddressLable()
            {
                return _customers.ShipLable();
            }
        public string ShippLable()
            {
                string totalString = "";
                foreach(Product product in _products)
                    {
                        totalString += product.PackingLable();
                    }
                return totalString;
            }
    }