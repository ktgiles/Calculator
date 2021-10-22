using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Giles_Lab3
{
    class Calculator
    {
        public Calculator() //contstructor class? 
        {
              
        }

       public static string DoMath(string num1, string num2, string operation)
        {
            if (operation == "add")
            {
                decimal dec1 = GetDec(num1);
                decimal dec2 = GetDec(num2);
                decimal sum = dec1 + dec2;
                string value = sum.ToString();
                return value;
            }
            if (operation == "subtract")
            {
                decimal dec1 = GetDec(num1);
                decimal dec2 = GetDec(num2);
                decimal difference = dec1 - dec2;
                string value = difference.ToString();
                return value;
            }
            if (operation == "multiply")
            {
                decimal dec1 = GetDec(num1);
                decimal dec2 = GetDec(num2);
                decimal product = dec1 * dec2;
                string value = product.ToString();
                return value;
            }
            if (operation == "divide")
            {
                decimal dec1 = GetDec(num1);
                decimal dec2 = GetDec(num2);
                //prevent division by zero
                try 
                {
                    decimal quotient = Decimal.Divide(dec1, dec2);
                    string value = quotient.ToString();
                    return value;
                }
                catch (DivideByZeroException)
                {
                    return "Error, cannot divide by zero";
                }
                
            }
            if (operation == "sqrt")
            {
                double dub1 = double.Parse(num1);
                double sqrt = Math.Sqrt(dub1);
                string value = sqrt.ToString();
                return value;
            }
            return "error";    
        }
        public static decimal GetDec(string num)
        {
            Debug.WriteLine(num);
            decimal dec = Convert.ToDecimal(num);
            return dec;
        }
    }
}
