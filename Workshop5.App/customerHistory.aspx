<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerHistory.aspx.cs" Inherits="Workshop5.App.customerHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <asp:GridView ID="GVHistory" runat="server" Width="474px">
             <AlternatingRowStyle BackColor="White" />
             <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
        <br />
    </p>
    <p style="width: 198px; margin-left: 320px">
        <asp:Label ID="lblTotal" runat="server" Text="Total"></asp:Label>
        :&nbsp;
        <asp:TextBox ID="txtTotal" runat="server" OnTextChanged="txtTotal_TextChanged" ReadOnly="True" Width="120px"></asp:TextBox>
        </p>
    <p>
        &nbsp;</p>
        <div>
        </div>
    </form>
</body>
</html>
