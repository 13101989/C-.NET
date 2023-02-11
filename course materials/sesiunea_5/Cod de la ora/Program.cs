// See https://aka.ms/new-console-template for more information


namespace ClassDemo
{
    class Program
    {
        static void Main()
        {
            Utilizator gicu = new Utilizator("Gicu", "IT", 25);
            Utilizator ana = new Utilizator("Ana", "IT", 26);
            ana.Buddy = gicu;

            Console.WriteLine(gicu.SayHello());
            Console.WriteLine(ana.SayHello());

            Console.WriteLine($"{gicu.GetName()} works in {gicu.Department}");
            //gicu.SetDepartment("HR");
            gicu.Department = "HR";
            Console.WriteLine($"{gicu.GetName()} works in {gicu.Department}");
            Console.WriteLine($"{ana.GetName()} works in {ana.Department}");

            Console.WriteLine($"{ana.Buddy.GetName()} is buddy for {ana.GetName()}");


            var isUnder26 = gicu.age < 26 ? "Gicu is under 26" : "Gicu is not under 26";
            if (gicu.age < 26)
            {
                isUnder26 = "Gicu is under 26";
            } 
            else
            {
                isUnder26 = "Gicu is not under 26";
            }
        }

    }
}
