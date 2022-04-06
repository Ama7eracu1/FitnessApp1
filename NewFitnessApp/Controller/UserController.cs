using System;

/// <summary>
/// класс,через который будет происходить управление
/// </summary>
namespace NewFitnessApp
{
    public class UserController
    {
        public User user { get; }
        public UserController(string nickName, string password, string userName, DateTime birthDay, double weight, double height, double typePhysicalActivity, bool gender)
        {
            //сделать проверки данных

            var user = new User(nickName, password, userName, birthDay, weight, height, typePhysicalActivity, gender);
        }
        //добавить запись в файл на выбор 
        //добавить добавление в бд на выбор 


    }
}
