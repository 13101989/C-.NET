﻿int thisCannotBeNull = 4;
//thisCannotBeNull = null; // compile error!
WriteLine(thisCannotBeNull);
int? thisCouldBeNull = null;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());
thisCouldBeNull = 7;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

// the actual type of int? is Nullable<int>
Nullable<int> thisCouldAlsoBeNull = null;
thisCouldAlsoBeNull = 9;
WriteLine(thisCouldAlsoBeNull);

Address address = new()
{
    Building = null,
    Street = null!,
    City = "London",
    Region = "UK"
};

WriteLine(address.Building?.Length);
WriteLine(address.Street?.Length);

// result will be 3 if authorName?.Length is null 
//int result = authorName?.Length ?? 3;
//Console.WriteLine(result);
