using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    class Meal
    {
        private string mealName;
        private string mealCategory;
        private int mealPrice;
        private double FinalPrice;
        private string mealType;

        public Meal()
        { }
        public string getmealName()
        {
            return mealName;
        }
        public void setmealName(string n)
        {
            this.mealName = n;
        }

        public string getmealCategory()
        {
            return mealCategory;
        }
        public void setmealCategory(string n)
        {
            this.mealCategory = n;
        }

        public string getmealType()
        {
            return mealType;
        }
        public void setmealType(string n)
        {
            this.mealType = n;
        }

        public int getmealPrice()
        {
            return mealPrice;
        }
        public void setmealPrice(int a)
        {
            this.mealPrice = a;
        }
        public double getFinalPrice()
        {
            return FinalPrice;
        }
        public void setFinalPrice(double d)
        {
            this.FinalPrice = d;
        }

        public Meal(string mealName, string mealType, string mealCategory, int mealPrice,double FinalPrice)
        {
            this.mealCategory = mealCategory;
            this.mealName = mealName;
            this.mealPrice = mealPrice;
            this.mealType = mealType;
            this.FinalPrice = FinalPrice;
        }
    }
}
