namespace pelis
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label sinopsisLabel;
            System.Windows.Forms.Label duracionLabel;
            System.Windows.Forms.Label clasificacionLabel;
            this.dtbpelisDataSet = new pelis.DtbpelisDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new pelis.DtbpelisDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new pelis.DtbpelisDataSetTableAdapters.TableAdapterManager();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.sinopsisTextBox = new System.Windows.Forms.TextBox();
            this.duracionTextBox = new System.Windows.Forms.TextBox();
            this.clasificacionTextBox = new System.Windows.Forms.TextBox();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            sinopsisLabel = new System.Windows.Forms.Label();
            duracionLabel = new System.Windows.Forms.Label();
            clasificacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtbpelisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.grbNavegacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtbpelisDataSet
            // 
            this.dtbpelisDataSet.DataSetName = "DtbpelisDataSet";
            this.dtbpelisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dtbpelisDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = pelis.DtbpelisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(13, 20);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(32, 22);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(183, 25);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 23);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Text = "label1";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloLabel.Location = new System.Drawing.Point(13, 65);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(67, 22);
            tituloLabel.TabIndex = 3;
            tituloLabel.Text = "Titulo:";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(170, 67);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(153, 22);
            this.tituloTextBox.TabIndex = 4;
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.Location = new System.Drawing.Point(13, 105);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(64, 22);
            autorLabel.TabIndex = 5;
            autorLabel.Text = "Autor:";
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(170, 107);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(100, 22);
            this.autorTextBox.TabIndex = 6;
            // 
            // sinopsisLabel
            // 
            sinopsisLabel.AutoSize = true;
            sinopsisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sinopsisLabel.Location = new System.Drawing.Point(13, 153);
            sinopsisLabel.Name = "sinopsisLabel";
            sinopsisLabel.Size = new System.Drawing.Size(92, 22);
            sinopsisLabel.TabIndex = 7;
            sinopsisLabel.Text = "Sinopsis:";
            // 
            // sinopsisTextBox
            // 
            this.sinopsisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Sinopsis", true));
            this.sinopsisTextBox.Location = new System.Drawing.Point(170, 155);
            this.sinopsisTextBox.Multiline = true;
            this.sinopsisTextBox.Name = "sinopsisTextBox";
            this.sinopsisTextBox.Size = new System.Drawing.Size(250, 49);
            this.sinopsisTextBox.TabIndex = 8;
            // 
            // duracionLabel
            // 
            duracionLabel.AutoSize = true;
            duracionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            duracionLabel.Location = new System.Drawing.Point(13, 231);
            duracionLabel.Name = "duracionLabel";
            duracionLabel.Size = new System.Drawing.Size(96, 22);
            duracionLabel.TabIndex = 9;
            duracionLabel.Text = "Duracion:";
            // 
            // duracionTextBox
            // 
            this.duracionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Duracion", true));
            this.duracionTextBox.Location = new System.Drawing.Point(170, 233);
            this.duracionTextBox.Name = "duracionTextBox";
            this.duracionTextBox.Size = new System.Drawing.Size(124, 22);
            this.duracionTextBox.TabIndex = 10;
            // 
            // clasificacionLabel
            // 
            clasificacionLabel.AutoSize = true;
            clasificacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clasificacionLabel.Location = new System.Drawing.Point(13, 285);
            clasificacionLabel.Name = "clasificacionLabel";
            clasificacionLabel.Size = new System.Drawing.Size(130, 22);
            clasificacionLabel.TabIndex = 11;
            clasificacionLabel.Text = "Clasificacion:";
            // 
            // clasificacionTextBox
            // 
            this.clasificacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Clasificacion", true));
            this.clasificacionTextBox.Location = new System.Drawing.Point(170, 285);
            this.clasificacionTextBox.Name = "clasificacionTextBox";
            this.clasificacionTextBox.Size = new System.Drawing.Size(100, 22);
            this.clasificacionTextBox.TabIndex = 12;
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblRegistro);
            this.grbNavegacion.Controls.Add(this.btnUltimo);
            this.grbNavegacion.Controls.Add(this.btnPrimero);
            this.grbNavegacion.Controls.Add(this.btnSiguiente);
            this.grbNavegacion.Controls.Add(this.btnAnterior);
            this.grbNavegacion.Location = new System.Drawing.Point(16, 361);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(669, 77);
            this.grbNavegacion.TabIndex = 13;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(13, 21);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(100, 50);
            this.btnPrimero.TabIndex = 14;
            this.btnPrimero.Text = "I<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(137, 21);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(92, 50);
            this.btnAnterior.TabIndex = 15;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(391, 21);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 50);
            this.btnSiguiente.TabIndex = 16;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(544, 21);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(99, 50);
            this.btnUltimo.TabIndex = 17;
            this.btnUltimo.Text = ">I";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(616, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 282);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edicion";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(43, 42);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 44);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(43, 127);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 52);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(43, 222);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 38);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Id", true));
            this.lblRegistro.Location = new System.Drawing.Point(258, 38);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(100, 23);
            this.lblRegistro.TabIndex = 15;
            this.lblRegistro.Text = "x de n";
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(tituloLabel);
            this.grbDatos.Controls.Add(this.clasificacionTextBox);
            this.grbDatos.Controls.Add(clasificacionLabel);
            this.grbDatos.Controls.Add(idLabel);
            this.grbDatos.Controls.Add(this.duracionTextBox);
            this.grbDatos.Controls.Add(this.idLabel1);
            this.grbDatos.Controls.Add(duracionLabel);
            this.grbDatos.Controls.Add(this.sinopsisTextBox);
            this.grbDatos.Controls.Add(this.tituloTextBox);
            this.grbDatos.Controls.Add(sinopsisLabel);
            this.grbDatos.Controls.Add(autorLabel);
            this.grbDatos.Controls.Add(this.autorTextBox);
            this.grbDatos.Location = new System.Drawing.Point(12, 3);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(495, 352);
            this.grbDatos.TabIndex = 15;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToAddRows = false;
            this.tableDataGridView.AllowUserToDeleteRows = false;
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(849, 92);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.ReadOnly = true;
            this.tableDataGridView.RowHeadersWidth = 51;
            this.tableDataGridView.RowTemplate.Height = 24;
            this.tableDataGridView.Size = new System.Drawing.Size(499, 225);
            this.tableDataGridView.TabIndex = 15;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(874, 50);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(488, 22);
            this.txtBuscar.TabIndex = 16;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sinopsis";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sinopsis";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Duracion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Duracion";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Clasificacion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Clasificacion";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 458);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbNavegacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtbpelisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.grbNavegacion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DtbpelisDataSet dtbpelisDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DtbpelisDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private DtbpelisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox sinopsisTextBox;
        private System.Windows.Forms.TextBox duracionTextBox;
        private System.Windows.Forms.TextBox clasificacionTextBox;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}

