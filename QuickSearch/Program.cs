using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuickSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchPath = @"C:\download";
            string searchMask = "*.zip";

            if (System.Diagnostics.Debugger.IsAttached && args.Length < 1)
            {
                args = new string[] { searchPath + @"\" + searchMask };
            }

            if (args.Length < 1)
            {
                Console.WriteLine("Usage: ");
                Console.WriteLine("  QuickSearch [searchpath+mask]");
                Console.WriteLine("    QuickSearch C:\\download\\*.zip");
                Console.WriteLine("  QuickSearch [searchPath] [mask]");
                Console.WriteLine("    QuickSearch C:\\download *.zip");
            }else{
                if (args.Length == 1)
                {
                    // split argument path and search string up
                    searchPath = System.IO.Path.GetDirectoryName(args[0]);
                    searchMask = System.IO.Path.GetFileName(args[0]);
                }
                else if (args.Length == 2)
                {
                    searchPath = System.IO.Path.GetDirectoryName(args[0]);
                    searchMask = args[1];
                }
            }

            SearchMsGenerator gen = new SearchMsGenerator();

            string tempFile = System.IO.Path.GetTempFileName() + ".search-ms";
            gen.GenerateSearchDoc(searchPath, searchMask).Save(tempFile);
            System.Diagnostics.Process.Start(tempFile);

            //System.Threading.Thread.Sleep(15000); // Can't use this
            //System.IO.File.Delete(tempFile); // DELETING the file at any time after the search has been loaded kills the search window and brings the user to their temp folder
            // Is there any way to clean up these files?
        }

       
    }
}
