<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="web-form.aspx.cs" Inherits="WebApplication2.web_form" Async="true"  %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="name" runat="server" required="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td>
                       <asp:TextBox ID="Dept" runat="server" required="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButton ID="Gender1" GroupName="Gender"  runat="server" Text="Male"/>
                        <asp:RadioButton ID="Gender2" GroupName="Gender" runat="server" Text="Female" />
                    </td>
                </tr>
            </table>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="ClickOn" />
            <asp:Button ID="Button2" runat="server" Text="Sokeuhh" OnClick="GetJoke" />
        </div>
    </form>
    <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:AgaaNagaConnectionString %>" ProviderName="<%$ ConnectionStrings:AgaaNagaConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Table]" ></asp:SqlDataSource>
    <asp:Label ID="showAns" runat="server"></asp:Label>
</body>
            
</html>
