using System;

namespace MyDictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDict = new MyDictionary<string, string>();
            myDict.Add("Red", "Kırmızı");
            myDict.Add("Dictionary", "Sözlük");
            myDict.Add("Game", "Oyun");
            myDict.Add("Music", "Müzik");

            foreach (string item in myDict.GetAll()) 
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine( myDict.GetValue("Flower"));
            //Console.WriteLine(myDict.GetKey("Çiçek"));
            Console.ReadKey();
           
        }
    }
}
