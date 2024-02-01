using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicLibrary
{
    public class SithLord
    {
        public static void ExecuteOrder66()
        {
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "OldManCanoli.jpg");

            if (File.Exists(imagePath))
            {
                try
                {
                    Process.Start("explorer.exe", imagePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error opening image: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("The Jedi have won.");
            }
        }
    }
}
