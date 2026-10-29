
using System.Security.Cryptography;

class Police: Person
{
    private string _weapons;
    public Police(string firstname, string lastname, int age, double weight, string weapon)
    :base(firstname, lastname, age, weight)
    {
        _weapons = weapon;
    }

    public string GetPoliceInformation()
    {
        return $"Tools: {_weapons}, {GetPersonInformation()}";
    }
}