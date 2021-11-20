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
    public partial class Choix : System.Web.UI.Page
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RencontreDB.mdf;Integrated Security=True");
        string email = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie email_cookie = Request.Cookies["email_cookies"];
            if(email_cookie != null)
            {
                email = email_cookie["email"];
            }

           /* if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
           */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Connection.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            RencontreDBEntities rencontreDBEntities = new RencontreDBEntities();

            Utilisateur utilisateur = rencontreDBEntities.Utilisateur.Where(x => x.Email == email).FirstOrDefault();

            //Criteres criteres = new Criteres();

            utilisateur.Criteres.Categorie = drpCategorie.SelectedValue;
            utilisateur.Criteres.Corps = drpCorps.SelectedValue;
            utilisateur.Criteres.Ethnie = drpEthnie.SelectedValue;
            utilisateur.Criteres.Religion = drpReligion.SelectedValue;

            //utilisateur.Criteres = criteres;
            utilisateur.choice = true;

            rencontreDBEntities.SaveChanges();

            Server.Transfer("Index.aspx");

            /*
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into criteres values ( '" + drpCategorie.SelectedValue + "','" + drpCorps.SelectedValue + "','" + drpEthnie.SelectedValue + "','" + drpReligion.SelectedValue + "','" + email + "')";
            //cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "update utilisateur set choice = 'true' where email = '"+email+"'";
            cmd2.ExecuteNonQuery();
            */
        }
    }
}