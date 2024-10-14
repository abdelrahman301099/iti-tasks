using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDoperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetDataFromDB();
        }

        private void GetDataFromDB()
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-4Q3BJNA;Database=pubs;trusted_connection=true;TrustServerCertificate=true");

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from authors";
            cmd.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                viewGrid.DataSource = dt;
            }
            
            finally { con.Close(); }

        }
    }
}
