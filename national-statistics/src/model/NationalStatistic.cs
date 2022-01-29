using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace national_statistics.src.model
{
    public class NationalStatistic {

        //Constant
        private static string SEPARATOR = ",";

        //Relationship
        private List<Department> departments;
    
        //Builder method
        public NationalStatistic()
        {
            departments = new List<Department>();
        }
        public List<Department> getDepartments()
        {
            return departments;
        }

        public importFile()
        {
            
        }

        private Department foundDepartment(string code)
        {
            Department result = null;
            for (int i = 0; i < departments.Count && result==null; i++)
            {
                if (departments.ElementAt(i).getCode().Equals(code))
                {
                    result = departments.ElementAt(i);
                }
            }
            return result;
        }

        public List<Department> filterDepartments(char letter)
        {
            List < Department > results = new List < Department >();
            for (int i = 0; i < departments.Count; i++)
            {
                if(departments.ElementAt(i).getName().Substring(0,1).Equals(letter))
                {
                    results.Add(results.ElementAt(i));
                }
            }
            return results;
        }



    }
}
