using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Brown_jaylen
{
    internal class fighting : game
    {

        public fighting(string esrbParam, string titleParam) : base(esrbParam, titleParam) 
        {
            Title = titleParam;
            Esrb = esrbParam;
        }
        public override string Describe()
        {
            return $"{Title} is a fighting game rated {Esrb}";
        }
    }
}
