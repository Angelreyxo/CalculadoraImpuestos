using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraImpuestos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void txtAfp_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtArs_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtIsr_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtDescuentoTotal_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtSueldoNeto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // instancio un usuario para la clase nomina
            ClaNomina usuario = new ClaNomina();

            // asignos los valores al usuario
            usuario.nombre = txtNombre.Text;
            double sueldo = double.Parse(txtSueldoBruto.Text);
            usuario.sueldo = sueldo;

            // Resultado que se va a mostrar por pantalla
            txtAfp.Text = usuario.calcularAfp(usuario.sueldo).ToString();
            txtArs.Text = usuario.calcularArs(usuario.sueldo).ToString();
            txtIsr.Text = usuario.calculoIsr(usuario.sueldo).ToString();
            txtDescuentoTotal.Text = usuario.descuentoTotal();
            txtSueldoNeto.Text = usuario.sueldoNeto();
            lblDetalle.Text = "Se verificaron los descuentos a: " + usuario.nombre;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtSueldoBruto.Text = "";
            txtAfp.Text = "";
            txtArs.Text = "";
            txtIsr.Text = "";
            txtDescuentoTotal.Text = "";
            txtSueldoNeto.Text = "";
            lblDetalle.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= 33 && e.KeyChar<=64 || e.KeyChar>=91 && e.KeyChar<=96 || e.KeyChar >=123 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo puede ingresar Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSueldoBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >=32 && e.KeyChar<=47 || e.KeyChar>= 58 && e.KeyChar <= 255)
            {
                MessageBox.Show("Solo puede ingresar Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
