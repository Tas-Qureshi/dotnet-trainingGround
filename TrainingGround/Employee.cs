public class Employee : Person, IPrintable
{
    public string? EmployeeId { get; set;}
    public List<Address> Addresses ;
    public Employee()
    {
        Addresses = new List<Address>();
    }
    public Employee(string name, string employeeId) : base(name)
    {
        Addresses = new List<Address>();
        this.EmployeeId = employeeId;
    }


    public string GetStringPrint()
    {
        return @$"{this.Name} ({this.EmployeeId})
        {this.Address.Street}
        {this.Address.StreetNo}
        {this.Address.City}
        ";
    }

}