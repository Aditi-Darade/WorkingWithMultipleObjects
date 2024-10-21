using ClassLibrary1;

namespace Sec5_Assign12_WorkingWithMultipleObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans = "";
            string EmployeeNo = "";

            do
            {
                for (int i = 1; i < 100; i++)
                {
                    switch (i)
                    {
                        case 1: EmployeeNo = "First Employee"; break;
                        case 2: EmployeeNo = "Second Employee"; break;
                        case 3: EmployeeNo = "Third Employee"; break;
                        case 4: EmployeeNo = "Fourth Employee"; break;
                        case 5: EmployeeNo = "Fifth Employee"; break;
                        default: EmployeeNo = "Next Employee"; break;
                    }


                    System.Console.WriteLine(EmployeeNo);
                    //create object
                    Employee emp = new Employee();
                    System.Console.WriteLine("Please enter the following information:");
                    System.Console.WriteLine("EmpID: ");
                    emp.EmpID = int.Parse(System.Console.ReadLine());   //EmpID is declared as public in classlibrary then why isnt it accessible here? gives error if used directly and says it needs to be declared???????????????????
                    System.Console.WriteLine("EmpName: ");
                    emp.EmpName = System.Console.ReadLine();
                    System.Console.WriteLine("SalaryPerHour: ");
                    emp.SalaryPerHour = double.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("NoOfWorkingHours: ");
                    emp.NoOfWorkingHours = double.Parse(System.Console.ReadLine());
                    Employee.OrganizationName = "Harsha Inc.";



                    System.Console.WriteLine("EmpID: " + emp.EmpID + ", EmpName: " + emp.EmpName + ", SalaryPerHour: " + emp.SalaryPerHour + ", NoOfWorkingHours: " + emp.NoOfWorkingHours + ", Net Salary: " + emp.SalaryPerHour * emp.NoOfWorkingHours + ", OrganizationName: " + Employee.OrganizationName + ", TypeOfEmployee: " + Employee.TypeOfEmployee + ", DepartmentName: " + emp.DepartmentName);


                    System.Console.WriteLine("Do you want to continue to next employee?");

                    ans = System.Console.ReadLine();
                }
            }
            while (ans == "Yes" || ans == "yes" || ans == "y" || ans == "Y");
            

         

            System.Console.ReadKey();
        }
    }
}
