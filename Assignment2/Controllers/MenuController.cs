using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class MenuController : ApiController
    {
        /// <summary>
        /// Computes the total calorie of the meal ordered(burger,drink,side,dessert)
        /// </summary>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <param name="drink"> Integer representing the index drink choice</param>
        /// <param name="side"> Integer representing the index side choice</param>
        /// <param name="dessert"> Integer representing the index dessert choice</param>
        /// <returns>Returns total calorie count selected by user for a meal</returns>
        /// <example>
        /// GET api/J1/Menu/4/4/4/4----> Your total calorie count is 0
        /// GET api/J1/Menu/1/2/3/4---->Your total calorie count is 691
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
      public string GetOrder(int burger,int drink ,int side, int dessert)
        {
            int burgerCalorie = NewMethod(burger);
            int drinkCalorie = DrinkCalorie(drink);
            int sideCalorie = SideCalorie(side);
            int dessertCalorie = DessertCalorie(dessert);

            int totalCalore = burgerCalorie+ sideCalorie+drinkCalorie+dessertCalorie;
            return "Your total calorie count is "+ totalCalore;
        }

        private static int NewMethod(int burger)
        {
            int burgerCalorie;
            switch (burger)
            {
                case 1: burgerCalorie = 461; break;
                case 2: burgerCalorie = 431; break;
                case 3: burgerCalorie = 420; break;
                default: burgerCalorie = 0; break;

            }

            return burgerCalorie;
        }

        private static int DrinkCalorie(int drink)
        {
            int calorie;
            switch (drink)
            {
                case 1: calorie = 130; break;
                case 2: calorie = 160; break;
                case 3: calorie = 118; break;
                default: calorie = 0; break;

            }

            return calorie;
        }

        private static int SideCalorie(int side)
        {
            int calorie;
            switch (side)
            {
                case 1: calorie = 100; break;
                case 2: calorie = 57; break;
                case 3: calorie = 70; break;
                default: calorie = 0; break;

            }

            return calorie;
        }

        private static int DessertCalorie(int dessert)
        {
            int calorie;
            switch (dessert)
            {
                case 1: calorie = 167; break;
                case 2: calorie = 266; break;
                case 3: calorie = 75; break;
                default: calorie = 0; break;

            }

            return calorie;
        }
    }
}