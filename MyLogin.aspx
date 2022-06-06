<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyLogin.aspx.cs" Inherits="WebApplication1.MyLogin" MasterPageFile="~/MyLayout.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <section class="jumbotron" style="margin-top:76px;margin-bottom:0px;height:84vh;background-image:url(Content/Bglogo.png)">
  <div class="container"style="display: flex;align-items: center;justify-content: center;" >
      <div class="col-12 col-md-6 col-lg-6 col-xl-5">
            <div class="form-outline mb-4" style="padding-bottom:20px;">
                
              <label class="form-label" for="typeEmailX-2">Email</label>
              <asp:TextBox ID="TextBoxEmail" runat="server" class="form-control form-control-lg" placeholder="Enter Email"></asp:TextBox>
              

            </div>

            <div class="form-outline mb-4" style="padding-bottom:20px;">
                
              <label class="form-label" for="typePasswordX-2">Password</label>
              <asp:TextBox ID="TextBoxPassword" runat="server" class="form-control form-control-lg" placeholder="Enter Valid Password" TextMode="Password"></asp:TextBox>
              

            </div>
          <asp:Button ID="ButtonLogin" class="btn btn-primary btn-lg " runat="server" Text="Login" OnClick="ButtonLogin_Click1" />
          <br />
          <br />
          <asp:Label ID="LabelMessage" runat="server" ForeColor="Red"></asp:Label>
            
          </div>
        
    </div>
  
</section>

    
</asp:Content>
