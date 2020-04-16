namespace Presentacion.Sala
{
    partial class sala
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombreSalatxt = new System.Windows.Forms.TextBox();
            this.AgregarSalabtn = new System.Windows.Forms.Button();
            this.ModificarSalabtn = new System.Windows.Forms.Button();
            this.eliminarSalabtn = new System.Windows.Forms.Button();
            this.SaladataGridView = new System.Windows.Forms.DataGridView();
            this.salagroupBox = new System.Windows.Forms.GroupBox();
            this.camillasParaAsigdataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.busquedaSalatextBox = new System.Windows.Forms.TextBox();
            this.buscarbtn = new System.Windows.Forms.Button();
            this.agregarCamillasbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SaladataGridView)).BeginInit();
            this.salagroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camillasParaAsigdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombreSalatxt
            // 
            this.nombreSalatxt.Location = new System.Drawing.Point(62, 32);
            this.nombreSalatxt.Name = "nombreSalatxt";
            this.nombreSalatxt.Size = new System.Drawing.Size(100, 20);
            this.nombreSalatxt.TabIndex = 2;
            // 
            // AgregarSalabtn
            // 
            this.AgregarSalabtn.Location = new System.Drawing.Point(195, 32);
            this.AgregarSalabtn.Name = "AgregarSalabtn";
            this.AgregarSalabtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarSalabtn.TabIndex = 4;
            this.AgregarSalabtn.Text = "Agregar";
            this.AgregarSalabtn.UseVisualStyleBackColor = true;
            this.AgregarSalabtn.Click += new System.EventHandler(this.AgregarSalabtn_Click);
            // 
            // ModificarSalabtn
            // 
            this.ModificarSalabtn.Location = new System.Drawing.Point(320, 221);
            this.ModificarSalabtn.Name = "ModificarSalabtn";
            this.ModificarSalabtn.Size = new System.Drawing.Size(75, 23);
            this.ModificarSalabtn.TabIndex = 5;
            this.ModificarSalabtn.Text = "Modificar";
            this.ModificarSalabtn.UseVisualStyleBackColor = true;
            this.ModificarSalabtn.Click += new System.EventHandler(this.ModificarSalabtn_Click);
            // 
            // eliminarSalabtn
            // 
            this.eliminarSalabtn.Location = new System.Drawing.Point(485, 221);
            this.eliminarSalabtn.Name = "eliminarSalabtn";
            this.eliminarSalabtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarSalabtn.TabIndex = 6;
            this.eliminarSalabtn.Text = "Eliminar";
            this.eliminarSalabtn.UseVisualStyleBackColor = true;
            this.eliminarSalabtn.Click += new System.EventHandler(this.eliminarSalabtn_Click);
            // 
            // SaladataGridView
            // 
            this.SaladataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaladataGridView.Location = new System.Drawing.Point(320, 61);
            this.SaladataGridView.Name = "SaladataGridView";
            this.SaladataGridView.Size = new System.Drawing.Size(287, 154);
            this.SaladataGridView.TabIndex = 7;
            this.SaladataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaladataGridView_CellClick);
            // 
            // salagroupBox
            // 
            this.salagroupBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.salagroupBox.Controls.Add(this.agregarCamillasbutton);
            this.salagroupBox.Controls.Add(this.camillasParaAsigdataGridView);
            this.salagroupBox.Location = new System.Drawing.Point(12, 86);
            this.salagroupBox.Name = "salagroupBox";
            this.salagroupBox.Size = new System.Drawing.Size(258, 215);
            this.salagroupBox.TabIndex = 8;
            this.salagroupBox.TabStop = false;
            this.salagroupBox.Text = "Agregar Camillas";
            // 
            // camillasParaAsigdataGridView
            // 
            this.camillasParaAsigdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.camillasParaAsigdataGridView.Location = new System.Drawing.Point(6, 19);
            this.camillasParaAsigdataGridView.Name = "camillasParaAsigdataGridView";
            this.camillasParaAsigdataGridView.Size = new System.Drawing.Size(116, 165);
            this.camillasParaAsigdataGridView.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Busqueda";
            // 
            // busquedaSalatextBox
            // 
            this.busquedaSalatextBox.Location = new System.Drawing.Point(378, 32);
            this.busquedaSalatextBox.Name = "busquedaSalatextBox";
            this.busquedaSalatextBox.Size = new System.Drawing.Size(97, 20);
            this.busquedaSalatextBox.TabIndex = 10;
            // 
            // buscarbtn
            // 
            this.buscarbtn.Location = new System.Drawing.Point(485, 32);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Size = new System.Drawing.Size(64, 23);
            this.buscarbtn.TabIndex = 11;
            this.buscarbtn.Text = "Buscar";
            this.buscarbtn.UseVisualStyleBackColor = true;
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click);
            // 
            // agregarCamillasbutton
            // 
            this.agregarCamillasbutton.Location = new System.Drawing.Point(139, 81);
            this.agregarCamillasbutton.Name = "agregarCamillasbutton";
            this.agregarCamillasbutton.Size = new System.Drawing.Size(64, 26);
            this.agregarCamillasbutton.TabIndex = 12;
            this.agregarCamillasbutton.Text = "Agregar";
            this.agregarCamillasbutton.UseVisualStyleBackColor = true;
            // 
            // sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.busquedaSalatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salagroupBox);
            this.Controls.Add(this.SaladataGridView);
            this.Controls.Add(this.eliminarSalabtn);
            this.Controls.Add(this.ModificarSalabtn);
            this.Controls.Add(this.AgregarSalabtn);
            this.Controls.Add(this.nombreSalatxt);
            this.Controls.Add(this.label1);
            this.Name = "sala";
            this.Text = "sala";
            this.Load += new System.EventHandler(this.sala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaladataGridView)).EndInit();
            this.salagroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.camillasParaAsigdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreSalatxt;
        private System.Windows.Forms.Button AgregarSalabtn;
        private System.Windows.Forms.Button ModificarSalabtn;
        private System.Windows.Forms.Button eliminarSalabtn;
        private System.Windows.Forms.DataGridView SaladataGridView;
        private System.Windows.Forms.GroupBox salagroupBox;
        private System.Windows.Forms.DataGridView camillasParaAsigdataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox busquedaSalatextBox;
        private System.Windows.Forms.Button buscarbtn;
        private System.Windows.Forms.Button agregarCamillasbutton;
    }
}