// See https://aka.ms/new-console-template for more information
using ObjectOrientedProgramming;

Calculator calculator = new Calculator();
calculator.Add(10, 50);
calculator.Add(20, 50, 60);

Bus bus = new Bus(6);
bus.BusDetail();

SemiBus semiBus = new SemiBus(8);
semiBus.BusDetail();

Bus semiBusObj = new SemiBus(60);
semiBusObj.BusDetail();

SemiBus schoolBusObj = new SemiSchoolBus(4);
schoolBusObj.BusDetail();
schoolBusObj.BusCapacity();

Employee employee = new Employee(1, "Maxwell","Boss","Google", "GoogleDescription");
//employee.Salary();
employee.EmployeeSalaryDetails();
employee.CompanyDetails();
