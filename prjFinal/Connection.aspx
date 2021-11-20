<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Connection.aspx.cs" Inherits="prjFinal.Connection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <form runat="server">
        
        <div class="d-flex justify-content-center">
           
             <div class="row g-3 ml-auto w-75">
                 <div class="col-12 card mb-3">
                    <asp:Image ID="Image1" runat="server" CssClass="card-img-top" ImageUrl="~/Images/connectionbg.jpg" />
                </div>
                 <h1 class="mt-4 pt-2" style="margin-left:330px;">Connection </h1>
                  <div class="col-12">
                    <asp:Label ID="Label4" runat="server" Text="Email" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>
                  <div class="col-12">
                   <asp:Label ID="Label5" runat="server" Text="Mot de passe" CssClass="form-label"></asp:Label>
                   <asp:TextBox ID="txtMotDePasse" runat="server" CssClass="form-control"></asp:TextBox>
                  </div>

                 <asp:Label ID="lblerreur" runat="server" Text=""></asp:Label>
                 
                  <asp:Button ID="Button1" runat="server" Text="Se connecter"  CssClass="btn btn-primary" OnClick="Button1_Click"/>

                 <div class="col-12">
                     <asp:Label ID="Label1" runat="server" Text="Vous n'avez pas de compte ?" CssClass="form-label"></asp:Label>
                     <a href="ContentPage.aspx" class="text-primary"> S'inscrire</a>
                  </div>
            </div>
         </div>
    </form>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" runat="server">
</asp:Content>
