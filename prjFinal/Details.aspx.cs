using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjFinal
{
    public partial class Details : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RencontreDB.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            string email = null;

            if (!string.IsNullOrEmpty(Request.QueryString["e"]))
            {
                string ex = Request.QueryString["e"];
                email = ex;
            }

            RencontreDBEntities rencontreDBEntities = new RencontreDBEntities();

            Utilisateur utilisateur = rencontreDBEntities.Utilisateur.Where(x => x.Email == email).FirstOrDefault();

            lblCat.Text = utilisateur.Criteres.Categorie;
            lblCorps.Text = utilisateur.Criteres.Corps;
            lblEthnie.Text = utilisateur.Criteres.Ethnie;
            lblReligion.Text = utilisateur.Criteres.Religion;

           /* SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select  * from criteres where email = '" + email + "'";
            SqlDataReader reader2 = cmd2.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader2.Read())
            {
                string cat = reader2[1].ToString();
                string crp = reader2[2].ToString();
                string eth = reader2[3].ToString();
                string rel = reader2[4].ToString();
                lblReligion.Text = rel;
                lblEthnie.Text = eth;
                lblCorps.Text = crp;
                lblCat.Text = cat;
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            SqlCommand cmd4 = con.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select  * from utilisateur where email = '" + email + "'";
            SqlDataReader reader4 = cmd4.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader4.Read())
            {
                var nom = reader4[1];
                var prenom = reader4[2];
                ESP.Text = prenom + " " + nom;
                lblTitle.Text = prenom + " " + nom;
                

            }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("index.aspx");
        }
    }
}