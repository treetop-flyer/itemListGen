using System;
using System.IO;
using System.Text;

namespace itemList
{
    class ItemListMain
    {
        //public static string itemListDoc = Environment.CurrentDirectory;

        public static void Main()
        {
            int[] numbers = new int[2];
            string type;

            Console.WriteLine("# Enter your starting number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("# Enter your ending number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("# Choose your item type: \n# 1.ETC \n# 2.ARMOR \n# 3.WEAPON");
            type = Console.ReadLine();

            //itemListDoc = Environment.CurrentDirectory;
            string itemListDoc = Environment.CurrentDirectory + @"\item_list.txt";

            if(File.Exists(itemListDoc) == true)
            {
                if (new FileInfo(itemListDoc).Length > 0)
                {
                    Console.WriteLine("Do you want to clear the file before continuing?");
                    string clearTheFile = Console.ReadLine();
                    
                    if (clearTheFile == "yes")
                    {
                        File.WriteAllText(itemListDoc, string.Empty);
                    }
                }
            }

            while (numbers[0] <= numbers[1])
            {
                if (type == "WEAPON")
                {
                    using (StreamWriter outputFile = new StreamWriter(itemListDoc, true))
                    {
                        outputFile.WriteLine("{0} {1} \ticon/item/{2}.tga\t d:ymir work/item/weapon/{2}.gr2", numbers[0], type, numbers[0] / 10 * 10);
                        //outputFile.WriteLine($"{numbers[0]} {type}");
                    }
                    numbers[0]++;
                }
                else
                {
                    using (StreamWriter outputFile = new StreamWriter(itemListDoc, true))
                    {
                        outputFile.WriteLine("{0} {1} \ticon/item/{2}.tga", numbers[0], type, numbers[0] / 10 * 10);
                    }
                    numbers[0]++;
                }
            } 
        }
    }
}
