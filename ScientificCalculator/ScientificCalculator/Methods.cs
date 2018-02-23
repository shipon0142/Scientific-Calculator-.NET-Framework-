using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculator
{
    class Methods
    {
        public double pi = 3.141592653599;

        public double tann(double theta)
        {
            return Math.Tan(theta * (Math.PI / 180));
        }
        public double sinn(double theta)
        {
            return Math.Sin(theta * (Math.PI / 180));
        }
        public double coss(double theta)
        {
            return Math.Cos(theta * (Math.PI / 180));
        }
        public double tan_inverse(double theta)
        {
            return Math.Atan(theta )* (180 / Math.PI);
        }
        public double sin_inverse(double theta)
        {
            return Math.Asin(theta) * (180 / Math.PI);
        }
        public double cos_inverse(double theta)
        {
            return Math.Acos(theta) * (180 / Math.PI);

        }
        public double logg(double theta)
        {
            return Math.Log10(theta);

        }
        public double ln(double theta)
        {
            return Math.Log(theta);

        }
        public double fact(int theta)
        {
            double ans = 1;
            for (int v = 1; v <= theta; v++)
            {
                ans = ans* Convert.ToDouble(v);
            }
            return ans;

        }
       
        public string calculation(string str)
        {
            try
            {
                Double v1, v2;
                int ck;
                level25:
                ck = 0;

                if (str.Contains("P"))
                {

                    int lin = (Convert.ToInt32(str.IndexOf("P").ToString()) - (int)2);
                    int fi = new int();
                    for (int k = lin; str[k] != '|'; k--)
                    {
                        fi = k;



                    }
                    string substr = str.Substring(fi, lin - fi + 1);
                    v1 = Convert.ToDouble(substr);
                    int fii = (Convert.ToInt32(str.IndexOf("P").ToString()) + (int)2);
                    int linn = new int();
                    
                    for (int k = fii; str[k] != '|'; k++)
                    {
                        linn = k;



                    }
                    string substr2 = str.Substring(fii, linn - fii + 1);
                    v2 = Convert.ToDouble(substr2);
                    int ii = Convert.ToInt32(v1);
                    int jj = Convert.ToInt32(v2);
                    int kk = ii - jj;
                    if (jj > ii)
                    {
                        return "Math Error";
                    }
                   
                    double an = fact(ii) / fact(kk);
                    string ReplaceString = substr + "|P|" + substr2;
                    str = str.Replace(ReplaceString, Convert.ToString(an));
                    ck = 1;


                }
                if (ck == 1)
                {
                    goto level25;
                }
                //////////////////////
                level26:
                ck = 0;

                if (str.Contains("C"))
                {

                    int lin = (Convert.ToInt32(str.IndexOf("C").ToString()) - (int)2);
                    int fi = new int();
                    for (int k = lin; str[k] != '|'; k--)
                    {
                        fi = k;



                    }
                    string substr = str.Substring(fi, lin - fi + 1);
                    v1 = Convert.ToDouble(substr);
                    int fii = (Convert.ToInt32(str.IndexOf("C").ToString()) + (int)2);
                    int linn = new int();

                    for (int k = fii; str[k] != '|'; k++)
                    {
                        linn = k;



                    }
                    string substr2 = str.Substring(fii, linn - fii + 1);
                    v2 = Convert.ToDouble(substr2);
                    int ii = Convert.ToInt32(v1);
                    int jj = Convert.ToInt32(v2);
                    if (jj > ii)
                    {
                        return "Math Error";
                    }
                    int kk = ii - jj;
                    

                    double an = fact(ii) / (fact(kk)*fact(jj));
                    string ReplaceString = substr + "|C|" + substr2;
                    str = str.Replace(ReplaceString, Convert.ToString(an));
                    ck = 1;


                }
                if (ck == 1)
                {
                    goto level26;
                }
                ///////////////////////
                level24:
                ck = 0;

                if (str.Contains("^"))
                {

                    int lin = (Convert.ToInt32(str.IndexOf("^").ToString()) - (int) 2);
                    int fi = new int();
                    for (int k = lin; str[k] != '|'; k--)
                    {
                        fi = k;



                    }
                    string substr = str.Substring(fi, lin - fi + 1);
                    v1 = Convert.ToDouble(substr);
                    int fii = (Convert.ToInt32(str.IndexOf("^").ToString()) + (int) 2);
                    int linn = new int();
                    if (str[fii] == '-')
                    {
                        str = str.Remove(fii + 1, 1);

                    }
                    for (int k = fii; str[k] != '|'; k++)
                    {
                        linn = k;



                    }
                    string substr2 = str.Substring(fii, linn - fii + 1);
                    v2 = Convert.ToDouble(substr2);
                    string ReplaceString = substr + "|^|" + substr2;
                    str = str.Replace(ReplaceString, Convert.ToString(Math.Pow(v1, v2)));
                    ck = 1;


                }
                if (ck == 1)
                {
                    goto level24;
                }
                ////////
                level20:
                ck = 0;

                if (str.Contains("/"))
                {

                    int lin = (Convert.ToInt32(str.IndexOf("/").ToString()) - (int) 2);
                    int fi = new int();
                    for (int k = lin; str[k] != '|'; k--)
                    {
                        fi = k;



                    }
                    string substr = str.Substring(fi, lin - fi + 1);
                    v1 = Convert.ToDouble(substr);
                    int fii = (Convert.ToInt32(str.IndexOf("/").ToString()) + (int) 2);
                    int linn = new int();
                    for (int k = fii; str[k] != '|'; k++)
                    {
                        linn = k;



                    }
                    string substr2 = str.Substring(fii, linn - fii + 1);
                    v2 = Convert.ToDouble(substr2);
                    string ReplaceString = substr + "|/|" + substr2;
                    str = str.Replace(ReplaceString, Convert.ToString(v1 / v2));
                    ck = 1;


                }
                if (ck == 1)
                {
                    goto level20;
                }
                level21:
                ck = 0;

                if (str.Contains("x"))
                {

                    int lin = (Convert.ToInt32(str.IndexOf("x").ToString()) - (int) 2);
                    int fi = new int();
                    for (int k = lin; str[k] != '|'; k--)
                    {
                        fi = k;



                    }
                    string substr = str.Substring(fi, lin - fi + 1);
                    v1 = Convert.ToDouble(substr);
                    int fii = (Convert.ToInt32(str.IndexOf("x").ToString()) + (int) 2);
                    int linn = new int();
                    for (int k = fii; str[k] != '|'; k++)
                    {
                        linn = k;



                    }
                    string substr2 = str.Substring(fii, linn - fii + 1);
                    v2 = Convert.ToDouble(substr2);
                    string ReplaceString = substr + "|x|" + substr2;
                    str = str.Replace(ReplaceString, Convert.ToString(v1 * v2));
                    ck = 1;


                }
                if (ck == 1)
                {
                    goto level21;
                }
                v1 = 0;
                v2 = 0;

                if (str.Contains("|+|-|"))
                {
                    str = str.Replace("|+|-|", "-");


                }
                if (str.Contains("|-|-|"))
                {

                    str = str.Replace("|-|-|", "+");

                }
                if (str.Contains("|-|"))
                {

                    str = str.Replace("|-|", "-");

                }
                if (str.Contains("|+|"))
                {

                    str = str.Replace("|+|", "+");

                }
                if (str.Length >= 2)
                {
                    if (str[1] != '-')
                    {
                        char[] ar = str.ToCharArray();
                        ar[0] = '+';
                        str = new string(ar);
                    }
                }

                v1 = 0;
                string sn = ",";
                for (int k = 0; k < str.Length; k++)
                {
                    if (str[k] == '+') sn = "+";
                    else if (str[k] == '-') sn = "-";
                    else if (sn != ",")
                    {
                        int f = k;
                        int la = new int();
                        for (int l = k; (str[l] >= '0' && str[l] <= '9') || str[l] == '.'; l++)
                        {
                            la = l;
                        }
                        string sub = str.Substring(f, la - f + 1);
                        if (sn == "+")
                        {
                            v1 = v1 + Convert.ToDouble(sub);
                        }
                        if (sn == "-")
                        {
                            v1 = v1 - Convert.ToDouble(sub);
                        }
                        sn = ",";

                    }

                }



                return Convert.ToString(v1);
            }
            catch (Exception ex)
            {
                return "Math Error";

            }




        }














        }
}
