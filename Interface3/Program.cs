using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFile file = new TextFile("notlar.txt");
            ExcelFile eFile = new ExcelFile("hesaplar.xls");
            XmlFile xFile = new XmlFile("kullanıcılar.xml");


            FileOperation operation = new FileOperation();
            operation.Dosya = file;
            operation.Oku();


            operation.Dosya = eFile;
            operation.Oku();




            operation.Dosya = xFile;
            operation.Oku();



            Console.ReadKey();

        }
    }
}
