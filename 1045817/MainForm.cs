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
    public partial class MainForm : Form
    {
        nov_jan_2021Entities db = new nov_jan_2021Entities();
        public MainForm()
        {
            InitializeComponent();
            GetRecords();
        }

        private void GetRecords()
        {
            var astros = db.C1045817_Astros.ToList();
            dgvRegistros.DataSource = astros;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var oForm = new AddForm();
            oForm.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
