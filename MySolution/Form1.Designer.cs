namespace MySolution
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
            this.textOriginalMessage = new System.Windows.Forms.TextBox();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.textSignature = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textMessageDigestSHA1 = new System.Windows.Forms.TextBox();
            this.buttonSign = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonLoadText = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadDSAParams = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textOriginalMessage
            // 
            this.textOriginalMessage.Location = new System.Drawing.Point(22, 30);
            this.textOriginalMessage.Multiline = true;
            this.textOriginalMessage.Name = "textOriginalMessage";
            this.textOriginalMessage.Size = new System.Drawing.Size(614, 28);
            this.textOriginalMessage.TabIndex = 9;
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(516, 480);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(120, 46);
            this.buttonVerify.TabIndex = 17;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // textSignature
            // 
            this.textSignature.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSignature.Location = new System.Drawing.Point(22, 150);
            this.textSignature.Multiline = true;
            this.textSignature.Name = "textSignature";
            this.textSignature.ReadOnly = true;
            this.textSignature.Size = new System.Drawing.Size(614, 28);
            this.textSignature.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(12, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(634, 64);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Digital Signature";
            // 
            // textMessageDigestSHA1
            // 
            this.textMessageDigestSHA1.Location = new System.Drawing.Point(22, 86);
            this.textMessageDigestSHA1.Multiline = true;
            this.textMessageDigestSHA1.Name = "textMessageDigestSHA1";
            this.textMessageDigestSHA1.ReadOnly = true;
            this.textMessageDigestSHA1.Size = new System.Drawing.Size(614, 28);
            this.textMessageDigestSHA1.TabIndex = 12;
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(12, 480);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(120, 46);
            this.buttonSign.TabIndex = 11;
            this.buttonSign.Text = "Sign";
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.textBoxQ);
            this.groupBox5.Controls.Add(this.textBoxP);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBoxY);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBoxG);
            this.groupBox5.Location = new System.Drawing.Point(12, 197);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(634, 277);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DSA Parameters";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Q";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(29, 83);
            this.textBoxQ.Multiline = true;
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.ReadOnly = true;
            this.textBoxQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQ.Size = new System.Drawing.Size(595, 55);
            this.textBoxQ.TabIndex = 5;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(29, 18);
            this.textBoxP.Multiline = true;
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.ReadOnly = true;
            this.textBoxP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxP.Size = new System.Drawing.Size(595, 56);
            this.textBoxP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Y";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(29, 148);
            this.textBoxY.Multiline = true;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxY.Size = new System.Drawing.Size(595, 55);
            this.textBoxY.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "G";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(29, 212);
            this.textBoxG.Multiline = true;
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.ReadOnly = true;
            this.textBoxG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxG.Size = new System.Drawing.Size(595, 56);
            this.textBoxG.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 55);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 56);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SHA1 Hash Bytes";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(138, 480);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 46);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoadText
            // 
            this.buttonLoadText.Location = new System.Drawing.Point(264, 480);
            this.buttonLoadText.Name = "buttonLoadText";
            this.buttonLoadText.Size = new System.Drawing.Size(120, 46);
            this.buttonLoadText.TabIndex = 19;
            this.buttonLoadText.Text = "Load";
            this.buttonLoadText.UseVisualStyleBackColor = true;
            this.buttonLoadText.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonLoadDSAParams
            // 
            this.buttonLoadDSAParams.Location = new System.Drawing.Point(390, 480);
            this.buttonLoadDSAParams.Name = "buttonLoadDSAParams";
            this.buttonLoadDSAParams.Size = new System.Drawing.Size(120, 46);
            this.buttonLoadDSAParams.TabIndex = 20;
            this.buttonLoadDSAParams.Text = "Load DSA";
            this.buttonLoadDSAParams.UseVisualStyleBackColor = true;
            this.buttonLoadDSAParams.Click += new System.EventHandler(this.buttonLoadDSAParams_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 534);
            this.Controls.Add(this.buttonLoadDSAParams);
            this.Controls.Add(this.buttonLoadText);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textOriginalMessage);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.textSignature);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textMessageDigestSHA1);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textOriginalMessage;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.TextBox textSignature;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textMessageDigestSHA1;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonLoadText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonLoadDSAParams;
    }
}

