<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="prjFinal.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <div class="card bg-dark text-white">
      <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/indexbg.jpg" CssClass="card-img-top" />
      <div class="card-img-overlay">
        <h5 class="card-title fs-2">Bienvenue sur VavaMatch</h5><br />
        <p class="card-text">VavaMatch est un site de rencontre qui vous permet de rencontrer d'autre personne par categories, par criteres etc...</p>
      </div>
    </div>


    <h2>Personnes interesser</h2>
  
    <asp:PlaceHolder ID="placeholder" runat="server"></asp:PlaceHolder>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" runat="server">
</asp:Content>
