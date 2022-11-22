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

namespace PCBDades
{
    public partial class frmDades : Form
    {
        public frmDades()
        {
            InitializeComponent();
          
        }
        //utilizacion base
        SqlConnection conect;
        SqlDataAdapter tablaTemporal;
        DataSet dts = new DataSet();
        string connectionString = "Data Source=CAFUNEPORTATIL\\SQLEXPRESS;Initial Catalog=PVDades;Integrated Security=True";
        string query = "select Nom, Bandol, IP, Edat from alumnes where 1=1";
        string nomTabla = "Alumnes";
        string select;

        public void Connect()
        {
            conect = new SqlConnection(connectionString);
        }

        public void UpdateData(DataSet dts, string consultaOriginal)
        {
            SqlDataAdapter actualizar = new SqlDataAdapter(consultaOriginal, conect);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(actualizar);

            conect.Open();

            if (dts.HasChanges())
            {
                int result = actualizar.Update(dts.Tables[0]);
            }
            dts.Tables[0].AcceptChanges();
        }

        private void cmdGetData_Click(object sender, EventArgs e)
        {
            //select con combobox
            if (cmbBandol.Text.Equals("Rebel Alliance"))
            {
                select = query + "and Bandol = '" + cmbBandol.Text.ToString() + "'";
            } else
            {
                select = query + "and Bandol = '" + cmbBandol.Text.ToString() + "'";
            }

            //traer tabla
            Connect();
            tablaTemporal = new SqlDataAdapter(select, conect);
            conect.Open();
            tablaTemporal.Fill(dts, nomTabla);
            conect.Close();

            dtgUsers.DataSource = dts.Tables[0];

            //Limpiar textBox
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    controle.DataBindings.Clear();
                }
            }

            //Escribir TextBox
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    if (controle.Tag == "Nom")
                    {
                        controle.DataBindings.Add("Text", dts.Tables[0], "Nom");
                    }
                    else if (controle.Tag == "IP")
                    {
                        controle.DataBindings.Add("Text", dts.Tables[0], "IP");
                    } else
                    {
                        controle.DataBindings.Add("Text", dts.Tables[0], "Edat");
                    }
                }
            }



        }


        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            UpdateData(dts,select);
            conect.Close();
        }

        private void frmDades_Load(object sender, EventArgs e)
        {
            //Connect();
            //tablaTemporal = new SqlDataAdapter(query, conect);
            //conect.Open();
            //tablaTemporal.Fill(dts, nomTabla);
            //conect.Close();

            //dtgUsers.DataSource = dts.Tables[0];
        }
    }
}
