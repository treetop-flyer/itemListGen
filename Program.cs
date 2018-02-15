using System;
using System.IO;
using System.Text;

namespace itemList
{
    class ItemListMain
    {
        public static string itemListDoc = Environment.CurrentDirectory;

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

            Console.WriteLine("Do you want to clear the file before contuning?");
            string clearTheFile = Console.ReadLine();

            itemListDoc = Environment.CurrentDirectory;

            if (clearTheFile == "yes")
            {
                File.WriteAllText(itemListDoc + @"\item_list.txt", string.Empty);
            }

            while (numbers[0] <= numbers[1])
            {
                if (type == "WEAPON")
                {
                    using (StreamWriter outputFile = new StreamWriter(itemListDoc + @"\item_list.txt", true))
                    {
                        outputFile.WriteLine("{0} {1} \ticon/item/{2}.tga\t d:ymir work/item/weapon/{2}.gr2", numbers[0], type, numbers[0] / 10 * 10);
                        //outputFile.WriteLine($"{numbers[0]} {type}");
                    }
                    numbers[0]++;
                }
                else
                {
                    using (StreamWriter outputFile = new StreamWriter(itemListDoc + @"\item_list.txt", true))
                    {
                        outputFile.WriteLine("{0} {1} \ticon/item/{2}.tga", numbers[0], type, numbers[0] / 10 * 10);
                    }
                    numbers[0]++;
                }
            } 
        }
    }
}
