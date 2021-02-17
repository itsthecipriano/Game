using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

            public GamerManager(IUserValidationService userValidationService) 
        {
            _userValidationService = userValidationService;
        }
        
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true )
            {
                Console.WriteLine("Signed Up");
            }
            else
            {
                Console.WriteLine("Verification is unseccessful");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("User Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("User Updated");
        }
    }
}
