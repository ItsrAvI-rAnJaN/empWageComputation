using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class EmpWageMultiCompanies
    {
        // Taking Const variable to Guess Emp is Fill or Time Part
        const int Is_Part_Time = 1;
        const int Is_Full_Time = 2;    

        // Defining Parametrized Method
        public static void EmpWage(string Company, int EmpRatePerHrs, int NumofWorkinDays, int MaxHrsInMnth)
        {
            int EmpHrs = 0;
            int TotalEmpHrs = 0;
            int totalWorkingDays = 0;

            // define Logic  if maxhrs in month & Total workin Days Define condition True Till While Loop Run...
            while (TotalEmpHrs < MaxHrsInMnth && totalWorkingDays < NumofWorkinDays)
            {
                totalWorkingDays++;

                // Create instance of Random Class 
                Random random = new Random();

                //use Random Instance/Object to Genrate 0,1,2 & Store in variable EmpCheck Variable..
                int empCheck = random.Next(0, 3);

                // Using Switch Method to Check Emp is Full or part Time & Get Working Hours of Emp....
                switch (empCheck)
                {
                    case Is_Full_Time:
                        EmpHrs = 8;
                        break;
                    case Is_Part_Time:
                        EmpHrs = 4;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }
                TotalEmpHrs += EmpHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + EmpHrs);

                // using if Block to Print if reached Condition Working hrs & Working Days in a Month
                if (TotalEmpHrs == MaxHrsInMnth)
                {
                    Console.WriteLine("Total Working Hours Condition has reached = " + MaxHrsInMnth + " Hrs");
                }
                if (totalWorkingDays == NumofWorkinDays)
                {
                    Console.WriteLine("Total Working Days Condition has reached = " + NumofWorkinDays + " days");
                }
            }
            // printing Total Wages Of Employee
            int TotalEmpWage = TotalEmpHrs * EmpRatePerHrs;
            Console.WriteLine("Total Employee Wage of {0} Company is {1}" , Company,TotalEmpWage);
        }
        // Calling Method or Giving Parameter
        public void Companies()
        {
            EmpWage("Google", 500, 20, 100);
            EmpWage("Microsoft", 500, 20, 100);
            EmpWage("Alphabet", 500, 20, 100);
        }
    }
}
