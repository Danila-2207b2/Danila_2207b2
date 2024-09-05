using System;
using System.Collections.Generic;
using System.Diagnostics;

public abstract class Product
{
    public string Name { get; set; }
    public virtual decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public abstract string GetInformation();
}

public class Toy : Product
{
    public int AgeRecommendation { get; set; }

    public Toy(string name, decimal price, int ageRecommendation) : base(name, price)
    {
        AgeRecommendation = ageRecommendation;
    }

    public override string GetInformation()
    {
        return $"Toy: {Name}, Price: {Price:C}, Recommended Age: {AgeRecommendation}+";
    }
}

public class Meat : Product
{
    public double Weight { get; set; } // Вес мяса в килограммах

    public Meat(string name, decimal price, double weight)
        : base(name, price)
    {
        Weight = weight;
    }

    public override string GetInformation()
    {
        return $"Meat: {Name}, Price: {Price:C}, Weight: {Weight} kg";
    }
}

public class Drink : Product
{
    public bool IsAlcoholic { get; set; } // Алкогольный или безалкогольный

    public Drink(string name, decimal price, bool isAlcoholic)
        : base(name, price)
    {
        IsAlcoholic = isAlcoholic;
    }

    public override string GetInformation()
    {
        return $"Drink: {Name}, Price: {Price:C}, Alcoholic: {IsAlcoholic}";
    }
}

public class Book : Product
{
    public string Author { get; set; } 

    public Book(string name, decimal price, string author)
        : base(name, price)
    {
        Author = author;
    }

    public override string GetInformation()
    {
        return $"Book: {Name}, Price: {Price:C}, Author: {Author}";
    }
}

public class Store
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    
}

public class Program
{
    public static void Main()
    {
        Store store = new Store();

        List<Product> products = new List<Product>()
         {
            new Toy("Plastic", 10.00m),
            new Meat("Chicken", 15.00m),
            new Drink(500, 2.50m),
            new Store("Rowling", 20.00m)
         };

        foreach (var product in products)
        {
            Console.WriteLine(product.GetInformation());
        }

    }
}


