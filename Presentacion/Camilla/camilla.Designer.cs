namespace Presentacion.Camilla
{
    partial class camilla
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
            this.numeroCamillalbl = new System.Windows.Forms.Label();
            this.estadoCamillalbl = new System.Windows.Forms.Label();
            this.numeroCamillatxt = new System.Windows.Forms.TextBox();
            this.estadoCamillatxt = new System.Windows.Forms.TextBox();
            this.agregarCamillabtn = new System.Windows.Forms.Button();
            this.eliminarCamillabtn = new System.Windows.Forms.Button();
            this.modificarCamillabtn = new System.Windows.Forms.Button();
            this.CamilladataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CamilladataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroCamillalbl
            // 
            this.numeroCamillalbl.AutoSize = true;
            this.numeroCamillalbl.Location = new System.Drawing.Point(23, 48);
            this.numeroCamillalbl.Name = "numeroCamillalbl";
            this.numeroCamillalbl.Size = new System.Drawing.Size(44, 13);
            this.numeroCamillalbl.TabIndex = 0;
            this.numeroCamillalbl.Text = "Numero";
            this.numeroCamillalbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // estadoCamillalbl
            // 
            this.estadoCamillalbl.AutoSize = true;
            this.estadoCamillalbl.Location = new System.Drawing.Point(23, 81);
            this.estadoCamillalbl.Name = "estadoCamillalbl";
            this.estadoCamillalbl.Size = new System.Drawing.Size(40, 13);
            this.estadoCamillalbl.TabIndex = 1;
            this.estadoCamillalbl.Text = "Estado";
            // 
            // numeroCamillatxt
            // 
            this.numeroCamillatxt.Location = new System.Drawing.Point(73, 45);
            this.numeroCamillatxt.Name = "numeroCamillatxt";
            this.numeroCamillatxt.Size = new System.Drawing.Size(19, 20);
            this.numeroCamillatxt.TabIndex = 2;
            // 
            // estadoCamillatxt
            // 
            this.estadoCamillatxt.Location = new System.Drawing.Point(73, 74);
            this.estadoCamillatxt.Name = "estadoCamillatxt";
            this.estadoCamillatxt.Size = new System.Drawing.Size(57, 20);
            this.estadoCamillatxt.TabIndex = 3;
            // 
            // agregarCamillabtn
            // 
            this.agregarCamillabtn.Location = new System.Drawing.Point(26, 125);
            this.agregarCamillabtn.Name = "agregarCamillabtn";
            this.agregarCamillabtn.Size = new System.Drawing.Size(75, 23);
            this.agregarCamillabtn.TabIndex = 4;
            this.agregarCamillabtn.Text = "Agregar";
            this.agregarCamillabtn.UseVisualStyleBackColor = true;
            this.agregarCamillabtn.Click += new System.EventHandler(this.agregarCamillabtn_Click);
            // 
            // eliminarCamillabtn
            // 
            this.eliminarCamillabtn.Location = new System.Drawing.Point(302, 27);
            this.eliminarCamillabtn.Name = "eliminarCamillabtn";
            this.eliminarCamillabtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarCamillabtn.TabIndex = 5;
            this.eliminarCamillabtn.Text = "Eliminar";
            this.eliminarCamillabtn.UseVisualStyleBackColor = true;
            // 
            // modificarCamillabtn
            // 
            this.modificarCamillabtn.Location = new System.Drawing.Point(302, 81);
            this.modificarCamillabtn.Name = "modificarCamillabtn";
            this.modificarCamillabtn.Size = new System.Drawing.Size(75, 23);
            this.modificarCamillabtn.TabIndex = 6;
            this.modificarCamillabtn.Text = "Modificar";
            this.modificarCamillabtn.UseVisualStyleBackColor = true;
            // 
            // CamilladataGridView1
            // 
            this.CamilladataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CamilladataGridView1.Location = new System.Drawing.Point(162, 27);
            this.CamilladataGridView1.Name = "CamilladataGridView1";
            this.CamilladataGridView1.Size = new System.Drawing.Size(116, 121);
            this.CamilladataGridView1.TabIndex = 7;
            this.CamilladataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CamilladataGridView1_CellClick);
            // 
            // camilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 197);
            this.Controls.Add(this.CamilladataGridView1);
            this.Controls.Add(this.modificarCamillabtn);
            this.Controls.Add(this.eliminarCamillabtn);
            this.Controls.Add(this.agregarCamillabtn);
            this.Controls.Add(this.estadoCamillatxt);
            this.Controls.Add(this.numeroCamillatxt);
            this.Controls.Add(this.estadoCamillalbl);
            this.Controls.Add(this.numeroCamillalbl);
            this.Name = "camilla";
            this.Text = "camilla";
            ((System.ComponentModel.ISupportInitialize)(this.CamilladataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeroCamillalbl;
        private System.Windows.Forms.Label estadoCamillalbl;
        private System.Windows.Forms.TextBox numeroCamillatxt;
        private System.Windows.Forms.TextBox estadoCamillatxt;
        private System.Windows.Forms.Button agregarCamillabtn;
        private System.Windows.Forms.Button eliminarCamillabtn;
        private System.Windows.Forms.Button modificarCamillabtn;
        private System.Windows.Forms.DataGridView CamilladataGridView1;
    }
}