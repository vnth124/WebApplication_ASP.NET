<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyAdmin.aspx.cs" Inherits="WebApplication1.MyAdmin" MasterPageFile="~/MyLayout.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="jumbotron"  style="margin-top:76px;margin-bottom:0px;height:84vh;background-image:url(Content/Bglogo.png)">

        

        

  <div class="form-group row" style="justify-content:center;">
    <label for="inputDefaultPageText1" class="col-sm-2 col-form-label">Default Page Text 1</label>
    <div class="col-sm-10" style="max-width: 28%;">
      <asp:TextBox ID="TextBoxDefaultPageText1" runat="server" class="form-control form-control-lg" placeholder="Enter Default Page Text 1"></asp:TextBox>
    </div>
  </div>


  <div class="form-group row" style="justify-content:center;">
    <label for="inputDefaultText2" class="col-sm-2 col-form-label">Default Page Text 2</label>
    <div class="col-sm-10" style="max-width: 28%;">
      <asp:TextBox ID="TextBoxDefaultPageText2" runat="server" class="form-control form-control-lg" placeholder="Enter Default Page Text 2"></asp:TextBox>
    </div>
  </div>


       <div class="form-group row" style="justify-content:center;">
    <label for="inputHeader" class="col-sm-2 col-form-label">Default Page Header</label>
    <div class="col-sm-10" style="max-width: 28%;">
      <asp:TextBox ID="TextBoxDefaultPageHeader" runat="server" class="form-control form-control-lg" placeholder="Enter Default Page Header"></asp:TextBox>
    </div>
  </div>


       <div class="form-group row" style="justify-content:center;">
    <label for="inputFooter" class="col-sm-2 col-form-label">Default Page Footer</label>
    <div class="col-sm-10" style="max-width: 28%;">
      <asp:TextBox ID="TextBoxDefaultPageFooter" runat="server" class="form-control form-control-lg" placeholder="Enter Default Page Footer"></asp:TextBox>
    </div>
  </div>
  
  <div class="form-group row">
    <div class="col-sm-12" style="text-align: center";>
        <asp:Button ID="ButtonSaveSettings" class="btn btn-primary btn-lg " runat="server" Text="Save Settings" OnClick="ButtonSaveSettings_Click" />
    </div>
  </div>
         
  
</section>

    
</asp:Content>
