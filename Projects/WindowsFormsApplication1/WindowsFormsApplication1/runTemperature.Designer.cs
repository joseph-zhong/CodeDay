namespace WindowsFormsApplication1
{
    partial class runTemperature
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
            this.Celsius = new System.Windows.Forms.TextBox();
            this.Fahrenheit = new System.Windows.Forms.TextBox();
            this.btnCtoF = new System.Windows.Forms.Button();
            this.btnFtoC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrenheit";
            // 
            // Celsius
            // 
            this.Celsius.Location = new System.Drawing.Point(15, 25);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(100, 20);
            this.Celsius.TabIndex = 2;
            this.Celsius.TextChanged += new System.EventHandler(this.Celsius_TextChanged);
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.Location = new System.Drawing.Point(169, 26);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(100, 20);
            this.Fahrenheit.TabIndex = 3;
            // 
            // btnCtoF
            // 
            this.btnCtoF.Location = new System.Drawing.Point(15, 51);
            this.btnCtoF.Name = "btnCtoF";
            this.btnCtoF.Size = new System.Drawing.Size(82, 27);
            this.btnCtoF.TabIndex = 4;
            this.btnCtoF.Text = ">>>>";
            this.btnCtoF.UseVisualStyleBackColor = true;
            // 
            // btnFtoC
            // 
            this.btnFtoC.Location = new System.Drawing.Point(170, 52);
            this.btnFtoC.Name = "btnFtoC";
            this.btnFtoC.Size = new System.Drawing.Size(82, 27);
            this.btnFtoC.TabIndex = 5;
            this.btnFtoC.Text = "<<<<";
            this.btnFtoC.UseVisualStyleBackColor = true;
            // 
            // runTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.btnFtoC);
            this.Controls.Add(this.btnCtoF);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "runTemperature";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Celsius;
        private System.Windows.Forms.TextBox Fahrenheit;
        private System.Windows.Forms.Button btnCtoF;
        private System.Windows.Forms.Button btnFtoC;

    }
}

