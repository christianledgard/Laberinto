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
using System.Collections;


// 0: Camino no explorado
// 1: Pared
// 2: Posicion Actual
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
            private const int tablaLargo = 40;
            private const int tablaAlto = 23;
            private int[,] array = new int[tablaAlto, tablaLargo];
            private int[] ubicacionActual = new int[] { 3, 1 };

            public Array() {
                //Inicializo el Array en 0's
                for (int i = 0; i < tablaAlto; ++i)
                {
                    for (int j = 0; j < tablaLargo; ++j)
                    {
                        array[i, j] = 0;
                    }
                }

                for (int i = 0; i < tablaLargo; i++)
                {
                    array[0, i] = 1;
                    array[tablaAlto - 1, i] = 1;
                }

                for (int i = 0; i < tablaAlto; i++)
                {
                    array[i, 0] = 1;
                    array[i, tablaLargo - 1] = 1;
                    array[i, 1] = 1;
                }

                array[3, 1] = 0;
            }
            public void updateLocation(int x, int y)
            {
                ubicacionActual[0] = x;
                ubicacionActual[1] = y;
            }

            public void updateLocationPro(int direccion)
            {
                if (direccion == 2)
                    updateLocation(ubicacionActual[0] + 1, ubicacionActual[1]);
                else if (direccion == 4)
                    updateLocation(ubicacionActual[0], ubicacionActual[1] - 1);
                else if (direccion == 6)
                    updateLocation(ubicacionActual[0], ubicacionActual[1] + 1);
                else if (direccion == 8)
                    updateLocation(ubicacionActual[0] -1 , ubicacionActual[1]);

            }

            public void Obstaculo(int direccion, int numero)
            {
                if (direccion == 2)
                    array[ubicacionActual[0] + 1, ubicacionActual[1]] = numero;
                else if (direccion == 4)
                    array[ubicacionActual[0], ubicacionActual[1] - 1] = numero;
                else if (direccion == 6)
                    array[ubicacionActual[0], ubicacionActual[1] + 1] = numero;
                else if (direccion == 8)
                    array[ubicacionActual[0] - 1, ubicacionActual[1]] = numero;

            }
            

            public bool Exist(int ubicacion, int valorABuscar)
            {
                if (ubicacion == 2)
                    if (getElement(ubicacionActual[0] + 1, ubicacionActual[1]) == valorABuscar)
                        return true;
                    else
                        return false;
                else if (ubicacion == 4)
                    if (getElement(ubicacionActual[0], ubicacionActual[1] - 1) == valorABuscar)
                        return true;
                    else
                        return false;
                else if (ubicacion == 6)
                    if (getElement(ubicacionActual[0], ubicacionActual[1] + 1) == valorABuscar)
                        return true;
                    else
                        return false;
                else if (ubicacion == 8)
                    if (getElement(ubicacionActual[0] - 1, ubicacionActual[1]) == valorABuscar)
                        return true;
                    else
                        return false;
                else
                    return false;

            }

            public void marcarUbicacionActual()
            {
                array[ubicacionActual[0], ubicacionActual[1]] = 2;
            }

            public int getTablaLenX()
            {
                return tablaLargo;
            }

            public int getTablaLenY()
            {
                return tablaAlto;
            }

            public int getElement(int x, int y) {
                return array[x, y];
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
            string Cp = "Cp", De = "De", Iz = "Iz", Ab = "Ab", Ar = "Ar", Cc = "Cc";

            Array arreglo = new Array();
            ArrayList movimientosRetorno = new ArrayList();
            int choclosComidos = 0;
            int dirActual;
            Random r = new Random((int)DateTime.Now.Ticks);


            for (int i = 0; i < 15000; ++i)
            {

                dirActual = r.Next(1, 5) * 2;


                if (!arreglo.Exist(dirActual, 1))
                {

                    string mensaje = enviarDATOS(dirActual);

                    if (mensaje.StartsWith(Cc))
                    {
                        movimientosRetorno.Reverse();
                        foreach (int j in movimientosRetorno)
                        {
                            enviarDATOS(j);
                            arreglo.updateLocationPro(j);
                        }
                        movimientosRetorno.Clear();
                        choclosComidos++;
                        if (choclosComidos == 20)
                            break;

                    }
                    else
                    {
                        if (mensaje.StartsWith(Ab) || mensaje.StartsWith(Iz) || mensaje.StartsWith(De) || mensaje.StartsWith(Ar))
                            arreglo.updateLocationPro(dirActual);

                        if (dirActual == 2 && mensaje.StartsWith(Ab))
                            movimientosRetorno.Add(8);

                        if (dirActual == 4 && mensaje.StartsWith(Iz))
                            movimientosRetorno.Add(6);

                        if (dirActual == 6 && mensaje.StartsWith(De))
                            movimientosRetorno.Add(4);

                        if (dirActual == 8 && mensaje.StartsWith(Ar))
                            movimientosRetorno.Add(2);

                        if (mensaje.StartsWith(Cp))
                            arreglo.Obstaculo(dirActual,1);
                    }

                    printInTextBox(dirActual.ToString());
                    printInTextBox(mensaje);
                }


            }

            ImprimirArreglo(arreglo);

        }

        private void ImprimirArreglo(Array arreglo)
        {
            arreglo.marcarUbicacionActual();

            listBox2.Items.Clear();

            string print = "";

            for (int i = 0; i < arreglo.getTablaLenY(); ++i)
            {
                for (int j = 0; j < arreglo.getTablaLenX(); ++j)
                {
                    print += arreglo.getElementString(i, j); print += " ";
                }
                printInTextBox2(print);
                print = "";
            }
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
