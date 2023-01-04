namespace UzmiSveVratiEure
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
            this.txtRacunEUR = new System.Windows.Forms.TextBox();
            this.txtPlacenoEUR = new System.Windows.Forms.TextBox();
            this.txtPlacenoKN = new System.Windows.Forms.TextBox();
            this.txtVratiti = new System.Windows.Forms.TextBox();
            this.txtPlacenoUkupno = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRacunEUR
            // 
            this.txtRacunEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRacunEUR.Location = new System.Drawing.Point(476, 12);
            this.txtRacunEUR.Multiline = true;
            this.txtRacunEUR.Name = "txtRacunEUR";
            this.txtRacunEUR.Size = new System.Drawing.Size(312, 61);
            this.txtRacunEUR.TabIndex = 0;
            // 
            // txtPlacenoEUR
            // 
            this.txtPlacenoEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacenoEUR.Location = new System.Drawing.Point(476, 79);
            this.txtPlacenoEUR.Multiline = true;
            this.txtPlacenoEUR.Name = "txtPlacenoEUR";
            this.txtPlacenoEUR.Size = new System.Drawing.Size(312, 61);
            this.txtPlacenoEUR.TabIndex = 1;
            // 
            // txtPlacenoKN
            // 
            this.txtPlacenoKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacenoKN.Location = new System.Drawing.Point(476, 146);
            this.txtPlacenoKN.Multiline = true;
            this.txtPlacenoKN.Name = "txtPlacenoKN";
            this.txtPlacenoKN.Size = new System.Drawing.Size(312, 61);
            this.txtPlacenoKN.TabIndex = 2;
            // 
            // txtVratiti
            // 
            this.txtVratiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVratiti.Location = new System.Drawing.Point(476, 291);
            this.txtVratiti.Multiline = true;
            this.txtVratiti.Name = "txtVratiti";
            this.txtVratiti.Size = new System.Drawing.Size(312, 61);
            this.txtVratiti.TabIndex = 6;
            this.txtVratiti.TabStop = false;
            // 
            // txtPlacenoUkupno
            // 
            this.txtPlacenoUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacenoUkupno.Location = new System.Drawing.Point(476, 224);
            this.txtPlacenoUkupno.Multiline = true;
            this.txtPlacenoUkupno.Name = "txtPlacenoUkupno";
            this.txtPlacenoUkupno.Size = new System.Drawing.Size(312, 61);
            this.txtPlacenoUkupno.TabIndex = 5;
            this.txtPlacenoUkupno.TabStop = false;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIzracunaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzracunaj.Location = new System.Drawing.Point(476, 373);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(312, 58);
            this.btnIzracunaj.TabIndex = 3;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = false;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.OrangeRed;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(12, 373);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(196, 58);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Iznos računa u EUR:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Plaćeno u EUR:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Plaćeno u KN:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Plaćeno:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vratiti:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.txtPlacenoUkupno);
            this.Controls.Add(this.txtVratiti);
            this.Controls.Add(this.txtPlacenoKN);
            this.Controls.Add(this.txtPlacenoEUR);
            this.Controls.Add(this.txtRacunEUR);
            this.Name = "Form1";
            this.Text = "Izračun povrata novca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRacunEUR;
        private System.Windows.Forms.TextBox txtPlacenoEUR;
        private System.Windows.Forms.TextBox txtPlacenoKN;
        private System.Windows.Forms.TextBox txtVratiti;
        private System.Windows.Forms.TextBox txtPlacenoUkupno;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

