<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DevUCSharpCS_ASP_0028.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Convert to Cups<br />
            <br />
            <asp:TextBox ID="quantityTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="fromCupsRadio" runat="server" AutoPostBack="True" Text="Cups" />
            <br />
            <asp:RadioButton ID="fromPintsRadio" runat="server" AutoPostBack="True" Text="Pints" />
            <br />
            <asp:RadioButton ID="fromQuartsRadio" runat="server" AutoPostBack="True" Text="Quarts" />
            <br />
            <asp:RadioButton ID="fromGallonsRadio" runat="server" AutoPostBack="True" Text="Gallons" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
