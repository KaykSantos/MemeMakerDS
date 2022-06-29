using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            labelTituloIMG.Text = textBoxTitulo.Text;
            labelLegendaIMG.Text = textBoxLegenda.Text;


        }

        private void radioButtonIMG1_CheckedChanged(object sender, EventArgs e)
        {
            picBoxMeme.Image = Properties.Resources.image1;
        }

        private void radioButtonIMG2_CheckedChanged(object sender, EventArgs e)
        {
            picBoxMeme.Image = Properties.Resources.image2;
        }

        private void radioButtonIMG3_CheckedChanged(object sender, EventArgs e)
        {
            picBoxMeme.Image = Properties.Resources.image3;
        }

        private void radioButtonIMG4_CheckedChanged(object sender, EventArgs e)
        {
            picBoxMeme.Image = Properties.Resources.image4;
        }

        private void radioButtonIMG5_CheckedChanged(object sender, EventArgs e)
        {
            picBoxMeme.Image = Properties.Resources.image5;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            string avisoSair = "O aplicativo será encerrado! Tem certeza? ";
            string tituloSair = "Alerta de encerramento";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(avisoSair, tituloSair, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Ok! Saindo...", "Saindo", MessageBoxButtons.OK);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Ok, voltando!", "Saindo", MessageBoxButtons.OK);
            }
        }

        private void checkBoxTema_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxMeme.BackColor = Color.Black;
            labelTituloIMG.ForeColor = Color.White;
            labelLegendaIMG.ForeColor = Color.White;
            groupBoxMeme.ForeColor = Color.White;
        }
    }
}
