using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class GamerManager : IGamerManagerService
    {
        IUserValidationManagerService _userValidationManager;

        public GamerManager(IUserValidationManagerService userValidationManager)  //GamerManager'ın içinde bir doğrulama servisini kullanacağımızı söylüyoruz.
        {
            _userValidationManager = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationManager.Validate(gamer))
            {
                Console.WriteLine("Kayıt olundu.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
