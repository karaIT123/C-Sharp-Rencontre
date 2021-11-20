using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;


namespace prjFinal
{
    public partial class Index : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RencontreDB.mdf;Integrated Security=True");
        string email = null;
        string category = null;
        List<ListItem> emailList = new List<ListItem>();
        List<CardItem> cardItems = new List<CardItem>();
        StringBuilder table = new StringBuilder(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie email_cookie = Request.Cookies["email_cookies"];
            if (email_cookie != null)
            {
                email = email_cookie["email"];
            }

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            RencontreDBEntities rencontreDBEntities = new RencontreDBEntities();

            Utilisateur user = rencontreDBEntities.Utilisateur.Where(x => x.Email == email).FirstOrDefault();
            category = user.Criteres.Categorie;
            string catInv = getCategoryInverse(category);

            List<Utilisateur> CatListInv = rencontreDBEntities.Utilisateur.Where(x => x.Criteres.Categorie == catInv).ToList();


            foreach (var item in CatListInv)
            {
                CardItem c = new CardItem();
                c.nom = item.Prenom + " " + item.Nom;
                c.lien = item.Email;
                c.genre = item.Genre;

                cardItems.Add(c);
            }

            

           /* SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select  * from criteres where email = '" + email + "'";
            SqlDataReader reader2 = cmd2.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader2.Read())
            {    
                category = reader2[1].ToString();
            }

            con.Close();
            con.Open();
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            //string catInv = getCategoryInverse(category);
            cmd3.CommandText = "select  * from criteres where categorie = '" + catInv + "'";
            SqlDataReader reader3 = cmd3.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader3.Read())
            {
                //var x1 = reader3[1].ToString();
                //var x2 = reader3[2];
                var genreX = reader3[3];
                //var x4 = reader3[4];
                var emailX = reader3[5];
                emailList.Add(new ListItem() { Text = emailX.ToString(), Value = genreX.ToString()});

            }
            con.Close();

            foreach (var listItem in emailList)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                SqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "select  * from utilisateur where email = '" + listItem.Text + "'";
                SqlDataReader reader4 = cmd4.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader4.Read())
                {
                    var nom = reader4[1];
                    var prenom = reader4[2];
                    var mail_ant = reader4[3];
                    //var xx4 = reader4[9];
                    //var xx5 = reader4[10];

                    CardItem c = new CardItem();
                    c.nom = prenom + " "+nom;
                    c.lien = mail_ant.ToString();
                    c.genre = listItem.Value;

                    cardItems.Add(c);

                }
            }
           */
            table.Append("<div class='row'>");
            foreach (var cardItem in cardItems)
            {
                table.Append("<div class='col-3'> " +
                "<div class='card border-dark mb-3' style='max-width: 18rem;'>" +
                "<div class='card-header'>" + cardItem.nom + "</div>" +
                "<div class='card-body text-dark'>" +
                "<h5 class='card-title'>" + cardItem.genre + "</h5>" +
                "<p class='card-text'> <a href='Details.aspx?e=" + cardItem.lien + "'>En savoir plus</a>  " +
                "</p>" +
                "</div>" +
                "</div>" +
                "</div>");
            }
            
            table.Append("</div>");
            placeholder.Controls.Add(new Literal { Text = table.ToString()});
            
        }

        string getCategoryInverse(string category)
        {
            string c = null;
            if(category == "Homme cherche femme")
            {
                c = "Femme cherche homme";
            }            
            else if(category == "Femme cherche homme")
            {
                c = "Homme cherche femme";
            }
            else if (category == "Femme cherche femme")
            {
                c = category;
            }
            else if (category == "Homme cherche homme")
            {
                c = category;
            }
            else
            {
                c = null;
            }

            return c;
        }

    }
}