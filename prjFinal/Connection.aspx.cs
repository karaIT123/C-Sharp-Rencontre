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
    public partial class Connection : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RencontreDB.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            RencontreDBEntities rencontreDBEntities = new RencontreDBEntities();

            /*Utilisateur utilisateur = new Utilisateur();
            utilisateur.Adresse = "4667 vezina";
            utilisateur.choice = false;
            utilisateur.CP = "H3W 1B7";
            utilisateur.Email = "vanelle@gmail.com";
            utilisateur.MotDePasse = "vanelle";
            utilisateur.Nom = "Nyanda";
            utilisateur.Prenom = "Vanelle";
            utilisateur.Province = "QC";
            utilisateur.Ville = "Montreal";
            utilisateur.Genre = "Femme";

            Criteres criteres = new Criteres();
            criteres.Categorie = "Femme cherche homme";
            criteres.Corps = "1,60";
            criteres.Ethnie = "Bameleke";
            criteres.Religion = "Chretienne";

            utilisateur.Criteres = criteres;

            rencontreDBEntities.Utilisateur.Add(utilisateur);
            rencontreDBEntities.SaveChanges();*/

            string email = txtEmail.Text;
            string mp = txtMotDePasse.Text;

            if(email == "" || mp == "")
            {
                lblerreur.Text = "Champs email ou mot de passe";
            }else
            {
                HttpCookie email_cookie = new HttpCookie("email_cookies");
                email_cookie["email"] = email;
                email_cookie.Expires = DateTime.Now.AddDays(3);

                Response.Cookies.Add(email_cookie);
            }

            Utilisateur user = rencontreDBEntities.Utilisateur.Where(x => x.Email == txtEmail.Text).FirstOrDefault();

            if(user.choice == true)
            {
                Server.Transfer("Index.aspx");
            }
            else
            {
                Server.Transfer("Choix.aspx");
            }

           

        }
    }
}