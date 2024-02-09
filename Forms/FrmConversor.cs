using Ejercicio_C01___Conversor_binario_recargado;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Forms
{
    public partial class FrmConversor : Form
    {
        // Constructor de instancia
        public FrmConversor()
        {
            InitializeComponent();
        }

        // Caracteristicas iniciales del formulario
        private void FrmConversor_Load(object sender, EventArgs e)
        {
            tbxDecimal.ReadOnly = true;
            tbxBinario.ReadOnly = true;
        }


        // Si pasa la validación, convierte el binario ingresado a decimal
        private void btnBinarioADecimal_Click(object sender, EventArgs e)
        {
            if (!ValidarBinario(tbxBinADec))
            {
                tbxDecimal.Text = "";
                tbxBinADec.Focus();
            }
            else
            {
                NumeroBinario binario = (NumeroBinario)tbxBinADec.Text;
                NumeroDecimal numeroDesimal = (NumeroDecimal)binario;
                tbxDecimal.Text = numeroDesimal.Numero.ToString();
            }
        }


        // Si pasa la validación, convierte el decimal ingresado a binario
        private void btnDecimalABinario_Click(object sender, EventArgs e)
        {
            if (!ValidarEntero(tbxDecABin))
            {
                tbxBinario.Text = "";
                tbxDecABin.Focus();
            }
            else
            {
                if (int.TryParse(tbxDecABin.Text, out int numeroInt))
                {
                    NumeroDecimal numeroDecimal = (NumeroDecimal)numeroInt;
                    NumeroBinario binario = (NumeroBinario)numeroDecimal;
                    tbxBinario.Text = binario.Numero;
                }
                else
                {
                    tbxBinario.Text = "";
                }
            }
        }


        // Muestra una etiqueta de error si el texto ingresado no representa un binario
        private void tbxBinADec_TextChanged(object sender, EventArgs e)
        {
            lblBinarioErroneo.Text = string.IsNullOrEmpty(tbxBinADec.Text) ? "" : !ValidarBinario(tbxBinADec) ? "Formato incorrecto" : "";
        }


        // Muestra una etiqueta de error si el texto ingresado no representa un decimal
        private void tbxDecABin_TextChanged(object sender, EventArgs e)
        {
            lblDecimalErroneo.Text = string.IsNullOrEmpty(tbxDecABin.Text) ? "" : !ValidarEntero(tbxDecABin) ? "Formato incorrecto" : "";
        }
       
        
        private static bool ValidarEntero(TextBox numeroTxt)
        {
            return int.TryParse(numeroTxt.Text, out int numero) && numero >= int.MinValue && numero <= int.MaxValue ? true : string.IsNullOrEmpty(numeroTxt.Text) ? false : false;

        }


        private static bool ValidarBinario(TextBox numeroTxt)
        {
            string patron = @"^-?[01]+$";
            return Regex.IsMatch(numeroTxt.Text, patron);
        }
    }
}
