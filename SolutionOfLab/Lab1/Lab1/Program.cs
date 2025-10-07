using Lab1;
using static Lab1.ListGenerator;

#region LINQ - Restriction Operators 
//Use ListGenerators.cs & Customers.xml
//1.Find all products that are out of stock.

/*
var result = ProductList.Where(p => p.UnitsInStock == 0); //method syntax
//var result = Enumerable.Where(ProductList , p=>p.UnitsInStock==0); //static syntax
//var result = from p in ProductList where p.UnitsInStock == 0 select p; //query syntax

foreach(var item in result)
{
    Console.WriteLine(item);
}
*/


// 2. Find all products that are in stock and cost more than 3.00 per unit.

/*
var result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

foreach (var item in result)
{
    Console.WriteLine(item);
}
*/


//3. Returns digits whose name is shorter than their value. 
/*
string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
var result = Arr
    .Select((name,value)=> new {Name = name, Value = value})
    .Where(x=>x.Name.Length < x.Value);

foreach (var item in result)
{
    Console.WriteLine($"{item.Name} ({item.Value})");
}
*/
#endregion
#region LINQ - Element Operators 

//Use ListGenerators.cs & Customers.xml
//1.Get first Product out of Stock  
/*
var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
if(result != null)
{
    Console.WriteLine($"First Product out of stock: {result}"); 
}
else
{
    Console.WriteLine($"No Products are out of stock");
}
*/

//2. Return the first product whose Price > 1000, unless there is no match, in which case null 
//is returned. 

/*
var result = ProductList
    .FirstOrDefault(p => p.UnitPrice > 1000);

if (result != null)
    Console.WriteLine($"First product with price > 1000: {result}");
else
    Console.WriteLine("No product found with price > 1000.");
*/

//3. Retrieve the second number greater than 5  
/*
int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var result = Arr
    .Where(n => n > 5)   // filter numbers > 5 → {9, 8, 6, 7}
    .Skip(1)             // skip the first one (9)
    .FirstOrDefault();   // take the next one (8)

Console.WriteLine($"Second number greater than 5: {result}");
*/
#endregion
#region LINQ - Set Operators
//Use ListGenerators.cs & Customers.xml
//1.Find the unique Category names from Product List 
/*
var uniqueCategories = ProductList
    .Select(p => p.Category) 
    .Distinct()              
    .OrderBy(c => c);        //optional step

Console.WriteLine("Unique Product Categories:");
foreach (var category in uniqueCategories)
{
    Console.WriteLine($"- {category}");
}
*/

//2. Produce a Sequence containing the unique first letter from both product and customer names.

/*
var customerFirstLetters = CustomerList
    .Select(c => c.CompanyName.FirstOrDefault());

var productFirstLetters = ProductList
    .Select(p => p.ProductName.FirstOrDefault());

var uniqueFirstLetters = customerFirstLetters.Union(productFirstLetters)
    .OrderBy(l => l); // Optional: Order for readability

Console.WriteLine("2. Unique First Letters (Customer OR Product) ==> (Union):");
Console.WriteLine(string.Join(", ", uniqueFirstLetters));

*/

//3. Create one sequence that contains the common first letter from both product and customer names. 

/*
var customerFirstLetters = CustomerList.Select(c=>c.CompanyName.FirstOrDefault());
var productFirstLetters = ProductList.Select(p=>p.ProductName.FirstOrDefault())
                                     .OrderBy(l => l); // Optional: Order for readability;

var commonFirstLetters = customerFirstLetters.Intersect(productFirstLetters);
Console.WriteLine("Common First Letters (Customer AND Product) ==> (intersect):");
Console.WriteLine(string.Join(", ", commonFirstLetters));
*/

//4. Create one sequence that contains the first letters of product names that are not also first letters of customer names

/*
var customerFirstLetters = CustomerList
    .Select(c => c.CompanyName.FirstOrDefault());

var productFirstLetters = ProductList
    .Select(p => p.ProductName.FirstOrDefault());

var productOnlyFirstLetters = productFirstLetters.Except(customerFirstLetters)
    .OrderBy(l => l);   // Optional: Order for readability

Console.WriteLine("Product-Only First Letters (Product NOT Customer):");
Console.WriteLine(string.Join(", ", productOnlyFirstLetters));

*/

//5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates 
/*
// 1. Get all customer names
var customerNames = CustomerList.Select(c => c.CompanyName);

// 2. Get all product names
var productNames = ProductList.Select(p => p.ProductName);

// 3. Combine both sequences into one
var allNames = customerNames.Concat(productNames);

// 4. Extract the last three characters for each name
var lastThreeChars = allNames.Select(name => name.Length >= 3 ? name.Substring(name.Length - 3) : name)
    .OrderBy(s => s); // Optional: Order for readability
Console.WriteLine("Last Three Characters of All Names (with duplicates):");
Console.WriteLine(string.Join(", ", lastThreeChars.Take(30)) + "..."); // Print first 30 for brevity
*/
#endregion

#region LINQ - Aggregate Operators

//1.Uses Count to get the number of odd numbers in the array 

/*
int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var oddNumbers = Arr.Count(n => n % 2 == 1);
Console.WriteLine($"Number of odd numbers: {oddNumbers}");
*/

//Use ListGenerators.cs & Customers.xml
//2.Return a list of customers and how many orders each has. 

/*
var customersWithOrderCounts = CustomerList
    .Select(c => new
    {
        CustomerID = c.CustomerID,
        CompanyName = c.CompanyName,
        OrderCount = c.Orders.Length // Access the length of the Orders array
    });

Console.WriteLine("2. Customer Order Counts:");
Console.WriteLine("--------------------------------------------------------------------------");
foreach (var item in customersWithOrderCounts)
{
    Console.WriteLine($"ID: {item.CustomerID,-5} | Company: {item.CompanyName,-40} | Orders: {item.OrderCount}");
}
*/

// 3. Return a list of categories and how many products each has.
/*
var categoryProductCounts = ProductList
    .GroupBy(p => p.Category) // Group products by their Category
    .Select(g => new
    {
        CategoryName = g.Key, // The category name
        ProductCount = g.Count() // The number of products in that group
    })
    .OrderByDescending(x => x.ProductCount); // Order by count (optional)

Console.WriteLine("3. Category Product Counts:");
Console.WriteLine("----------------------------------");
foreach (var item in categoryProductCounts)
{
    Console.WriteLine($"Category: {item.CategoryName,-20} | Products: {item.ProductCount}");
}
*/


//4. Get the total of the numbers in an array. 
/*
int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
int totalSum = Arr.Sum();
Console.WriteLine($"Total of numbers in array: {totalSum}");
*/

//5.Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

/*
string filePath = "dictionary_english.txt";
string[] words = File.ReadAllLines(filePath);

var totalChars = words.Where(w => !string.IsNullOrWhiteSpace(w)).Sum(w=>w.Length);


// Step 3: Print the result
Console.WriteLine("5. Total number of characters of all words in dictionary_english.txt:");
Console.WriteLine(new string('-', 80));
Console.WriteLine($"Total Characters: {totalChars}");

*/

//Use ListGenerators.cs & Customers.xml 
//6. Get the total units in stock for each product category. 

/*
var totalUnitsInStockByCategory = ProductList
    .GroupBy(p => p.Category)
    .Select(g => new
    {
        CategoryName = g.Key,
        TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
    })
    .OrderByDescending(x => x.TotalUnitsInStock);

Console.WriteLine("6. total units in stock for each product category:");
Console.WriteLine("----------------------------------");
foreach (var item in totalUnitsInStockByCategory)
{
    Console.WriteLine($"Category: {item.CategoryName,-20} | Products: {item.TotalUnitsInStock}");
}
*/


//7. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First)

/*
string filePath = "dictionary_english.txt";
string[] words= File.ReadAllLines(filePath);

int shortestWordLength = words.Where(w => !string.IsNullOrWhiteSpace(w)).Min(w => w.Length);

// Step 3: Print the result
Console.WriteLine("7. Length of the shortest word in dictionary_english.txt:");
Console.WriteLine(new string('-', 70));
Console.WriteLine($"Shortest Word Length: {shortestWordLength}");
*/


//Use ListGenerators.cs & Customers.xml 
//8. Get the cheapest price among each category's products 

/*
var cheapestPriceByCategory = ProductList
    .GroupBy(p => p.Category)
    .Select(g => new
    {
        CategoryName = g.Key,
        MinPrice = g.Min(p => p.UnitPrice)
    })
    .OrderBy(x => x.CategoryName);

Console.WriteLine("8.Cheapest Price among each category's products:");
Console.WriteLine("-------------------------------------------------------");
foreach (var item in cheapestPriceByCategory)
{
    Console.WriteLine($"Category: {item.CategoryName,-20} | Min Price: {item.MinPrice}");
}
*/

//9. Get the products with the cheapest price in each category (Use Let) 
/*
var cheapestProductByCategory =
    from p in ProductList
    group p by p.Category into g
    let minPrice = g.Min(p => p.UnitPrice) // Use 'let' to store the minimum price
    select new
    {
        Category = g.Key,
        CheapestProduct = g
            .Where(p => p.UnitPrice == minPrice)
            .OrderBy(p => p.ProductName)
            .FirstOrDefault()
    };

Console.WriteLine("9. Cheapest product in each category:");
Console.WriteLine(new string('-', 90));

foreach (var item in cheapestProductByCategory)
{
    if (item.CheapestProduct != null)
    {
        Console.WriteLine($"Category: {item.Category,-20} | Product: {item.CheapestProduct.ProductName,-35} | Price: {item.CheapestProduct.UnitPrice:C}");
    }
}

*/


// 10. Get the length of the longest word in dictionary_english.txt

/*
// Step 1: Read all lines into an array of strings
string filePath = "dictionary_english.txt";
string[] words = File.ReadAllLines(filePath);

// Step 2: Use LINQ to find the length of the longest word
int longestWordLength = words
    .Where(w => !string.IsNullOrWhiteSpace(w)) // ignore empty lines
    .Max(w => w.Length);

// Step 3: Print the result
Console.WriteLine("10. Length of the longest word in dictionary_english.txt:");
Console.WriteLine(new string('-', 70));
Console.WriteLine($"Longest Word Length: {longestWordLength}");
*/



//Use ListGenerators.cs & Customers.xml 
//11. Get the most expensive price among each category's products. 


/*
var mostExpensivePriceByCategory = ListGenerator.ProductList
    .GroupBy(p => p.Category)
    .Select(g => new
    {
        CategoryName = g.Key,
        MaxPrice = g.Max(p => p.UnitPrice)
    })
    .OrderBy(x => x.CategoryName);

Console.WriteLine("Most Expensive Product Price by Category:");
Console.WriteLine(new string('-', 70));

foreach (var item in mostExpensivePriceByCategory)
{
    Console.WriteLine($"Category: {item.CategoryName,-25} | Max Price: {item.MaxPrice,8:C}");
}
*/

//12. Get the products with the most expensive price in each category. 


/*
var mostExpensiveProductByCategory =
    from p in ProductList
    group p by p.Category into g
    let maxPrice = g.Max(p => p.UnitPrice) // Use 'let' to store the maximum price
    select new
    {
        Category = g.Key,
        MostExpensiveProduct = g
            .Where(p => p.UnitPrice == maxPrice)
            .OrderBy(p => p.ProductName)
            .FirstOrDefault()
    };

Console.WriteLine("Most Expensive Product in Each Category:");
Console.WriteLine(new string('-', 80));

foreach (var item in mostExpensiveProductByCategory)
{
    if (item.MostExpensiveProduct != null)
    {
        Console.WriteLine(
            $"Category: {item.Category,-25} | " +
            $"Product: {item.MostExpensiveProduct.ProductName,-35} | " +
            $"Price: {item.MostExpensiveProduct.UnitPrice,8:C}");
    }
}
*/


//13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First). 

/*
// Step 1: Read all lines into an array of strings
string filePath = "dictionary_english.txt";
string[] words = File.ReadAllLines(filePath);

// Step 2: Use LINQ to calculate the average word length
double averageLength = words
    .Where(w => !string.IsNullOrWhiteSpace(w)) // ignore empty lines
    .Average(w => w.Length);

// Step 3: Print the result
Console.WriteLine("13. Average length of words in dictionary_english.txt:");
Console.WriteLine(new string('-', 70));
Console.WriteLine($"Average Word Length: {averageLength:F2}");

*/

//14. Get the average price of each category's products. 


/*
var averagePrice = ProductList
    .GroupBy(g => g.Category)
    .Select(g => new
    {
        CategoryName = g.Key,
        AveragePrice = g.Average(p => p.UnitPrice)
    })
    .OrderBy(x => x.CategoryName);

Console.WriteLine("Average product price per category:");
Console.WriteLine(new string('-', 70));

foreach (var item in averagePrice)
{
    Console.WriteLine($"Category: {item.CategoryName,-25} | Average Price: {item.AveragePrice,8:C}");
}
*/

#endregion
#region LINQ - Ordering Operators

//Use ListGenerators.cs & Customers.xml
//1.Sort a list of products by name 
//2. Uses a custom comparer to do a case-insensitive sort of the words in an array. 
//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" }
//;
//Use ListGenerators.cs & Customers.xml
//3.Sort a list of products by units in stock from highest to lowest. 
//4. Sort a list of digits, first by length of their name, and then alphabetically by the name 
//itself. 
//string[] Arr = {
//    "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", 
//"nine" }
//;
//5.Sort first by word length and then by a case-insensitive sort of the words in an array. 
//string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" }
//;
//Use ListGenerators.cs & Customers.xml
//6.Sort a list of products, first by category, and then by unit price, from highest to lowest. 
//7. Sort first by word length and then by a case-insensitive descending sort of the words in 
//an array. 
//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" }
//;
//8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the 
//order in the original array. 
//string[] Arr = {
//    "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", 
//"nine" };
#endregion
#region LINQ - Partitioning Operators
//Use ListGenerators.cs & Customers.xml
//1.Get the first 3 orders from customers in Washington 
//2. Get all but the first 2 orders from customers in Washington. 
//3. Return elements starting from the beginning of the array until a number is hit that is 
//less than its position in the array. 
//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }
//;
//4.Get the elements of the array starting from the first element divisible by 3. 
//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }
//;
//5.Get the elements of the array starting from the first element less than its position. 
//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }
//;

#endregion
#region LINQ - Projection Operators 

//Use ListGenerators.cs & Customers.xml
//1.Return a sequence of just the names of a list of products. 
//2. Produce a sequence of the uppercase and lowercase versions of each word in the 
//original array (Anonymous Types). 
//string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" }
//;
//Use ListGenerators.cs & Customers.xml
//3.Produce a sequence containing some properties of Products, including UnitPrice which 
//is renamed to Price in the resulting type. 
//4. Determine if the value of ints in an array match their position in the array. 
//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }
//;
//Result
//Number: In - place ?
//5 : False
//4: False
//1: False
//3: True
//9: False
//8: False
//6: True
//7: True
//2: False
//0: False
//5. Returns all pairs of numbers from both arrays such that the number from numbersA is 
//less than the number from numbersB. 
//int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 }
//;
//int[] numbersB = { 1, 3, 5, 7, 8 };
//Result
//Pairs where a < b: 
//0 is less than 1
//0 is less than 3
//0 is less than 5
//0 is less than 7
//0 is less than 8
//2 is less than 3
//2 is less than 5
//2 is less than 7
//2 is less than 8
//4 is less than 5
//4 is less than 7
//4 is less than 8
//5 is less than 7
//5 is less than 8
//6 is less than 7
//6 is less than 8
//Use ListGenerators.cs & Customers.xml
//6.Select all orders where the order total is less than 500.00. 
//7. Select all orders where the order was made in 1998 or later. 

#endregion
#region LINQ - Quantifiers 
//1.Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into 
//Array of String First) contain the substring 'ei'. 
//Use ListGenerators.cs & Customers.xml 
//2. Return a grouped a list of products only for categories that have at least one product 
//that is out of stock. 
//3. Return a grouped a list of products only for categories that have all of their products in 
//stock.
#endregion
#region LINQ - Grouping Operators 

//1.Use group by to partition a list of numbers by their remainder when divided by 5 
//Output:  
//Numbers with a remainder of 0 when divided by 5: 
//0
//5
//10
//Numbers with a remainder of 1 when divided by 5: 
//1
//6
//11
//Numbers with a remainder of 2 when divided by 5: 
//7
//2
//12
//Numbers with a remainder of 3 when divided by 5: 
//3
//8
//13
//Numbers with a remainder of 4 when divided by 5: 
//4
//9
//14
//2.Uses group by to partition a list of words by their first letter. 
//Use dictionary_english.txt for Input 
//3. Consider this Array as an Input  
//string[] Arr = {
//    "from   ", " salt", " earn ", "  last   ", " near 
//", " form  " }; 
//Use Group By with a custom comparer that matches words that are consists of the same
//Characters Together
//Result... 
//from
//form
//...
//salt
//last
//... 
//earn
//near

#endregion



