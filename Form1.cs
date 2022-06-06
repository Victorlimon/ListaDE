using System;
using System.Windows.Forms;

namespace ListaDE
{
    public partial class Form1 : Form
    {
        TLisAsig Lista1;
        public Form1()
        {
            InitializeComponent();
            Lista1 = new TLisAsig();
        }

        private void button_insertar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("Escribe los datos");
                return;
            }
            else
            {
                Lista1.crearLista(textBox1.Text, int.Parse(textBox2.Text));
                textBox1.Text = "Escribir aqui";
                textBox2.Text = "";
                textBox1.Focus();
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }
        private void button_eliminar_Click(object sender, EventArgs e)
        {
            TNodoAsig elim;
            if(Lista1.BuscarAsig(textBox1.Text))
            {
                elim = (TNodoAsig)Lista1.eliminar();
                Lista1.eliminarLista(textBox1.Text);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else 
                MessageBox.Show("Lista vacia");
        }
        private void button_primero_Click(object sender, EventArgs e)
        {
            TNodoAsig nodoPrimero;
            nodoPrimero = (TNodoAsig)Lista1.getPrimero();
            if(nodoPrimero == null)
            {
                MessageBox.Show("Lista vacia");
                return;
            }
            else
            {
                textBox1.Text=nodoPrimero.dameAsig();
                textBox2.Text = (nodoPrimero.dameHoras()).ToString();
            }
        }
        private void button_anterior_Click(object sender, EventArgs e)
        {
            if(Lista1.BuscarAsig(textBox1.Text) == true)
            {
                TNodoAsig nodoAnterior = (TNodoAsig)Lista1.getAntCursor();
                textBox1.Text = nodoAnterior.dameAsig();
                textBox2.Text = (nodoAnterior.dameHoras()).ToString();
            }
            else
            {
                MessageBox.Show("La lista no tiene Sucesor");
            }
        }
        private void button_siguiente_Click(object sender, EventArgs e)
        {
            TNodoAsig nodoSucesor;
            if(Lista1.BuscarAsig(textBox1.Text) == true)
            {
                nodoSucesor = (TNodoAsig)Lista1.getProxCursor();
                textBox1.Text = nodoSucesor.dameAsig();
                textBox2.Text = (nodoSucesor.dameHoras()).ToString();
            }
            else
            {
                MessageBox.Show("La lista no tiene Sucesor");
            }
        }
        private void button_Ultimo_Click(object sender, EventArgs e)
        {
            TNodoAsig nodoUltimo;
            nodoUltimo = (TNodoAsig)Lista1.getUltimo();
            if(nodoUltimo == null)
            {
                MessageBox.Show("Lista vacia");
                return;
            }
            else
            {
                textBox1.Text=nodoUltimo.dameAsig();
                textBox2.Text=(nodoUltimo.dameHoras()).ToString();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
