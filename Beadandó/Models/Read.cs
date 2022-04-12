using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Beadandó.Models
{
    internal class Reader
    {
        private List<string[]> list;

        public Reader()
        {
            list = new List<string[]>();
        }

       /*Car.txt file beolvasása listába*/
        public void Beolv(string file)
        {
            try
            {
                StreamReader sr = new StreamReader(file);
                string str = sr.ReadLine();
                while (str != null)
                {
                    list.Add(str.Split(','));
                    str = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Baj van a file-al!");
                Console.WriteLine(e.Message);
            }

        }
        public List<string[]> GetList
        {
            get
            {
                return list;
            }
        }
    }
}
