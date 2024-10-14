using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDoperations
{
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
         
        }

        

        private void btnInsert_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Server=DESKTOP-4Q3BJNA;Database=pubs;trusted_connection=true;TrustServerCertificate=true");

            SqlCommand command = new SqlCommand();
            command.CommandText = $"insert into authors (au_id,au_fname,au_lname,Address) values(@id,@fname,@lname,@address)";
            command.Parameters.AddWithValue("@id", txtID.Text);
            command.Parameters.AddWithValue("@fname", txtFname.Text);
            command.Parameters.AddWithValue("@lname", txtLname.Text);
            command.Parameters.AddWithValue("@address", txtAdress.Text);

            command.Connection = con;
            try
            {

                con.Open();

                var affected = command.ExecuteNonQuery();
                if (affected > 0)
                {
                    label5.Text = " Added ";
                }
            }
            catch (Exception ex) {


            }
            finally
            {
                con.Close();
            }

        }
    }
}
