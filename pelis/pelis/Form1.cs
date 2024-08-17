using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pelis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dtbpelisDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtbpelisDataSet.Table' Puede moverla o quitarla según sea necesario.
            this.tableTableAdapter.Fill(this.dtbpelisDataSet.Table);
            registro();

        }
        private void registro()
        {
            lblRegistro.Text = (tableBindingSource.Position + 1) + "de" + tableBindingSource.Count;
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            tableBindingSource.MoveFirst();
            registro();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tableBindingSource.MovePrevious();
            registro();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            tableBindingSource.MoveNext();
            registro();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            tableBindingSource.MoveLast();
            registro();
        }
        private void estadoCtrls(Boolean estado)
        {
            grbNavegacion.Enabled = estado;
            btnEliminar.Enabled = estado;
            grbDatos.Enabled = !estado;
            registro();

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(btnAgregar.Text == "Agregar")
            {
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                estadoCtrls(false);
                tableBindingSource.AddNew();//agregar el nuevo registro
            }
            else
            {//Guardar
                tableBindingSource.EndEdit();
                tableTableAdapter.Update(this.dtbpelisDataSet);
                estadoCtrls(true);
                btnAgregar.Text = "Agregar";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                btnAgregar.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                estadoCtrls(false);
            }
            else
            {//Cancelar
                tableBindingSource.CancelEdit();
                estadoCtrls(true);
                btnAgregar.Text = "Agregar";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de eliminar a" + tituloTextBox.Text.Trim() + "?", "Eliminando registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { }
            tableBindingSource.RemoveCurrent();
            tableTableAdapter.Update(dtbpelisDataSet);
            registro();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {//aun no lo hago funcionar
            BindingSource bs = new BindingSource();
            bs.DataSource = tableDataGridView.DataSource;
            //bs.Filter = "titulo like" '%" + txt.buscar "%';
        }
    }
}
