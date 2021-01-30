using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface IUserValidationManagerService
    {
        bool Validate(Gamer gamer);
    }
}
