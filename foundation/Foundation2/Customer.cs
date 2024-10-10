public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
            {
                _name = name;
                _address = address;
            }
        public bool LiveInUSA()
            {
                return _address.IsUSA();
            }
        public string ShipLable()
            {
                return $"Customer's name:\n {_name}\n\nAddress:\n {_address.GetAddress()}";
            }
    }