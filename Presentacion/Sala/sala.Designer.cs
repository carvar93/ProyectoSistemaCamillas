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
            this.label2 = new System.Windows.Forms.Label();
            this.nombreSalatxt = new System.Windows.Forms.TextBox();
            this.cantidadCamillatxt = new System.Windows.Forms.TextBox();
            this.AgregarSalabtn = new System.Windows.Forms.Button();
            this.ModificarSalabtn = new System.Windows.Forms.Button();
            this.eliminarSalabtn = new System.Windows.Forms.Button();
            this.SaladataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SaladataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Camillas";
            // 
            // nombreSalatxt
            // 
            this.nombreSalatxt.Location = new System.Drawing.Point(137, 35);
            this.nombreSalatxt.Name = "nombreSalatxt";
            this.nombreSalatxt.Size = new System.Drawing.Size(100, 20);
            this.nombreSalatxt.TabIndex = 2;
            // 
            // cantidadCamillatxt
            // 
            this.cantidadCamillatxt.Location = new System.Drawing.Point(137, 81);
            this.cantidadCamillatxt.Name = "cantidadCamillatxt";
            this.cantidadCamillatxt.Size = new System.Drawing.Size(41, 20);
            this.cantidadCamillatxt.TabIndex = 3;
            // 
            // AgregarSalabtn
            // 
            this.AgregarSalabtn.Location = new System.Drawing.Point(26, 128);
            this.AgregarSalabtn.Name = "AgregarSalabtn";
            this.AgregarSalabtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarSalabtn.TabIndex = 4;
            this.AgregarSalabtn.Text = "Agregar";
            this.AgregarSalabtn.UseVisualStyleBackColor = true;
            this.AgregarSalabtn.Click += new System.EventHandler(this.AgregarSalabtn_Click);
            // 
            // ModificarSalabtn
            // 
            this.ModificarSalabtn.Location = new System.Drawing.Point(311, 180);
            this.ModificarSalabtn.Name = "ModificarSalabtn";
            this.ModificarSalabtn.Size = new System.Drawing.Size(75, 23);
            this.ModificarSalabtn.TabIndex = 5;
            this.ModificarSalabtn.Text = "Modificar";
            this.ModificarSalabtn.UseVisualStyleBackColor = true;
            this.ModificarSalabtn.Click += new System.EventHandler(this.ModificarSalabtn_Click);
            // 
            // eliminarSalabtn
            // 
            this.eliminarSalabtn.Location = new System.Drawing.Point(406, 180);
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
            this.SaladataGridView.Location = new System.Drawing.Point(311, 12);
            this.SaladataGridView.Name = "SaladataGridView";
            this.SaladataGridView.Size = new System.Drawing.Size(240, 150);
            this.SaladataGridView.TabIndex = 7;
            this.SaladataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaladataGridView_CellClick);
            // 
            // sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.SaladataGridView);
            this.Controls.Add(this.eliminarSalabtn);
            this.Controls.Add(this.ModificarSalabtn);
            this.Controls.Add(this.AgregarSalabtn);
            this.Controls.Add(this.cantidadCamillatxt);
            this.Controls.Add(this.nombreSalatxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sala";
            this.Text = "sala";
            ((System.ComponentModel.ISupportInitialize)(this.SaladataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreSalatxt;
        private System.Windows.Forms.TextBox cantidadCamillatxt;
        private System.Windows.Forms.Button AgregarSalabtn;
        private System.Windows.Forms.Button ModificarSalabtn;
        private System.Windows.Forms.Button eliminarSalabtn;
        private System.Windows.Forms.DataGridView SaladataGridView;
    }
}