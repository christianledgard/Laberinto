using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace LaberintoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbRaton.SelectedIndex = 0;
        }

        //enviarDATOS envia los datos para ejecutar el juego
        // enviarDATOS(x), si x=2 ABAJO, si x=4 IZQ, si x=6 DER, si x=8 ARRIBA.
        private string enviarDATOS(int Direccion) {
            string request = cbRaton.Text + Direccion.ToString() + "\r\n";
            Byte[] bytesSent = Encoding.ASCII.GetBytes(request);
            Byte[] bytesReceived = new Byte[256];

            Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                ClientSocket.Connect(edtHost.Text, 3000);
                if (!ClientSocket.Connected)
                    throw new Exception();
                ClientSocket.Send(bytesSent, bytesSent.Length, 0);
                int bytes = 0;
                string result = "";

                // Esto hace que funcione como un blocking connection
                do
                {
                    bytes = ClientSocket.Receive(bytesReceived, bytesReceived.Length, 0);
                    result = result + Encoding.ASCII.GetString(bytesReceived, 0, bytes);
                }
                while (bytes > 0);
                return result;
            }
            catch (Exception)
            {
                return "No se pudo conectar";
            }

            
        }

        //printInTextBox imprime un string en el recuadro.
        private void printInTextBox(string texto)
        {
            listBox1.Items.Add(texto);
        }
        private void printInTextBox2(string texto)
        {
            listBox2.Items.Add(texto);
        }


        class Array {
            private const int tablaLargo = 39;
            private const int tablaAlto = 23;
            private int[,] array = new int[tablaAlto, tablaLargo];
            private int[] ubicacionActual = new int[] {19,0};

            public Array() {
                //Inicializo el Array en 0's
                for (int i = 0; i < tablaAlto; ++i)
                {
                    for (int j = 0; j < tablaLargo; ++j)
                    {
                        array[i, j] = 0;
                    }
                }
            }
            public void updateLocation(int x, int y)
            {
                ubicacionActual[0] = x;
                ubicacionActual[1] = y;
            }

            public void abajoCP()
            {
                array[ubicacionActual[0], ubicacionActual[1] - 1] = 1;
            }
            public void arribaCP()
            {
                array[ubicacionActual[0], ubicacionActual[1] + 1] = 1;
            }
            public void derechaCP()
            {
                array[ubicacionActual[0] + 1, ubicacionActual[1]] = 1;
            }
            public void izquierdaCP()
            {
                array[ubicacionActual[0] - 1, ubicacionActual[1]] = 1;
            }

            public int getTablaLenX()
            {
                return tablaLargo;
            }

            public int getTablaLenY()
            {
                return tablaAlto;
            }

            public int getElement(int x, int y){
                return array[x,y];
            }

            public string getElementString(int x, int y)
            {
                string resultado = array[x, y].ToString();
                return resultado;
            }


        };

        private void btnArriba_Click(object sender, EventArgs e)
        {
            string request = cbRaton.Text + ((Button)sender).Tag.ToString() + "\r\n";
            Byte[] bytesSent = Encoding.ASCII.GetBytes(request);
            Byte[] bytesReceived = new Byte[256];

            Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                ClientSocket.Connect(edtHost.Text, 3000);
                if (!ClientSocket.Connected)
                    throw new Exception();
                ClientSocket.Send(bytesSent, bytesSent.Length, 0);
                int bytes = 0;
                string result = "";

                // Esto hace que funcione como un blocking connection
                do
                {
                    bytes = ClientSocket.Receive(bytesReceived, bytesReceived.Length, 0);
                    result = result + Encoding.ASCII.GetString(bytesReceived, 0, bytes);
                }
                while (bytes > 0);

                listBox1.Items.Add(result);
            }
            catch (Exception)
            {
                listBox1.Items.Add("No se pudo conectar");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
            while (true)
            {
                Random r = new Random((int)DateTime.Now.Ticks);
                int Direccion = r.Next(1, 4) * 2;
                printInTextBox(enviarDATOS(Direccion));
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Array arreglo = new Array();

            for (int i = 0; i < 4 ;++i)
            {
                Random r = new Random((int)DateTime.Now.Ticks);
                int dirActual = r.Next(1, 5) * 2;

                string mensaje = enviarDATOS(dirActual);

                printInTextBox2(mensaje);
                printInTextBox2(dirActual.ToString());

                textBox1.AppendText((string.Equals(mensaje,"Cp")).ToString());

                if (dirActual == 2 && mensaje == "Cp")
                {
                    arreglo.abajoCP();
                } // 2 = Abajo

                if (dirActual == 4 && mensaje == "Cp") // 4 = Izquierda
                    arreglo.izquierdaCP();

                if (dirActual == 6 && mensaje == "Cp") // 6 = Derecha
                    arreglo.derechaCP();

                if (dirActual == 8 && mensaje == "Cp") // 8 = Arriba
                    arreglo.arribaCP();
                

                printInTextBox(dirActual.ToString());
            }

            /*
            listBox2.Items.Clear();
            
            string print = "";

            for(int i = 0; i < arreglo.getTablaLenY(); ++i)
            {
                for(int j = 0; j < arreglo.getTablaLenX(); ++j)
                {
                    print += arreglo.getElementString(i, j); 
                }
                printInTextBox2(print);
                print = "";
            }
             */

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
