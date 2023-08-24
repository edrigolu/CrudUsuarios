namespace Usuarios.Presentacion
{
    partial class Registros
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
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CboCiudad = new System.Windows.Forms.ComboBox();
            this.CboDepartamento = new System.Windows.Forms.ComboBox();
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RdbNombre = new System.Windows.Forms.RadioButton();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.RdbNumDocumento = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.RdbApellidos = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.lblFiltroApellido = new System.Windows.Forms.Label();
            this.txtFiltroNumDoc = new System.Windows.Forms.TextBox();
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            this.txtFiltroApellido = new System.Windows.Forms.TextBox();
            this.lblFiltroNumDoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnNuevo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNuevo.Location = new System.Drawing.Point(445, 181);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(101, 34);
            this.BtnNuevo.TabIndex = 79;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(17, 97);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(256, 20);
            this.txtCelular.TabIndex = 76;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(378, 53);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(339, 20);
            this.txtTelefono.TabIndex = 75;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Orange;
            this.BtnEliminar.Location = new System.Drawing.Point(415, 516);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 34);
            this.BtnEliminar.TabIndex = 74;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Khaki;
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEditar.Location = new System.Drawing.Point(311, 516);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 34);
            this.BtnEditar.TabIndex = 73;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(698, -91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Edad:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGuardar.Location = new System.Drawing.Point(311, 181);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(101, 34);
            this.BtnGuardar.TabIndex = 71;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // CboCiudad
            // 
            this.CboCiudad.FormattingEnabled = true;
            this.CboCiudad.Location = new System.Drawing.Point(378, 3);
            this.CboCiudad.Name = "CboCiudad";
            this.CboCiudad.Size = new System.Drawing.Size(438, 21);
            this.CboCiudad.TabIndex = 67;
            // 
            // CboDepartamento
            // 
            this.CboDepartamento.FormattingEnabled = true;
            this.CboDepartamento.Location = new System.Drawing.Point(44, 4);
            this.CboDepartamento.Name = "CboDepartamento";
            this.CboDepartamento.Size = new System.Drawing.Size(229, 21);
            this.CboDepartamento.TabIndex = 66;
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Location = new System.Drawing.Point(80, -48);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(193, 21);
            this.CboTipoDocumento.TabIndex = 64;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(756, -97);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(51, 26);
            this.txtEdad.TabIndex = 63;
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDocumento.Location = new System.Drawing.Point(477, -49);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(339, 26);
            this.txtNumDocumento.TabIndex = 65;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(402, -98);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(265, 26);
            this.txtApellidos.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(324, -48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Numero de documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(324, -97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Apellidos:";
            // 
            // RdbNombre
            // 
            this.RdbNombre.AutoSize = true;
            this.RdbNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbNombre.Location = new System.Drawing.Point(12, 21);
            this.RdbNombre.Name = "RdbNombre";
            this.RdbNombre.Size = new System.Drawing.Size(93, 20);
            this.RdbNombre.TabIndex = 0;
            this.RdbNombre.TabStop = true;
            this.RdbNombre.Text = "Por nombre";
            this.RdbNombre.UseVisualStyleBackColor = true;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupacion.Location = new System.Drawing.Point(17, 150);
            this.txtOcupacion.MaxLength = 50;
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(256, 26);
            this.txtOcupacion.TabIndex = 70;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(388, 99);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(329, 26);
            this.txtCorreo.TabIndex = 69;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(17, 55);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(256, 26);
            this.txtDireccion.TabIndex = 68;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(8, -100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 26);
            this.txtNombre.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(-61, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Ocupación:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Turquoise;
            this.BtnLimpiar.Location = new System.Drawing.Point(627, 41);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 37);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnBuscar.Location = new System.Drawing.Point(546, 41);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 37);
            this.BtnBuscar.TabIndex = 6;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // RdbNumDocumento
            // 
            this.RdbNumDocumento.AutoSize = true;
            this.RdbNumDocumento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbNumDocumento.Location = new System.Drawing.Point(790, 21);
            this.RdbNumDocumento.Name = "RdbNumDocumento";
            this.RdbNumDocumento.Size = new System.Drawing.Size(178, 20);
            this.RdbNumDocumento.TabIndex = 0;
            this.RdbNumDocumento.TabStop = true;
            this.RdbNumDocumento.Text = "Por numero de documento";
            this.RdbNumDocumento.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(324, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Ciudad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(324, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Correo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(-61, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(-61, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Departamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(-61, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(-61, -46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tipo de documento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(-61, -99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "Nombre:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(29, 331);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(862, 150);
            this.dgvUsuarios.TabIndex = 49;
            // 
            // RdbApellidos
            // 
            this.RdbApellidos.AutoSize = true;
            this.RdbApellidos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbApellidos.Location = new System.Drawing.Point(380, 21);
            this.RdbApellidos.Name = "RdbApellidos";
            this.RdbApellidos.Size = new System.Drawing.Size(93, 20);
            this.RdbApellidos.TabIndex = 0;
            this.RdbApellidos.TabStop = true;
            this.RdbApellidos.Text = "Por apellido";
            this.RdbApellidos.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(324, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Teléfono:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLimpiar);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.RdbNumDocumento);
            this.groupBox1.Controls.Add(this.RdbApellidos);
            this.groupBox1.Controls.Add(this.RdbNombre);
            this.groupBox1.Controls.Add(this.txtFiltroNombre);
            this.groupBox1.Controls.Add(this.lblFiltroApellido);
            this.groupBox1.Controls.Add(this.txtFiltroNumDoc);
            this.groupBox1.Controls.Add(this.lblFiltroNombre);
            this.groupBox1.Controls.Add(this.txtFiltroApellido);
            this.groupBox1.Controls.Add(this.lblFiltroNumDoc);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-58, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 104);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroNombre.Location = new System.Drawing.Point(87, 57);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(265, 26);
            this.txtFiltroNombre.TabIndex = 1;
            // 
            // lblFiltroApellido
            // 
            this.lblFiltroApellido.AutoSize = true;
            this.lblFiltroApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFiltroApellido.Location = new System.Drawing.Point(8, 65);
            this.lblFiltroApellido.Name = "lblFiltroApellido";
            this.lblFiltroApellido.Size = new System.Drawing.Size(60, 16);
            this.lblFiltroApellido.TabIndex = 0;
            this.lblFiltroApellido.Text = "Apellidos:";
            // 
            // txtFiltroNumDoc
            // 
            this.txtFiltroNumDoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroNumDoc.Location = new System.Drawing.Point(169, 57);
            this.txtFiltroNumDoc.Name = "txtFiltroNumDoc";
            this.txtFiltroNumDoc.Size = new System.Drawing.Size(331, 26);
            this.txtFiltroNumDoc.TabIndex = 5;
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFiltroNombre.Location = new System.Drawing.Point(9, 62);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(52, 16);
            this.lblFiltroNombre.TabIndex = 0;
            this.lblFiltroNombre.Text = "Nombre:";
            // 
            // txtFiltroApellido
            // 
            this.txtFiltroApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroApellido.Location = new System.Drawing.Point(87, 57);
            this.txtFiltroApellido.Name = "txtFiltroApellido";
            this.txtFiltroApellido.Size = new System.Drawing.Size(265, 26);
            this.txtFiltroApellido.TabIndex = 2;
            // 
            // lblFiltroNumDoc
            // 
            this.lblFiltroNumDoc.AutoSize = true;
            this.lblFiltroNumDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFiltroNumDoc.Location = new System.Drawing.Point(8, 65);
            this.lblFiltroNumDoc.Name = "lblFiltroNumDoc";
            this.lblFiltroNumDoc.Size = new System.Drawing.Size(131, 16);
            this.lblFiltroNumDoc.TabIndex = 0;
            this.lblFiltroNumDoc.Text = "Numero de documento:";
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 545);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CboCiudad);
            this.Controls.Add(this.CboDepartamento);
            this.Controls.Add(this.CboTipoDocumento);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNumDocumento);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOcupacion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registros";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CboCiudad;
        private System.Windows.Forms.ComboBox CboDepartamento;
        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RdbNombre;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.RadioButton RdbNumDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.RadioButton RdbApellidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Label lblFiltroApellido;
        private System.Windows.Forms.TextBox txtFiltroNumDoc;
        private System.Windows.Forms.Label lblFiltroNombre;
        private System.Windows.Forms.TextBox txtFiltroApellido;
        private System.Windows.Forms.Label lblFiltroNumDoc;
    }
}