using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProg
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        List<string> paises = new List<string>
            {
               "Afganistán",
                "Albania",
                "Alemania",
                "Andorra",
                "Angola",
                "Antigua y Barbuda",
                "Arabia Saudita",
                "Argelia",
                "Argentina",
                "Armenia",
                "Australia",
                "Austria",
                "Azerbaiyán",
                "Bahamas",
                "Bangladés",
                "Barbados",
                "Baréin",
                "Bélgica",
                "Belice",
                "Benín",
                "Bielorrusia",
                "Birmania",
                "Bolivia",
                "Bosnia y Herzegovina",
                "Botsuana",
                "Brasil",
                "Brunéi",
                "Bulgaria",
                "Burkina Faso",
                "Burundi",
                "Bután",
                "Cabo Verde",
                "Camboya",
                "Camerún",
                "Canadá",
                "Catar",
                "Chad",
                "Chile",
                "China",
                "Chipre",
                "Colombia",
                "Comoras",
                "Corea del Norte",
                "Corea del Sur",
                "Costa de Marfil",
                "Costa Rica",
                "Croacia",
                "Cuba",
                "Dinamarca",
                "Dominica",
                "Ecuador",
                "Egipto",
                "El Salvador",
                "Emiratos Árabes Unidos",
                "Eritrea",
                "Eslovaquia",
                "Eslovenia",
                "España",
                "Estados Unidos",
                "Estonia",
                "Esuatini",
                "Etiopía",
                "Filipinas",
                "Finlandia",
                "Fiyi",
                "Francia",
                "Gabón",
                "Gambia",
                "Georgia",
                "Ghana",
                "Granada",
                "Grecia",
                "Guatemala",
                "Guinea",
                "Guinea-Bisáu",
                "Guinea Ecuatorial",
                "Guyana",
                "Haití",
                "Honduras",
                "Hungría",
                "India",
                "Indonesia",
                "Irak",
                "Irán",
                "Irlanda",
                "Islandia",
                "Islas Marshall",
                "Islas Salomón",
                "Israel",
                "Italia",
                "Jamaica",
                "Japón",
                "Jordania",
                "Kazajistán",
                "Kenia",
                "Kirguistán",
                "Kiribati",
                "Kuwait",
                "Laos",
                "Lesoto",
                "Letonia",
                "Líbano",
                "Liberia",
                "Libia",
                "Liechtenstein",
                "Lituania",
                "Luxemburgo",
                "Macedonia del Norte",
                "Madagascar",
                "Malasia",
                "Malaui",
                "Maldivas",
                "Malí",
                "Malta",
                "Marruecos",
                "Mauricio",
                "Mauritania",
                "México",
                "Micronesia",
                "Moldavia",
                "Mónaco",
                "Mongolia",
                "Montenegro",
                "Mozambique",
                "Namibia",
                "Nauru",
                "Nepal",
                "Nicaragua",
                "Níger",
                "Nigeria",
                "Noruega",
                "Nueva Zelanda",
                "Omán",
                "Países Bajos",
                "Pakistán",
                "Palaos",
                "Panamá",
                "Papúa Nueva Guinea",
                "Paraguay",
                "Perú",
                "Polonia",
                "Portugal",
                "Reino Unido",
                "República Centroafricana",
                "República Checa",
                "República del Congo",
                "República Democrática del Congo",
                "República Dominicana",
                "Ruanda",
                "Rumanía",
                "Rusia",
                "Samoa",
                "San Cristóbal y Nieves",
                "San Marino",
                "San Vicente y las Granadinas",
                "Santa Lucía",
                "Santo Tomé y Príncipe",
                "Senegal",
                "Serbia",
                "Seychelles",
                "Sierra Leona",
                "Singapur",
                "Siria",
                "Somalia",
                "Sri Lanka",
                "Sudáfrica",
                "Sudán",
                "Sudán del Sur",
                "Suecia",
                "Suiza",
                "Surinam",
                "Tailandia",
                "Tanzania",
                "Tayikistán",
                "Timor Oriental",
                "Togo",
                "Tonga",
                "Trinidad y Tobago",
                "Túnez",
                "Turkmenistán",
                "Turquía",
                "Tuvalu",
                "Ucrania",
                "Uganda",
                "Uruguay",
                "Uzbekistán",
                "Vanuatu",
                "Vaticano",
                "Venezuela",
                "Vietnam",
                "Yemen",
                "Yibuti",
                "Zambia",
                "Zimbabue"
               };
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboPaises.DataSource = paises;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateNac_ValueChanged(object sender, EventArgs e)
        {
            int edad = DateTime.Today.Year - dateNac.Value.Year;
            if (edad <= 0)
            {
                txtEdad.Text = "";
            }
            else
            {
                txtEdad.Text = edad.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEdad.Text = "";
            txtApellido.Clear();
            txtNombre.Clear();  
            dateNac.Value = DateTime.Now;
            comboPaises.SelectedItem = 0;

        }
    }
}
