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
        string select = "Select Salt, Password from Alumnes where 1=1 and Login = '";
        string selectPass = "Select Password from Alumnes where 1=1 and Login = '";
        string passDeDDBB;
        string nomTabla = "Alumnes";
        string sal, psenha, paraHash;
        bool valido = false;

        private void btnValida_Click(object sender, EventArgs e)
        {
            //devuelve password para verificar
            GetPassword(txtUser.Text.ToString());




            //paraHash = sal + csenha;

            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(paraHash));
                string Hasheado = BitConverter.ToString(hashedBytes);
                paraHash = Hasheado;
            }


            if (paraHash == psenha)
            {
                valido = true;
            }
            //if (valido)
            //{
            //    this.Hide();
            //    frmDades formDades = new frmDades();
            //    formDades.ShowDialog();
            //}
        }

        public DataSet GetPassword(string cadena)
        {
            Connect(); 
            tablaTemporal = new SqlDataAdapter(selectPass, conect);
            conect.Open();
            tablaTemporal.Fill(dts, nomTabla);
            conect.Close();

            string csenha = txtPassword.Text.ToString();

            return dts;
        }
        public void Connect()
        {
            conect = new SqlConnection(connectionString);
        }

    }
}
