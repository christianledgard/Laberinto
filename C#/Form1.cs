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

        class Array {

            public Array() {
                int tablaLargo = 39;
                int tablaAlto = 23;
                int[,] array = new int[tablaAlto, tablaLargo];

                for (int i = 0; i < tablaAlto; ++i)
                {
                    for (int j = 0; j < tablaLargo; ++j)
                    {
                        array[i, j] = 0;
                    }
                }
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

            Random r = new Random((int)DateTime.Now.Ticks);
            int Direccion = r.Next(1, 4) * 2;
            Direccion = 8;

            printInTextBox(enviarDATOS(Direccion));
            printInTextBox(Direccion.ToString());


        }
    }
}
