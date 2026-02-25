// person -> employee(base, Salary)

class Employee : Person
{
    public Employee(string name, int age, decimal salary)
    : base(name, age)
    {
        this.Salary = salary;
    }

    public decimal Salary { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}, Salary : {this.Salary}$";
    }
}
