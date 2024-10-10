using System;

class Program
{
    static void Main(string[] args)
    {
        Product firstProduct = new Product("Shoes","E03LPS",10.53,2);
        Product secondProduct = new Product("T-Shirt","S01LST",5.25,3);
        Address address = new Address("1765 Roud low","Spanish fork","UT","USA");
        Customer customer = new Customer("Pedro Fuentes", address);
        Order order = new Order(customer);
        order.AddProducts(firstProduct);
        order.AddProducts(secondProduct);
        Console.Clear();
        Console.WriteLine($"Shipping Lable:\n{order.AddressLable()} \n\n\nPacking Lable:\n{order.ShippLable()} \nTotal price: ${order.CalculateOrder():.00}");
        
    }
}