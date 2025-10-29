using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecryptText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enEncyptDecrypt
        {
            Encryption,
            Decryption
        }

        short SecretNumber = 7;

        string EncryptText(string Text,int SecretKey)
        {
            string EncryptedText = "";

            for(int i=0;i<Text.Length;i++)
            {
                if (Text[i] == ' ')
                {
                    EncryptedText += "¤";
                    continue;
                }

                EncryptedText += (char)(((Text[i] + SecretKey)+ SecretNumber) %256);

            }

            return EncryptedText;
        }

        string DecryptText(string Text, int SecretKey)
        {
            string DecrptedText = "";

            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == '¤')
                {
                    DecrptedText +=' ';
                    continue;
                }

                DecrptedText += (char)(((256 + Text[i] - SecretKey)- SecretNumber) % 256);

            }

            return DecrptedText;
        }

        bool IsEncryptionDataFull()
        {
            if (txtEncryption.Text == "Enter plain text to be Encrypted")
            {
                MessageBox.Show("Please,enter text to be Encrypted");
                return false;
            }

            if (txtEncryptionSecretKey.Text == "")
            {
                MessageBox.Show("Please,enter Secret Key");
                return false;
            }

            return true;
        }

        bool IsDecryptionDataFull()
        {
            if (txtDecryption.Text == "Enter text to be Decrypted")
            {
                MessageBox.Show("Please,enter text to be Decrypted");
                return false;
            }

            if (txtDecryptionSecretKey.Text == "")
            {
                MessageBox.Show("Please,enter Secret Key");
                return false;
            }

            return true;
        }

        bool IsDataFull(enEncyptDecrypt Type)
        {
            switch(Type)
            {
                case enEncyptDecrypt.Encryption:
                    {
                        if (IsEncryptionDataFull())
                            return true;
                    }
                    break;
                case enEncyptDecrypt.Decryption:
                    {
                        if (IsDecryptionDataFull())
                            return true;
                    }
                    break;
            }
            return false;
        }

        void EncryptDecryptText(enEncyptDecrypt Type)
        {

            switch (Type)
            {
                case enEncyptDecrypt.Encryption:
                    {
                        if (IsDataFull(enEncyptDecrypt.Encryption))
                        {
                            txtEncryptedOutput.Enabled = true;
                            txtEncryptedOutput.ReadOnly = true;
                            txtEncryptedOutput.Text = EncryptText(txtEncryption.Text, Convert.ToInt32(txtEncryptionSecretKey.Text));

                        }
                    }
                    break;
                case enEncyptDecrypt.Decryption:
                    {
                        if (IsDataFull(enEncyptDecrypt.Decryption))
                        {
                            txtDecryptedText.Enabled = true;
                            txtDecryptedText.ReadOnly = true;
                            txtDecryptedText.Text = DecryptText(txtDecryption.Text, Convert.ToInt32(txtDecryptionSecretKey.Text));

                        }

                    }
                    break;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0, 0, 0);
            Pen pen = new Pen(Black);
            pen.Width = 3;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;

            e.Graphics.DrawLine(pen, 450, 50, 450, 750);
        }

        private void txtEncryption_Enter(object sender, EventArgs e)
        {
            if (txtEncryption.Text == "Enter plain text to be Encrypted")
                txtEncryption.Text = "";
          }

        private void txtEncryption_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEncryption.Text))
                 txtEncryption.Text = "Enter plain text to be Encrypted";
        }

        private void txtDecryption_Enter(object sender, EventArgs e)
        {
            if (txtDecryption.Text == "Enter text to be Decrypted")
                txtDecryption.Text = "";
        }

        private void txtDecryption_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDecryptedText.Text))
                txtDecryption.Text = "Enter text to be Decrypted";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            EncryptDecryptText(enEncyptDecrypt.Encryption);
        }

     

        private void txtSecretKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            EncryptDecryptText(enEncyptDecrypt.Decryption);
        }
    }
}
