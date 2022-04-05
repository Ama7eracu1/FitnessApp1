using System;

/// <summary>
/// класс,через который будет происходить управление
/// </summary>
namespace NewFitnessApp
{
   public class UserController
    {
        public User user {get;}
        public UserController(string userName,DateTime birthDay,double weight,double height,double typePhysicalActivity,bool gender,string password)
        {
            var user = new User(userName, birthDay, weight, height, typePhysicalActivity, gender, password);
        }
         //добавить запись в файл на выбор 
         //добавить добавление в бд на выбор 


    }
}
