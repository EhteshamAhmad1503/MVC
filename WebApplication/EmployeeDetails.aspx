<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="WebApplication.EmployeeDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:Repeater ID="repeater"  runat="server">
               <HeaderTemplate>
                   <table border="1" cellspacing="10">
                       <tr>
                           <td>
                               <asp:Label ID="Label1" runat="server" Text="Age"></asp:Label>
                           </td>
                            <td>
                               <asp:Label ID="Label2" runat="server" Text="Gender"></asp:Label>
                           </td>
                            <td>
                               <asp:Label ID="Label3" runat="server" Text="PolicyTerm"></asp:Label>
                           </td>
                           <td>
                               <asp:Label ID="Label4" runat="server" Text="PayingTerm"></asp:Label>
                           </td>
                            <td>
                               <asp:Label ID="Label5" runat="server" Text="SumAssuredSlab"></asp:Label>
                           </td>
                            <td>
                               <asp:Label ID="Label6" runat="server" Text="Rate"></asp:Label>
                           </td>
                       </tr>
                 
               </HeaderTemplate>
               <ItemTemplate>
                   <tr>
                        <td> <%#Eval("Age")%></td>
                        <td> <%#Eval("Gender")%> </td>
                        <td> <%#Eval("PolicyTerm")%> </td>
                        <td> <%#Eval("PayingTerm")%> </td>
                        <td> <%#Eval("SumAssuredSlab")%> </td>
                        <td> <%#Eval("Rate")    %> </td>
                        
                    </tr>
               </ItemTemplate>
               <FooterTemplate>
                     </table>
               </FooterTemplate>
           </asp:Repeater>
        </div>
        <asp:Button ID="GetEmployees" runat="server" Text="Get Employees Details" OnClick="GetEmployees_Click" />
    </form>
</body>
</html>
