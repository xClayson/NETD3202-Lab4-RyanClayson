/*
 * Name: Ryan Clayson
 * Date: 11/20/2020
 * Purpose: Textbook class that sets/gets attributes of a textbook
 *          Calculate Appraisal
 *          Print out appraisal message
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETD3202_Lab4_RyanClayson.Models
{
    public class Textbook
    {
        //Declaration of data members and Getters and Setters for Textbook
        public string title { get; set; }

        public int isbn { get; set; }

        public double version { get; set; }

        public double price { get; set; }

        public string condition { get; set; }

        //Default constructor 
        public Textbook()
        {

        }

        //Parameterized constructor
        public Textbook(string title, int isbn, double version, double price, string condition)
        {
            this.title = title;
            this.isbn = isbn;
            this.version = version;
            this.price = price;
            this.condition = condition;
        }
        /// <summary>
        /// Depending on what the user has selected as the condition. Calculate appraisalusing 3 conditions (Bad, Good, New)
        /// </summary>
        /// <param name="price"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public double CalculateAppraisal(double price, string condition)
        {
            //Formula to calculate appraisal price
            //If condition is Bad
            if (condition == "Bad")
            {
                return Math.Round((price / 4), 2);
            }
            //If condition is Good
            if (condition == "Good")
            {
                return Math.Round((price / 3), 2);
            }
            //If condition is LikeNew
            else
            {
                return Math.Round((price / 2), 2);
            }
        }

        /// <summary>
        /// To String Method used to display the user's input when Appraised
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return "Your textbook: " + title + ",  Version " + version + ", was appraised at: $" +
                   CalculateAppraisal(price, condition);
        }
    }
}