<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetData.aspx.cs" Inherits="WebApplication.GetData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Shruthi.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="input">
        <div>
        <asp:Label ID="Label1"  runat="server" Text="Age"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="Age" Width="100" runat="server"></asp:TextBox>
        </div>
        <div>
        <asp:Label ID="Label2" runat="server" Text="Gender"></asp:Label>
        </div>
        <div>
            <asp:DropDownList ID="DropDownList1" Width="100px" runat="server">
                <asp:ListItem Value="">select</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>F</asp:ListItem>
            </asp:DropDownList>
        </div>
         <div>
        <asp:Label ID="Label6" runat="server" Text="Smoker"></asp:Label>
        </div>
        <div>
          <asp:DropDownList ID="DropDownList2" Width="100px" runat="server">
                <asp:ListItem Value="">select</asp:ListItem>
                <asp:ListItem>Smoker</asp:ListItem>
                <asp:ListItem>NonSmoker</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
        <asp:Label ID="Label3" runat="server" Text="PolicyTerm"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="PolicyTerm" Width="100" runat="server"></asp:TextBox>
        </div>
        <div>
        <asp:Label ID="Label4" runat="server" Text="PayingTerm"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="PayingTerm" Width="100" runat="server"></asp:TextBox>
        </div> 
        <div>
        <asp:Label ID="Label5" runat="server" Text="SumAssured"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="SumAssured" Width="100" runat="server"></asp:TextBox>
        </div> 
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>

        <div>
           <asp:Repeater ID="repeater2"  runat="server">
               <HeaderTemplate>
                   <table border="1" cellspacing="8">
                       <tr>
                           <td>
                               <asp:Label ID="Label1" runat="server" Text="Age"></asp:Label>
                           </td>
                           <td>
                           <asp:Label ID="Label14" runat="server" Text="Gender"></asp:Label>
                            </td>
                            <td>
                               <asp:Label ID="Label2" runat="server" Text="Policy Term"></asp:Label>
                           </td>
                            <td>
                               <asp:Label ID="Label3" runat="server" Text="Paying Term"></asp:Label>
                           </td>
                           <td>
                               <asp:Label ID="Label4" runat="server" Text="Tobacco User"></asp:Label>
                           </td>
                            <td>
                               <asp:Label ID="Label5" runat="server" Text="YearlyPremium_WO_GST"></asp:Label>
                           </td>
                         <td>
                               <asp:Label ID="Label7" runat="server" Text="SumAssured"></asp:Label>
                           </td>
                            <td>
                               <asp:Label ID="Label8" runat="server" Text="Maturity_Benefits"></asp:Label>
                           </td>
                            <td>
                               <asp:Label ID="Label9" runat="server" Text="GST"></asp:Label>
                           </td>
                           <td>
                               <asp:Label ID="Label10" runat="server" Text="YearlyPremium_With_GST"></asp:Label>
                           </td>
                            
                            <td>
                               <asp:Label ID="Label12" runat="server" Text="MonthlyPremium_With_GST"></asp:Label>
                           </td>
                           <td>
                               <asp:Label ID="Label13" runat="server" Text="MaturityAge"></asp:Label>
                           </td>
                       </tr>
                 
               </HeaderTemplate>
               <ItemTemplate>
                   <tr>
                        <td> <%#Eval("Age")%></td>
                        <td> <%#Eval("Gender")%></td>
                        <td> <%#Eval("PolicyTerm")%> </td>
                        <td> <%#Eval("PayingTerm")%> </td>
                        <td> <%#Eval("NonSmoker")%> </td>
                        <td> <%#Eval("YearlyPremium_WO_GST")%> </td>
                        <td> <%#Eval("SumAssured") %> </td>
                       <td> <%#Eval("Maturity_Benefits")%></td>
                        <td> <%#Eval("GST")%> </td>
                        <td> <%#Eval("YearlyPremium_With_GST")%> </td>
                        <td> <%#Eval("MonthlyPremium_With_GST")%> </td>
                        <td> <%#Eval("MaturityAge")%> 

                        </td>

                   </tr>
               </ItemTemplate>
               <FooterTemplate>
                     </table>
               </FooterTemplate>
           </asp:Repeater>
        </div>
        <asp:Label ID="Label11" runat="server" ></asp:Label>
       </form>
       
    </body>
</html>
