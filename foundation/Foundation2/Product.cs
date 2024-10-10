public class Product
    {
        private string _name;
        private string _id;
        private double _price;
        private int _quantity;

        public Product(string name, string id, double price, int quantity)
            {
                        _name = name;
                        _id = id;
                        _price =  price;
                        _quantity = quantity;
            }
        public double TotalPrice()
            {
                double total;
                total = _quantity * _price;
                return total;
            }
        public string PackingLable()
            {
                return $"Product name:\n {_name} \nID:\n {_id}\n";
            }
    }