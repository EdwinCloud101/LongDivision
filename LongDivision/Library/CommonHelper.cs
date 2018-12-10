using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public static class CommonHelper
    {
        public static string AddText(string param, int times)
        {
            string toReturn = "";

            for (int i = 0; i < times; i++)
            {
                toReturn += param;
            }

            return toReturn;
        }
    }
}
