
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonSerialization

{
    class Program
    {
        static void Main(string[] args)
        {
            string book1 = @"{
               ""Name"": ""Yeraltindan notlar"",
               ""Genre"": ""Drama"",
               ""Price"": 5           
            }";

            //string json = JsonSerializer.Serialize(book1);
            //Console.WriteLine(json);

            Book book = JsonSerializer.Deserialize<Book>(book1);

            Console.WriteLine($"Name: {book.Name}");
            Console.WriteLine($"Genre: {book.Genre}");
            Console.WriteLine($"Price: {book.Price}");


        }
    }
}
