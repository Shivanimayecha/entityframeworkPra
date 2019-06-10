<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EFPractical.aspx.cs" Inherits="entityframeworkPra.EFPractical" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%--    <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TextBox runat="server" ID="txtId"></asp:TextBox>
            <input type="text" placeholder="Id" name="id" id="txtId"/>

        </div>--%>
        <br />
        <br />
        <div>
            <asp:Label ID="lbl_name" runat="server" Text="Name :"></asp:Label>
            <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
            <%--<input type="text" placeholder="Name" name="Name" id="txtName" />--%>
        </div>
        <br />
        <br />
        <div>
            <asp:Label ID="lbl_cname" runat="server" Text="CompanyName :"></asp:Label>

            <asp:TextBox runat="server" ID="txtCname">
            </asp:TextBox>
            <%--            <input type="text" placeholder="CompanyName" name="CompanyName" id="txtCname" />--%>
        </div>
        <br />
        <br />
        <div>
            <asp:Label ID="lbl_Add" runat="server" Text="Address :"></asp:Label>

            <asp:TextBox runat="server" ID="txtAdd" TextMode="MultiLine"></asp:TextBox>
            <%--            <input type="text" placeholder="Address" name="Address" id="txtAdd" />--%>
        </div>
        <br />
        <br />
        <div>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" Height="26px" Style="margin-left: 17px" Width="91px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" Style="margin-left: 16px" Width="79px" />
        </div>
        <br />

        <div>
            <asp:GridView ID="gridView" runat="server">
            </asp:GridView>
        </div>

    </form>
</body>
</html>
