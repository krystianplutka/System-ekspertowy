namespace EkspertSoczewki1
{
    partial class Knn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPowrotForm1 = new System.Windows.Forms.Button();
            this.buttonUruchom = new System.Windows.Forms.Button();
            this.labelA1 = new System.Windows.Forms.Label();
            this.labelA2 = new System.Windows.Forms.Label();
            this.labelA3 = new System.Windows.Forms.Label();
            this.labelA4 = new System.Windows.Forms.Label();
            this.textBoxAtrybut1 = new System.Windows.Forms.TextBox();
            this.textBoxAtrybut2 = new System.Windows.Forms.TextBox();
            this.textBoxAtrybut3 = new System.Windows.Forms.TextBox();
            this.textBoxAtrybut4 = new System.Windows.Forms.TextBox();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelIlośćDanych = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonPowrotForm1
            // 
            this.buttonPowrotForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPowrotForm1.Location = new System.Drawing.Point(13, 403);
            this.buttonPowrotForm1.Name = "buttonPowrotForm1";
            this.buttonPowrotForm1.Size = new System.Drawing.Size(75, 23);
            this.buttonPowrotForm1.TabIndex = 1;
            this.buttonPowrotForm1.Text = "Powrót";
            this.buttonPowrotForm1.UseVisualStyleBackColor = true;
            this.buttonPowrotForm1.Click += new System.EventHandler(this.buttonPowrotForm1_Click);
            // 
            // buttonUruchom
            // 
            this.buttonUruchom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUruchom.Location = new System.Drawing.Point(13, 360);
            this.buttonUruchom.Name = "buttonUruchom";
            this.buttonUruchom.Size = new System.Drawing.Size(123, 23);
            this.buttonUruchom.TabIndex = 2;
            this.buttonUruchom.Text = "Uruchom diagnozę";
            this.buttonUruchom.UseVisualStyleBackColor = true;
            this.buttonUruchom.Click += new System.EventHandler(this.buttonUruchom_Click);
            // 
            // labelA1
            // 
            this.labelA1.AutoSize = true;
            this.labelA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelA1.Location = new System.Drawing.Point(10, 65);
            this.labelA1.Name = "labelA1";
            this.labelA1.Size = new System.Drawing.Size(162, 52);
            this.labelA1.TabIndex = 3;
            this.labelA1.Text = "Wiek pacjenta: \n 1 -> Młody\n 2 -> Przed starczowzrocznością \n 3 -> Ze starczowzro" +
    "cznością";
            // 
            // labelA2
            // 
            this.labelA2.AutoSize = true;
            this.labelA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelA2.Location = new System.Drawing.Point(10, 145);
            this.labelA2.Name = "labelA2";
            this.labelA2.Size = new System.Drawing.Size(124, 39);
            this.labelA2.TabIndex = 4;
            this.labelA2.Text = "Recepta na okulary: \n 1 -> Krótkowzroczność, \n 2 -> Dalekowzroczność";
            // 
            // labelA3
            // 
            this.labelA3.AutoSize = true;
            this.labelA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelA3.Location = new System.Drawing.Point(10, 210);
            this.labelA3.Name = "labelA3";
            this.labelA3.Size = new System.Drawing.Size(74, 39);
            this.labelA3.TabIndex = 5;
            this.labelA3.Text = "Astygmatyzm: \n 1 -> Tak \n 2 -> Nie";
            // 
            // labelA4
            // 
            this.labelA4.AutoSize = true;
            this.labelA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelA4.Location = new System.Drawing.Point(10, 276);
            this.labelA4.Name = "labelA4";
            this.labelA4.Size = new System.Drawing.Size(132, 39);
            this.labelA4.TabIndex = 6;
            this.labelA4.Text = "Ilość produkowanych łez: \n 1 -> Niska \n 2 -> Normalna";
            // 
            // textBoxAtrybut1
            // 
            this.textBoxAtrybut1.Location = new System.Drawing.Point(13, 124);
            this.textBoxAtrybut1.Name = "textBoxAtrybut1";
            this.textBoxAtrybut1.Size = new System.Drawing.Size(50, 20);
            this.textBoxAtrybut1.TabIndex = 8;
            // 
            // textBoxAtrybut2
            // 
            this.textBoxAtrybut2.Location = new System.Drawing.Point(13, 189);
            this.textBoxAtrybut2.Name = "textBoxAtrybut2";
            this.textBoxAtrybut2.Size = new System.Drawing.Size(50, 20);
            this.textBoxAtrybut2.TabIndex = 9;
            this.textBoxAtrybut2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxAtrybut3
            // 
            this.textBoxAtrybut3.Location = new System.Drawing.Point(13, 255);
            this.textBoxAtrybut3.Name = "textBoxAtrybut3";
            this.textBoxAtrybut3.Size = new System.Drawing.Size(50, 20);
            this.textBoxAtrybut3.TabIndex = 10;
            // 
            // textBoxAtrybut4
            // 
            this.textBoxAtrybut4.Location = new System.Drawing.Point(13, 321);
            this.textBoxAtrybut4.Name = "textBoxAtrybut4";
            this.textBoxAtrybut4.Size = new System.Drawing.Size(50, 20);
            this.textBoxAtrybut4.TabIndex = 11;
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis.Location = new System.Drawing.Point(10, 29);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(202, 13);
            this.labelOpis.TabIndex = 15;
            this.labelOpis.Text = "Wprowadź wartości dla każdego atrybutu";
            // 
            // labelIlośćDanych
            // 
            this.labelIlośćDanych.AutoSize = true;
            this.labelIlośćDanych.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIlośćDanych.Location = new System.Drawing.Point(229, 360);
            this.labelIlośćDanych.Name = "labelIlośćDanych";
            this.labelIlośćDanych.Size = new System.Drawing.Size(0, 13);
            this.labelIlośćDanych.TabIndex = 16;
            this.labelIlośćDanych.Click += new System.EventHandler(this.labelIlośćDanych_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.labelA4);
            this.panel1.Controls.Add(this.labelIlośćDanych);
            this.panel1.Controls.Add(this.textBoxAtrybut4);
            this.panel1.Controls.Add(this.labelOpis);
            this.panel1.Controls.Add(this.textBoxAtrybut3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buttonPowrotForm1);
            this.panel1.Controls.Add(this.labelA1);
            this.panel1.Controls.Add(this.textBoxAtrybut1);
            this.panel1.Controls.Add(this.textBoxAtrybut2);
            this.panel1.Controls.Add(this.labelA3);
            this.panel1.Controls.Add(this.buttonUruchom);
            this.panel1.Controls.Add(this.labelA2);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 451);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Knn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Knn";
            this.Text = "System ekspertowy wspomagający wybór soczewek - Wprowadzanie danych";
            this.Load += new System.EventHandler(this.Knn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPowrotForm1;
        private System.Windows.Forms.Button buttonUruchom;
        private System.Windows.Forms.Label labelA1;
        private System.Windows.Forms.Label labelA2;
        private System.Windows.Forms.Label labelA3;
        private System.Windows.Forms.Label labelA4;
        
        private System.Windows.Forms.TextBox textBoxAtrybut1;
        private System.Windows.Forms.TextBox textBoxAtrybut2;
        private System.Windows.Forms.TextBox textBoxAtrybut3;
        private System.Windows.Forms.TextBox textBoxAtrybut4;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelIlośćDanych;
        private System.Windows.Forms.Panel panel1;
    }
}