<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style123.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="abd">
            <div>
                <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Lat" runat="server" Text="last Name"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="email Id"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="mobile number"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="MobileNo" runat="server" TextMode="Number"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="dob"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="Dob" runat="server" TextMode="Date"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="Label6" runat="server" Text="password"></asp:Label>
            </div>
            <div>
                <asp:TextBox ID="Psswd" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="SignUp" OnClick="Button1_Click" />
            </div>
        </div>
    </form>
    <asp:Label ID="sucess" runat="server"></asp:Label>
</body>
</html>
