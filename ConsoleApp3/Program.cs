using System.Text;

namespace FileTopicContinue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ////Faylga malumot yozish
            //var fileName = "D:\\YangiPapka\\Text\\Dunyo.txt";

            //using var faylYasash = File.Create(fileName);
            //byte[] bytes = Encoding.UTF8.GetBytes("salom Dunyo!\n HelloWorld!");
            //faylYasash.Write(bytes, 0, bytes.Length);
            //faylYasash.Close();
            //Console.WriteLine("Faylga malumot yozildi.\n");


            ////Fayl mavjudligini tekshirish
            //var newFileName = "D:\\YangiPapka\\Text\\Dunyo.txt";
            //if(File.Exists(newFileName)) 
            //{
            //    Console.WriteLine("Fayl Bor!");
            //}
            //else 
            //{
            //    Console.WriteLine("Fayl Yo'q!");
            //}

            ////CTRL + C, CTRL + V
            //var newFaylName = "D:\\YangiPapka\\Text\\Olam.txt";
            //File.Copy(fileName, newFaylName);
            //Console.WriteLine("Fayl nusxalandi");

            ////CTRL + X, CTRL + V
            //var newFileNameLocation = "D:\\YangiPapka\\Texts\\Mir.txt";
            //File.Move(fileName, newFileNameLocation);
            //Console.WriteLine("Fayl boshqa joyga ko'chirildi");

            //Faylni ochib o'qish => 1 - Usul

            //using var stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //byte[] fileBytes = new byte[1024];
            //int bytesRead;
            //while ((bytesRead = stream.Read(fileBytes, 0, fileBytes.Length)) > 0)
            //{
            //    Console.WriteLine(Encoding.UTF8.GetString(fileBytes, 0, bytesRead));
            //}
            //stream.Close();

            //Faylni ochib o'qish => 2 - usuli

            //using var streamRead = File.OpenRead(fileName);
            //byte[] bytes1 = new byte[1024];
            //int bytesRead1;
            //while(( bytesRead1 = streamRead.Read(bytes1, 0, bytes1.Length)) > 0)
            //{
            //    Console.WriteLine(Encoding.UTF8.GetString(bytes1, 0, bytesRead1));
            //}
            //streamRead.Close();

            ////OpenText metodi yordamida matnli faylni o'qish
            //using var reader = File.OpenText(fileName);
            //string s = string.Empty;
            //while(( s = reader.ReadLine()) != null )
            //{
            //    Console.WriteLine(s);
            //}
            //reader.Close();

            ////File classining OpenWriter metodi bilan StreamWriter clasi yordamida faylga malumotlar yozish
            //var path = "D:\\YangiPapka\\Texts\\Mir.txt";
            //using var fileStream = File.OpenWrite(path);
            //using var streamWrite = new StreamWriter(fileStream);
            //streamWrite.WriteLine("Java\nC#\nGo\n.Net\nPython");
            //streamWrite.Close();
            //fileStream.Close();
            //Console.WriteLine("Malumotlar yozildi\n");

            ////File clasining ReadAllLines methodi bilan faylni o'qish
            //var lines = File.ReadAllLines(path);
            ////File.ReadLines(path) => IEnumerable<string>, File.ReadAllLines(path) => string[]
            ////ReadLines() methodi faylni qatorma-qator o'qish davomida IEnumerable tipidagi to'plamga string qo'shib boradi
            ////ReadAllLines() methodi esa faylni to'liq o'qib bo'lganidan so'ng string[] tipdagimassivga string qo'shib beradi
            ////ReadAllLines() methodi kichik hajimdagi fayllar uchun, ReadLines() esa katta hajmdagi fayllar uchun samarali.
            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //Console.WriteLine();

            //string readText = File.ReadAllText(path);
            //Console.WriteLine(readText);

            ////Bu yerda ReadAllLines() methodi bilan o'qilgan malumotlar massivga saqlanadi
            //string line1 = "Java";
            //string line2 = "C#";
            //string line3 = "Go";
            //string line4 = ".Net";
            //string line5 = "Python";
            //string[] readAllLines = { line1, line2, line3, line4, line5 };

            ////Bu yerda ReadAllText() mettodi bilan o'qiladigan malumotlar string tipidagi o'zgaruvchiga saqlanadi
            //string join = String.Join("\n", readAllLines);
            //string allText = "Java\r\nC#\r\nGo\r\n.Net\r\nPython";

            ////File.ReadAllBytes metodi orqali rasmni baytga o'girib consolga chiqarish
            //var path = "D:\\YangiPapka\\Texts\\Mir.jpg";
            //byte[] bytes = File.ReadAllBytes(path);
            //int i = 0;
            //foreach(byte c in bytes)
            //{
            //    Console.Write("{0:X2}", c);
            //    i++;
            //    if(i %30 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}

            ////WriteAllText metodi bilan faylga matn yozish
            //var path = "D:\\YangiPapka\\Texts\\Mir.txt";
            //string qushlar = "Bulbul\nBurgut\nLaylak\nMayna\nHakka";
            //File.WriteAllText(path, qushlar);
            //Console.WriteLine("Malumotlar yozildi.\n");

            ////WriteAllLines metodi bilan faylga matn yozish
            //var newPath = "D:\\YangiPapka\\Texts\\Mir.txt";
            //string[] hayvonlar = { "It", "Bo'ri", "Quyon", "Tulki", "Xo'roz", "Taka", "Ot" };
            //File.WriteAllLines(newPath, hayvonlar, Encoding.UTF8);
            //Console.WriteLine("Boshqa malumotlar yozildi\n");

            //////WriteAllBytes metodi bilan faylga bayt yozish
            //var anotherPath = "D:\\YangiPapka\\Texts\\Mir.txt";
            //var gullar = "Atirgul\nLola\nChinnigul\nQorashaxzoda\nNilufar\nRayhon\nBaxmal";
            //var bytes = Encoding.UTF8.GetBytes(gullar);
            //File.WriteAllBytes(anotherPath, bytes);
            //Console.WriteLine("Yana malumotlar yozildi.\n");

            ////File.AppendText metodi bilan faylning oxiridan boshlab matn qo'shish
            //var manzil = "d:\\yangipapka\\texts\\mir.txt";
            //using var streamwriter = File.AppendText(manzil);
            //streamwriter.WriteLine("rust");
            //streamwriter.Close();
            //Console.WriteLine("mavjud faylga  malunot qo'shildi\n");

            ////// File.AppendAllText metodi bilan faylning oxiridan boshlab matn qo'shish
            //var contents = "Boshqa dastur tillarin bilmayman!\nAgar bilsang izohda yozib qoldir.";
            //File.AppendAllText(manzil, contents);
            //Console.WriteLine("Mavjud faylga boshqa malumotlar qo'shildi...\n");

            ////File.AppendAllLines metodi bilan faylning oxiridan boshlab matn qo'shish
            //List<string> languages = new()
            //{
            //    "Kotlin",
            //    "C",
            //    "Fortran",
            //    "VB.NET",
            //    "Dart"
            //};
            //File.AppendAllLines(manzil, languages);
            //Console.WriteLine("Mavjud faylga yana boshqa malumot qo'shildi...\n");
        }
    }
}