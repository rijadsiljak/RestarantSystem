using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Xml;
using System.Xml.Linq; 

namespace RestaurantSystem
{
    class XML
    {
        public static void saveAppetizer(Meal a)
        {
            XDocument xDoc = XDocument.Load("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Appetizer.xml");
            xDoc.Element("Appetizer").Add(new XElement("Meals", new XElement("name", a.getmealName()), new XElement("type", a.getmealType()),
                new XElement("price", a.getmealPrice().ToString()), new XElement("category", a.getmealCategory())));
            xDoc.Save("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Appetizer.xml");
        }
        public static void saveAlcoholic(Meal a)
        {
            XDocument xDoc = XDocument.Load("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Alcoholic.xml");
            xDoc.Element("Alcoholic").Add(new XElement("Meals", new XElement("name", a.getmealName()), new XElement("type", a.getmealType()),
                new XElement("price", a.getmealPrice().ToString()), new XElement("category", a.getmealCategory())));
            xDoc.Save("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Alcoholic.xml");
        }
        public static void saveDessert(Meal a)
        {
            XDocument xDoc = XDocument.Load("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Dessert.xml");
            xDoc.Element("Dessert").Add(new XElement("Meals", new XElement("name", a.getmealName()), new XElement("type", a.getmealType()),
                new XElement("price", a.getmealPrice().ToString()), new XElement("category", a.getmealCategory())));
            xDoc.Save("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Dessert.xml");
        }
        public static void saveHot(Meal a)
        {
            XDocument xDoc = XDocument.Load("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Hot.xml");
            xDoc.Element("Hot").Add(new XElement("Meals", new XElement("name", a.getmealName()), new XElement("type", a.getmealType()),
                new XElement("price", a.getmealPrice().ToString()), new XElement("category", a.getmealCategory())));
            xDoc.Save("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Hot.xml");
        }
        public static void saveMain(Meal a)
        {
            XDocument xDoc = XDocument.Load("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Main.xml");
            xDoc.Element("Main").Add(new XElement("Meals", new XElement("name", a.getmealName()), new XElement("type", a.getmealType()),
                new XElement("price", a.getmealPrice().ToString()), new XElement("category", a.getmealCategory())));
            xDoc.Save("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Main.xml");
        }
        public static void saveSalad(Meal a)
        {
            XDocument xDoc = XDocument.Load("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Salad.xml");
            xDoc.Element("Salad").Add(new XElement("Meals", new XElement("name", a.getmealName()), new XElement("type", a.getmealType()),
                new XElement("price", a.getmealPrice().ToString()), new XElement("category", a.getmealCategory())));
            xDoc.Save("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Salad.xml");
        }
        public static void saveSoft(Meal a)
        {
            XDocument xDoc = XDocument.Load("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Soft.xml");
            xDoc.Element("Soft").Add(new XElement("Meals", new XElement("name", a.getmealName()), new XElement("type", a.getmealType()),
                new XElement("price", a.getmealPrice().ToString()), new XElement("category", a.getmealCategory())));
            xDoc.Save("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Soft.xml");
        }
        public static void saveMeal(Meal a)
        {
            XDocument xDoc = XDocument.Load("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\Meals.xml");
            xDoc.Element("Restaurant").Add(new XElement("Meals", new XElement("name", a.getmealName()), new XElement("type", a.getmealType()),
                new XElement("price", a.getFinalPrice().ToString()), new XElement("category", a.getmealCategory())));
            xDoc.Save("C:\\Users\\PC\\Documents\\Visual Studio 2012\\Projects\\RestaurantSystem\\RestaurantSystem\\MEals.xml");
        }
       
       


    }
}
