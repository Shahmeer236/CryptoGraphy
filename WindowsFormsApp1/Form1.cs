using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Encrypted_button_Click(object sender, EventArgs e)
        {
            try {

                string key = "z1x2c3v4b5n6m7l8";
                string input = Text_Plain.Text;

                AesManaged SymAlgo = new AesManaged();
                SymAlgo.Key=UTF8Encoding.UTF8.GetBytes(key);
                SymAlgo.Padding=PaddingMode.PKCS7;
                SymAlgo.Mode = CipherMode.ECB;

                ICryptoTransform ctransform = SymAlgo.CreateEncryptor();
                byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
                byte[] resultArray = ctransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                SymAlgo.Clear();

                Text_Encrypted.Text=Convert.ToBase64String(resultArray);
            }

            catch(Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Decrypt_button_Click(object sender, EventArgs e)
        {
            try {
                string key = "z1x2c3v4b5n6m7l8";
                string encryptedText= Text_Encrypted.Text;

                SymmetricAlgorithm SymAlgo = new AesManaged();
                SymAlgo.Key=UTF8Encoding.UTF8.GetBytes(key);
                SymAlgo.Padding = PaddingMode.PKCS7;
                SymAlgo.Mode = CipherMode.ECB;

                ICryptoTransform Ctransform =SymAlgo.CreateDecryptor();
                byte[] inputArray = Convert.FromBase64String(encryptedText);
                byte[] resultArray = Ctransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                SymAlgo.Clear();

                Text_Decrypted.Text = Encoding.UTF8.GetString(resultArray);



            }
            catch(Exception err)
            {

            MessageBox.Show(err.Message); 
            }
        }
    }
}
