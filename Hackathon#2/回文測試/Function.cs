using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon004
{
    public class Function
    {
        public bool Palindrome(string text)
        {
            int a = text.Length - 1;
            for (int i = 0; i < text.Length; )
            {
                if(text[i] == text[a])
                {
                    i++;
                    a--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
