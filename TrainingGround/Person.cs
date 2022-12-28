public class Person : IPrintable
{
    public string? Name { get; private set; }
    public int BirthYear { get; private set; }
    public double LengthInMeters { get; set; }
    public Address Address { get; set; } = null!;
    public Person()
    {
    }
    public Person(string name)
    {
        this.Name = name;
    }
    public Person(int birthYear)
    {
        this.BirthYear = birthYear;
    }
    public int GetAge(int currentYear)
    {
        //return currentYear - this.BirthYear;
        var age = currentYear - this.BirthYear;
        if (age < 0)
        {
            throw new Exception("Not born yet");
        }
        return age;
    }

    public string GetStringPrint()
    {
        return @$"{this.Name}
        {this.Address.Street}
        {this.Address.StreetNo}
        {this.Address.City}
        ";
    }
}