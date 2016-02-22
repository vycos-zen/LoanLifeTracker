﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanLifeTracker
{
    public class FormatDigitInput
    {
        public static void FilterKeypressToDigits(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static decimal FormatToDecimal(object d)
        {
            try
            {
                decimal dConvert = Convert.ToDecimal(d);
                d = decimal.Round(dConvert, 2, MidpointRounding.AwayFromZero);
                return dConvert;
            }
            catch
            {
                return 0;
            }
        }


    }
}