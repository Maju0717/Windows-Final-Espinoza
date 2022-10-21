using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MariaJuliaEspinozaZarate_WindowsFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guardo lo que el usuario llena en el formulario

            
            String Nombre = textBox1.Text;
            String Apellido = textBox2.Text;
            int Sueldo = int.Parse(textBox3.Text);
            String Puesto = textBox4.Text;

            //Validación nombre y apellido mayor a 2 y menor a 50
            if (Nombre.Length < 2)
            { if (Nombre.Length > 5)
                { MessageBox.Show("Nombre o Apellido invalido, por favor intente de nuevo");
                }
            }

            if (Apellido.Length < 2)
            { if (Apellido.Length > 5){
                    MessageBox.Show("Apellido invalido, por favor intente de nuevo");
                }
            }

            //VALIDACIONES
            if ((Sueldo <= 0) && (Puesto != "Soporte Técnico" | Puesto != "DBA" | Puesto != "Desarrollador"))
            {
                MessageBox.Show("Los datos ingresados no son validos porfavo vuelva a ingresarlos y valide nuevamente");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Mostrar en un cuadro de dialogo el nombre completo y el puesto
            todo en mayúscula*/
            String Nombre = textBox1.Text;
            String Apellido = textBox2.Text;
            int Sueldo = int.Parse(textBox3.Text);
            String Puesto = textBox4.Text;

            String NOMBRE = Nombre.ToUpper();
            String APELLIDO = Apellido.ToUpper();
            String PUESTO =Puesto.ToUpper();    

            MessageBox.Show("Nombre y Apellido: "+NOMBRE+ "\nPuesto de trabajo: "+PUESTO );

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* Usar InputBox para realizar la carga de las horas de trabajo diarias de lunes a viernes
                Al finalizar la carga mostrar en un cuadro de dialogo el total de horas trabajadas
            */
            int valorHoras = 0;
            int contador = 0;
            int menor = 0;
           
            do
            { valorHoras = valorHoras + Convert.ToInt32(Interaction.InputBox("Ingresa la cantidad de horas trabajas por día"));
                contador++;
                if (valorHoras < 4) {menor=contador;};
            } while (contador < 5);

            //Mostrar Promedio de horas trabajadas
            int prom = valorHoras / 5;

            //Mostrar el día que trabajo menos de 4 hs ->No lo pude hacer funcionar
            /*String Dia;
           if (menor == 1) { Dia = "Lunes"; };
           if (menor == 2) { Dia = "Martes"; };
           if (menor == 3) { Dia = "Miercoles"; };
           if (menor == 4) { Dia = "Jueves"; };
           if (menor == 5) { Dia = "Viernes"; };
            MessageBox.Show("Total de horas trabajadas semanalmente: " + valorHoras +
               "\nPromedio de horas trabajadas semanalmente: " + prom +
               "\nEl día que menos horas se trabajaron fue: " + Dia);*/


            MessageBox.Show("Total de horas trabajadas semanalmente: " + valorHoras +
                "\nPromedio de horas trabajadas semanalmente: " + prom +
                "\nEl día que menos horas se trabajaron fue: "+ menor);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //LIMPIAR TODOS LOS CAMPOS
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
    }
}
