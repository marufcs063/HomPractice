using System;
using System.Collections.Generic;

namespace CollectionGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictonary 
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);
            
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);

            openWith["doc"] = "winword.exe";

            string value = "";
            if (openWith.TryGetValue("doc", out value))
            {
                Console.WriteLine("For key = \"doc\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"doc\" is not found.");
            }

            openWith.ContainsKey("abc");
            openWith.ContainsValue("window.xp");
            openWith.Remove("doc");
            openWith.TryAdd("docx", "alhamdulillah");

            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
            #endregion

            #region 

            #endregion
        }
    }
}
