namespace mc.crypt.form.tool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTextValue = new System.Windows.Forms.TextBox();
            this.txtResultValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnToRsa = new System.Windows.Forms.Button();
            this.btnFromRSA = new System.Windows.Forms.Button();
            this.btnToBase64 = new System.Windows.Forms.Button();
            this.btnFromBase64 = new System.Windows.Forms.Button();
            this.btnGetPublicKey = new System.Windows.Forms.Button();
            this.txtPassPhrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTextValue
            // 
            this.txtTextValue.Location = new System.Drawing.Point(15, 25);
            this.txtTextValue.Multiline = true;
            this.txtTextValue.Name = "txtTextValue";
            this.txtTextValue.Size = new System.Drawing.Size(473, 134);
            this.txtTextValue.TabIndex = 0;
            // 
            // txtResultValue
            // 
            this.txtResultValue.Location = new System.Drawing.Point(15, 178);
            this.txtResultValue.Multiline = true;
            this.txtResultValue.Name = "txtResultValue";
            this.txtResultValue.Size = new System.Drawing.Size(473, 135);
            this.txtResultValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result value";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(511, 25);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(131, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(649, 25);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(131, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnToRsa
            // 
            this.btnToRsa.Location = new System.Drawing.Point(511, 54);
            this.btnToRsa.Name = "btnToRsa";
            this.btnToRsa.Size = new System.Drawing.Size(131, 23);
            this.btnToRsa.TabIndex = 6;
            this.btnToRsa.Text = "ToRSA";
            this.btnToRsa.UseVisualStyleBackColor = true;
            this.btnToRsa.Click += new System.EventHandler(this.btnToRsa_Click);
            // 
            // btnFromRSA
            // 
            this.btnFromRSA.Location = new System.Drawing.Point(649, 54);
            this.btnFromRSA.Name = "btnFromRSA";
            this.btnFromRSA.Size = new System.Drawing.Size(131, 23);
            this.btnFromRSA.TabIndex = 7;
            this.btnFromRSA.Text = "FromRSA";
            this.btnFromRSA.UseVisualStyleBackColor = true;
            this.btnFromRSA.Click += new System.EventHandler(this.btnFromRSA_Click);
            // 
            // btnToBase64
            // 
            this.btnToBase64.Location = new System.Drawing.Point(511, 83);
            this.btnToBase64.Name = "btnToBase64";
            this.btnToBase64.Size = new System.Drawing.Size(131, 23);
            this.btnToBase64.TabIndex = 8;
            this.btnToBase64.Text = "To Base 64";
            this.btnToBase64.UseVisualStyleBackColor = true;
            this.btnToBase64.Click += new System.EventHandler(this.btnToBase64_Click);
            // 
            // btnFromBase64
            // 
            this.btnFromBase64.Location = new System.Drawing.Point(649, 83);
            this.btnFromBase64.Name = "btnFromBase64";
            this.btnFromBase64.Size = new System.Drawing.Size(131, 23);
            this.btnFromBase64.TabIndex = 9;
            this.btnFromBase64.Text = "From Base 64";
            this.btnFromBase64.UseVisualStyleBackColor = true;
            this.btnFromBase64.Click += new System.EventHandler(this.btnFromBase64_Click);
            // 
            // btnGetPublicKey
            // 
            this.btnGetPublicKey.Location = new System.Drawing.Point(511, 112);
            this.btnGetPublicKey.Name = "btnGetPublicKey";
            this.btnGetPublicKey.Size = new System.Drawing.Size(269, 23);
            this.btnGetPublicKey.TabIndex = 10;
            this.btnGetPublicKey.Text = "Get Public Key";
            this.btnGetPublicKey.UseVisualStyleBackColor = true;
            // 
            // txtPassPhrase
            // 
            this.txtPassPhrase.Location = new System.Drawing.Point(511, 178);
            this.txtPassPhrase.Name = "txtPassPhrase";
            this.txtPassPhrase.Size = new System.Drawing.Size(269, 20);
            this.txtPassPhrase.TabIndex = 11;
            this.txtPassPhrase.Text = "Password phrase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pass phrase";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassPhrase);
            this.Controls.Add(this.btnGetPublicKey);
            this.Controls.Add(this.btnFromBase64);
            this.Controls.Add(this.btnToBase64);
            this.Controls.Add(this.btnFromRSA);
            this.Controls.Add(this.btnToRsa);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultValue);
            this.Controls.Add(this.txtTextValue);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextValue;
        private System.Windows.Forms.TextBox txtResultValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnToRsa;
        private System.Windows.Forms.Button btnFromRSA;
        private System.Windows.Forms.Button btnToBase64;
        private System.Windows.Forms.Button btnFromBase64;
        private System.Windows.Forms.Button btnGetPublicKey;
        private System.Windows.Forms.TextBox txtPassPhrase;
        private System.Windows.Forms.Label label3;
    }
}

