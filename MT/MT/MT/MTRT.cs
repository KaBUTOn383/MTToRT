using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mt
{
    public class MTRT
    {
        private static string MT;

        static void Main(string[] args)
        {
            while (true)
            {
                string militaryTime = Console.ReadLine();
                militaryTime = MilitaryTimeToRegularTime(militaryTime);


                Console.Write(militaryTime);
            }
        }
        public static string MilitaryTimeToRegularTime(string militaryTime)
        {
            string str  = new string(new char[8]);
            str = MT;
            string str1 = new string(new char[1]); ///hr
            string str2 = new string(new char[0]); ///:
            string str3 = new string(new char[1]); ///min

            int i = 0; ///5 data+am/pm
            int a = 0; ///hr
            int b = 0; ///:
            int c = 0; ///min

            for (i = 0; i < 5; i++)
            {
                if (i >= 0 && i <= 1)
                {
                    str1 = String(str1, a++, str[i]);
                }
                if (i == 2)
                {
                    str2 = String(str2, b++, str[i]);
                }
                if (i >= 3 && i <= 4)
                {
                    str3 = String(str3, c++, str[i]);
                }
            }
            str1 = String(str1, 2, '\0');
            str2 = String(str2, 1, '\0');
            str3 = String(str3, 2, '\0');

            if (str.Length != 5 || string.Compare(str2, ":") != 0)
            {

                Console.Write("error");
                Console.Write("\n");

                Environment.Exit(1);

            }
            for (i = 0; i < 5; i++)
            {

                if ((i >= 0 && i <= 1) || (i >= 3 && i <= 4))
                {

                    if (str[i] < 48 || str[i] > 57)
                    {

                        Console.Write("error");
                        Console.Write("\n");

                        Environment.Exit(1);

                    }

                }

            }
            if (Convert.ToInt32(str1) > 24 || Convert.ToInt32(str3) > 59)
            {

                Console.Write("error");
                Console.Write("\n");

                Environment.Exit(1);

            }
            string str4 = new string(new char[2]);

            string temp = new string(new char[1]);

            string temp1 = new string(new char[0]);

            string temp2 = new string(new char[0]);

            if (Convert.ToInt32(str1) >= 0 && Convert.ToInt32(str1) < 12)
            {

                str4 = " am";

                if (string.Compare(str1, "00") == 0)
                {

                    str1 = "12";

                }

            }

            else if (Convert.ToInt32(str1) >= 12 && Convert.ToInt32(str1) <= 24)
            {

                str4 = " pm";

                if (string.Compare(str1, "24") == 0)
                {
                    str1 = "12";
                }
                else if (Convert.ToInt32(str1) >= 13 && Convert.ToInt32(str1) <= 21)
                {

                    temp1 = " ";

                    itoa(Convert.ToInt32(str1) - 12, temp2, 10);

                    str1 = String(str1, 0, temp1[0]);

                    str1 = String(str1, 1, temp2[0]);

                }

                else if (Convert.ToInt32(str1) >= 22 && Convert.ToInt32(str1) <= 23)
                {

                    itoa(Convert.ToInt32(str1) - 12, temp, 10);

                    str1 = temp;

                }

            }

            str4 = String(str4, 3, '\0');

            a = 0;

            b = 0;

            c = 0;

            int TS = 0;

            for (i = 0; i < 8; i++)
            {

                if (i >= 0 && i <= 1)
                {

                    str = String(str, i, str1[a++]);

                }

                else if (i >= 5 && i <= 7)
                {

                    str = String(str, i, str4[TS++]);

                }

            }

            str = String(str, 8, '\0');
            return "";
        }

        private static string String(string str, int v1, char v2)
        {
            throw new NotImplementedException();
        }

        private static void itoa(int v1, string temp2, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
