Step 1: Create a class library and console application. Add reference of class library into console application.



Step 2: Create a class called Employee in the class library with fields EmpID, EmpName, SalaryPerHour, NoOfWorkingHours and NetSalary. Additionally, add the following fields:

    - A static field called OrganizationName. It should be initialized as "Harsha Inc." in Main method.

    - A constant field called TypeOfEmployee and initialize it as "Contract Based" along with declaration.

    - A readonly field called DepartmentName and initialize it as "Finance Department" in constructor.



Step 3: Create up to 5 objects of Employee class in the console application. Read each employee details (EmpID, EmpName, SalaryPerHour, NoOfWorkingHours) from the user (from the keyboard) using loop.

Calculate net salary (SalaryPerHour * NoOfWorkingHours).

And display the all details of the same object (including EmpID, EmpName, SalaryPerHour, NoOfWorkingHours, NetSalary, OrganizationName, TypeOfEmployee, DepartmentName) and then ask the user 'Do you want to continue to next employee'.

If the user choose 'Yes', proceed to the next employee; otherwise stop the loop.
