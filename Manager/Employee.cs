using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Manager;

public class Managers
{
    protected string name;
    protected int salary;

    public Managers(string Name , int Salary)
    {
        name = Name;
        salary = Salary;
    }
    public void ReceiveworkingHour(int workingHour)
    {
        Console.WriteLine("manager received working hour;"+workingHour);
    }
    public  void Deposit()
    {
        Console.WriteLine("Manager {0} deposited {1} to each employee",name,salary);

    }
    public void REceiveWorking(int workingHour) 
    {
        Console.WriteLine("Manager{0} receive working hours:{1} ",name ,workingHour);
    
    }


}
public class Employee : Managers
{
    private int workingHours;
   

   
    public Employee(string  employeeName , int employeesalary):
        base(employeeName , employeesalary)
    {

        workingHours = 0;
        
            
    }
   

    public  void Deposit()
    {
        Console.WriteLine("Employee {0} received",name , salary);

    }
  public void SetWorking(int hours)
    { workingHours = hours;

      base.ReceiveworkingHour(workingHours);
    
    
    
    }

}
