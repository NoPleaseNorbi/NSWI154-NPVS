using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Employee_tests;
using System.IO;

namespace EmployeeTests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Test_1_Average_Salary()
        {
            Employees emp = new Employees();
            emp.add("Norbi", 2);
            emp.add("Fanni", 4);
            emp.add("Niki", 8);
            emp.add("Lili", 19);
            Statistics stat = new Statistics(emp);
            Assert.AreEqual((2 + 4 + 8 + 19) / 4, stat.ComputeAverageSalary());
        }

        [TestMethod]
        public void Test_2_Min_Salary()
        {
            Employees emp = new Employees();
            emp.add("Norbi", 2);
            emp.add("Fanni", 4);
            emp.add("Niki", 8);
            emp.add("Lili", 19);
            Statistics stat = new Statistics(emp);
            Assert.AreEqual(2, stat.getMinSalary());
        }

        [TestMethod]
        public void Test_3_Write_Out()
        {
            Employees emp = new Employees();
            emp.add("Norbi", 2);
            emp.add("Fanni", 4);
            emp.add("Niki", 8);
            emp.add("Lili", 19);
            Statistics stat = new Statistics(emp);
            
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            stat.printSalariesByName();
            Assert.AreEqual("Norbi 2\r\nFanni 4\r\nNiki 8\r\nLili 19\r\n", stringWriter.ToString());
        }
    }
}
