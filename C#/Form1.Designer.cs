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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.cbRaton.Location = new System.Drawing.Point(96, 54);
            this.cbRaton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRaton.Name = "cbRaton";
            this.cbRaton.Size = new System.Drawing.Size(180, 28);
            this.cbRaton.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Raton:";
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(96, 209);
            this.btnAbajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(112, 35);
            this.btnAbajo.TabIndex = 11;
            this.btnAbajo.Tag = "2";
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(14, 165);
            this.btnIzquierda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(112, 35);
            this.btnIzquierda.TabIndex = 10;
            this.btnIzquierda.Tag = "4";
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(172, 165);
            this.btnDerecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(112, 35);
            this.btnDerecha.TabIndex = 9;
            this.btnDerecha.Tag = "6";
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(300, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 364);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(96, 120);
            this.btnArriba.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(112, 35);
            this.btnArriba.TabIndex = 7;
            this.btnArriba.Tag = "8";
            this.btnArriba.Text = "Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Host:";
            // 
            // edtHost
            // 
            this.edtHost.Location = new System.Drawing.Point(96, 18);
            this.edtHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtHost.Name = "edtHost";
            this.edtHost.Size = new System.Drawing.Size(148, 26);
            this.edtHost.TabIndex = 15;
            this.edtHost.Text = "127.0.0.1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "Movimiento Aleatorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Comer TODO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 426);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edtHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRaton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnArriba);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

