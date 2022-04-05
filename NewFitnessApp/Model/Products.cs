using System;
/// <summary>
/// класс реализует добавление нового продукта.
/// </summary>
namespace NewFitnessApp.Model
{
    public class Products
    {
        public string Name { get; }
        public double Weight { get; set; }//вес в граммах//сделать проверку 
        public double CalloriesIn100Grams { get; }
        public Products(string Name, double Weight, double CalloriesIn100Grams)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.CalloriesIn100Grams = CalloriesIn100Grams;
        }


    }
}
