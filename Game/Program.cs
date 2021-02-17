using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1995,
                FirstName = "Hilal",
                LastName = "Çetindere",
                IdentityNumber = 12345678987
            });
        }
    }
}
