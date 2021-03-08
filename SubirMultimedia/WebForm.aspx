<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="SubirMultimedia.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        

        <asp:FileUpload ID="selectFile" runat="server" />
        <br />
            <asp:Button ID="btnPlay" runat="server" OnClick="btnPlay_Click" Text="Reproducir" />
        
        

        <p>
            <asp:Literal ID="videoLiteral" runat="server"></asp:Literal>
        </p>
        
        

    </form>
</body>
</html>
