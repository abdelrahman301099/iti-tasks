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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDoperations
{
    public partial class Form3 : Form
    {
        public Form3()
        {


            InitializeComponent();
            GetAutherData();
        }

        private void GetAutherData()
        {
            
            SqlConnection con = new SqlConnection("Server=DESKTOP-4Q3BJNA;Database=pubs;trusted_connection=true;TrustServerCertificate=true");
            

            
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from authors";

           
            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "au_fname";
                comboBox1.ValueMember = "au_id"; 
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            SqlConnection con = new SqlConnection("Server=DESKTOP-4Q3BJNA;Database=pubs;trusted_connection=true;TrustServerCertificate=true");
            

         
            SqlCommand command = new SqlCommand();
            string id = comboBox1.SelectedValue.ToString();
            command.CommandText = $"select t.* from authors a,titles t,titleauthor ta where a.au_id=ta.au_id and ta.title_id=t.title_id  and a.au_id='{id}'";

           
            command.Connection = con;

            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            catch { }
            finally { con.Close(); }

        }
    }
}

