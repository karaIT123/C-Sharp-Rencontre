using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace prjFinal
{
    public partial class ContentPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RencontreDB.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RencontreDBEntities rencontreDBEntities = new RencontreDBEntities();

            Utilisateur user = new Utilisateur();
            user.Ville = txtVille.Text;
            user.Province = txtProvince.Text;
            user.Adresse = txtAdresse.Text;
            user.choice = false;
            user.CP = txtCP.Text;
            user.Email = txtEmail.Text;
            user.Genre = drpGenre.SelectedValue;
            user.MotDePasse = txtMP.Text;
            user.Nom = txtNom.Text;
            user.Prenom = txtPrenom.Text;
            //user.Criteres_Id = -1;
            user.Criteres = new Criteres();


            rencontreDBEntities.Utilisateur.Add(user);
            rencontreDBEntities.SaveChanges();



            Server.Transfer("Connection.aspx");

            /*SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into utilisateur values ( '" + txtNom.Text + "','" + txtPrenom.Text + "','"+txtEmail.Text+"','"+txtAdresse.Text+"','"+txtVille.Text+"','"+txtProvince.Text+"','"+txtCP.Text+"','"+txtMP.Text+"','"+drpGenre.SelectedValue +"','false' )";
            cmd.ExecuteNonQuery();
            Server.Transfer("Connection.aspx");*/
        }
    }
}