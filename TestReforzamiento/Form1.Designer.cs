namespace TestReforzamiento
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, -31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "F8CizCBmb3gdgaHkI8E9EA%3d%3d";
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(36, 73);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(72, 20);
            this.btnAsistencia.TabIndex = 34;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblMsg.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMsg.Location = new System.Drawing.Point(197, 73);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(51, 20);
            this.lblMsg.TabIndex = 36;
            this.lblMsg.Text = "\r\n";
            // 
            // lblIngreso
            // 
            this.lblIngreso.Location = new System.Drawing.Point(36, 283);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(213, 41);
            this.lblIngreso.TabIndex = 37;
            this.lblIngreso.Text = "Ingreso:";
            // 
            // lblSalida
            // 
            this.lblSalida.Location = new System.Drawing.Point(35, 327);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(213, 41);
            this.lblSalida.TabIndex = 38;
            this.lblSalida.Text = "Salida:";
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(36, 239);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(213, 41);
            this.lblHora.TabIndex = 39;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(35, 195);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(213, 41);
            this.lblFecha.TabIndex = 40;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblLugar
            // 
            this.lblLugar.Location = new System.Drawing.Point(35, 146);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(213, 41);
            this.lblLugar.TabIndex = 41;
            this.lblLugar.Text = "Lugar:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.Location = new System.Drawing.Point(35, 105);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(213, 41);
            this.lblAlumno.TabIndex = 42;
            this.lblAlumno.Text = "Alumno:";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(114, 73);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(72, 20);
            this.btnReload.TabIndex = 33;
            this.btnReload.Text = "Limpiar";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 43;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(441, 105);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(231, 237);
            this.picFoto.TabIndex = 44;
            this.picFoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 388);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.btnReload);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox picFoto;
    }
}

