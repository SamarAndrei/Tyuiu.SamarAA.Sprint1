using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SamarAA.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string[] str1 = value.Split(' ');
            string result = "";
            foreach(string word in str1)
            {
                string modifiedWord = word.Substring(1) + word[0];
                result += modifiedWord + " ";
            }
            result = result.TrimEnd(' ');
            return result;

        }
    }
}
