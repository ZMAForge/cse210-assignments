class Program
{
    public static void Main()
    {
        Person myPerson = new Person("John", "Revalator", 50, 180.0);
        Console.WriteLine(myPerson.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Paine", 45, 279, "Knife");
        Console.WriteLine(myDoctor.GetPersonInformation());
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}