using System;
/// <summary>
/// описание класса пользователя
/// </summary>
namespace NewFitnessApp
{

    public class User
    {

        private string NickName { get; set; }
        private string Password { get; set; }
        protected double DailyCalorieIntake;
        public string Name { get; }
        public DateTime BirthDay { get; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double TypePhysicalActivity { get; }
        public bool Gender { get; }//установка пола пользователя.1-мужчина.2-девушка
        public User(string NickName, string Password, string Name, DateTime BirthDay, double Weight, double Height, double TypePhysicalActivity, bool Gender)
        { //сделать проверку данных
            this.NickName = NickName;
            this.Password = Password;
            this.Name = Name;
            this.BirthDay = BirthDay;
            this.Weight = Weight;
            this.Height = Height;
            this.TypePhysicalActivity = TypePhysicalActivity;
            this.Gender = Gender;
        }

        public void CalculationDailyNormCalories(double Weight, double Height, double TypePhysicalActivity, DateTime BirthDay, double Gender)
        {
            if (Gender == 1)//для мужчин 
            {
                this.DailyCalorieIntake = (66 + (13.7 * Weight) + (5 * Height) - (6.8 * DateTime.Now.Year - BirthDay.Year)) * TypePhysicalActivity;
            }
            else//для девушек 
            {
                this.DailyCalorieIntake = (655.1 + (9.6 * Weight) + (1.8 * Height) - (4.7 * DateTime.Now.Year - BirthDay.Year)) * TypePhysicalActivity;
            }
        }
        public void IntakeFood(Products product)//реализация добавления приёма пищи.
        {
            double oneGram = product.CalloriesIn100Grams / 100;
            this.DailyCalorieIntake = this.DailyCalorieIntake - oneGram * product.Weight;
        }


    }



}

