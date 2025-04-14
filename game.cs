using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Brown_jaylen
{
    abstract internal class game
    {
        public string Esrb { get; set; }

        public string Title { get; set; }

        public game(string esraParam, string titleParam)
        { 
            Esrb = esraParam;
            Title = titleParam;

        }

        public void PlayGame() 
        {
            Console.WriteLine($"{Title} is staring");
        }

        public abstract string Describe();
    }
}
