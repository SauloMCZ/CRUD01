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

namespace CRUD01
{
    public partial class Form1 : Form
    {
        SqlDataAdapter da;
        SqlDataReader dr;
        SqlCommand comand;
        SqlConnection con;
        public string strData;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Server=DESKTOP-C43IAVO;Database=CRUD;User Id=sa;Password=Jo@o2005;");
                strData = "SELECT * FROM CLIENTES WHERE NOME = @NOME";
                comand = new SqlCommand(strData, con);
            

                comand.Parameters.AddWithValue("@NOME", tbNome.Text);

                con.Open();

                dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    tbId.Text = Convert.ToString (dr["ID"]);
                    tbNome.Text = (string)dr["NOME"];
                    tbTelefone.Text = Convert.ToString(dr["TELEFONE"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                con.Close();
                comand = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Server=DESKTOP-C43IAVO;Database=CRUD;User Id=sa;Password=Jo@o2005;");
                strData = "UPDATE CLIENTES SET NOME=@NOME, TELEFONE=@TELEFONE WHERE ID=@ID";
                comand = new SqlCommand(strData, con);

                comand.Parameters.AddWithValue("@ID", tbId.Text);
                comand.Parameters.AddWithValue("@NOME", tbNome.Text);
                comand.Parameters.AddWithValue("@TELEFONE", tbTelefone.Text);

                con.Open();

                comand.ExecuteNonQuery();

                MessageBox.Show("Alterado com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                comand = null;
            }
        }

        private void btnExibe_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Server=DESKTOP-C43IAVO;Database=CRUD;User Id=sa;Password=Jo@o2005;");
                strData = "SELECT * FROM CLIENTES";
                comand = new SqlCommand(strData, con);
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(strData, con);

                con.Open();

                da.Fill(ds);

                dgvDados.DataSource = ds.Tables[0];

                tbNome.Text = "";
                tbId.Text = "";
                tbTelefone.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally 
            {
                con.Close();
                comand = null;

            
            }

        }

        private void btnGrava_Click(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(@"Server=DESKTOP-C43IAVO;Database=CRUD;User Id=sa;Password=Jo@o2005;");
                strData = "INSERT INTO CLIENTES (NOME,TELEFONE)VALUES (@NOME,@TELEFONE)";
                comand = new SqlCommand(strData, con);

                comand.Parameters.AddWithValue("@ID", tbId.Text);
                comand.Parameters.AddWithValue("@NOME", tbNome.Text);
                comand.Parameters.AddWithValue("@TELEFONE", tbTelefone.Text);

                con.Open();
                comand.ExecuteNonQuery();
                MessageBox.Show("Gravado com sucesso");

                tbNome.Text = "";
                tbId.Text = "";
                tbTelefone.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally 
            {
            con.Close();
            comand = null;

            }
            }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Server=DESKTOP-C43IAVO;Database=CRUD;User Id=sa;Password=Jo@o2005;");
                strData = "DELETE CLIENTES WHERE NOME=@NOME";
                comand = new SqlCommand(strData, con);

                comand.Parameters.AddWithValue("@NOME", tbNome.Text);

                con.Open();
                comand.ExecuteNonQuery();

                MessageBox.Show("Excluido com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
