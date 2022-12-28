public class TypesClass
{
    [Fact]
public void getting_age_from_person()
{
  // arrange
  var p = new Person(1972);

  // act
  var age = p.GetAge(2022);

  // assert
  Assert.Equal(50, age);
  Assert.IsType(typeof(Person), p);
  Assert.IsType(typeof(int), age);
}
}