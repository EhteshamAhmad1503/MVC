<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web.aspx.cs" Inherits="Connections.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1234.css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server">
     <div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
       </div>
        <div>
        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
        </div>
        <div>
        <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="Address" runat="server"></asp:TextBox>
        </div>
          <div>
        <asp:Label ID="Label3" runat="server" Text="Branch"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="Branch" runat="server"></asp:TextBox>
        </div>
        <div>
        <asp:Label ID="Label4" runat="server" Text="MobileNo"></asp:Label>
        </div>
         <div>
        <asp:TextBox ID="MobileNo" runat="server"></asp:TextBox>
         </div>
         <div>
        <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
         </div>
         <div>
         <asp:TextBox ID="Email" runat="server"></asp:TextBox>
         </div>
        <div>
        <asp:Label ID="Label6" runat="server" Text="Salary"></asp:Label>
         </div>
        <div>
         <asp:TextBox ID="Salary" runat="server"></asp:TextBox>
         </div>
        <asp:Button ID="Button1" runat="server" Text="Submit" />
        <div>
            <asp:Label ID="Success" runat="server"></asp:Label>
            </div>
    </form>
</body>
</html>
