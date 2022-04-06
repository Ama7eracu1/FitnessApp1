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
       /*добавить реализацию записи в файл предварительно пропарсить его по введённому нику,если такой уже существует 
       потребовать пароль,если такого не существует,то запросить регистрацию.Сделать два варианта на выбор
            1)запись в файл2) в бд через энтитифраемворк*/
       void UserSafeOnFile(User user)
        {



        }

    }
}
