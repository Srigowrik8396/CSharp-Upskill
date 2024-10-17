// See https://aka.ms/new-console-template for more information
using ObjectOrientedProgramming;

Calculator calculator = new Calculator();
calculator.Add(10, 50);
calculator.Add(20, 50, 60);

Bus bus = new Bus(6);
bus.BusDetails();

SemiBus semiBus = new SemiBus(8);
semiBus.BusDetails();

Bus semiBusObj = new SemiBus(6);
semiBusObj.BusDetails();

SemiBus schoolBusObj = new SemiSchoolBus(4);
schoolBusObj.BusDetails();
schoolBusObj.BusCapacity();

Employee employee = new Employee(1, "Maxwell","Boss","Google", "GoogleDescription");
//employee.Salary();
employee.EmployeeSalaryDetails();
employee.CompanyDetails();
