using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace national_statistics.src.model
{
     public class Department
    {
        private string code;
        private string name;
        private List<Municipality> municipalities;

        public Department(string code, string name)
        {
            this.code = code;
            this.name = name;
            municipalities= new();
        }

        public string getCode()
        {
            return code;
        }

        public string getName()
        {
            return name;
        }

        public List<Municipality> getMunicipalities()
        {
            return municipalities;
        }
    }
}
