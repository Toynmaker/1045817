using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleIV._1045817
{
    public partial class AddForm : Form
    {
        nov_jan_2021Entities db = new nov_jan_2021Entities();
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            var astro = new C1045817_Astros();
            astro.ClasificacionAstro = cboClasificacion.Text;
            astro.TipoSuperficie = cboSuperficie.Text;
            astro.Nombre = txtNombre.Text;
            astro.Edad = Convert.ToInt32(intEdad.Text);
            astro.Color = txtColor.Text;
            astro.RadioPlanetaKm = Convert.ToInt32(intRadio.Text);

            db.C1045817_Astros.Add(astro);
            var added = db.SaveChanges() > 0;

            if (added)
            {
                MessageBox.Show($"El Astro {txtNombre.Text} fue agregado correctamente.");
                ClearForm();
            }
        }

        private void ClearForm()
        {
            cboClasificacion.Text = string.Empty;
            cboSuperficie.Text = string.Empty;
            txtNombre.Text = string.Empty;
            intEdad.Text = string.Empty;
            txtColor.Text = string.Empty;
            intRadio.Text = string.Empty;
            intCantidad.Text = string.Empty;
            intTemperatura.Text = string.Empty;
            intDistancia.Text = string.Empty;
            floatGravedad.Text = string.Empty;
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void intEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void floatGravedad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
