using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Validation
{
    public class BasicValidation
    {

        static public bool SalaryValidate(string amount)
        {
            bool state = true;
            double number;

            state = double.TryParse(amount, out number);

            if (state == false)
            {
              //  Console.WriteLine("Invalid entry");
            }
            return state;
        }



        static public bool BNumberValidate(string bNumber)
        {
            bool state = true;
            string startYear = "14";

            if (bNumber.Length != 10)//check the legth
            {
                //Console.WriteLine("Invalid length");
                state = false;
            }
            else
            {

                if (bNumber[0] != startYear[0] || bNumber[1] != startYear[1]) //check the first two digits is the year of start
                {
                   // Console.WriteLine("Invalid Company date");
                    state = false;
                }
                else if (bNumber[5] != ' ') //check if the 6 spot in the string is a space proper format
                {
                   // Console.WriteLine("Invalid format");
                    state = false;
                }
                else
                {
                    int count = 0;
                    while (count < bNumber.Length) // check each string if it is a number
                    {
                        if (count != 5) // dont check the space
                        {
                            if (!(char.IsNumber(bNumber, count))) //check if it is a number
                            {
                                //Console.WriteLine("Invalid, only numbers allowed");
                                state = false;
                                break;

                            }

                        }
                        count++;
                    }
                }
            }

            return state;
        }


        static public bool SeasonValidate(string season)
        {
            bool state = false;

            if ((season.Equals("Winter", StringComparison.CurrentCultureIgnoreCase)))
            {
                state = true;
            }
            else if ((season.Equals("Spring", StringComparison.CurrentCultureIgnoreCase)))
            {
                state = true;
            }
            else if ((season.Equals("Summer", StringComparison.CurrentCultureIgnoreCase)))
            {
                state = true;
            }
            else if ((season.Equals("Fall", StringComparison.CurrentCultureIgnoreCase)))
            {
                state = true;
            }
            else
            {
                Console.WriteLine("Invalid Season");
                state = false;
            }


            return state;
        }

        static public bool sinValidator(string strSinNum)
        {
            bool bResult = false;
            //true for 111 111 111 , 111 111111 , 111111 111.
            Regex validator = new Regex(@"^\d{3}\s?\d{3}\s?\d{3}$");
            //bool run = true;

            string sinNumber = string.Empty;
            string sinNumber1 = string.Empty;

            int ii = 0;
            int jj = 0;
            int sum = 0;
            int sum1 = 0;
            int checkDigit = 0;

            int count = 0;


            sinNumber = strSinNum;

            if (sinNumber.Length == 0)
            {

                bResult = false;
            }
            else
            {
                if (validator.IsMatch(sinNumber))
                {
                    //removes the space from the sinNumer.
                    sinNumber1 = sinNumber.Replace(" ", "");

                    //Console.WriteLine("{0}", sinNumber1);
                    checkDigit = (int)Char.GetNumericValue(sinNumber[8]);

                    if (sinNumber1.Length == 9)
                    {
                        for (int i = 0; i < sinNumber1.Length - 1; i++)
                        {
                            if (i % 2 == 0)
                            {
                                jj = (int)Char.GetNumericValue(sinNumber1[i]);
                                sum1 += jj;
                            }
                            else
                            {
                                ii = (int)Char.GetNumericValue(sinNumber1[i]);
                                ii += ii;

                                if (ii > 9)
                                {

                                    int u = ii % 10;
                                    int l = ii / 10;
                                    ii = 0;
                                    sum += u + l;
                                }
                                else
                                {
                                    sum += ii;
                                }
                            }
                        }
                        sum += sum1;
                        for (int i = 0; i < sum; i += 10)
                        {
                            count++;
                        }

                        int gg = count * 10;
                        int kkk = gg - sum;
                        if (kkk == checkDigit)
                        {
                            // run = false;
                            bResult = true;
                        }
                        else
                        {
                            bResult = false;
                        }

                    }
                    else
                    {
                        //Console.WriteLine("Invalid sin");
                        bResult = false;
                    }
                }
                else
                {
                    // Console.WriteLine("Invalid pattern.");
                    bResult = false;
                }
            }
            Console.WriteLine("{0}", bResult);
            return bResult;
        }



        static public  bool stringValidator(string strArgv)
        {
            bool bResult = false;
            Regex validator = new Regex(@"^[a-zA-Z'.]{1,40}$");
            // bool run = true;
            string str = strArgv;



            if (str.Length == 0)
            {
               // Console.WriteLine("string is empty.");
                bResult = false;

            }
            else
            {
                if (validator.IsMatch(str))
                {
                    bResult = true;
                }
                else
                {
                    bResult = false;
                }
            }

            return bResult;
        }

        static public bool dateValidator(string strDate)
        {
            bool bResult = false;
            //bool run = true;
            DateTime dateValue;
            string str = strDate;





            if (str.Length == 0)
            {
                bResult = false;
            }
            else
            {
                if (DateTime.TryParse(str, out dateValue))
                {
                    //Console.WriteLine(dateValue.ToString());
                    // DateTime dateOnly = dateValue.Date;
                    //Console.WriteLine(dateOnly.ToString("yyyy-MM-dd"));
                    bResult = true;

                }
                else
                {
                    bResult = false;
                }
            }

            return bResult;

        }



    }
}
