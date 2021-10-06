using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCalculadora
{
    public partial class Form1 : Form
    {
        int PrimerOperando = 0;
        string Operador = "";
        int SegundoOperando = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ActualizarOperando(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int operando = int.Parse(button.Text);
            int valorOperadorActual = 0;
            if (string.IsNullOrEmpty(Operador))
                valorOperadorActual = PrimerOperando;
            else
                valorOperadorActual = SegundoOperando;
            valorOperadorActual = (valorOperadorActual * 10) + operando;
            if (string.IsNullOrEmpty(Operador))
                PrimerOperando = valorOperadorActual;
            else
                SegundoOperando = valorOperadorActual;
            resultado.Text = valorOperadorActual.ToString();
        }
        private void ActualizarSegundoOperando(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int operador = int.Parse(button.Text);
            SegundoOperando = (SegundoOperando * 10) + operador;
            resultado.Text = SegundoOperando.ToString();
        }

        private void ActualizarOperador(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operador = button.Text;
            LimpiarResultado(sender,e);
        }

        private void LimpiarResultado(object sender, EventArgs e)
        {
            resultado.Text = "0";
        }

    }
}
