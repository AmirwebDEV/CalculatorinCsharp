using System;

using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string[] strNum = new string[16] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        double[] dblNum = new double[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double resault = 0.0D;
        string amaliat;
        string amaliat2 = "";
        double FirstNumD = 0.0D;
        double SecNumD = 0.0D;
        double semiRes = 0.0D;
        double MultiFnum = 1.0D;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnN1_Click(object sender, EventArgs e)
        {
            txtInput.Text += 1.ToString();

        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            txtInput.Text += 2.ToString();

        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            txtInput.Text += 3.ToString();

        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            txtInput.Text += 4.ToString();

        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            txtInput.Text += 5.ToString();

        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            txtInput.Text += 6.ToString();

        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            txtInput.Text += 7.ToString();

        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            txtInput.Text += 8.ToString();

        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            txtInput.Text += 9.ToString();

        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            txtInput.Text += 0.ToString();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                txtInput.Text = "0.";
            }
            else if (txtInput.Text.Contains("."))
            {

            }
            else
            {
                txtInput.Text += ".";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        //private void btnSum_Click(object sender, EventArgs e)
        //{
        //    int i = 0;

        //    for (i = 0; i <= dblNum.Length; i++)
        //    {
        //        if (strNum[i] == "")
        //        {
        //            strNum[i] = txtInput.Text;
        //            if (strNum[i] != "")
        //            {
        //                dblNum[i] = double.Parse(txtInput.Text);
        //            }
        //            break;
        //        }
        //    }
        //    txtInput.Text = "";
        //}

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                switch (amaliat)
                {
                    case "+":
                        SecNumD = Convert.ToDouble(txtInput.Text);
                        semiRes += SecNumD;
                        resault = semiRes;
                        break;
                    case "-":
                        SecNumD = Convert.ToDouble(txtInput.Text);
                        semiRes -= SecNumD;
                        resault = semiRes;
                        break;
                    case "*":
                        if (amaliat2 == "-")
                        {
                            SecNumD = Convert.ToDouble(txtInput.Text);
                            semiRes -= (MultiFnum * SecNumD);
                            resault = semiRes;

                        }
                        else if (amaliat2 == "+")
                        {
                            SecNumD = Convert.ToDouble(txtInput.Text);
                            semiRes += (MultiFnum * SecNumD);
                            resault = semiRes;
                        }
                        else if (amaliat2 == "")
                        {
                            SecNumD = Convert.ToDouble(txtInput.Text);
                            semiRes *= SecNumD;
                            resault = semiRes;
                        }
                        break;
                    case "/":
                        if (amaliat2 == "-")
                        {
                            SecNumD = Convert.ToDouble(txtInput.Text);
                            semiRes -= (MultiFnum / SecNumD);
                            resault = semiRes;

                        }
                        else if (amaliat2 == "+")
                        {
                            SecNumD = Convert.ToDouble(txtInput.Text);
                            semiRes += (MultiFnum / SecNumD);
                            resault = semiRes;
                        }
                        else if (amaliat2 == "")
                        {
                            SecNumD = Convert.ToDouble(txtInput.Text);
                            semiRes /= SecNumD;
                            resault = semiRes;
                        }
                        break;
                }
            }


            for (int i = 0; i < dblNum.Length; i++)
            {
                strNum[i] = "";
                dblNum[i] = 0;
            }
            txtInput.Text = resault.ToString();
            resault = 0;
            MultiFnum = 1.0D;
            semiRes = 0.0D;
            amaliat = "";
            amaliat2 = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAmalit_Click(object sender, EventArgs e)
        {

            FirstNumD = Convert.ToDouble(txtInput.Text);

            Button opBtn = (Button)sender;
            switch (opBtn.Text)
            {
                case "+":
                    if (amaliat2 == "-")
                    {
                        semiRes -= FirstNumD;
                        amaliat = "+";
                        amaliat2 = "+";
                        break;
                    }
                    if (amaliat == "*")
                    {
                        semiRes += (MultiFnum * FirstNumD);
                        MultiFnum = 1.0D;
                        amaliat = "+";
                        amaliat2 = "+";
                        break;
                    }
                    semiRes += FirstNumD;
                    MultiFnum = 1.0D;
                    amaliat = "+";
                    amaliat2 = "+";
                    break;
                case "-":
                    //for (int i = 0; i < 15; i++)
                    //{
                    //    resault -= dblNum[i];
                    //}
                    if (amaliat2 == "+")
                    {
                        semiRes += MultiFnum * FirstNumD;
                        MultiFnum = 1.0D;
                        amaliat = "-";
                        amaliat2 = "-";
                        break;
                    }
                    if (amaliat == "*")
                    {
                        semiRes -= (MultiFnum * FirstNumD);
                        MultiFnum = 1.0D;
                        amaliat = "-";
                        amaliat2 = "-";
                        break;
                    }
                    if (amaliat == "+")
                    {
                        semiRes += FirstNumD;
                        amaliat = "-";
                        break;
                    }
                    if (dblNum[0] == 0)
                        semiRes += FirstNumD;
                    if (dblNum[0] != 0)
                    {
                        semiRes -= FirstNumD;
                        amaliat = "-";
                        break;
                    }
                    if (amaliat == "/")
                    {
                        semiRes = (semiRes / FirstNumD);
                        amaliat = "-";
                        break;
                    }
                    semiRes += FirstNumD;
                    amaliat = "-";
                    amaliat2 = "-";
                    MultiFnum = 1.0D;
                    break;
                case "*":
                    if (amaliat2 == "+" || amaliat2 == "-")
                    {
                        MultiFnum *= FirstNumD;
                        amaliat = "*";
                        break;

                    }
                    //if (amaliat == "-")
                    //{
                    //    semiRes -= FirstNumD;
                    //    amaliat = "*";

                    //    break;
                    //}
                    if (amaliat == "*")
                    {
                        semiRes = (semiRes * FirstNumD);
                        break;
                    }
                    semiRes += FirstNumD;
                    amaliat = "*";
                    break;
                case "/":
                    if (amaliat2 == "+" || amaliat2 == "-")
                    {
                        MultiFnum = FirstNumD;
                        amaliat = "/";
                        break;

                    }
                    if (amaliat == "/")
                    {
                        semiRes = (semiRes / FirstNumD);
                        break;
                    }
                    semiRes += FirstNumD;
                    amaliat = "/";
                    break;

            }
            for (int i = 0; i < dblNum.Length; i++)
            {
                if (txtInput.Text != "")
                {
                    dblNum[i] = Convert.ToDouble(txtInput.Text);
                    break;
                }
            }
            txtInput.Text = "";

        }
    }
}