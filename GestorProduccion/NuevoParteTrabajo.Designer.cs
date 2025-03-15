namespace GestorProduccion
{
    partial class NuevoParteTrabajo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoParteTrabajo));
            this.dgvParteTrabajo = new System.Windows.Forms.DataGridView();
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.btnBloquearFechaAndTrabajador = new System.Windows.Forms.Button();
            this.cbTrabajador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnAñadirTarea = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTiempoInvertido = new System.Windows.Forms.TextBox();
            this.nudCantidadPiezas = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcularAndRegistrarRendimiento = new System.Windows.Forms.Button();
            this.txtRendimiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.parteTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1TrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2TrabajadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piezasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoInvertidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminarTarea = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParteTrabajo)).BeginInit();
            this.PanelOpciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPiezas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parteTrabajoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParteTrabajo
            // 
            this.dgvParteTrabajo.AllowUserToAddRows = false;
            this.dgvParteTrabajo.AllowUserToDeleteRows = false;
            this.dgvParteTrabajo.AutoGenerateColumns = false;
            this.dgvParteTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParteTrabajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreTrabajadorDataGridViewTextBoxColumn,
            this.apellido1TrabajadorDataGridViewTextBoxColumn,
            this.apellido2TrabajadorDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.piezasDataGridViewTextBoxColumn,
            this.tiempoInvertidoDataGridViewTextBoxColumn,
            this.colEliminarTarea});
            this.dgvParteTrabajo.DataSource = this.parteTrabajoBindingSource;
            this.dgvParteTrabajo.Location = new System.Drawing.Point(26, 25);
            this.dgvParteTrabajo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvParteTrabajo.Name = "dgvParteTrabajo";
            this.dgvParteTrabajo.ReadOnly = true;
            this.dgvParteTrabajo.RowHeadersWidth = 82;
            this.dgvParteTrabajo.Size = new System.Drawing.Size(1874, 452);
            this.dgvParteTrabajo.TabIndex = 0;
            this.dgvParteTrabajo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParte_CellContentClick);
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOpciones.Controls.Add(this.btnBloquearFechaAndTrabajador);
            this.PanelOpciones.Controls.Add(this.cbTrabajador);
            this.PanelOpciones.Controls.Add(this.label4);
            this.PanelOpciones.Controls.Add(this.label3);
            this.PanelOpciones.Controls.Add(this.dtpFecha);
            this.PanelOpciones.Location = new System.Drawing.Point(26, 490);
            this.PanelOpciones.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(486, 294);
            this.PanelOpciones.TabIndex = 1;
            // 
            // btnBloquearFechaAndTrabajador
            // 
            this.btnBloquearFechaAndTrabajador.Location = new System.Drawing.Point(12, 212);
            this.btnBloquearFechaAndTrabajador.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBloquearFechaAndTrabajador.Name = "btnBloquearFechaAndTrabajador";
            this.btnBloquearFechaAndTrabajador.Size = new System.Drawing.Size(466, 75);
            this.btnBloquearFechaAndTrabajador.TabIndex = 9;
            this.btnBloquearFechaAndTrabajador.Text = "1er Paso: Bloquear Datos para Archivar";
            this.btnBloquearFechaAndTrabajador.UseVisualStyleBackColor = true;
            this.btnBloquearFechaAndTrabajador.Click += new System.EventHandler(this.btnBloquearFechaAndTrabajador_Click);
            // 
            // cbTrabajador
            // 
            this.cbTrabajador.FormattingEnabled = true;
            this.cbTrabajador.Location = new System.Drawing.Point(16, 94);
            this.cbTrabajador.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbTrabajador.Name = "cbTrabajador";
            this.cbTrabajador.Size = new System.Drawing.Size(458, 33);
            this.cbTrabajador.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seleccionar Trabajador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccionar Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(216, 9);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(258, 31);
            this.dtpFecha.TabIndex = 5;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(272, 37);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(310, 33);
            this.cbCliente.TabIndex = 0;
            this.cbCliente.SelectedValueChanged += new System.EventHandler(this.cbCliente_SelectedValueChanged);
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(274, 88);
            this.cbProducto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(308, 33);
            this.cbProducto.TabIndex = 2;
            this.cbProducto.SelectedValueChanged += new System.EventHandler(this.cbProducto_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccionar Producto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.btnAñadirTarea);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTiempoInvertido);
            this.groupBox1.Controls.Add(this.nudCantidadPiezas);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.cbProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(526, 488);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(598, 425);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir Tareas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nombre del Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(244, 140);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(338, 31);
            this.txtProducto.TabIndex = 10;
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAñadirTarea
            // 
            this.btnAñadirTarea.Location = new System.Drawing.Point(18, 340);
            this.btnAñadirTarea.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAñadirTarea.Name = "btnAñadirTarea";
            this.btnAñadirTarea.Size = new System.Drawing.Size(562, 73);
            this.btnAñadirTarea.TabIndex = 9;
            this.btnAñadirTarea.Text = "2º Paso: Añadir Tareas al Parte de Trabajo";
            this.btnAñadirTarea.UseVisualStyleBackColor = true;
            this.btnAñadirTarea.Click += new System.EventHandler(this.btnAñadirTarea_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tiempo Invertido (Ejemplo: \'2,64\'):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad Piezas/Tareas:";
            // 
            // txtTiempoInvertido
            // 
            this.txtTiempoInvertido.Location = new System.Drawing.Point(390, 265);
            this.txtTiempoInvertido.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTiempoInvertido.Name = "txtTiempoInvertido";
            this.txtTiempoInvertido.Size = new System.Drawing.Size(186, 31);
            this.txtTiempoInvertido.TabIndex = 6;
            this.txtTiempoInvertido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudCantidadPiezas
            // 
            this.nudCantidadPiezas.Location = new System.Drawing.Point(390, 213);
            this.nudCantidadPiezas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudCantidadPiezas.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudCantidadPiezas.Name = "nudCantidadPiezas";
            this.nudCantidadPiezas.Size = new System.Drawing.Size(192, 31);
            this.nudCantidadPiezas.TabIndex = 5;
            this.nudCantidadPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidadPiezas.ValueChanged += new System.EventHandler(this.nudCantidadPiezas_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalcularAndRegistrarRendimiento);
            this.groupBox2.Controls.Add(this.txtRendimiento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(1136, 490);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(764, 240);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cálculo del Rendimiento de la Prima:";
            // 
            // btnCalcularAndRegistrarRendimiento
            // 
            this.btnCalcularAndRegistrarRendimiento.Location = new System.Drawing.Point(68, 65);
            this.btnCalcularAndRegistrarRendimiento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCalcularAndRegistrarRendimiento.Name = "btnCalcularAndRegistrarRendimiento";
            this.btnCalcularAndRegistrarRendimiento.Size = new System.Drawing.Size(624, 90);
            this.btnCalcularAndRegistrarRendimiento.TabIndex = 2;
            this.btnCalcularAndRegistrarRendimiento.Text = "3er Paso: Calcular y Registrar el Rendimiento de la Prima";
            this.btnCalcularAndRegistrarRendimiento.UseVisualStyleBackColor = true;
            this.btnCalcularAndRegistrarRendimiento.Click += new System.EventHandler(this.btnCalcularAndRegistrarRendimiento_Click);
            // 
            // txtRendimiento
            // 
            this.txtRendimiento.Enabled = false;
            this.txtRendimiento.Location = new System.Drawing.Point(418, 177);
            this.txtRendimiento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRendimiento.Name = "txtRendimiento";
            this.txtRendimiento.Size = new System.Drawing.Size(216, 31);
            this.txtRendimiento.TabIndex = 1;
            this.txtRendimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rendimiento de la Prima:";
            // 
            // parteTrabajoBindingSource
            // 
            this.parteTrabajoBindingSource.DataSource = typeof(GestorProduccion.ParteTrabajo);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // nombreTrabajadorDataGridViewTextBoxColumn
            // 
            this.nombreTrabajadorDataGridViewTextBoxColumn.DataPropertyName = "nombreTrabajador";
            this.nombreTrabajadorDataGridViewTextBoxColumn.HeaderText = "Nombre del Trabajador";
            this.nombreTrabajadorDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nombreTrabajadorDataGridViewTextBoxColumn.Name = "nombreTrabajadorDataGridViewTextBoxColumn";
            this.nombreTrabajadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreTrabajadorDataGridViewTextBoxColumn.Width = 80;
            // 
            // apellido1TrabajadorDataGridViewTextBoxColumn
            // 
            this.apellido1TrabajadorDataGridViewTextBoxColumn.DataPropertyName = "apellido1Trabajador";
            this.apellido1TrabajadorDataGridViewTextBoxColumn.HeaderText = "1er Apellido";
            this.apellido1TrabajadorDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.apellido1TrabajadorDataGridViewTextBoxColumn.Name = "apellido1TrabajadorDataGridViewTextBoxColumn";
            this.apellido1TrabajadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellido1TrabajadorDataGridViewTextBoxColumn.Width = 80;
            // 
            // apellido2TrabajadorDataGridViewTextBoxColumn
            // 
            this.apellido2TrabajadorDataGridViewTextBoxColumn.DataPropertyName = "apellido2Trabajador";
            this.apellido2TrabajadorDataGridViewTextBoxColumn.HeaderText = "2º Apellido";
            this.apellido2TrabajadorDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.apellido2TrabajadorDataGridViewTextBoxColumn.Name = "apellido2TrabajadorDataGridViewTextBoxColumn";
            this.apellido2TrabajadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellido2TrabajadorDataGridViewTextBoxColumn.Width = 80;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 70;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "nombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreClienteDataGridViewTextBoxColumn.Width = 80;
            // 
            // codigoProductoDataGridViewTextBoxColumn
            // 
            this.codigoProductoDataGridViewTextBoxColumn.DataPropertyName = "codigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.HeaderText = "Código Producto";
            this.codigoProductoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.codigoProductoDataGridViewTextBoxColumn.Name = "codigoProductoDataGridViewTextBoxColumn";
            this.codigoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoProductoDataGridViewTextBoxColumn.Width = 90;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.nombreProductoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreProductoDataGridViewTextBoxColumn.Width = 90;
            // 
            // piezasDataGridViewTextBoxColumn
            // 
            this.piezasDataGridViewTextBoxColumn.DataPropertyName = "piezas";
            this.piezasDataGridViewTextBoxColumn.HeaderText = "Piezas Realizadas";
            this.piezasDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.piezasDataGridViewTextBoxColumn.Name = "piezasDataGridViewTextBoxColumn";
            this.piezasDataGridViewTextBoxColumn.ReadOnly = true;
            this.piezasDataGridViewTextBoxColumn.Width = 70;
            // 
            // tiempoInvertidoDataGridViewTextBoxColumn
            // 
            this.tiempoInvertidoDataGridViewTextBoxColumn.DataPropertyName = "tiempoInvertido";
            this.tiempoInvertidoDataGridViewTextBoxColumn.HeaderText = "Tiempo Invertido";
            this.tiempoInvertidoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tiempoInvertidoDataGridViewTextBoxColumn.Name = "tiempoInvertidoDataGridViewTextBoxColumn";
            this.tiempoInvertidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiempoInvertidoDataGridViewTextBoxColumn.Width = 50;
            // 
            // colEliminarTarea
            // 
            this.colEliminarTarea.HeaderText = "Eliminar";
            this.colEliminarTarea.MinimumWidth = 10;
            this.colEliminarTarea.Name = "colEliminarTarea";
            this.colEliminarTarea.ReadOnly = true;
            this.colEliminarTarea.Text = "Eliminar";
            this.colEliminarTarea.UseColumnTextForLinkValue = true;
            this.colEliminarTarea.Width = 90;
            // 
            // NuevoParteTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 944);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PanelOpciones);
            this.Controls.Add(this.dgvParteTrabajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoParteTrabajo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Parte de Trabajo";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvParteTrabajo)).EndInit();
            this.PanelOpciones.ResumeLayout(false);
            this.PanelOpciones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPiezas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parteTrabajoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTrabajador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudCantidadPiezas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTiempoInvertido;
        private System.Windows.Forms.Button btnBloquearFechaAndTrabajador;
        private System.Windows.Forms.Button btnAñadirTarea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalcularAndRegistrarRendimiento;
        private System.Windows.Forms.TextBox txtRendimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DataGridView dgvParteTrabajo;
        private System.Windows.Forms.BindingSource parteTrabajoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1TrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2TrabajadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn piezasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoInvertidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn colEliminarTarea;
    }
}