namespace EkspertSoczewki1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRozpocznij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAutorzy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRozpocznij
            // 
            this.buttonRozpocznij.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRozpocznij.Location = new System.Drawing.Point(177, 198);
            this.buttonRozpocznij.Name = "buttonRozpocznij";
            this.buttonRozpocznij.Size = new System.Drawing.Size(209, 57);
            this.buttonRozpocznij.TabIndex = 0;
            this.buttonRozpocznij.Text = "Rozpocznij";
            this.buttonRozpocznij.UseVisualStyleBackColor = true;
            this.buttonRozpocznij.Click += new System.EventHandler(this.buttonRozpocznij_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(106, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "System ekspertowy wspomagający wybór soczewek";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.labelAutorzy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonRozpocznij);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 392);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelAutorzy
            // 
            this.labelAutorzy.AutoSize = true;
            this.labelAutorzy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelAutorzy.Location = new System.Drawing.Point(22, 262);
            this.labelAutorzy.Name = "labelAutorzy";
            this.labelAutorzy.Size = new System.Drawing.Size(46, 18);
            this.labelAutorzy.TabIndex = 2;
            this.labelAutorzy.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 392);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "System ekspertowy wspomagający wybór soczewek - Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRozpocznij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAutorzy;
    }
}

