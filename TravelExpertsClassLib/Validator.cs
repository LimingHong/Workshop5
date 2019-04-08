using System;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace TravelExpertsClassLib
{
    /// <summary>
    /// Provides static methods for validating data.
    /// </summary>
    public static class Validator
    {
        public static bool IsEmail(TextBox emailTB, string name)
        {
            try
            {
                MailAddress m = new MailAddress(emailTB.Text);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(" Please use Email format, for " + name + ". ", "Entry Error");
                emailTB.Focus();
                return false;
            }
        }

        public static bool IsNameValid(string text, string name)
        {
            string pattern = @"^[a-zA-Z0-9]*$";
            if (!Regex.IsMatch(text, pattern))
            {
                MessageBox.Show(name + "Please use a-z A-Z 0-9", "Entry Error");
              
                return false;
            }

            return true;
        }
        public static bool IsPasswordValid(string text, string name)
        {
            string pattern = @"^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{6,15}$";
            if (!Regex.IsMatch(text, pattern))
            {
                MessageBox.Show("Password must contain at least one letter, at least one number, and be longer than six charaters.", "Entry Error");

                return false;
            }

            return true;
        }

        public static bool IsPostalValid(string text, string name)
        {
            string pattern = @"^[A-Za-z]\d[A-Za-z] \d[A-Za-z]\d$";
            if (!Regex.IsMatch(text, pattern))
            {
                MessageBox.Show(name + "Please use correct format T1T 1T1", "Entry Error");

                return false;
            }

            return true;
        }
        public static bool IsStateValid(string text, string name)
        {
            string pattern = @"^[A-Z][A-Z]$";
            if (!Regex.IsMatch(text, pattern))
            {
                MessageBox.Show(name + "Please use correct format AB", "Entry Error");

                return false;
            }

            return true;
        }




        public static bool IsPresent(string textBox, string name)
        {
            if (textBox== "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                
                return false;
            }
            return true;
        }
        public static bool IsPresentCombo(ComboBox textBox, string name)
        {
            if (textBox.DisplayMember == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsPresentRichTB(RichTextBox richtextBox, string name)
        {
            if (richtextBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                richtextBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsPresentDateTimePicker(DateTimePicker dateTimePicker, string name)
        {
            if (dateTimePicker.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                dateTimePicker.Focus();
                return false;
            }
            return true;
        }

        public static bool IsCorrectLength(string textBox, string name, int maxLen)
        {
            if ((textBox).Length > maxLen)
            {
                MessageBox.Show(name + " can be at most " + maxLen.ToString() + " long", "Entry Error");
                
                return false;
            }
            return true;
        }
        public static bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsNonNegativeDecimal(TextBox textBox, string name)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < 0)
            {
                MessageBox.Show(name + " must be positive or zero", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsNonNegativeInt(TextBox textBox, string name)
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number < 0)
            {
                MessageBox.Show(name + " must be positive or zero", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}