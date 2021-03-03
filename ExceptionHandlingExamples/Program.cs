using System;
using System.IO;

namespace ExceptionHandlingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            GetText();
        }

        static void GetText()
        {
            try
            {
                var path = "C://Myfile.txt";
                var text = File.ReadAllText(path);

                if (!string.IsNullOrWhiteSpace(text))
                    throw new EmptyFileException("File content is empty");

                Console.WriteLine(text);
            }
            catch(FileNotFoundException f)
            {
                Console.WriteLine("File does not exists");
            }
            catch(EmptyFileException ee)
            {
                Console.WriteLine(ee.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("There was some problem, please try again!");
            }
            finally
            {
                Console.WriteLine("Program ended");
            }
        }
    }
}
