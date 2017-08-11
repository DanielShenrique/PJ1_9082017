using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ14082107
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FAZ ESCREVER UM TEXTO NO COMEÇO
            //textBox1.Text = "HHHHHHHHHH, Fisica is bom";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            int randomNumber = rand.Next(0, trackBar1.Value);
            //FAZ ESCREVER UM TEXTO QUANDO CLICA NO BOTÃO
            //textBox1.Text = "dyuichi, dyuni, dyusan, dyugo, dyurozo ";

            //FAZ VARIOS TEXTOS QUANDO CLICA NO BOTÃO E COMEÇA A CONTAR O TRACKBOX. O "\n" FAZ PULAR LINHA
            textBox1.AppendText(" Aee" + + randomNumber);
            textBox1.AppendText("\n");

            //FAZ DESABILITAR E ABILITAR A CHECKBOX1
            if (checkBox1.Enabled)
            {
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
            }

            label1.Text = randomNumber.ToString();

            
          
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //UM TIPO DE CAIXA DE TEXTO. MODIFICAMOS PARA VIRAR UM INT
            label2.Text = trackBar1.Value.ToString();

          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
