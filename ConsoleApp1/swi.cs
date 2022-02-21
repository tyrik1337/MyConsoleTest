using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class swi
    {
        string NameU;
        string NameB;
        public string ConstrucrorName(int first)
        {
            switch (first)
            {
                case 0:
                    {
                        NameU= "Tom";
                        break;
                    }
                case 1:
                    {


                        NameU= "Tom";
                        break;
                    }
                case 2:
                    {
                        NameU= "Alice";
                        break;

                    }
                case 3:
                    {
                        NameU = "Erjan";
                        break;

                    }
            }
           
            return NameU;

        }
        public string ConstrucrorBook(int second)
        {
            switch (second)
            {
                case 1:
                    {
                        NameB = "Potter";
                        break;
                    }
                case 2:
                    {
                        NameB = "Jizn";
                        break;
                    }
                case 3:
                    {
                        NameB = "War";
                        break;
                    }
            }
            return NameB;
        }

    }

}
