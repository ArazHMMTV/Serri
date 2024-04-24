using System.Text.Json;

namespace SerialzationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            //product.Id = 1;
            //product.Name="Test";
            //product.Description = "Test";
            //product.Category = "Test";
            //ProductToJson(product);
            Product product1 = JsonToProduct(product);
            Console.WriteLine(product1.Name);
            Console.WriteLine(product1.Description);
            Console.WriteLine(product1.Category);
            Console.WriteLine(product1.Id);

        }
        public static void ProductToJson(Product product)
        {
            string path = "C:\\Users\\Administrator\\Desktop\\file.txt";

            string jsonString = JsonSerializer.Serialize(product);

            File.WriteAllText(path, jsonString);

            Console.WriteLine(path);

        }
        public static Product JsonToProduct(Product product)
        {
            string path = "C:\\Users\\Administrator\\Desktop\\file.txt";

            string jsonString = File.ReadAllText(path);

            return JsonSerializer.Deserialize<Product>(jsonString);

        }
    }
}
