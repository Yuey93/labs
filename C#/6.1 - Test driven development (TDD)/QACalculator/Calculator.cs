using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator
{
    public class Calculator
    {
        public double Calc(string input)
        {
            double result = 0;
            if (input == "")
            {
                return result;
            }
            else if (input.Contains("+") || input.Contains(",") || input.Contains("\n"))
            {
                input = input.Contains("\n") ? input.Replace("\n", ",") : input;
                result = Add(input);
            }
            //else if (input.Contains("-"))
            //{
            //    result = Subtract(input);
            //}
            //else if (input.Contains("*"))
            //{
            //    result = Multiply(input);
            //}
            //else if (input.Contains("/"))
            //{
            //    result = Divide(input);
            //}
            else
            {
                var isNum = double.TryParse(input, out result);
                if (isNum)
                {
                    result = double.Parse(input);
                }
                else
                {
                    return result;
                }
            }
            return result;
        }

        public int Divide(String n1)
        {
            int result = 0;
            char separator = ',';
            // if doesn't contain a comma call this
            if (!n1.Contains(","))
                separator = Utils.ValidSeperator(n1);    // slows down test
            String[] numbers = n1.Split(separator);
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) / Utils.ToNumber(numbers[1]);
            return result;
        }

        public int Multiply(String n1)
        {
            int result = 0;
            String[] numbers = n1.Split(',');
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {  // check number is valid
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) * Utils.ToNumber(numbers[1]);
            return result;
        }

        public int Subtract(String n1)
        {
            int result = 0;

            String[] numbers = n1.Split(',');
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {  // check number is valid
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) - Utils.ToNumber(numbers[1]);
            return result;
        }

        public int Add(String n1)
        {
            int result = 0;
            String[] numbers = n1.Split(',');
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {  // check number is valid
                    return result;
                }
                else
                {
                    result += Utils.ToNumber(number);
                }
            }
            //result = Utils.ToNumber(numbers[0]) + Utils.ToNumber(numbers[1]);
            return result;
        }
    }
}
