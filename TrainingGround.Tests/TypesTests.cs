public class TypesTests
{
    [Fact]
    public void reference_types_can_be_changed_via_reference()
    {
        // arrang
        Person a = new Person("Person a");
        a.LengthInMeters = 1.95D;
        Person b = a;

        // act
        b.LengthInMeters = 1.96D;

        // assert
        Assert.Equal(1.96, b.LengthInMeters);
        Assert.Equal(1.96, a.LengthInMeters);

    }
}