using mc.cript;
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

namespace mc.crypt.form.tool
{
    public partial class frmMain : Form
    {
        RSAParameters parameters = new RSACryptoServiceProvider(2048).ExportParameters(true);

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtResultValue.Text = Cryptographer.Encrypt(txtTextValue.Text, txtPassPhrase.Text);
        }

        private void btnToBase64_Click(object sender, EventArgs e)
        {
            txtResultValue.Text = Cryptographer.ToBase64(txtTextValue.Text);
        }

        private void btnFromBase64_Click(object sender, EventArgs e)
        {
            txtResultValue.Text = Cryptographer.FromBase64(txtTextValue.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtResultValue.Text = Cryptographer.Decrypt(txtTextValue.Text, txtPassPhrase.Text);
        }

        private void btnToRsa_Click(object sender, EventArgs e)
        {
            txtResultValue.Text = Cryptographer.ToRsa(txtTextValue.Text, parameters);
        }

        private void btnFromRSA_Click(object sender, EventArgs e)
        {
            txtResultValue.Text = Cryptographer.FromRsa(txtTextValue.Text, parameters);
        }
    }
}
