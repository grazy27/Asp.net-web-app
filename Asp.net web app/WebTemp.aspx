<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebTemp.aspx.cs" Inherits="Asp.net_web_app.WebTemp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 215px;
            width: 436px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    &nbsp;<asp:Label ID="Label3" runat="server" Text="Введите кол-во экзаменов  в этом семестре"></asp:Label>
&nbsp;&nbsp;&nbsp;
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="101px"></asp:TextBox>
        &nbsp;
        <br />
        <asp:Label ID="Label5" runat="server" Text="Введите свои оценки по экзаменам через пробел"></asp:Label>
&nbsp; <asp:TextBox ID="TextBox2" runat="server" Width="415px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Проверить средний балл" Width="426px" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server"></asp:Label>
    </form>
</body>
</html>
