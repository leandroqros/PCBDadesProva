using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace PCBDades
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //utilizacion base
        SqlConnection conect;
        SqlDataAdapter tablaTemporal;
        DataSet dts = new DataSet();
        string connectionString = "Data Source=CAFUNEPORTATIL\\SQLEXPRESS;Initial Catalog=PVDades;Integrated Security=True";
        string select = "Select Password,Salt from Alumnes where 1=1 and Login = '";
        string selectPass = "Select Password from Alumnes where 1=1 and Login = '";
        string valor, valor2;
        string nomTabla = "Alumnes";
        string paraHash;
        bool valido = false;

        private void btnValida_Click(object sender, EventArgs e)
        {
            //devuelve password para verificar
            GetPassword(txtUser.Text.ToString() + "'");

            //passBBDD
            valor = dts.Tables[0].Rows[0]["Password"].ToString();
            valor2 = dts.Tables[0].Rows[0]["Salt"].ToString();


            paraHash = valor2 + txtPassword.Text.ToString();


            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(paraHash));
                string Hasheado = BitConverter.ToString(hashedBytes);
                paraHash = Hasheado;
            }


            if (paraHash == valor)
            {
                valido = true;
            }

            if (valido)
            {
                this.Hide();
                frmDades formDades = new frmDades();
                formDades.ShowDialog();
            }
        }

        public DataSet GetPassword(string cadena)
        {
            Connect(); 
            tablaTemporal = new SqlDataAdapter(select + cadena, conect);
            conect.Open();
            tablaTemporal.Fill(dts, nomTabla);
            conect.Close();

            return dts;
        }

        public void Connect()
        {
            conect = new SqlConnection(connectionString);
        }

    }
}
