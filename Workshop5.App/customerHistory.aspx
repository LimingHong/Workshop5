<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerHistory.aspx.cs" Inherits="Workshop5.App.customerHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
        <div>
        </div>
    </form>
</body>
</html>
