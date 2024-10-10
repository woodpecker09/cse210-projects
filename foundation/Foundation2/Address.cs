public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _statepro;
        private string _country;    

        public Address(string streetAddress,string city,string statepro,string country)
            {
                _streetAddress = streetAddress;
                _city = city;
                _statepro = statepro;
                _country = country;
            }
        public bool IsUSA()
            {
                if(_country == "USA")
                    {
                        return true;
                    }
                else
                    {
                        return false;
                    }
            }
        public string GetAddress ()
            {
                return $"{_streetAddress} \n {_city} \n {_statepro}, {_country}";
            }
    }