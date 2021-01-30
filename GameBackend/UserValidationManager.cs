using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class UserValidationManager : IUserValidationManagerService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.BirthYear==1996 && gamer.FirstName == "BERKAY" && gamer.LastName == "ÖZDEMİR" && gamer.IdentityNumber == 12345) 
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
