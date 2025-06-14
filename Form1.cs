using System.Globalization;

namespace Calcular_IMC
{
    public partial class FormCalcularIMC : Form
    {
        private clsCalcularIMC clsCalcularIMC;
        public FormCalcularIMC()
        {
            clsCalcularIMC = new clsCalcularIMC();
            InitializeComponent();
            //permite cambiar el punto por la coma y viceversa
            CultureInfo cultura = new CultureInfo("es-MX");
            CultureInfo.DefaultThreadCurrentCulture = cultura;
            CultureInfo.DefaultThreadCurrentUICulture = cultura;
        }
        private void btnIMC_Click(object sender, EventArgs e)
        {
            //Evita que las textbox puedan irse sin valores
            if (string.IsNullOrWhiteSpace(txtEstatura.Text))
            {
                MessageBox.Show("Por favor ingrese la estatura para continuar", "Error");
                txtEstatura.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                MessageBox.Show("Por favor ingrese su peso para continuar", "Error");
                txtPeso.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtZancada.Text))
            {
                MessageBox.Show("Por favor ingrese su zancada para continuar", "Error");
                txtZancada.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPasos.Text))
            {
                MessageBox.Show("Porfavor ingrese su número de pasos para continuar", "Error");
                txtPasos.Focus();
                return;
            }
            //ejecuta los calculos
            clsCalcularIMC.calcularIMC(float.Parse(txtEstatura.Text), float.Parse(txtPeso.Text));
            clsCalcularIMC.calcularKm(float.Parse(txtZancada.Text), float.Parse(txtPasos.Text));
            clsCalcularIMC.evaluarPasos(float.Parse(txtPasos.Text));
            //muestra los resultados
            MessageBox.Show(clsCalcularIMC.resultados(), "Calcular IMC");
            //limpia las textbox para poder ingresar nuevos datos
            txtEstatura.Text = "";
            txtPeso.Text = "";
            txtZancada.Text = "";
            txtPasos.Text = "";
        }
        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            //valida que solo se puedan colocar digitos, puntos y borrar datos con el backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            //valida que solo pueden escribirse 4 digitos solamente
            if (txtEstatura.Text.Length >= 4 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            //valida para que no pueda haber más de un punto decimal
            if (e.KeyChar == '.' && txtEstatura.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (txtPeso.Text.Length >= 4 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtPeso.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void txtZancada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (txtZancada.Text.Length >= 4 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtZancada.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void txtPasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //valida que solo se puedan colocar digitos, puntos y borrar datos con el backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            //valida que solo pueden escribirse 5 digitos solamente
            if (txtPasos.Text.Length >= 5 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}