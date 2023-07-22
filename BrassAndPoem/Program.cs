
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Trumpet",
        Price = 250.00M,
        ProductTypeId = 1
    },

    new Product()
    {
        Name = "Tuba",
        Price = 300.00M,
        ProductTypeId = 1
    },

    new Product()
    {
        Name = "Trombone",
        Price = 125.00M,
        ProductTypeId = 1
    },

    new Product()
    {
        Name = "Black Girl, Call Home",
        Price = 25.00M,
        ProductTypeId = 2
    },

    new Product()
    {
        Name = "The Hill We Climb",
        Price = 10.00M,
        ProductTypeId = 2
    },
};
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypeId = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Brass Instrument",
        Id = 1
    },

    new ProductType()
    {
        Title = "Poetry Book",
        Id = 2
    },
};
//put your greeting here
string greeting = "Welcome to Brass and Poetry.";

Console.WriteLine(greeting);

void DisplayMenu()

{
    string menu = null;
    while (menu != "0")
    {
        Console.WriteLine(@"Choose an option:
                            0. Exit
                            1. Display all products
                            2. Delete a product
                            3. Add a product
                            4. Update product properties");
                            
        menu = Console.ReadLine();
        if (menu == "0")
        {
            Console.WriteLine("Peace Out");
        }
        else if (menu == "1")
        {
            DisplayAllProducts(products, productTypeId);
        }
        else if (menu == "2")
        {
            Console.WriteLine("Which item would you like to delete?: ");
            Console.ReadLine();
            DeleteProduct(products, productTypeId);
        }
        else if (menu == "3")
        {
            AddProduct(products, productTypeId);
        }
        //else if (menu == "4")
        //{

        //}
    }
}

    DisplayMenu();
void DisplayAllProducts(List<Product> products, List<ProductType> productTypeId)
{
    //implement your loop here
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}.{products[i].Name} sells for ${products[i].Price}");
    }


    for (int i = 0; i < productTypeId.Count; i++)
    {
        Console.WriteLine($"{i + 1}.{productTypeId[i].Title}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypeId)
{
    DisplayAllProducts(products, productTypeId);
    for (int i = 0;i < products.Count;i++)
    {
        Product product = products[i];
    }
    int response = int.Parse(Console.ReadLine().Trim()); 
    if (response >= 1 && response <= products.Count)
    {
        products.RemoveAt(response - 1);
        Console.WriteLine("Product removed successfully");
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypeId)
{
    Console.WriteLine("Enter the product name: ");
    string Name = Console.ReadLine();
    Console.WriteLine("Enter the product price: ");
    decimal Price = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Choose a Product Type: 1. Brass Instrument, 2. Poetry Book");
    int Id = int.Parse(Console.ReadLine());

    Product newProduct = new Product
    { 
        Name = Name,
        Price = Price,
        ProductTypeId = Id
    };

    products.Add(newProduct);
    DisplayAllProducts(products, productTypeId);
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }