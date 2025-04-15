using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Brown_jaylen
{
    abstract internal class game
    {
        //make an automatic proprtey
        public string Esrb { get; set; }
        // make an automatic proprty
        public string Title { get; set; }
        // makes an constructor
        public game(string esraParam, string titleParam)
        { 
           // sets proamitors 
            Esrb = esraParam;
            Title = titleParam;

        }
        // if called prints whatever title is set than says it is starting
        public void PlayGame() 
        {
            Console.WriteLine($"{Title} is staring");
        }
        // makes the describe method
        public abstract string Describe();
    }
}
