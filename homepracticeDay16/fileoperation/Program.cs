using System;
using System.IO;
using System.Text;

namespace fileoperation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region file read
            var filePath = @"E:\Soft Dev\Pro C# Dev skill\Home practice\HomPractice\homepracticeDay16\fileoperation\forRead.txt";
            if(File.Exists(filePath))
            {
                var text = File.ReadAllText(filePath);
                Console.WriteLine(text);

                var lines = File.ReadAllLines(filePath);
                foreach(var line in lines)
                {
                    Console.WriteLine($"-{line}-");
                }

               // File.Create(@"E:\Soft Dev\Pro C# Dev skill\Home practice\HomPractice\homepracticeDay16\fileoperation\Newcreated.txt");
                File.Delete(@"E:\Soft Dev\Pro C# Dev skill\Home practice\HomPractice\homepracticeDay16\fileoperation\Newcreated.txt");
            }

            var file = new FileInfo(filePath);
            if(file.Exists)
            {
                var reader = file.OpenText();
                string line = null;

                do
                {
                    line = reader.ReadLine();
                    Console.WriteLine($"=={line}==");
                } while (line != null);
              
            }

            #endregion

            #region file write
            var writeFilePath = @"E:\Soft Dev\Pro C# Dev skill\Home practice\HomPractice\homepracticeDay16\fileoperation\forWrite.txt";
            var content = "Subahanallai owbihamdihi";
            File.WriteAllText(writeFilePath, content);

            using var writer = File.OpenWrite(writeFilePath);
            var bytes = Encoding.ASCII.GetBytes(content);
             writer.Write(bytes);
            FileInfo fileInfo = new FileInfo(writeFilePath);
            Console.WriteLine(fileInfo.Length);
            #endregion
        }
    }
}
