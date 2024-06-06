using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_Validar_Click(object sender, EventArgs e)
        {
            if (radioAlumno.Checked)
            {
                //sirve para guardar la información de la persona, tomandolo de la textbox que se indica 
                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox6.Text);
                int mat = Convert.ToInt32(textBox4.Text);
                string carrera = textBox5.Text;
                Alumno alumno = new Alumno(nom, edad, fech, carrera, mat);
            }
            else
            {
                if (radioEmpleado.Checked)
                {

                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox6.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox3.Text);
                    Empleado empleado = new Empleado(nom, edad, fech, puesto, sueldo);
                }
                else if (radioMaestro.Checked)
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox6.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox3.Text);
                    Empleado empleado = new Empleado(nom, edad, fech, puesto, sueldo);
                }
                else
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox6.Text);
                }
            }
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            if (radioAlumno.Checked)//Alumno
            {
                  //envia un mensaje con el resultado de la opcion que elijas
                MessageBox.Show("DATOS GUARDADOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
                + "\nEdad: " + textBox6.Text + "\nMatricula: " + textBox4.Text + "\nCarrera: " + textBox5.Text);
            }
            else
            {
                if (radioMaestro.Checked || radioEmpleado.Checked)//Docente o maestro o empleado
                {
                    MessageBox.Show("DATOS GUARDADOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
              + "\nEdad: " + textBox6.Text + "\nDNI: " + textBox4.Text + "\nPuesto: " + textBox5.Text + "\nSueldo: " + textBox3.Text);
                }
                else//Persona
                {
                    MessageBox.Show("DATOS GUARDADOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
               + "\nEdad: " + textBox6.Text);
                }

            }
        }

        private void b_Limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void b_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioPersona_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\LICENCIATURAS\\Desktop\\persona_herencia\\Imagenes_personas\\Personas.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = false;
            textBox4.Visible = false;
            label7.Visible = false;
            textBox3.Visible = false;
            label6.Visible = false;
            textBox5.Visible = false;
        }

        private void radioEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\LICENCIATURAS\\Desktop\\persona_herencia\\Imagenes_personas\\Empleados.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox4.Visible = true;
            label7.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            textBox5.Visible = true;
        }

        private void radioAlumno_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\LICENCIATURAS\\Desktop\\persona_herencia\\Imagenes_personas\\Alumnos.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label7.Visible = false;
            textBox3.Visible = false;
        }

        private void radioMaestro_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\LICENCIATURAS\\Desktop\\persona_herencia\\Imagenes_personas\\Maestros.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox4.Visible = true;
            label7.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            textBox5.Visible = true;
        }
    }
}
