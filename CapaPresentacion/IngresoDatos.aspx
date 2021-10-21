<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresoDatos.aspx.cs" Inherits="CapaPresentacion.IngresoDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Codigo:<asp:TextBox ID="TxtCodigo" runat="server"></asp:TextBox><br />
            Nombre:<asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox><br />
            Horas laboradas:<asp:TextBox ID="TxtHoras" runat="server"></asp:TextBox><br />
            Salario Horas:<asp:TextBox ID="TxtSalHora" runat="server"></asp:TextBox><br />
            Salario Bruto:<asp:TextBox ID="TxtSalBruto" runat="server"></asp:TextBox><br />
            <asp:Button ID="btn_Ingreso" runat="server" Text="Ingreso" OnClick="btn_Ingreso_Click"/><br />
        </div>
    </form>
</body>
</html>
