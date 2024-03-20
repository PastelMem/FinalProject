using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class CSV
    {
        private string path = @"C:\Users\maste\Documents\GitHub\Final Project\Data.csv";

        public bool Savetofile(string screensize , string processor , string display , string memory , string storage, string graphics , string weight , string price)
        {

            string content = screensize + "," + processor + "," + display + "," + memory + "," + storage + "," + graphics + "," + weight + "," + price + "\n";
            try
            {
                File.AppendAllText(path, content);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
