<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="prjFinal.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <form runat="server">
         <div class="d-flex justify-content-center mt-4">
            <div class="row g-3 ml-auto w-50">
                <div class="alert alert-primary" role="alert">
                En savoir plus sur: <asp:Label ID="ESP" runat="server" Text="Jhon Doe" Font-Bold="True"></asp:Label>
                </div>
            <div class="card mb-3" style="max-width: 100%;">
                <div class="row g-0">
                    <div class="col-md-4">
                        <asp:Image ID="Image1" runat="server" CssClass="img-fluid rounded-start" ImageUrl="~/Images/women.jpg" />
                    </div>
                    <div class="col-md-8">
                      <div class="card-body">
                          <asp:Label ID="Label2" runat="server" Text="Nom:" CssClass="card-title" Font-Size="XX-Large"></asp:Label>
                          <asp:Label ID="lblTitle" runat="server" Text="Title" CssClass="card-title" Font-Size="XX-Large" Font-Bold="True"></asp:Label>
                          <br /><br />
                          <asp:Label ID="Label3" runat="server" Text="Coprs:" CssClass="card-title" Font-Size="X-Large"></asp:Label>
                          <asp:Label ID="lblCorps" runat="server" Text="Coprs" CssClass="card-text" Font-Size="X-Large" Font-Bold="True"></asp:Label>
                          <br /><br />
                          <asp:Label ID="Label4" runat="server" Text="Ethnie:" CssClass="card-title" Font-Size="X-Large"></asp:Label>
                          <asp:Label ID="lblEthnie" runat="server" Text="Ethnie" CssClass="card-text"  Font-Size="X-Large"  Font-Bold="True"></asp:Label>
                          <br /><br />
                          <asp:Label ID="Label5" runat="server" Text="Religion:" CssClass="card-title" Font-Size="X-Large"></asp:Label>
                          <asp:Label ID="lblReligion" runat="server" Text="Religion" CssClass="card-text"  Font-Size="X-Large"  Font-Bold="True"></asp:Label>
                          <br /><br />
                          <asp:Label ID="Label6" runat="server" Text="Categorie:" CssClass="card-title" Font-Size="X-Large"></asp:Label>
                          <asp:Label ID="lblCat" runat="server" Text="cat" CssClass="card-text"  Font-Size="X-Large"  Font-Bold="True"></asp:Label>
      
                    </div>
                </div>
              </div>
            </div>
           <div class="d-flex bd-highlight mb-3">
              <div class="me-auto p-2 bd-highlight">
                   <asp:Button ID="Button1" runat="server" Text="Retour" CssClass="btn btn-danger" OnClick="Button1_Click" />
              </div>
              <div class="p-2 bd-highlight">
                   <asp:Button ID="Button2" runat="server" Text="Envoyer message" CssClass="btn btn-primary"/>
              </div>
            </div>

       </div>
     </div>
        
    </form>
    
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" runat="server">
</asp:Content>
