using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tariff_ComparisonApp.Model;

namespace Tariff_ComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<Products> product_list = new List<Products>();
            Products products_A = new Products();
            products_A =new Products{ Id = 1, product = "Product A", Name = "basic electricity tariff" };
            

            Products products_B = new Products();
            products_B =new Products { Id = 2, product = "Product B", Name = "“Packaged tariff" };
            
           
            Console.WriteLine("\nPlease Enter your Consuption(kWh/year)? ");
            int Consumption = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Enter Consumption :" + Consumption + "(kWh/year)");

            products_A.Consumption = Consumption;
            products_B.Consumption = Consumption;

            products_A.AnualCost=  products_A.CalOfAnualCostForProduct_A(Consumption);
            products_B.AnualCost = products_B.CalOfAnualCostForProduct_B(Consumption);

            product_list.Add(products_A);
            product_list.Add(products_B);

            //Console.WriteLine("Your Anual Cost:" + products_A.AnualCost + "(kWh/year)");

            //Console.WriteLine("Your Anual Cost:" + products_B.AnualCost+ "(kWh/year)");

            //for (int i = 0; i < product_list.Count; i++)
            //{
            //    Console.WriteLine("\n\n\nproduct Data\n Product Id :" + product_list[i].Id + "\nProducts :" + product_list[i].product + "\nProduct Name:" + product_list[i].Name + "\nAnual Cost :" + product_list[i].AnualCost + "(kWh/year)");
            //}

            //Console.WriteLine("The list should be sorted by costs in ascending order.");

            product_list = product_list.OrderBy(n => n.AnualCost).ToList();
            foreach (var product in product_list)
            {
                Console.WriteLine("\n\n\nproduct Data\n Product Id :" + product.Id + "\nProducts :" + product.product + "\nProduct Name:" + product.Name + "\nAnual Cost :" + product.AnualCost + "(kWh/year)"); 
            }
           
            Console.ReadKey();
            
        }

        
    }
}
