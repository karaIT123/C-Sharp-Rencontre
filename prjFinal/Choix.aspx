<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Choix.aspx.cs" Inherits="prjFinal.Choix" %>
<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <form runat="server">
        <h1 class="mt-4 pt-2" style="margin-left:330px;">Criteres </h1>
        <div class="d-flex justify-content-center">
             <div class="row g-3 ml-auto w-25">
                  <div class="col-12">
                    <asp:Label ID="Label1" runat="server" Text="Categorie" CssClass="form-label"></asp:Label>
                    <asp:DropDownList runat="server"  CssClass="form-control" ID="drpCategorie">
                        <asp:ListItem>Homme cherche femme</asp:ListItem>
                        <asp:ListItem>Femme cherche homme</asp:ListItem>
                        <asp:ListItem>Femme cherche Femme</asp:ListItem>
                        <asp:ListItem>Homme cherche homme</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                  <div class="col-12">
                    <asp:Label ID="Label4" runat="server" Text="Type de corps" CssClass="form-label"></asp:Label>
                    <asp:DropDownList runat="server"  CssClass="form-control" ID="drpCorps">
                        <asp:ListItem>Mince</asp:ListItem>
                        <asp:ListItem>Moyen</asp:ListItem>
                        <asp:ListItem Value="Gros"></asp:ListItem>
                      </asp:DropDownList>
                  </div>
                  <div class="col-12">
                   <asp:Label ID="Label5" runat="server" Text="Ethnie" CssClass="form-label"></asp:Label>
                   <asp:DropDownList runat="server" CssClass="form-control" ID="drpEthnie" >
                       <asp:ListItem>Noir</asp:ListItem>
                       <asp:ListItem>Europeen</asp:ListItem>
                       <asp:ListItem>Asiatique</asp:ListItem>
                       <asp:ListItem>Americain</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                 <div class="col-12">
                   <asp:Label ID="Label2" runat="server" Text="Religion" CssClass="form-label"></asp:Label>
                   <asp:DropDownList runat="server"  CssClass="form-control" ID="drpReligion">
                       <asp:ListItem>Chretien</asp:ListItem>
                       <asp:ListItem>Catolique</asp:ListItem>
                       <asp:ListItem>Musulman</asp:ListItem>
                       <asp:ListItem>Juif</asp:ListItem>
                     </asp:DropDownList>
                  </div>

                 <div class="col-6">
                      <asp:Button ID="Button1" runat="server" Text="Retour"  CssClass="btn btn-danger w-100" OnClick="Button1_Click" />
                 </div>
                  <div class="col-6">
                      <asp:Button ID="Button2" runat="server" Text="Continuer"  CssClass="btn btn-primary w-100" OnClick="Button2_Click" />
                 </div>
                 

                
            </div>
         </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" runat="server">
</asp:Content>
