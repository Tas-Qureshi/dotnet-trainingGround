public class CollectionTests
{
    [Fact]
    public void an_array_has_a_length()
    {
        // act
        int[] arrayOfIntegers = new int[5];
        int[] arrayOfIntegersWithValues = new int[] { 1, 2, 4, 5 };
        string[] arrayOfStrings = new String[] { "Name 1", "Name 2" };
        var testArray = new string[] { "Name1" };
        int[] a = { 1, 3, 5 };

        // assert
        Assert.Equal(5, arrayOfIntegers.Length);
        Assert.Equal(4, arrayOfIntegersWithValues.Length);
        Assert.Equal(2, arrayOfStrings.Length);
    }
    [Fact]
    public void getting_items_out_()
    {
        // act
        string[] arrayOfStrings = new String[] { "Name 1", "Name 2" };

        // assert
        Assert.Equal("Name 1", arrayOfStrings[0]);
        Assert.Equal("Name 2", arrayOfStrings[1]);

    }

    [Fact]
    public void showing_object_initializer()
    {
        // act
        var a = new Address();
        a.Street = "B Street";
        a.StreetNo = 22;
        a.City = "Malmö";

        var b = new Address
        {
            Street = "B Street",
            StreetNo = 22,
            City = "Malmö"
        };

        // assert
        Assert.Equal(a.Street, b.Street);
        Assert.Equal(a.StreetNo, b.StreetNo);
        Assert.Equal(a.City, b.City);
    }
    [Fact]
    public void a_list_of_integers_is_very_flexible()
    {
        // arrange
        //List<int> integerList = new List<int> {1,2,3};
        List<int> integerList = new List<int>();
        
        // act
        integerList.Add(1);
        integerList.Add(2);
        integerList.Add(3);
        //integerList.Remove(1); it weill remove the value 1
        integerList.RemoveAt(0); // it will remove whatever value is at index 0

        // assert
        Assert.Equal(2 ,integerList.Count);
        Assert.Equal(2, integerList[0]);
        Assert.Equal(3, integerList[1]);
    }
}