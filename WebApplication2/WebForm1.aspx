<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
              
              <div>
            <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
          </div>
            <asp:TextBox ID="Id" runat="server"></asp:TextBox>
              <div>
           <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
           </div>
            <div>
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            </div>
            <div>
              <asp:Label ID="Label3" runat="server" Text="Course"></asp:Label>
              <div>
              </div>
            <asp:TextBox ID="Course" runat="server"></asp:TextBox>
             </div>
             <div>
              <asp:Label ID="Label4" runat="server" Text="Collage"></asp:Label>
              </div>
                <div>
               <asp:TextBox ID="Collag" runat="server"></asp:TextBox>
                </div>
                <div>
              <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
                </div>
                <div>
            <asp:TextBox ID="Gender" runat="server"></asp:TextBox>
                </div>
               <div>
              <asp:Label ID="Label6" runat="server" Text="City"></asp:Label>
                 </div>
              <div>
            <asp:TextBox ID="City" runat="server"></asp:TextBox>
            </div>
            <div>
            <asp:Button ID="Button1" runat="server" Text="SignUp" OnClick="Button1_Click" />
            </div>
     
    </form>
</body>
</html>
