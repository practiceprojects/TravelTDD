using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTDD
{
    public class Travel
    {
        public Travel()
        {
            //DEFAULT CONSTRUCTOR
        }

        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public string GetDate(int month, int date, int year)
        {
            month = 9;
            date = 8;
            year = 2018;

            string getdate;
            getdate = month + "/" + date + "/" + year;

            return getdate;
        }

        public int TtlTravel(int num)
        {
            return 5;
        }

        public string GetSelection(int place)
        {

            if (place == 5) {
                return "Cali";
            }
            if (place == 4)
            {
                return "Georgia";
            }
            if (place == 3)
            {
                return "Florida";
            }
            if (place == 2)
            {
                return "Nashville";
            }
            if (place == 1)
            {
                return "Put In Bay";
            }
            if (place == 0)
            {
                return "Go Home";
            }
            if(place > 5)
            {
                return "The World Is Yours";
            }
            else
            {
                return "hi";
            };
        }

        //public int TtlTravel (int month, int date, int year)
        //{
        //    var datestring = "9/8/2018";
        //    string[]datestringone = datestring.Split('/');
        //    int[]datestringtwo = int
        //        //set datestringtwo to int array with month, date, and year
        //        //make a for loop to set the int array to the string array?
        //}






































































    } //TRAVEL CLASS
}