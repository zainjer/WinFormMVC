using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vplquiz.Resources
{
    public class Utils
    {
        public static string GetHash(string text)
        {
            using (SHA256 encrypt = SHA256.Create())
            {

                var encoding = new UnicodeEncoding();
                byte[] hashValue = encrypt.ComputeHash((encoding.GetBytes(text)));

                var hash = Convert.ToBase64String(hashValue);
                return hash;
            }

        }

        public static void TbClickHandler(TextBox textBox, bool isPassword = false)
        {
            if (isPassword)
            {
                var status = textBox.Text.ToLower().Contains("password");
                if (!status) return;
            }
            else
            {
                var status = textBox.Text.ToLower().Contains("email");
                if (!status) return;
            }

            textBox.Text = "";
            textBox.ForeColor = Color.Black;
            textBox.UseSystemPasswordChar = isPassword;
        }

        public static void TbLeaveHandler(TextBox textBox, string message)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = message;
                textBox.ForeColor = Color.DimGray;
                textBox.UseSystemPasswordChar = false;
            }
        }
    }
}
