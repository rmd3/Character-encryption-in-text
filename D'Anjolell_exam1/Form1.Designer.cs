
namespace D_Anjolell_exam1
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
            this.txtCh = new System.Windows.Forms.TextBox();
            this.lblEntry = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnEcrypt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblChResult = new System.Windows.Forms.Label();
            this.lblEncryptResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCh
            // 
            this.txtCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtCh.Location = new System.Drawing.Point(411, 12);
            this.txtCh.Name = "txtCh";
            this.txtCh.Size = new System.Drawing.Size(100, 38);
            this.txtCh.TabIndex = 0;
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEntry.Location = new System.Drawing.Point(150, 19);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(230, 31);
            this.lblEntry.TabIndex = 1;
            this.lblEntry.Text = "Enter a character:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSubmit.Location = new System.Drawing.Point(253, 84);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 51);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnEcrypt
            // 
            this.btnEcrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnEcrypt.Location = new System.Drawing.Point(281, 228);
            this.btnEcrypt.Name = "btnEcrypt";
            this.btnEcrypt.Size = new System.Drawing.Size(210, 51);
            this.btnEcrypt.TabIndex = 5;
            this.btnEcrypt.Text = "Ecryption";
            this.btnEcrypt.UseVisualStyleBackColor = true;
            this.btnEcrypt.Click += new System.EventHandler(this.btnEcrypt_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.Location = new System.Drawing.Point(411, 84);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 51);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblChResult
            // 
            this.lblChResult.AutoSize = true;
            this.lblChResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblChResult.Location = new System.Drawing.Point(182, 161);
            this.lblChResult.Name = "lblChResult";
            this.lblChResult.Size = new System.Drawing.Size(0, 31);
            this.lblChResult.TabIndex = 7;
            // 
            // lblEncryptResult
            // 
            this.lblEncryptResult.AutoSize = true;
            this.lblEncryptResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEncryptResult.Location = new System.Drawing.Point(109, 305);
            this.lblEncryptResult.Name = "lblEncryptResult";
            this.lblEncryptResult.Size = new System.Drawing.Size(0, 31);
            this.lblEncryptResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 782);
            this.Controls.Add(this.lblEncryptResult);
            this.Controls.Add(this.lblChResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEcrypt);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.txtCh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCh;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnEcrypt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblChResult;
        private System.Windows.Forms.Label lblEncryptResult;
    }
}

