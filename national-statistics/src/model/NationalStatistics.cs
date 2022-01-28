﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace national_statistics.src.model
{
    public class NationalStatistics {

        //Constant
        private static string SEPARATOR = ",";

        //Relationship
        private List<Department> departments;
    
        //Builder method
        public NationalStatistics()
        {
            departments = new List<Department>();
        }

        public importFile()
        {
            
        }

        private Boolean foundDepartment(string code)
        {
            Boolean result = false;
            for (int i = 0; i < departments.Count; i++)
            {
                if (departments.ElementAt(i).getCode().Equals(code))
                {
                    result = true;
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