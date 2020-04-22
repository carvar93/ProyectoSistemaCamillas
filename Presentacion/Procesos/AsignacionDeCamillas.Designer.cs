namespace Presentacion.Procesos
{
    partial class AsignacionDeCamillas
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
            this.estadolbl = new System.Windows.Forms.Label();
            this.Pacientesdgv = new System.Windows.Forms.DataGridView();
            this.Asignarbtn = new System.Windows.Forms.Button();
            this.busquedalbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buscarPacientebtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CamillasgroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.finalizarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pacientesdgv)).BeginInit();
            this.CamillasgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // estadolbl
            // 
            this.estadolbl.AutoSize = true;
            this.estadolbl.Location = new System.Drawing.Point(21, 210);
            this.estadolbl.Name = "estadolbl";
            this.estadolbl.Size = new System.Drawing.Size(40, 13);
            this.estadolbl.TabIndex = 0;
            this.estadolbl.Text = "Estado";
            // 
            // Pacientesdgv
            // 
            this.Pacientesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pacientesdgv.Location = new System.Drawing.Point(24, 45);
            this.Pacientesdgv.Name = "Pacientesdgv";
            this.Pacientesdgv.Size = new System.Drawing.Size(282, 150);
            this.Pacientesdgv.TabIndex = 1;
            this.Pacientesdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pacientesdgv_CellClick);
            // 
            // Asignarbtn
            // 
            this.Asignarbtn.Location = new System.Drawing.Point(135, 184);
            this.Asignarbtn.Name = "Asignarbtn";
            this.Asignarbtn.Size = new System.Drawing.Size(75, 23);
            this.Asignarbtn.TabIndex = 2;
            this.Asignarbtn.Text = "Asignar";
            this.Asignarbtn.UseVisualStyleBackColor = true;
            // 
            // busquedalbl
            // 
            this.busquedalbl.AutoSize = true;
            this.busquedalbl.Location = new System.Drawing.Point(21, 21);
            this.busquedalbl.Name = "busquedalbl";
            this.busquedalbl.Size = new System.Drawing.Size(57, 13);
            this.busquedalbl.TabIndex = 3;
            this.busquedalbl.Text = " Pacientes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 4;
            // 
            // buscarPacientebtn
            // 
            this.buscarPacientebtn.Location = new System.Drawing.Point(234, 16);
            this.buscarPacientebtn.Name = "buscarPacientebtn";
            this.buscarPacientebtn.Size = new System.Drawing.Size(75, 23);
            this.buscarPacientebtn.TabIndex = 5;
            this.buscarPacientebtn.Text = "Buscar";
            this.buscarPacientebtn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 20);
            this.textBox2.TabIndex = 6;
            // 
            // CamillasgroupBox
            // 
            this.CamillasgroupBox.Controls.Add(this.dataGridView1);
            this.CamillasgroupBox.Controls.Add(this.Asignarbtn);
            this.CamillasgroupBox.Location = new System.Drawing.Point(378, 21);
            this.CamillasgroupBox.Name = "CamillasgroupBox";
            this.CamillasgroupBox.Size = new System.Drawing.Size(231, 225);
            this.CamillasgroupBox.TabIndex = 7;
            this.CamillasgroupBox.TabStop = false;
            this.CamillasgroupBox.Text = "Camillas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(175, 147);
            this.dataGridView1.TabIndex = 3;
            // 
            // finalizarbtn
            // 
            this.finalizarbtn.Location = new System.Drawing.Point(231, 205);
            this.finalizarbtn.Name = "finalizarbtn";
            this.finalizarbtn.Size = new System.Drawing.Size(75, 23);
            this.finalizarbtn.TabIndex = 8;
            this.finalizarbtn.Text = "Finalizar ";
            this.finalizarbtn.UseVisualStyleBackColor = true;
            // 
            // AsignacionDeCamillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 383);
            this.Controls.Add(this.finalizarbtn);
            this.Controls.Add(this.CamillasgroupBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buscarPacientebtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.busquedalbl);
            this.Controls.Add(this.Pacientesdgv);
            this.Controls.Add(this.estadolbl);
            this.Name = "AsignacionDeCamillas";
            this.Text = "AsignacionDeCamillas";
            ((System.ComponentModel.ISupportInitialize)(this.Pacientesdgv)).EndInit();
            this.CamillasgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label estadolbl;
        private System.Windows.Forms.DataGridView Pacientesdgv;
        private System.Windows.Forms.Button Asignarbtn;
        private System.Windows.Forms.Label busquedalbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buscarPacientebtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox CamillasgroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button finalizarbtn;
    }
}