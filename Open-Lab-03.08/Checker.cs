using System;

namespace Open_Lab_03._08
{
    public class Checker
    {
        public bool IsPlural(string word)
        {
            bool mnoznecislo = word.EndsWith("s");
            return mnoznecislo;
        }
    }
}
