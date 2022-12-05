<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BigliettiCinema.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>UCI Cinemas</h1>
            <p>Nome:</p>
            <div class="inputs">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <p>Cognome:</p>
            <div class="inputs">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <p>Sala:</p>
            <div class="dropdwn">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="1">SALA NORD</asp:ListItem>
                    <asp:ListItem Value="2">SALA EST</asp:ListItem>
                    <asp:ListItem Value="3">SALA SUD</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBox ID="CheckBox1" runat="server" /> <p>Biglietto Ridotto</p>
            </div>
            <div class="btn">
            <asp:Button ID="Button1" runat="server" Text="Prenota" OnClick="Button1_Click"/>
            </div>
                <div class="info">

                        <h4>Informazioni Sale:</h4>

                    <div>
                        <p>BIGLIETTI VENDUTI SALA NORD: <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>, DI CUI RIDOTTI: <asp:Label ID="Label2" runat="server" Text="0"></asp:Label> </p>
                    </div>
                    <div>
                        <p>BIGLIETTI VENDUTI SALA EST: <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>, DI CUI RIDOTTI: <asp:Label ID="Label4" runat="server" Text="0"></asp:Label> </p>
                    </div>
                    <div>
                        <p>BIGLIETTI VENDUTI SALA SUD: <asp:Label ID="Label5" runat="server" Text="0"></asp:Label>, DI CUI RIDOTTI: <asp:Label ID="Label6" runat="server" Text="0"></asp:Label> </p>
                    </div>
                </div>
        </div>
    </form>
</body>
</html>
