using System;
using System;
using System.Collections;
using System.IO;
using System.Xml.Serialization;
namespace XmlSerialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car 
            {
                Name = "Camry",
                Price = 45.5,
                Brand = "Toyota"
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Car));
            using(StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, car);
                string xml = writer.ToString();
                Console.WriteLine(xml);
            }

            string xmld = @"<Car>
                              <Name>Camry</Name>
                              <Price>45.5</Price>
                              <Brand>Toyota</Brand>
                          </Car>";
            using(StringReader reader = new StringReader(xmld))
            {
                Car desCar = (Car)serializer.Deserialize(reader);
                Console.WriteLine($"Name: {desCar.Name}");
                Console.WriteLine($"Price: { desCar.Price}");
                Console.WriteLine($"Brand: {desCar.Brand}");
            }


        }
    }
}
