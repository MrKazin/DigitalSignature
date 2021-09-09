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

namespace MySolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DSACryptoServiceProvider dsa;
        DSAParameters dsaparams;
        byte[] signaturebytes;

        private void buttonSign_Click(object sender, EventArgs e)
        {
            byte[] messagebytes = Encoding.UTF8.GetBytes(textOriginalMessage.Text);
            
            
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] hashbytes =sha.ComputeHash(messagebytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashbytes.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ", hashbytes[i]));
            }
            textMessageDigestSHA1.Text = sb.ToString();


            dsa = new DSACryptoServiceProvider();
            signaturebytes = dsa.SignHash(hashbytes, "1.3.14.3.2.26");

            sb = new StringBuilder();
            for (int i = 0; i < signaturebytes.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ", signaturebytes[i]));
            }
            textSignature.Text = sb.ToString();


            dsaparams = dsa.ExportParameters(false);
            sb = new StringBuilder();
            for (int i = 0; i < dsaparams.P.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ", dsaparams.P[i]));
            }
            textBoxP.Text = sb.ToString();
            sb = new StringBuilder();
            for (int i = 0; i < dsaparams.Q.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ", dsaparams.Q[i]));
            }
            textBoxQ.Text = sb.ToString();
            for (int i = 0; i < dsaparams.Y.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ", dsaparams.Y[i]));
            }
            textBoxY.Text = sb.ToString();
            for (int i = 0; i < dsaparams.G.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ", dsaparams.G[i]));
            }
            textBoxG.Text = sb.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.InitialDirectory = @"C:\Users\Main\Desktop\Информационная безопасность\Лабы\Лр4 DigitalSignature";

            MessageBox.Show("Choose Place For Text.");
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string textName = saveFileDialog.FileName;
                System.IO.File.WriteAllText(textName, textOriginalMessage.Text);


                MessageBox.Show("Choose Place For DSA Params.");
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string dsaParamsName = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(dsaParamsName, dsa.ToXmlString(false));


                    MessageBox.Show("Choose Place For Signature.");
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string signatureName = saveFileDialog.FileName;
                        System.IO.File.WriteAllBytes(signatureName, signaturebytes);
                        MessageBox.Show("Success.");
                    }
                }
            }

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = @"C:\Users\Main\Desktop\Информационная безопасность\Лабы\Лр4 DigitalSignature";

            MessageBox.Show("Load Text.");
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string textFileName = openFileDialog.FileName;
                    textOriginalMessage.Text = System.IO.File.ReadAllText(textFileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonLoadDSAParams_Click(object sender, EventArgs e)
        {
            dsa = new DSACryptoServiceProvider();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = @"C:\Users\Main\Desktop\Информационная безопасность\Лабы\Лр4 DigitalSignature";

            MessageBox.Show("Load DSA Params.");
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string dsaParamsFileName = openFileDialog.FileName;
                    string xmlParams = System.IO.File.ReadAllText(dsaParamsFileName);
                    dsa.FromXmlString(xmlParams);

                    dsaparams = dsa.ExportParameters(false);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < dsaparams.P.Length; i++)
                    {
                        sb.Append(String.Format("{0,2:X2} ", dsaparams.P[i]));
                    }
                    textBoxP.Text = sb.ToString();
                    sb = new StringBuilder();
                    for (int i = 0; i < dsaparams.Q.Length; i++)
                    {
                        sb.Append(String.Format("{0,2:X2} ", dsaparams.Q[i]));
                    }
                    textBoxQ.Text = sb.ToString();
                    for (int i = 0; i < dsaparams.Y.Length; i++)
                    {
                        sb.Append(String.Format("{0,2:X2} ", dsaparams.Y[i]));
                    }
                    textBoxY.Text = sb.ToString();
                    for (int i = 0; i < dsaparams.G.Length; i++)
                    {
                        sb.Append(String.Format("{0,2:X2} ", dsaparams.G[i]));
                    }
                    textBoxG.Text = sb.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = @"C:\Users\Main\Desktop\Информационная безопасность\Лабы\Лр4 DigitalSignature";

            MessageBox.Show("Load Signature.");
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string signatureFileName = openFileDialog.FileName;
                    signaturebytes =System.IO.File.ReadAllBytes(signatureFileName);

                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < signaturebytes.Length; i++)
                    {
                        sb.Append(String.Format("{0,2:X2} ", signaturebytes[i]));
                    }
                    textSignature.Text = sb.ToString();

                    byte[] messagebytes = Encoding.UTF8.GetBytes(textOriginalMessage.Text);
                    SHA1 sha = new SHA1CryptoServiceProvider();
                    byte[] hashbytes = sha.ComputeHash(messagebytes);
                    sb = new StringBuilder();
                    for (int i = 0; i < hashbytes.Length; i++)
                    {
                        sb.Append(String.Format("{0,2:X2} ", hashbytes[i]));
                    }
                    textMessageDigestSHA1.Text = sb.ToString();



                    bool match = dsa.VerifyHash(hashbytes, "1.3.14.3.2.26", signaturebytes);

                    String strResult;
                    if (match)
                        strResult = "VerifySignature returned TRUE";
                    else
                        strResult = "VerifySignature returned FALSE";
                    MessageBox.Show(strResult, "Result From Calling VerifySignature", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
