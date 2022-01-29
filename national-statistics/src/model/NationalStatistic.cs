using System;
using System.Collections.Generic;
using System.Data;
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

        /*
        public void importFile(string fileName)
        {
            using (StreamReader rd = new StreamReader(fileName))
            {
                rd.ReadLine();
                while (!rd.EndOfStream)
                {
                    string[] parts = rd.ReadLine().Split(SEPARATOR);
                    if (!foundDepartment(parts[0]))
                    {
                        departments.Add(new Department(parts[0], parts[2]));
                        if (!departments.Last().foundMunicipality(parts[1]))
                        {
                            departments.Last().getMunicipalities().Add(new Municipality(parts[1], parts[3], parts[4]));
                        }
                    }
                }

            }
        }*/

        public void importFile(string file)
        {

            StreamReader streamReader = new StreamReader(file);
            string line;
            string[] parts;
            while ((line = streamReader.ReadLine()) != null)
            {

                parts = line.Split(SEPARATOR);

                Department dep = foundDepartment(parts[0]);
                if (dep == null)
                {
                    departments.Add(new Department(parts[0], parts[2]));
                    dep = departments.ElementAt(departments.Count - 1);
                }
                dep.getMunicipalities().Add(new Municipality(parts[1], parts[3], parts[4]));

            }
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

        public DataTable fillTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo del Dept.");
            dt.Columns.Add("Codigo del Municipio");
            dt.Columns.Add("Nombre del Dept.");
            dt.Columns.Add("Nombre del Municipio");
            dt.Columns.Add("Tipo");
            foreach(Department department in departments)
            {
                for (int i = 0;i < department.getMunicipalities().Count; i++)
                {
                    dt.Rows.Add(department.getCode(), department.getMunicipalities().ElementAt(i).getCode(), department.getName(), department.getMunicipalities().ElementAt(i).getName(), department.getMunicipalities().ElementAt(i).getType());
                } 
            }

            return dt;
        }

    }
}
