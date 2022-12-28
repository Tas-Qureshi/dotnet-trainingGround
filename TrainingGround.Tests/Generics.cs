public class Generics
{
    [Fact]
    public void lists_can_hold_anything()
    {

        // arrange
        var intList = new List<int>();
        var stringList = new List<string>();
        var addressList = new List<Address>();

        // act
        intList.Add(1); intList.Add(2); intList.Add(3);
        stringList.Add("1"); stringList.Add("2"); stringList.Add("3");
        addressList.Add(new Address() { Street = "Street", StreetNo = 1 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 2 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 3 });

        // assert
        Assert.IsType<int>(intList[0]);
        Assert.IsType<string>(stringList[2]);
        Assert.IsType<Address>(addressList[1]);
        Assert.IsNotType<int>(addressList[0]);

    }
    [Fact]
    public void an_employee_have_more_than_one_address()
    {
        // arrange
        var emp = new Employee("Marcus", "DBCSAS-1253");

        // act
        emp.Addresses.Add(new Address() { Street = "Work street", StreetNo = 2, City = "Stockholm" });
        emp.Addresses.Add(new Address() { Street = "Vacation street", StreetNo = 2, City = "Honolulu" });

        // assert
        Assert.Equal(2, emp.Addresses.Count);
    }
}