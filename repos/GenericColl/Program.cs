using System.Collections;
using GenericColl;
// See https://aka.ms/new-console-template for more information
GenericClass<string> anan = new GenericClass<string>();


List<Customer> list = new List<Customer>();
list.Add(new GenericColl.Customer(1, "Anan", "Bayram", "aaaa"));
list.Add(new GenericColl.Customer(3, "baban", "sssaassaas", "bbbbb"));



Repository<Customer> repoCus = new Repository<Customer>();
repoCus.Bring();
List<Customer> customers = new List<Customer>();
 

Repository<Product> product = new Repository<Product>();
List<Product> productsL = new List<Product>();

repoCus.Add(new Customer(1,"a","aaa","22233"));
Repository<Product> productRepository = new Repository<Product>();
List<Product> products = productRepository.Bring();
Product product2 = new Product();
product2.price = 5.12;
product2.name = "Sap";
product2.productID = 5;
productRepository.Add(product2);
