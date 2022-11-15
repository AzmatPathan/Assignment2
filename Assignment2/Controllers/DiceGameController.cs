using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class DiceGameController : ApiController
    {
        /// <summary>
        /// Determines number of ways 2 dice can roll total value of 10 
        /// </summary>
        /// <param name="m">first Dice total side</param>
        /// <param name="n">second Dice total side</param>
        /// <returns>Gives total ways of getting the sum of 10</returns>
        /// <example>
        /// GET -> api/J2/DiceGame/6/8 ----> There are 5 ways to get the sum 10
        /// GET -> api/J2/DiceGame/12/4----> There are 4 ways to get the sum 10
        /// GET -> api/J2/DiceGame/6/8 ----> There are 0 ways to get the sum 10
        /// GET -> api/J2/DiceGame/5/5 ----> There is 1 way to get the sum 10
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string GetDice(int m, int n)
        {
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        count++;
                    }
                }
            }
            if (count == 1)
            {
                return "There is "+count+" way to get the sum 10";
            }
            else
            {
                return "There are " + count + " ways to get the sum 10";
            }

        }
    }
}