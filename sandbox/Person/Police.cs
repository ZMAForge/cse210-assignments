
using System.Security.Cryptography;

class Police: Person
{
    private string _weapons;
    public Police(string firstname, string lastname, int age, double weight, string weapon)
    :base(firstname, lastname, age, weight)
    {
        _weapons = weapon;
    }

    public override string GetPersonInformation()
    {
        return $"Tools: {_weapons}, {GetPersonInformation()}";
    }

    public override double GetSalary()
    {
        return 550000.00;
    }
}