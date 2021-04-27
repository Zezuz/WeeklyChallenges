using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            var arr = vals.Contains(false);
            return arr;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return false;
            }
            
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
                
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            return false;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //var isLower = false;
            //var isUpper = false;
            //var isNumber = false;

            //for (int i = 0; i < password.Length; i++)
            //{
            //    if (char.IsLower(password[i])) 
            //    {
            //        isLower = true;
            //    }
            //    if (char.IsUpper(password[i]))
            //    {
            //        isUpper = true;
            //    }
            //    if (char.IsNumber(password[i]))
            //    {
            //        isNumber = true;
            //    }
            //}

            //if (isLower && isUpper && isNumber)
            //{
            //    return true;
            //}
            //else 
            //{
            //    return false;
            //}

            return password.Any(char.IsNumber);
                   password.Any(char.IsUpper);
                   password.Any(char.IsLower);
        }

        public char GetFirstLetterOfString(string val)
        {
            char c = val.FirstOrDefault();
            return c;

            //return val[0]; a string is just an array and it can be accessed via brackets
        }

        public char GetLastLetterOfString(string val)
        {
            char c = val.Last();
            return c;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;

            //if (divisor == 0)
            // return 0;
            //else
            // return dividend/divisor;

        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            int oddIncrement = 1;
            int[] x = new int[50];
            for (int i = 0; i < 50; i++)
            {
                x[i] = oddIncrement;
                oddIncrement += 2;
            }
            return x;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            foreach (var word in words)
            {
                word.ToUpper();
            }

            //for (int i = 0; i < words.Length; i++)
            //{
            //    words[i] = words[i].ToUpper();
            //}
        }
    }
}
