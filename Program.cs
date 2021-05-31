using System;
using System.IO;

namespace moneys4_dl5
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("{0:yyyy-MM-dd HH:mm:ss} Converze XML exportu z Money S4 do DL5 formátu.", DateTime.Now);

            if (args.Length != 2) {
                Console.WriteLine("Chyba vstupních argumentů. Povolený počet: 2.");
                return 1;
            }

            string inputXmlFile = args[0];
            string outputDir = args[1];

            if (!Directory.Exists(outputDir)) {
                Console.WriteLine($"Nepodařilo se najít cílovou složku: {outputDir}.");
                return 1;
            }

            if (!File.Exists(inputXmlFile)) {
                Console.WriteLine($"Nepodařilo se načíst vstupní XML soubor: {inputXmlFile}.");
                return 1;
            }

            DLV_Data dl5 = new DLV_Data(inputXmlFile, outputDir);
            dl5.createDL5Files();

            return 0;
        }
    }
}
