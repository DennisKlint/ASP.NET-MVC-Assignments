using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayoutAndViewsAssignment2.Models
{
    static public class FeverCheckModels
    {

        static public string tempChecker(decimal temperature)
        {
            if (temperature >= Convert.ToDecimal("37,5"))
            {
                return ("You are not fine, your temperature is " + temperature + ", you have a fever.");
            }
            else if (temperature <= 35)
            {
                return "You are not fine, yor temperature is " + temperature + ", you have hypothermia.";
            }
            else
            {
                return "Your temperature is normal.";
            }
        } 
    }
}