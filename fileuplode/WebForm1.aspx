<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="fileuplode.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            select a file to be uploded
            <br/>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br/>
            <asp:Button ID="Btnuplode" runat="server" Text="uplode" OnClick="Btnuplode_Click" />
            <asp:Label ID="lbluplode" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
