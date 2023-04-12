using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        class product
        {
           public string ID;
           public string name;
           public int price;
            public string category;
            public string country;
            public string brandName;


        }
        static void Main(string[] args)
        {
            product[] p = new product[10];
            int count = 0;
            char option;
            do
            {
                option = menu();
                if (option == '1')
                {
                    p[count] = addProduct();
                    count++;
                }
                else if (option == '2')
                {
                    viewProduct(p, count);
                }
                else if (option == '3')
                {
                    int total;
                    total = storeWorth(p, count);
                    Console.WriteLine("total worth is : {0}", total);
                    Console.ReadKey();
                }
                else
                {
                    break;
                }
            }
            while (option!=4);
            Console.WriteLine("press enter to exit");
            Console.ReadKey();
        }
        static char menu()
        {
            Console.Clear();
            Console.WriteLine("1.press 1 for add product");
            Console.WriteLine("2.press 2 for show product");
            Console.WriteLine("3.press 3 for total store worth");
            Console.WriteLine("4.EXIT");
            char choice;
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static product addProduct ()
        {
            Console.Clear();
            product p1 = new product();
            Console.WriteLine("enter product ID");
            p1.ID = Console.ReadLine();
            Console.WriteLine("enter product name");
            p1.name = Console.ReadLine();
            Console.WriteLine("enter price");
            p1.price = int.Parse(Console.ReadLine());
            Console.WriteLine("enter category");
            p1.category = Console.ReadLine();
            Console.WriteLine("enter country");
            p1.country = Console.ReadLine();
            Console.WriteLine("enter brand  name");
            p1.brandName = Console.ReadLine();
            return p1;
        }
        static void viewProduct(product[] p,int count)
        {
            Console.Clear();
             
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("product ID:{0} productName:{1} price: {2} category:{3} country: {4} brandName: {5}", p[x].ID, p[x].name, p[x].price, p[x].category, p[x].country, p[x].brandName);
                    }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
        static int storeWorth(product[] p,int count)
        {
            int  sum = 0;
            for(int idx = 0; idx<count; idx++)
            {
                sum = sum + p[idx].price;
            }
            return sum;
        }
    }
}
