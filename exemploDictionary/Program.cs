using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);


            // remove um elemento
            cookies.Remove("email");

            //verifica se existe key no dictionary 
            if (cookies.ContainsKey("email"))
                Console.WriteLine(cookies["email"]);
            else 
                Console.WriteLine("There is no 'email' key");

            // mostra o total de registro no Dictionary
            Console.WriteLine($"Size: {cookies.Count}");


            Console.WriteLine("ALL COOKIES:");
            foreach (KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


            Console.ReadKey();
        }
    }
}
