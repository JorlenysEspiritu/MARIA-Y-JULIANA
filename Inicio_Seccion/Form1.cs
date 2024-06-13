using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Seccion
{
    public partial class InicioSección : Form
    {
       
        //Intancea
        string Rutaconexion = null;
        SqlConnection conexion;
        string consulta = null;


        //Instancea
        public object Conexion { get; private set; }

        private readonly string usuario= "Jorlenys";
        private readonly string contraseña = "123456";


        

        
        

        public InicioSección()
        {
            InitializeComponent();
            //conecciòn
            conexion = new SqlConnection();
            //ruta de conexion con la base de datos
            Rutaconexion = @"Data Source=DESKTOP-JORLE;Initial Catalog=Ventas;Persist Security Info=True; User ID=""Jorlenys"";Password=123456;Encrypt=True;Trust Server Certificate=True";

        }



        private void btn_iniciar_Click(object sender, EventArgs e)
        {
           

       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contrasenaIngresada = txtcontraseña.Text;

            if (usuarioIngresado == usuario && contrasenaIngresada == contraseña)
            {

                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {

                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void InicioSección_Load(object sender, EventArgs e)
        {

        }
    }
}

