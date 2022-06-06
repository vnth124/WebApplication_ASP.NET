<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/MyLayout.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-full-bg">
    <div class="jumbotron jumbotron-fluid" style="height:95vh;margin-bottom: 0;background-image:url(Content/Bglogo.png)">
       
        <p class="lead" style="height: 89vh;
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: xxx-large;
    font-style: oblique;
    font-weight: 700;
    font-family: sans-serif;">
            <asp:Label ID="LabelDefaultPageText1" runat="server" Text="Label" ></asp:Label></p>
    </div>
        </div>

</asp:Content>
