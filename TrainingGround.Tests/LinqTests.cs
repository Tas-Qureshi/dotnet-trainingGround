public class LinqTests
{
    [Fact]
    public void loop_to_filer_numbers()
    {
        // arrange
        List<int> ints = new List<int>() { 20, 2, 44, 7, 8, 50, 22, 5, 0 };


        // act
        List<int> numbersLargerThan15 = new List<int>();
        foreach (var num in ints)
        {
            if (num > 15)
            {
                numbersLargerThan15.Add(num);
                continue;
            }
        }

        // assert
        Assert.Equal(4, numbersLargerThan15.Count);

    }
    [Fact]
    public void linq_to_filer_numbers()
    {
        // arrange
        List<int> numbers = new List<int>() { 20, 2, 44, 7, 8, 50, 22, 5, 0 };

        // act
        var numbersLargerThan15 = numbers.FindAll(c => c > 15);

        // assert
        Assert.Equal(4, numbersLargerThan15.Count);
    }
    [Fact]
    public void linq_to_find_first()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var firstNumberLargerThan15 = numbers.Find(number => number > 15);

        // assert
        Assert.Equal(53, firstNumberLargerThan15);
    }
    [Fact]
    public void linq_to_check_if_any_matches()
    {
        // arrange
        var numbers = new List<int> { 1, 51, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var anyOver100 = numbers.Any(number => number > 100);

        // assert
        Assert.Equal(false, anyOver100);
    }
    [Fact]
    public void filter_people_by_age()
    {
        // arrange
        var people = new List<Person> {
            new Person("Aaaron"),
            new Person("Bea"),
            new Person("Ceasar"),
            new Person("Dave"),
        };

        // act
        var allWithLongNames = people.Where(p => p.Name.Length > 4).ToList();

        // assert
        Assert.Equal(2, allWithLongNames.Count);
        Assert.Equal("Ceasar", allWithLongNames[1].Name);
    }
    public void filter_people_by_age_only_names()
    {
        // arrange
        var people = new List<Person> {
    new Person("Aaaron"),
    new Person("Bea"),
    new Person("Ceasar"),
    new Person("Dave"),
  };

        // act
        var allWithLongNames = people
          .Where(p => p.Name.Length > 4)
          .Select(p => p.Name)
          .ToList();

        // assert
        Assert.Equal(2, allWithLongNames.Count);
        Assert.Equal("Aaaron", allWithLongNames[0]);
        Assert.Equal("Ceasar", allWithLongNames[1]);
    }
    [Fact]
    public void filter_people_by_age_names_age()
    {
        // arrange
        var a = new Person("Aaaron");
        a.LengthInMeters = 1.96;
        var people = new List<Person> {
            a,
            new Person("Bea"),
            new Person("Ceasar"),
            new Person("Dave"),
        };

        // act
        var namesAndAges = people
          .Where(p => p.Name.Length > 4)
          .Select(p => new { Name = p.Name, Height = p.LengthInMeters })
          .ToList();

        // assert
        Assert.Equal(2, namesAndAges.Count);
        Assert.Equal("Aaaron", namesAndAges[0].Name);
        Assert.Equal(1.96, namesAndAges[0].Height);
    }
    [Fact]
    public void linq_to_sort_ascendingAndDescending_order()
    {
        // arrange
        var numbers = new List<int> { 1, 51, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var sortAscending = numbers.OrderBy(num => num);
        var sortDeAscending = numbers.OrderByDescending(num => num);

        // assert
        //Assert.Equal( 8 ,sortAscending);

    }
    [Fact]
    public void filter_people_by_age_names_age_query_syntax()
    {
        // arrange
        var a = new Person("Aaaron");
        a.LengthInMeters = 1.96;
        var people = new List<Person> {
            a,
            new Person("Bea"),
            new Person("Ceasar"),
            new Person("Dave"),
        };
        //act
        var peopleWithLongNames =
        from p in people
        where p.Name.Length > 4
        select new { Name = p.Name, Height = p.LengthInMeters };

        var queryPeopleWithTwoAs =
          from lp in peopleWithLongNames
          where lp.Name.ToLower().StartsWith("aa")
          select new { Name = lp.Name };

        var longNamedAAPeopleList = queryPeopleWithTwoAs.ToList();

        Assert.Equal(1, longNamedAAPeopleList.Count);
        Assert.Equal("Aaaron", longNamedAAPeopleList[0].Name);    
    }
}