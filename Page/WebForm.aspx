<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Page.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title></title>
     <link href="StyleSheet.css" rel="stylesheet" />
    
</head>
<body>
    <form id="form1" runat="server">
       <div class="inputCol">
        <div>
            <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
        </div>
      
        <div>
        <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
        </div>
            </div>
         <div>
            <asp:Label ID="Label2" runat="server" Text="LastName"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="Label3" runat="server" Text="MobileNo"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="Mobile" runat="server" TextMode="Number"></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="Label4" runat="server" Text="Dob"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="Dob" runat="server" TextMode="Date"></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="Button1_Click1" />
        <div>
          <asp:Label ID="sucess" runat="server" ></asp:Label>
           </div>
    </form>
     
</body>
</html>
