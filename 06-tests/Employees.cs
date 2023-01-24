using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_tests
{
    public class Program 
    {
        static void Main() 
        {
            Employees emp = new Employees();
            emp.add("Norbi", 2);
            emp.add("Fanni", 4);
            emp.add("Niki", 8);
            emp.add("Lili", 19);
            Statistics stat = new Statistics(emp);
        }
    }
    public class Employees
    {
        public List<int> IDs;
        public List<int> salaries;
        public List<string> names;
        public Employees() 
        {
            IDs = new List<int>();
            salaries = new List<int>();
            names = new List<string>();
        }
        public int add(string name, int salary) 
        {
            int ID = 0;
            if (IDs.Count != 0) 
            {
                ID = IDs.Count + 1;
            }
            IDs.Add(ID);
            salaries.Add(salary);
            names.Add(name);
            return ID;
        }
        public List<int> getAll() 
        {
            return IDs;
        }

        public string getName(int id) 
        {
            return names.ElementAt(id);
        }

        public int getSalary(int id) 
        {
            return salaries.ElementAt(id);
        }

        public void changeSalary(int id, int newSalary) 
        {
            salaries[id] = newSalary;
        }
    }

    public class Statistics
    {
        Employees employees_;
        public Statistics(Employees employees) 
        {
            employees_ = employees;
        }
        public int ComputeAverageSalary() 
        {
            List<int> salaries = employees_.salaries;
            int length = salaries.Count;
            int j = 0;
            foreach (int i in salaries) 
            {
                j += i;
            }
            return j / length;
        }

        public int getMinSalary() 
        {
            List<int> salaries = employees_.salaries;
            return salaries.Min();
        }

        public void printSalariesByName() 
        {
            List<int> salaries = employees_.salaries;
            List<string> names = employees_.names;
            for (int i = 0; i<names.Count; i++) 
            {
                Console.WriteLine(names[i] + " " + salaries[i]);
            }
        }
    }
}
