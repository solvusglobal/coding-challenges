class Employee:
    def __init__(self, name, employee_type, hours_worked, hourly_rate, bonus=0):
        self.name = name
        self.type = employee_type
        self.hours_worked = hours_worked
        self.hourly_rate = hourly_rate
        self.bonus = bonus


class PayrollCalculator:
    def calculate_salary(self, employee):
        salary = 0

        if employee.type == "FullTime":
            salary = employee.hours_worked * employee.hourly_rate + employee.bonus
        elif employee.type == "PartTime":
            salary = employee.hours_worked * employee.hourly_rate
        elif employee.type == "Intern":
            salary = employee.hours_worked * (employee.hourly_rate / 2)

        return salary


if __name__ == "__main__":
    employees = [
        Employee(name="John", employee_type="FullTime", hours_worked=40, hourly_rate=25, bonus=500),
        Employee(name="Jane", employee_type="PartTime", hours_worked=20, hourly_rate=20, bonus=0),
        Employee(name="Alice", employee_type="Intern", hours_worked=30, hourly_rate=15, bonus=0)
    ]

    payroll_calculator = PayrollCalculator()

    for employee in employees:
        print(f"{employee.name}'s salary: {payroll_calculator.calculate_salary(employee)}")
