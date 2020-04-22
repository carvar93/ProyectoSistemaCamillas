namespace Presentacion.Pacientes1
{
    partial class frmPaciente
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
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIdPaciente = new System.Windows.Forms.TextBox();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.tbPadecimiento = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbIdTrabajdador = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCargarDatos = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(516, 26);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(121, 20);
            this.tbBuscar.TabIndex = 11;
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Buscar Por ID";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(412, 53);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(779, 362);
            this.dg.TabIndex = 14;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbIdPaciente);
            this.groupBox1.Controls.Add(this.tbMotivo);
            this.groupBox1.Controls.Add(this.tbPadecimiento);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.cbIdTrabajdador);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btAgregar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btModificar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btEliminar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btLimpiar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 386);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Pacientes";
            // 
            // tbIdPaciente
            // 
            this.tbIdPaciente.Enabled = false;
            this.tbIdPaciente.Location = new System.Drawing.Point(174, 36);
            this.tbIdPaciente.Name = "tbIdPaciente";
            this.tbIdPaciente.Size = new System.Drawing.Size(121, 20);
            this.tbIdPaciente.TabIndex = 1;
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(174, 212);
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(121, 20);
            this.tbMotivo.TabIndex = 5;
            // 
            // tbPadecimiento
            // 
            this.tbPadecimiento.Location = new System.Drawing.Point(174, 172);
            this.tbPadecimiento.Name = "tbPadecimiento";
            this.tbPadecimiento.Size = new System.Drawing.Size(121, 20);
            this.tbPadecimiento.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(174, 133);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "",
            "Atencion",
            "Finalizado"});
            this.cbEstado.Location = new System.Drawing.Point(174, 250);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 6;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // cbIdTrabajdador
            // 
            this.cbIdTrabajdador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdTrabajdador.FormattingEnabled = true;
            this.cbIdTrabajdador.Location = new System.Drawing.Point(174, 81);
            this.cbIdTrabajdador.Name = "cbIdTrabajdador";
            this.cbIdTrabajdador.Size = new System.Drawing.Size(121, 21);
            this.cbIdTrabajdador.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado";
            // 
            // btAgregar
            // 
            this.btAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btAgregar.Location = new System.Drawing.Point(290, 313);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 35);
            this.btAgregar.TabIndex = 10;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Motivo Emergencia";
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(195, 313);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 35);
            this.btModificar.TabIndex = 9;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Padecimineto";
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(97, 313);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 35);
            this.btEliminar.TabIndex = 8;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(6, 313);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(63, 35);
            this.btLimpiar.TabIndex = 7;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IdTrabajdor";
            // 
            // btCargarDatos
            // 
            this.btCargarDatos.Location = new System.Drawing.Point(1070, 19);
            this.btCargarDatos.Name = "btCargarDatos";
            this.btCargarDatos.Size = new System.Drawing.Size(99, 23);
            this.btCargarDatos.TabIndex = 13;
            this.btCargarDatos.Text = "Cargar Datos";
            this.btCargarDatos.UseVisualStyleBackColor = true;
            this.btCargarDatos.Click += new System.EventHandler(this.btCargarDatos_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(654, 24);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 12;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.tbBuscar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 450);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCargarDatos);
            this.Controls.Add(this.btBuscar);
            this.Name = "frmPaciente";
            this.Text = "Formulario Paciente";
            this.Load += new System.EventHandler(this.frmPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIdPaciente;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.TextBox tbPadecimiento;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbIdTrabajdador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCargarDatos;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}