using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Expresiones_Regulares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar que se ingrese un número de 3 dígitos enteros, el carácter punto y 2 dígitos decimales.
            string patron1 = @"^\d{3}\.\d{2}$";
            //Solicitar el ingreso de la coordenada de un punto. Formato: (999,999) Los números pueden tener entre 1 y 3 dígitos
            string patron2 = @"^[(]\d{1,3},\d{1,3}[)]$";
            //Validar si un string contiene 4 números de 3 dígitos cada uno separados por coma.
            string patron3 = @"\d{3},\d{3},\d{3},\d{3}";
            //Confeccionar una expresión regular que valide el ingreso del nombre de un día de la
            //semana, un espacio y un número de 1 o 2 dígitos.
            string patron4 = @"\A(Lunes|Martes|Miércoles|Jueves|Viernes|Sábado|Domingo)+\ \d{1,2}$";
            //Validar el ingreso de una hora con el formato hh:mm: ss o hh: mm
            string patron5 = @"\A(?:[0-9]|1[0-9]|2[0-4])[:](?:[0-9]|5[0-9])[:](?:[0-9]|5[0-9])$";
            //Validar que se ingrese un código IBAN(de una cuenta bancaria) de 20 caracteres.
            //Ej: ESXX - XXXX - XXXX - XX - XXXXXXXXXX
            string patron6 = @"\AES\d{2}-\d{4}-\d{4}-\d{2}-\d{10}$";
            //Validar que se ingrese un número entero(positivo o negativo)
            string patron7 = @"\A-?\d+$";
            //Validar el formato de un DNI. Sabiendo que las letras de un DNI son:
            //T - R - W - A - G - M - Y - F - P - D - X - B - N - J - Z - S - Q - V - H - L - C - K - E
            string patron8 = @"\A\d{8}[A-HJ-NP-TV-Z]$";
            //Validar una dirección IP. Sabiendo que el formato es:
            //Num.num.num.num Y cada “num” está entre 0 y 255, incluidos.
            string patron9 = "";
            //Validar una matrícula de un coche con formato NNNNLLL
            string patron10 = @"\A\d{4}\s?[B-DF-HJ-NPR-TV-Z]{3}\Z$";
            //Validar que se ingresa un número real(positivo o negativo), cuyo separador de
            //decimales puede ser la coma o el punto
            string patron11 = @"\A[0]|[+-]?[1-9]\d*|[+-]?([0][1-9]\d*[.,]\d[1-9]\Z$";
            //Validar una fecha con formato dd/ mm / aaaa
            string patron12 = @"\A(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}\Z";
            //Validar un nombre, incluyendo nombres compuestos por dos palabras como mucho
            string patron13 = @"\A([A-ZÁ-ÚÑ][a-zá-úñ]+)(\s[A-ZÁ-ÚÑ][a-zá-úñ]+)?\Z$";
            //Valida un nombre de usuario en Twitter, empieza por @ y puede contener letras
            //mayúsculas y minúsculas, números, guiones y guiones bajos.
            string patron14 = @"\A[@][\w\-]{3,15}\Z$";
            //Validar ISBN de 13 dígitos, siempre empieza en 978 o 979
            //EJ: 978 - 0 - 13 - 235088 - 4
            string patron15 = @"\A(978|979)[-][0-9][-][0-9]{2}[-][0-9]{6}[-][0-9]\Z$";
            //una contraseña teniendo en cuenta que debe
            //tener entre 8 y 12 caracteres, y al menos una mayúscula, una minúscula, y un dígito
            string patron16 = @"\A(?=.*[A-Z])(?=.*[a-z])(?=.*\d)\w{8,12}\Z$";


            string entrada = txt1.Text;

            if (Regex.IsMatch(entrada, patron12))
            {
                MessageBox.Show("Válido");
            }
            else
            {
                MessageBox.Show("No válido");
            }
        }
    }
}