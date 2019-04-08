using System;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TextBox = System.Web.UI.WebControls.TextBox;



namespace TravelExpertsClassLib
{
    /// <summary>
    /// Provides static methods for validating data.
    /// </summary>
    public static class Validator
    {
        public static string message = "";

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

        private static bool IsUsorCanadianZipCode(string zipCode)
        {
            string _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
            string _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
            bool validZipCode = true;
            if ((!Regex.Match(zipCode, _usZipRegEx).Success) && (!Regex.Match(zipCode, _caZipRegEx).Success))
            {
                validZipCode = false;
            }
            return validZipCode;
        }

        // Defining the function to check if data is present in the textbox
        public static bool IsPresentWeb(System.Web.UI.WebControls.TextBox textbox, string name)
        {
            if (textbox.Text == "")
            {
                message = name + " is a required field.";
                textbox.Focus();
                return false;
            }
            message = "";
            return true;
        }


        // Defining the function to check if data present in the textbox is a string
        public static bool IsString(System.Web.UI.WebControls.TextBox textBox, string name) // If textbox data is an alpha string
        {
            Regex r = new Regex("^[a-zA-Z]+$");
            if (r.IsMatch(textBox.Text))
            {
                message = "";
                return true;
            }
            else
                message = name + " should contain only characters.";

            textBox.Focus();
            return false;
        }

        // Defining the function to check if city name is valid, contains only alphabets and spaces 
        public static bool IsCity(System.Web.UI.WebControls.TextBox textBox, string name) // If textbox data is an alpha string
        {
            Regex r = new Regex("^[a-zA-Z -.]|[A-Za-z -.]+$");
            if (r.IsMatch(textBox.Text))
            {
                message = "";
                return true;
            }
            else
                message = name + " should be contain characters only.";

            textBox.Focus();
            return false;
        }

        // Defining the function to check if country name is valid, contains only alphabets and spaces
        public static bool IsCountry(System.Web.UI.WebControls.TextBox textBox, string name) // If textbox data is an alpha string
        {
            Regex r = new Regex("^[a-zA-Z -.]|[A-Za-z -.]+$");
            if (r.IsMatch(textBox.Text))
            {
                message = "";
                return true;
            }
            else
                message = name + " should be contain characters only.";

            textBox.Focus();
            return false;
        }


        // Defining the function to check if province is in the correct format
        public static bool IsProvince(System.Web.UI.WebControls.TextBox textBox, string name) // If textbox data is an alpha string
        {
            Regex r = new Regex("^[A-Za-z]{2}$");
            if (r.IsMatch(textBox.Text))
            {
                message = "";
                return true;
            }
            else
                message = name + " should contain only 2 characters. Example AB";
            textBox.Focus();
            return false;
        }

        // Defining the function to check if postal code is in the correct format
        public static bool IsPostal(System.Web.UI.WebControls.TextBox textBox, string name)
        {
            Regex r = new Regex("[A-Za-z][0-9][A-Za-z] ?[0-9][A-Za-z][0-9]");
            if (r.IsMatch(textBox.Text))
            {
                message = "";
                return true;
            }
            else
                message = name + " should be a valid postal code in the format: A1A 1A1";
            textBox.Focus();
            return false;
        }


        // Defining the function to check if email is in the correct format
        public static bool IsEmailWeb(System.Web.UI.WebControls.TextBox textBox, string name)
        {
            try
            {
                MailAddress m = new MailAddress(textBox.Text);
                message = "";

                return true;
            }
            catch (FormatException ex)
            {
                message = ex.Message;
                return false;
            }

        }

        public static string CalculateMD5(string input)
        {
            // Step 1: calculate MD5 hash from input
            string password = input;

            // byte array representation of that string
            byte[] encodedPassword = new UTF8Encoding().GetBytes(password);


            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // Step 2: convert to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        //*****************************************************************
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

        //public static bool IsNameValid(string text, string name)
        //{
        //    string pattern = @"^[a-zA-Z0-9]*$";
        //    if (!Regex.IsMatch(text, pattern))
        //    {
        //        MessageBox.Show(name + "Please use a-z A-Z 0-9", "Entry Error");

        //        return false;
        //    }

        //    return true;
        //}
        //public static bool IsPasswordValid(string text, string name)
        //{
        //    string pattern = @"^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{6,15}$";
        //    if (!Regex.IsMatch(text, pattern))
        //    {
        //        MessageBox.Show("Password must contain at least one letter, at least one number, and be longer than six charaters.", "Entry Error");

        //        return false;
        //    }

        //    return true;
        //}

        //public static bool IsPostalValid(string text, string name)
        //{
        //    string pattern = @"^[A-Za-z]\d[A-Za-z] \d[A-Za-z]\d$";
        //    if (!Regex.IsMatch(text, pattern))
        //    {
        //        MessageBox.Show(name + "Please use correct format T1T 1T1", "Entry Error");

        //        return false;
        //    }

        //    return true;
        //}
        //public static bool IsStateValid(string text, string name)
        //{
        //    string pattern = @"^[A-Z][A-Z]$";
        //    if (!Regex.IsMatch(text, pattern))
        //    {
        //        MessageBox.Show(name + "Please use correct format AB", "Entry Error");

        //        return false;
        //    }

        //    return true;
        //}




        public static bool IsPresent(string textBox, string name)
        {
            if (textBox == "")
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