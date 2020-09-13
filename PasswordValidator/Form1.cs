using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            this.warningLabel.ForeColor = Color.Red;

            if (this.password.Text == String.Empty || this.cPassword.Text == String.Empty)
            {
                String warning          = "Please fill both fields";
                this.warningLabel.Text  = warning;
                this.Logger(warning);
                return;
            }

            if(this.password.Text != this.cPassword.Text)
            {
                String warning          = "Passwords do not match";
                this.warningLabel.Text  = warning;
                this.Logger(warning);
                return;
            }

            this.CheckIfSafePassword(this.password.Text);
            this.DisplayTextInfo();

        }

        private void CheckIfSafePassword(String password)
        {
            Regex regex = new Regex("^[a-zA-Z0-9]*$");

            Boolean longEnough = password.Count<Char>() >= 10;
            Boolean hasLowerCase    = password.Count(Char.IsLower)  != 0;
            Boolean hasUpperCase    = password.Count(Char.IsUpper)  != 0;
            Boolean hasDigits       = password.Count(Char.IsDigit)  != 0;
            Boolean hasSymbol       = !regex.IsMatch(password);
            Boolean hasSpaces       = password.Count(Char.IsWhiteSpace) != 0;

            if (!longEnough)
            {
                String warning = "Password should be at least 10 char long";
                this.warningLabel.Text = warning;
                this.Logger(warning);
                return;
            }

            if (hasSpaces)
            {
                String warning = "Spaces are not allowed";
                this.warningLabel.Text = warning;
                this.Logger(warning);
                return;
            }

            if(!hasLowerCase)
            {
                String warning = "Has no lower case letters";
                this.warningLabel.Text = warning;
                this.Logger(warning);
                return;
            }

            if (!hasUpperCase)
            {
                String warning = "Has no upper case letters";
                this.warningLabel.Text = warning;
                this.Logger(warning);
                return;
            }

            if (!hasDigits)
            {
                String warning = "Has no digits";
                this.warningLabel.Text = warning;
                this.Logger(warning);
                return;
            }

            if (!hasSymbol)
            {
                String warning = "Has no symbols";
                this.warningLabel.Text = warning;
                this.Logger(warning);
                return;
            }

            String info = "Password is safe";
            this.warningLabel.ForeColor = Color.Green;
            this.warningLabel.Text = info;
            this.Logger(info);


        }

        private void DisplayTextInfo()
        {
            // Get value entered
            this.valueLabel1.Text = "Value: " + this.password.Text;
            this.valueLabel2.Text = "Value: " + this.cPassword.Text;

            // Get hash
            this.hashLabel1.Text = "Hash: " + this.password.Text.GetHashCode();
            this.hashLabel2.Text = "Hash: " + this.cPassword.Text.GetHashCode();

            // Get char count
            this.charCountLabel1.Text = "Chars: " + this.password.Text.Count<char>();
            this.charCountLabel2.Text = "Chars: " + this.cPassword.Text.Count<char>();

            // Get letters count
            this.letterCountLabel1.Text = "Letters: " + this.password.Text.Count(Char.IsLetter);
            this.letterCountLabel2.Text = "Letters: " + this.cPassword.Text.Count(Char.IsLetter);

            // Get digit count
            this.digitCountLabel1.Text = "Digits: " + this.password.Text.Count(Char.IsDigit);
            this.digitCountLabel2.Text = "Digits: " + this.cPassword.Text.Count(Char.IsDigit);
        }


        // Simple logging funciton
        private void Logger(String info)
        {
            DateTime timeNow = DateTime.Now;
            StringBuilder sb = new StringBuilder();

            sb.Append("Time: " + timeNow.ToString("dd-MM-yyyy HH-mm") + "\n");
            sb.Append("First value: " + this.password.Text + "\n");
            sb.Append("Second value: " + this.cPassword.Text + "\n");
            sb.Append("Info: " + info + "\n");
            sb.Append("--------------------------------------------------" + "\n");

            if (!Directory.Exists(@"C:\\Log"))
            {
                Directory.CreateDirectory(@"C:\\Log");
            }

            File.AppendAllText("C:\\Log\\" + "password.log", sb.ToString());


        }
    }
}
