public class ValueTypesTests
{
    [Fact]
    public void value_types_cannot_be_changed_via_reference()
    {
        // arrange
        double aLengthInMeters = 1.95;
        double bLengthInMeters = aLengthInMeters;

        // act
        bLengthInMeters = 1.96;

        // assert
        Assert.Equal(1.96, bLengthInMeters);
        Assert.Equal(1.95, aLengthInMeters);
    }
}