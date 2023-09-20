using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args) 
        {
            Product product1 = new Product();//class örneği
            product1.Adı = "Elma";
            product1.Fiyatı = 15;
            product1.Acıklama = "lkdsdjcjkdj";


            Product product2 = new Product();
            product2.Adı = "Karpuz";
            product2.Fiyatı = 85;
            product2.Acıklama = "dfghjk";

            Product[] products =new Product[] { product1, product2 };   


            foreach (Product product in products)
            {
                Console.WriteLine(product.Adı);  
                
            }
            //instance-class örneği oluşturmak
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            
            
        }
    }
}