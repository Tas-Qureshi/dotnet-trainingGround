using TrainingGround;
//using static TrainingGround.AgeCalculator;

public class ConditionalTests
{
    [Fact]
    public void should_be_kid_when_younger_than_18()
    {
        // arrange
        var p = new Person(2005);

        // act
        var category = AgeCalculator.GetAgeCategory(p, 2022);

        // assert
        Assert.Equal(AgeCategory.Kid, category);
    }

    [Fact]
    public void when_50_then_prime_Age()
    {
        // arrange
        Person p = new Person(1972);

        // act
        var category = AgeCalculator.GetAgeCategory(p, 2022);

        // assert
        Assert.Equal(AgeCategory.Prime, category);

    }
    // XUnit Theory and InlineDataAttribute 
    [Theory]
    [InlineDataAttribute(AgeCategory.Kid, "Under 18 years")]
    [InlineDataAttribute(AgeCategory.Adult, "Above 18")]
    [InlineDataAttribute(AgeCategory.Prime, "Exactly 50 - and proud!")]
    public void return_under_18_for_kid(AgeCategory ageCategory, string expectedResult)
    {
        // arrange

        // act
        var span = AgeCalculator.GetAgeSpan(ageCategory);
        
        // assert
        Assert.Equal(expectedResult, span);
    }

    // [Fact]
    // public void return_Over_49_for_Prime()
    // {
    //     // act
    //     var span = AgeCalculator.GetAgeSpan(AgeCategory.Prime);
    
    //     // assert
    //     Assert.Equal("Exactly 50 - and proud!", span);
    // }
}