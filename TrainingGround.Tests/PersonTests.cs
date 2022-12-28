public class PersonTests
{
    // arrange
    
   
   
    [Fact]
    public void create_person_using_parameterless_constructor()
    {
        // act 
        var p = new Person("Tas");

        // assert
        Assert.NotNull(p);
        Assert.Equal("Tas", p.Name);
    }
    // XUnit Theory and InlineDataAttribute 
    [Theory]
    [InlineData(1972, 2022 , 50)]
    [InlineData(1982, 2022, 40)]
    [InlineData(1992, 2022, 30)]
    [InlineData(2022, 2022, 0)]
    public void a_person_born_1972_is_50_2022(int birthYear, int currentYear, int expectedResult)
    {
        // act
        Person p = new(birthYear);
        var age = p.GetAge(currentYear);

        // assert
        Assert.Equal(expectedResult, age);
    }

    // [Fact]
    // public void a_person_born_1982_is_40_2022()
    // {
    //     // act
    //var personBornIn1982 = new Person(1982);
    //     var age = personBornIn1982.GetAge(2022);

    //     // assert
    //     Assert.Equal(40, age);
    // }

    [Fact]
    public void an_employee_is_a_person()
    {
        //act
        var emp = new Employee();
        emp.LengthInMeters = 1.95D;

        // assert
        Assert.IsType(typeof(Employee), emp);
        Assert.Equal(1.95, emp.LengthInMeters);
    }
    [Fact]
    public void an_employee_has_an_employeeId()
    {
        // act
        var emp = new Employee("Tas", "124-BDAS");

        // assert

        Assert.IsType(typeof(Employee), emp);
        Assert.Equal("Tas", emp.Name);
        Assert.Equal("124-BDAS", emp.EmployeeId);
    }
    [Fact]
    public void a_person_has_an_address()
    {
        // arrange
        var p = new Person("Marcus");

        // act
        p.Address = new Address();
        p.Address.Street = "A Street";
        p.Address.StreetNo = 23;
        p.Address.City = "Stockholm";

        // assert
        Assert.NotNull(p.Address);
        Assert.IsType(typeof(Address), p.Address);

        Assert.Equal("A Street", p.Address.Street);
        Assert.Equal(23, p.Address.StreetNo);
        Assert.Equal("Stockholm", p.Address.City);
    }
    [Fact]
    public void an_employee_gets_a_nice_printed_address()
    {
        // arrange
        Employee emp = new Employee("Tas", "124-BDAS");
        emp.Address = new Address();
        emp.Address.Street = "A Street";
        emp.Address.StreetNo = 23;
        emp.Address.City = "Stockholm";
        //var p = new Person();
        // act
        var printString = emp.GetStringPrint();

        // assert
        Assert.Equal(@"Tas (124-BDAS)
        A Street
        23
        Stockholm
        ", printString);
    }
    public void Print(IPrintable printable)
    {
        var printString = printable.GetStringPrint();
        Console.WriteLine(printString);
    }


    [Fact]
    public void can_print_printables()
    {
        // arrange
        var emp = new Employee("Ossian", "234-BDAS");
        emp.Address = new Address();
        emp.Address.Street = "B Street";
        emp.Address.StreetNo = 22;
        emp.Address.City = "Malmö";

        var p = new Person("Tas");
        p.Address = new Address();
        p.Address.Street = "A Street";
        p.Address.StreetNo = 23;
        p.Address.City = "Stockholm";

        // act
        this.Print(p);
        this.Print(emp);
    }

}