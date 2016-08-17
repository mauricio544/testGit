namespace Reforzamiento
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(7, 32);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(72, 20);
            this.btnAsistencia.TabIndex = 17;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblMsg.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMsg.Location = new System.Drawing.Point(168, 32);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(51, 20);
            this.lblMsg.Text = "\r\n";
            // 
            // lblIngreso
            // 
            this.lblIngreso.Location = new System.Drawing.Point(7, 242);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(213, 41);
            this.lblIngreso.Text = "Ingreso:";
            // 
            // lblSalida
            // 
            this.lblSalida.Location = new System.Drawing.Point(6, 286);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(213, 41);
            this.lblSalida.Text = "Salida:";
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(7, 198);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(213, 41);
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(6, 154);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(213, 41);
            this.lblFecha.Text = "Fecha:";
            // 
            // lblLugar
            // 
            this.lblLugar.Location = new System.Drawing.Point(6, 105);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(213, 41);
            this.lblLugar.Text = "Lugar:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.Location = new System.Drawing.Point(6, 64);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(213, 41);
            this.lblAlumno.Text = "Alumno:";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(85, 32);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(72, 20);
            this.btnReload.TabIndex = 16;
            this.btnReload.Text = "Limpiar";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtQR
            // 
            this.txtQR.Location = new System.Drawing.Point(6, -25);
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(213, 21);
            this.txtQR.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 21);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "F8CizCBmb3gdgaHkI8E9EA%3d%3d";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
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
            this.Controls.Add(this.txtQR);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Reforzamiento - Asistencias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.TextBox textBox1;


    }
}

