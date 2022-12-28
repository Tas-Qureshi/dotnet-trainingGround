using FluentAssertions;
using static TrainingGround.AgeCalculator;
namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    private AgeCalculator calculator {get; set;}
    public AgeCalculatorTests()
    {
        calculator = new AgeCalculator();   
    }
    [Fact]
    public void someone_born_1972_is_50_in_2022()
    {      
        // act
        var age = AgeCalculator.GetAge(1972,2022);

        // assert
        age.Should().Be(50);
        //Assert.Equal(50,age);
    }
    [Fact]
    public void someone_born_2022_is_0_in_2022()
    {
        // act 
        var age = GetAge(2022,2022);

        // assert
        Assert.Equal(0,age);
    }

}