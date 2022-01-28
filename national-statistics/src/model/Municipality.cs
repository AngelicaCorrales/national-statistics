using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace national_statistics.src.model
{
    public class Municipality
    {
        // Attributes
     
        private string code;
        private string name;
        private string type;

        // Builder method
        public Municipality(string c, string n, string t)
        {
            this.code = c;
            this.name = n;
            this.type = t;
        }

        public string getCode() 
        { 
            return code; 
        }

        public string getName()
        {
            return name;
        }

        public string getType()
        {
            return type;
        }

    }
}
