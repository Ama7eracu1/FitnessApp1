using System;

namespace NewFitnessApp.Model
{
    public class Products
    {
        public string Name { get; }
        public double Weight { get; set; }//вес в граммах//сделать проверку 
        public double CalloriesIn100Grams { get; }
        public Products(string Name,double Weight,double CalloriesIn100Grams) {
        
        
        }


    }
}
