namespace LaberintoTest
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
            this.cbRaton = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnArriba = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edtHost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbRaton
            // 
            this.cbRaton.DisplayMember = "1";
            this.cbRaton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaton.FormattingEnabled = true;
            this.cbRaton.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbRaton.Location = new System.Drawing.Point(64, 35);
            this.cbRaton.Name = "cbRaton";
            this.cbRaton.Size = new System.Drawing.Size(121, 21);
            this.cbRaton.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Raton:";
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(64, 136);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(75, 23);
            this.btnAbajo.TabIndex = 11;
            this.btnAbajo.Tag = "2";
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(9, 107);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 10;
            this.btnIzquierda.Tag = "4";
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(115, 107);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 9;
            this.btnDerecha.Tag = "6";
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(200, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 238);
            this.listBox1.TabIndex = 8;
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(64, 78);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(75, 23);
            this.btnArriba.TabIndex = 7;
            this.btnArriba.Tag = "8";
            this.btnArriba.Text = "Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Host:";
            // 
            // edtHost
            // 
            this.edtHost.Location = new System.Drawing.Point(64, 12);
            this.edtHost.Name = "edtHost";
            this.edtHost.Size = new System.Drawing.Size(100, 20);
            this.edtHost.TabIndex = 15;
            this.edtHost.Text = "127.0.0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 277);
            this.Controls.Add(this.edtHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRaton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnArriba);
            this.Name = "Form1";
            this.Text = "Prueba de Laberinto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRaton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtHost;
    }
}

