<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ContentPage.aspx.cs" Inherits="prjFinal.ContentPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <form id="form1" runat="server">
       
        <h1 class="mt-4 pt-2" style="margin-left:330px;">Inscription </h1>
        <div class="d-flex justify-content-center">
             <div class="row g-3 ml-auto w-50">
                  <div class="col-md-6">
                    <asp:Label ID="Label3" runat="server" Text="Prenom" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtPrenom" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
                  <div class="col-md-6">
                    <asp:Label ID="Label4" runat="server" Text="Nom" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtNom" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
                  <div class="col-12">
                   <asp:Label ID="Label5" runat="server" Text="Email" CssClass="form-label"></asp:Label>
                   <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
                  <div class="col-12">
                   <asp:Label ID="Label10" runat="server" Text="Genre" CssClass="form-label"></asp:Label>
                      <asp:DropDownList ID="drpGenre" runat="server" CssClass="form-control">
                          <asp:ListItem>Homme</asp:ListItem>
                          <asp:ListItem>Femme</asp:ListItem>
                      </asp:DropDownList>
                  </div>
                 <div class="col-12">
                   <asp:Label ID="Label2" runat="server" Text="Mot de passe" CssClass="form-label"></asp:Label>
                   <asp:TextBox ID="txtMP" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
                  <div class="col-12">
                   <asp:Label ID="Label6" runat="server" Text="Adresse" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtAdresse" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
                  <div class="col-md-6">
                    <asp:Label ID="Label7" runat="server" Text="Ville" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtVille" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
                  <div class="col-md-4">
                   <asp:Label ID="Label8" runat="server" Text="Province" CssClass="form-label"></asp:Label>
      
                   <asp:TextBox ID="txtProvince" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
                  <div class="col-md-2">
                   <asp:Label ID="Label9" runat="server" Text="Code postal" CssClass="form-label"></asp:Label>
                   <asp:TextBox ID="txtCP" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
                  <div class="col-12">
                  <asp:Button ID="Button1" runat="server" Text="S'inscrire"  CssClass="btn btn-primary" OnClick="Button1_Click"/>

                  </div>
                 <div class="col-12">
                  
                     <asp:Label ID="Label1" runat="server" Text="Vous avez deja un compte ?" CssClass="form-label"></asp:Label>
                     <a href="Connection.aspx" class="text-primary"> Se connecter</a>
                  </div>
            </div>
        </div>
       

    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" runat="server">
</asp:Content>
