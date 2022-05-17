using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t*****Welcome to Employee Wage Computation****\n");

            //create instance/object of class EmpWageComputatin
            //EmpWageComputation objEmp = new EmpWageComputation();

            // Calling Method/Function define in class EmpWageComputatin
            //objEmp.CalcEmpWage();


            //create instance/object of class EmpWageMultiCompanies
            EmpWageMultiCompanies objempcomp =new EmpWageMultiCompanies();

            // Calling Method/Function Define in EmpWageMultiCompanies
            objempcomp.Companies();



            Console.ReadKey();
        }
    }
}
