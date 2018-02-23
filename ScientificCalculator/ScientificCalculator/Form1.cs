using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{

    public partial class Form1 : Form
    {
        public static int onoff = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> sz = new List<int>();
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button24_Click(object sender, EventArgs e)
        {
        }


        private void button15_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Length > 0)
            {
                int tmp = sz[sz.Count - 1];
                textBoxInput = textBoxInput.Remove(textBoxInput.Length - tmp, tmp);
                txtboxInput.Text = textBoxInput;
                sz.RemoveAt(sz.Count - 1);
                label2.Text = "";
                label3.Text = "";
            }
        }

        public static string newstr = "";
        public static string ans2 = "";
        private string textBoxInput = "";
    
        private void button1_Click(object sender, EventArgs e)
        {
            if (onoff == 0) return;
            try
            {
                string temp_string = (sender as Button).Text;
                if (temp_string == "ANS")
                {
                    textBoxInput = textBoxInput + ans2;
                    sz.Add(3);
                }
                else if (temp_string == "nPr")
                {
                    textBoxInput = textBoxInput + "P";
                    sz.Add(1);
                }
                else if (temp_string == "nCr")
                {
                    textBoxInput = textBoxInput + "C";
                    sz.Add(1);
                }


                else if ((temp_string == "tan") || (temp_string == "cos") || (temp_string == "sin") ||
                         (temp_string == "log"))
                {
                    textBoxInput = textBoxInput + temp_string + "(";
                    sz.Add(4);
                }
                else if ((temp_string == "sin-1") || (temp_string == "cos-1") || (temp_string == "tan-1"))
                {
                    textBoxInput = textBoxInput + temp_string + "(";
                    sz.Add(6);
                }
                else if (temp_string == "x^y")
                {
                    textBoxInput = textBoxInput + "^";
                    sz.Add(1);

                }
                else if (temp_string == "x^2")
                {
                    textBoxInput = textBoxInput + "^2";
                    sz.Add(2);


                }
                else if (temp_string == "10^x")
                {
                    textBoxInput = textBoxInput + "10^";
                    sz.Add(3);


                }
                else if (temp_string == "x^-1")
                {
                    textBoxInput = textBoxInput + "^-1";
                    sz.Add(3);


                }
                else if (temp_string == "ln")
                {
                    textBoxInput = textBoxInput + "ln(";
                    sz.Add(3);


                }
                else if (temp_string == "x!")
                {
                    textBoxInput = textBoxInput + "!";
                    sz.Add(1);


                }
                else
                {
                    textBoxInput = textBoxInput + temp_string;
                    sz.Add(1);
                }
                txtboxInput.Text = textBoxInput;
            }
            catch (Exception exception)
            {
                label3.Text = "Please input correctly";
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            textBoxInput = "";
            txtboxInput.Text = textBoxInput;
            label3.Text = "";
            sz.Clear();


        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (onoff == 0) return;
            try
            {
                if (textBoxInput == null) return;
                newstr = textBoxInput;
                int check = 0;
                level4:
                check = 0;
                if (newstr.Contains("tan-1"))
                {

                    int fi = (Convert.ToInt32(newstr.IndexOf("tan-1").ToString()) + (int)6);
                    int lin = new int();

                    for (int i = fi; newstr[i] != ')'; i++)
                    {
                        lin = i;
                    }
                    string value = newstr.Substring(fi, lin - fi + 1);
                    string value2 = newstr.Substring(fi - 6, lin - fi + 8);
                    Methods var = new Methods();
                    string retValue = "|" + var.tan_inverse(Convert.ToDouble(value)).ToString() + "|";
                    newstr = newstr.Replace(value2, retValue);
                    check = 1;

                }
                if (check == 1) goto level4;
                level5:
                check = 0;
                if (newstr.Contains("sin-1"))
                {

                    int fi = (Convert.ToInt32(newstr.IndexOf("sin-1").ToString()) + (int)6);
                    int lin = new int();

                    for (int i = fi; newstr[i] != ')'; i++)
                    {
                        lin = i;
                    }
                    string value = newstr.Substring(fi, lin - fi + 1);
                    string value2 = newstr.Substring(fi - 6, lin - fi + 8);

                    Methods var = new Methods();
                    string retValue = "|" + var.sin_inverse(Convert.ToDouble(value)).ToString() + "|";
                    newstr = newstr.Replace(value2, retValue);
                    check = 1;

                }
                if (check == 1) goto level5;
                level6:
                check = 0;
                if (newstr.Contains("cos-1"))
                {

                    int fi = (Convert.ToInt32(newstr.IndexOf("cos-1").ToString()) + (int)6);
                    int lin = new int();

                    for (int i = fi; textBoxInput[i] != ')'; i++)
                    {
                        lin = i;
                    }
                    string value = newstr.Substring(fi, lin - fi + 1);
                    string value2 = newstr.Substring(fi - 6, lin - fi + 8);
                    Methods var = new Methods();
                    string retValue = "|" + var.cos_inverse(Convert.ToDouble(value)).ToString() + "|";
                    newstr = newstr.Replace(value2, retValue);
                    check = 1;

                }
                if (check == 1) goto level6;
                level1:
                check = 0;
                if (newstr.Contains("tan"))
                {

                    int fi = (Convert.ToInt32(newstr.IndexOf("tan").ToString()) + (int)4);
                    int lin = new int();

                    for (int i = fi; newstr[i] != ')'; i++)
                    {

                        lin = i;
                    }
                    string value = newstr.Substring(fi, lin - fi + 1);
                    string value2 = newstr.Substring(fi - 4, lin - fi + 6);
                    Methods var = new Methods();
                    string retValue = "|" + var.tann(Convert.ToDouble(value)).ToString() + "|";
                    newstr = newstr.Replace(value2, retValue);
                    check = 1;

                }
                if (check == 1) goto level1;
                level2:
                check = 0;
                if (newstr.Contains("sin"))
                {

                    int fi = (Convert.ToInt32(newstr.IndexOf("sin").ToString()) + (int)4);
                    int lin = new int();

                    for (int i = fi; newstr[i] != ')'; i++){
                        lin = i;
                    }
                    string value = newstr.Substring(fi, lin - fi + 1);
                    string value2 = newstr.Substring(fi - 4, lin - fi + 6);


                    Methods var = new Methods();
                    string retValue = "|" + var.sinn(Convert.ToDouble(value)).ToString() + "|";
                    newstr = newstr.Replace(value2, retValue);
                    check = 1;

                }
                if (check == 1) goto level2;
                level3:
                check = 0;
                if (newstr.Contains("cos"))
                {

                    int fi = (Convert.ToInt32(newstr.IndexOf("cos").ToString()) + (int)4);
                    int lin = new int();

                    for (int i = fi; newstr[i] != ')'; i++)
                    {
                        lin = i;
                    }

                    string value = newstr.Substring(fi, lin - fi + 1);
                    string value2 = newstr.Substring(fi - 4, lin - fi + 6);


                    Methods var = new Methods();
                    string retValue = "|" + var.coss(Convert.ToDouble(value)).ToString() + "|";
                    newstr = newstr.Replace(value2, retValue);
                    check = 1;

                }
                if (check == 1) goto level3;
                level7:
                check = 0;
                if (newstr.Contains("log"))
                {

                    int fi = (Convert.ToInt32(newstr.IndexOf("log").ToString()) + (int)4);
                    int lin = new int();

                    for (int i = fi; newstr[i] != ')'; i++)
                    {
                        lin = i;
                    }
                    string value = newstr.Substring(fi, lin - fi + 1);
                    string value2 = newstr.Substring(fi - 4, lin - fi + 6);
                    Methods var = new Methods();
                    string retValue = "|" + var.logg(Convert.ToDouble(value)).ToString() + "|";
                    newstr = newstr.Replace(value2, retValue);
                    check = 1;

                }
                if (check == 1) goto level7;
                level8:
                check = 0;
                if (newstr.Contains("ln"))
                {

                    int fi = (Convert.ToInt32(newstr.IndexOf("ln").ToString()) + (int)3);
                    int lin = new int();

                    for (int i = fi; newstr[i] != ')'; i++)
                    {
                        lin = i;
                    }
                    string value = newstr.Substring(fi, lin - fi + 1);
                    string value2 = newstr.Substring(fi - 3, lin - fi + 5);
                    Methods var = new Methods();
                    string retValue = "|" + var.ln(Convert.ToDouble(value)).ToString() + "|";
                    newstr = newstr.Replace(value2, retValue);
                    check = 1;

                }
                if (check == 1) goto level8;
                level9:
                check = 0;
                if (newstr.Contains("!"))
                {

                    int lin = (Convert.ToInt32(newstr.IndexOf("!").ToString()) - (int)1);
                    int fi = new int();


                    for (int i = lin; newstr[i] >= '0' && newstr[i] <= '9' && i >= 0; i--)
                    {
                        fi = i;
                        if (fi == 0) break;
                    }
                    //  fi = 0;
                    string value = newstr.Substring(fi, lin - fi + 1);
                    string value2 = newstr.Substring(fi, lin - fi + 2);
                    Methods var = new Methods();
                    string retValue = "|" + var.fact(Convert.ToInt32(value)).ToString() + "|";
                    newstr = newstr.Replace(value2, retValue);
                    check = 1;

                }
                if (check == 1) goto level9;
                level10:
                check = 0;
                if (newstr.Contains("√"))
                {

                    int fi = (Convert.ToInt32(newstr.IndexOf("√").ToString()) + (int)1);
                    int lin = new int();


                    for (int i = fi; newstr[i] >= '0' && newstr[i] <= '9' && i < newstr.Length; i++)
                    {
                        lin = i;
                        if (lin == textBoxInput.Length - 1) break;}
                    string value = newstr.Substring(fi, lin - fi + 1);
                    string value2 = newstr.Substring(fi - 1, lin - fi + 2);
                    Methods var = new Methods();
                    string retValue = "|" + Math.Sqrt(Convert.ToDouble(value)).ToString() + "|";
                    check = 1;

                }
                if (check == 1) goto level10;
                if (newstr.Contains("π"))
                {
                    string ss = Convert.ToString(Math.PI);
                    newstr = newstr.Replace("π", ss);

                }


                for (int j = 1; j < newstr.Length; j++)
                {

                    if ((newstr[j] == '+' || newstr[j] == 'x' || newstr[j] == '-' || newstr[j] == '/' ||
                         newstr[j] == '^' || newstr[j] == 'P' || newstr[j] == 'C') && newstr[j - 1] != '|' && j - 1 >= 0 && newstr[j - 1] != 'E')
                    {
                        newstr = newstr.Insert(j, "|");
                    }


                }

                for (int j = 1; j < newstr.Length; j++)
                {
                    if ((newstr[j] == '+' || newstr[j] == 'x' || newstr[j] == '-' || newstr[j] == '/' ||
                         newstr[j] == '^' || newstr[j] == 'P' || newstr[j] == 'C') && newstr[j + 1] != '|' && newstr[j - 1] != 'E')
                    {
                        newstr = newstr.Insert(j + 1, "|");
                    }


                }
                if (newstr != "")
                {
                    if (newstr[0] != '|') newstr = newstr.Insert(0, "|");
                    if (newstr[newstr.Length - 1] != '|') newstr = newstr.Insert(newstr.Length, "|");
                }

                label2.Text = txtboxInput.Text;
                Methods var1 = new Methods();
                string st = var1.calculation(newstr);
                ans2 = st;
                label3.Text = ans2.ToString();
                newstr = ans2;
            }
            catch (Exception exceptio)
            {
                label3.Text = "Please input correctly";
            }


        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (onoff == 0) return;
            txtboxInput.Text = "Ans";
            label2.Text = "Ans";
            label3.Text = ans2;

        }

        private void button43_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "DEC";
                string val = Convert.ToInt32(ans2, 10).ToString();

                label3.Text = val;
            }
            catch (Exception ee)
            {
                label3.Text = "";
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "BIN";
                int v = Convert.ToInt32(ans2);
                string val = Convert.ToString(v, 2);

                label3.Text = val;
            }
            catch (Exception ee)
            {
                label3.Text = "";
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "HEX";
                int v = Convert.ToInt32(ans2);
                string val = Convert.ToString(v, 16);

                label3.Text = val;
            }
            catch (Exception ee)
            {
                label3.Text = "";
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "OCT";
                int v = Convert.ToInt32(ans2);
                string val = Convert.ToString(v, 8);

                label3.Text = val;
            }
            catch (Exception ee)
            {
                label3.Text = "";
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void onOffButton_Click(object sender, EventArgs e)
        {

            if (onoff == 0)
            {
                onOffButton.Text = "OFF";
                onOffButton.BackColor = Color.DarkGray;
                onoff = 1;
            }
            else if (onoff == 1)
            {
                onOffButton.Text = "ON";
                onOffButton.BackColor = DefaultBackColor;
                onoff = 0;
                textBoxInput = "";
                newstr = "";
                txtboxInput.Text = "";
                label2.Text = "";
                label3.Text = "";


            }





        }
    }
}

