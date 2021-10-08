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
        double PrimerOperando = 0;
        string Operador = "";
        double SegundoOperando = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ActualizarOperando(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int operando = int.Parse(button.Text);
            double valorOperadorActual = 0;
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

        private void ActualizarOperador(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Operador))
            {
                CalcularResultado(sender, e);
                SegundoOperando = 0;
            }else
                LimpiarResultado();
            Button button = (Button)sender;
            Operador = button.Text;
            txtOperador.Text = Operador;
        }

        private void CalcularResultado (object sender, EventArgs e)
        {
            switch (Operador)
            {

                case "+":
                    PrimerOperando += SegundoOperando;
                    break;
                case "-":
                    PrimerOperando -= SegundoOperando;
                    break;
                case "*":
                    PrimerOperando *= SegundoOperando;
                    break;
                case "/":
                    PrimerOperando /=  SegundoOperando;
                    break;
            }
            resultado.Text = PrimerOperando.ToString();
        }

        private void LimpiarResultado()
        {
            resultado.Text = "0";
        }

        private void LimpiarTodo(object sender, EventArgs e)
        {
            Operador = "";
            PrimerOperando = 0;
            SegundoOperando = 0;
            LimpiarResultado();
        }



    }
}
