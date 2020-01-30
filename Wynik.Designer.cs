namespace EkspertSoczewki1
{
    partial class Wynik
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
            this.labelWynik = new System.Windows.Forms.Label();
            this.buttonPowrotdoKNN = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Location = new System.Drawing.Point(52, 21);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(35, 13);
            this.labelWynik.TabIndex = 0;
            this.labelWynik.Text = "label1";
            // 
            // buttonPowrotdoKNN
            // 
            this.buttonPowrotdoKNN.Location = new System.Drawing.Point(180, 293);
            this.buttonPowrotdoKNN.Name = "buttonPowrotdoKNN";
            this.buttonPowrotdoKNN.Size = new System.Drawing.Size(75, 23);
            this.buttonPowrotdoKNN.TabIndex = 1;
            this.buttonPowrotdoKNN.Text = "Powrót";
            this.buttonPowrotdoKNN.UseVisualStyleBackColor = true;
            this.buttonPowrotdoKNN.Click += new System.EventHandler(this.buttonPowrotdoKNN_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(54, 80);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(312, 172);
            this.textBoxLog.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.textBoxLog);
            this.panel1.Controls.Add(this.labelWynik);
            this.panel1.Controls.Add(this.buttonPowrotdoKNN);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 358);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Wynik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 358);
            this.Controls.Add(this.panel1);
            this.Name = "Wynik";
            this.Text = "System ekspertowy wspomagający wybór soczewek - Wynik";
            this.Load += new System.EventHandler(this.Wynik_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Button buttonPowrotdoKNN;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Panel panel1;
    }
}