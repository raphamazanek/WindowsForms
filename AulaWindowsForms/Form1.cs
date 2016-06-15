using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaWindowsForms
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {            
            if(!string.IsNullOrEmpty(txtNumeroDois.Text) && !string.IsNullOrEmpty(txtNumeroDois.Text))
            {
                double numero1 = Convert.ToDouble(txtNumeroUm.Text);
                double numero2 = Convert.ToDouble(txtNumeroDois.Text);
                double soma = (numero1 + numero2);

                //Mostrar Mensagem com o resultado.
                MessageBox.Show("Soma: " + soma,
                                "Resultado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                //Mostrar resultado na Label.
                lblResultado.Text = "Resultado: " + soma; 
            }
            else
            {
                MessageBox.Show("Preencha o Campo de texto.",
                                "ERRO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

     }
}
