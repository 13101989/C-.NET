using static System.Console;

TimesTable(7);
//TimesTable(8,20);

decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"You must pay {taxToPay:C} in tax.");
WriteLine("\n");

RunCardinalToOrdinal();
WriteLine("\n");

RunFactorial();
WriteLine("\n");

RunFibImperative();
WriteLine("\n");

RunFibFunctional();
WriteLine("\n");