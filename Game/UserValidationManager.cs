using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1995 && gamer.FirstName == "Hilal" && gamer.LastName == "Çetindere" 
                && gamer.IdentityNumber == 12345678987 && gamer.Id == 1 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
