// See https://aka.ms/new-console-template for more information
using Manager;



 Managers manager = new Managers("Ali mohammadi",12000);

 List<Employee> employees = new List<Employee>()
{
    new Employee("Ahmad", 560),
    new Employee("farhad",800),
    new Employee("farid",1900)

};
while (true)
{
    foreach (Employee employee in employees)
    {
        employee.Deposit();

    }
    Thread.Sleep(4000);

    foreach(Employee employee in employees)
    {

        employee.SetWorking(8);
    }


}
