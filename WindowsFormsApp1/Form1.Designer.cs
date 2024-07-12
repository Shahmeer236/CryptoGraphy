namespace WindowsFormsApp1
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
            this.Encrypt_button = new System.Windows.Forms.Button();
            this.Text_Plain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_Encrypted = new System.Windows.Forms.TextBox();
            this.Decrypt_text = new System.Windows.Forms.Label();
            this.Text_Decrypted = new System.Windows.Forms.TextBox();
            this.Decrypt_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Encrypt_button
            // 
            this.Encrypt_button.Location = new System.Drawing.Point(517, 176);
            this.Encrypt_button.Name = "Encrypt_button";
            this.Encrypt_button.Size = new System.Drawing.Size(75, 23);
            this.Encrypt_button.TabIndex = 0;
            this.Encrypt_button.Text = "Encrypt";
            this.Encrypt_button.UseVisualStyleBackColor = true;
            this.Encrypt_button.Click += new System.EventHandler(this.Encrypted_button_Click);
            // 
            // Text_Plain
            // 
            this.Text_Plain.Location = new System.Drawing.Point(199, 68);
            this.Text_Plain.Multiline = true;
            this.Text_Plain.Name = "Text_Plain";
            this.Text_Plain.Size = new System.Drawing.Size(215, 55);
            this.Text_Plain.TabIndex = 1;
            this.Text_Plain.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plain Text";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted Text";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Text_Encrypted
            // 
            this.Text_Encrypted.Location = new System.Drawing.Point(199, 176);
            this.Text_Encrypted.Multiline = true;
            this.Text_Encrypted.Name = "Text_Encrypted";
            this.Text_Encrypted.Size = new System.Drawing.Size(215, 55);
            this.Text_Encrypted.TabIndex = 3;
            this.Text_Encrypted.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Decrypt_text
            // 
            this.Decrypt_text.AutoSize = true;
            this.Decrypt_text.Location = new System.Drawing.Point(196, 266);
            this.Decrypt_text.Name = "Decrypt_text";
            this.Decrypt_text.Size = new System.Drawing.Size(80, 13);
            this.Decrypt_text.TabIndex = 6;
            this.Decrypt_text.Text = "Decrypted Text";
            this.Decrypt_text.Click += new System.EventHandler(this.label3_Click);
            // 
            // Text_Decrypted
            // 
            this.Text_Decrypted.Location = new System.Drawing.Point(199, 282);
            this.Text_Decrypted.Multiline = true;
            this.Text_Decrypted.Name = "Text_Decrypted";
            this.Text_Decrypted.Size = new System.Drawing.Size(215, 55);
            this.Text_Decrypted.TabIndex = 5;
            this.Text_Decrypted.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Decrypt_button
            // 
            this.Decrypt_button.Location = new System.Drawing.Point(517, 208);
            this.Decrypt_button.Name = "Decrypt_button";
            this.Decrypt_button.Size = new System.Drawing.Size(75, 23);
            this.Decrypt_button.TabIndex = 7;
            this.Decrypt_button.Text = "Decrypt";
            this.Decrypt_button.UseVisualStyleBackColor = true;
            this.Decrypt_button.Click += new System.EventHandler(this.Decrypt_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 459);
            this.Controls.Add(this.Decrypt_button);
            this.Controls.Add(this.Decrypt_text);
            this.Controls.Add(this.Text_Decrypted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_Encrypted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_Plain);
            this.Controls.Add(this.Encrypt_button);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encrypt_button;
        private System.Windows.Forms.TextBox Text_Plain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_Encrypted;
        private System.Windows.Forms.Label Decrypt_text;
        private System.Windows.Forms.TextBox Text_Decrypted;
        private System.Windows.Forms.Button Decrypt_button;
    }
}

