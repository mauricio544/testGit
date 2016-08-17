using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestReforzamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Decrypt(string cipherText)
        {
            reforzamiento.Asistencias id = new reforzamiento.Asistencias();
            return id.DecryptQR(cipherText);
        }

        public string ConfirmAsistencia(int asistencia)
        {
            reforzamiento.Asistencias id = new reforzamiento.Asistencias();
            return id.ConfirmaAsistencia(asistencia);
        }

        public object Marca(int asistencia)
        {
            reforzamiento.Asistencias id = new reforzamiento.Asistencias();
            return id.PJsonResult(asistencia);
        }        

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            string id = Decrypt(textBox1.Text);
            int asistencia = Int32.Parse(id);            
            //int asistencia = 21;
            string message = ConfirmAsistencia(asistencia);
            if (message == "Entrada")
            {
                object resultado = Marca(asistencia);
                //string result = resultado.GetType().GetProperty("alumno").GetValue(resultado, null).ToString();
                //string result = resultado.GetType().GetField("alumnoField").ToString();
                lblAlumno.Text = "Alumno: " + resultado.GetType().GetProperty("alumno").GetValue(resultado, null).ToString();
                //lblEvento.Text = "Evento: " + resultado.GetType().GetProperty("evento").GetValue(resultado, null).ToString();
                //lblExpositor.Text = "Expositor: " + resultado.GetType().GetProperty("expositor").GetValue(resultado, null).ToString();
                lblLugar.Text = "Lugar: " + resultado.GetType().GetProperty("lugar").GetValue(resultado, null).ToString();
                lblFecha.Text = "Fecha: " + resultado.GetType().GetProperty("fecha").GetValue(resultado, null).ToString();
                lblHora.Text = "Hora: " + resultado.GetType().GetProperty("hora").GetValue(resultado, null).ToString();
                lblIngreso.Text = "Ingreso: " + resultado.GetType().GetProperty("ingreso").GetValue(resultado, null).ToString();
                lblSalida.Text = "Salida: " + resultado.GetType().GetProperty("salida").GetValue(resultado, null).ToString();
                lblMsg.Text = resultado.GetType().GetProperty("message").GetValue(resultado, null).ToString();
                byte[] b = Convert.FromBase64String(resultado.GetType().GetProperty("foto").GetValue(resultado, null).ToString());
                System.IO.MemoryStream ms = new System.IO.MemoryStream(b);
                picFoto.Image = Image.FromStream(ms);
            }else if(message == "NoDate" || message == "NoHorarios"){
                MessageBox.Show("Fecha Inválida");
            }
            else
            {
                MessageBox.Show("La asistencia ya fue tomada!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            lblAlumno.Text = "Alumno: ";
            //lblEvento.Text = "Evento: ";
            //lblExpositor.Text = "Expositor: ";
            lblLugar.Text = "Lugar: ";
            lblFecha.Text = "Fecha: ";
            lblHora.Text = "Hora: ";
            lblIngreso.Text = "Ingreso: ";
            lblSalida.Text = "Salida: ";
            lblMsg.Text = "";
            textBox1.Text = "";
        }
    }
}