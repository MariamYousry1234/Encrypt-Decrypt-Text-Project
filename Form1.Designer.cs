
namespace EncryptDecryptText
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEncryption = new System.Windows.Forms.TextBox();
            this.txtDecryption = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEncryptionSecretKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDecryptionSecretKey = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtEncryptedOutput = new System.Windows.Forms.TextBox();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text Encryption:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(515, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text Decryption:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter any text to be Encrypted";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(515, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Encrypted Text to Decrypt";
            // 
            // txtEncryption
            // 
            this.txtEncryption.BackColor = System.Drawing.Color.White;
            this.txtEncryption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryption.Location = new System.Drawing.Point(52, 162);
            this.txtEncryption.Multiline = true;
            this.txtEncryption.Name = "txtEncryption";
            this.txtEncryption.Size = new System.Drawing.Size(332, 146);
            this.txtEncryption.TabIndex = 4;
            this.txtEncryption.Text = "Enter plain text to be Encrypted";
            this.txtEncryption.Enter += new System.EventHandler(this.txtEncryption_Enter);
            this.txtEncryption.Leave += new System.EventHandler(this.txtEncryption_Leave);
            // 
            // txtDecryption
            // 
            this.txtDecryption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryption.Location = new System.Drawing.Point(515, 162);
            this.txtDecryption.Multiline = true;
            this.txtDecryption.Name = "txtDecryption";
            this.txtDecryption.Size = new System.Drawing.Size(332, 146);
            this.txtDecryption.TabIndex = 5;
            this.txtDecryption.Text = "Enter text to be Decrypted";
            this.txtDecryption.Enter += new System.EventHandler(this.txtDecryption_Enter);
            this.txtDecryption.Leave += new System.EventHandler(this.txtDecryption_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter Secret Key";
            // 
            // txtEncryptionSecretKey
            // 
            this.txtEncryptionSecretKey.Location = new System.Drawing.Point(52, 404);
            this.txtEncryptionSecretKey.Name = "txtEncryptionSecretKey";
            this.txtEncryptionSecretKey.Size = new System.Drawing.Size(292, 20);
            this.txtEncryptionSecretKey.TabIndex = 7;
            this.txtEncryptionSecretKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecretKey_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(515, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Enter Secret Key";
            // 
            // txtDecryptionSecretKey
            // 
            this.txtDecryptionSecretKey.Location = new System.Drawing.Point(515, 404);
            this.txtDecryptionSecretKey.Name = "txtDecryptionSecretKey";
            this.txtDecryptionSecretKey.Size = new System.Drawing.Size(292, 20);
            this.txtDecryptionSecretKey.TabIndex = 9;
            this.txtDecryptionSecretKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecretKey_KeyPress);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(52, 478);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(161, 45);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(515, 478);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(161, 45);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtEncryptedOutput
            // 
            this.txtEncryptedOutput.Enabled = false;
            this.txtEncryptedOutput.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedOutput.Location = new System.Drawing.Point(52, 597);
            this.txtEncryptedOutput.Multiline = true;
            this.txtEncryptedOutput.Name = "txtEncryptedOutput";
            this.txtEncryptedOutput.Size = new System.Drawing.Size(332, 146);
            this.txtEncryptedOutput.TabIndex = 12;
            this.txtEncryptedOutput.Text = "Result goes here";
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.Enabled = false;
            this.txtDecryptedText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptedText.Location = new System.Drawing.Point(515, 597);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.Size = new System.Drawing.Size(332, 146);
            this.txtDecryptedText.TabIndex = 13;
            this.txtDecryptedText.Text = "Decrypted Text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(47, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Encrypted Output";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(516, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Decrypted Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(916, 764);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDecryptedText);
            this.Controls.Add(this.txtEncryptedOutput);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtDecryptionSecretKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEncryptionSecretKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDecryption);
            this.Controls.Add(this.txtEncryption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Encrypt&Decrypt Text";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEncryption;
        private System.Windows.Forms.TextBox txtDecryption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEncryptionSecretKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDecryptionSecretKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtEncryptedOutput;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

