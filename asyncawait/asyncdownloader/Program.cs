namespace asyncdownloader
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> files = new List<string>
            {
                "setup.exe",
                "readme.pdf",
                "crack.exe"
            };
            Console.WriteLine("İndirme işlemleri başlatılıyor...\n");
            List<Task> downloadTasks = new List<Task>();
            foreach(var file in files)
            {
                downloadTasks.Add(Downloader.DownloadFileAsync(file));
                Console.WriteLine("Tüm dosyalar başarıyla indirildi.");
            }
        }
    }
    internal class Downloader
    {
        public static async Task DownloadFileAsync(string fileName)
        {
            Random rnd = new Random();
            int delay = rnd.Next(2000, 6000);
            Console.WriteLine($"{fileName} indirilmeye başladnı...");
            await Task.Delay(delay);
            Console.WriteLine($"{fileName} indirildi. (Sure: {delay / 1000.0:F1} sn");
        }
    }
}
