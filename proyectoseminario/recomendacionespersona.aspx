<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="recomendacionespersona.aspx.cs" Inherits="proyectoseminario.WebForm3" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <table style="width: 100%;">
    <tr>
        <td>Datos</td>
        <td>Campos</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Nombre Persona:</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Recomendacion:</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Height="156px" Width="383px"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
        </td>
    </tr>
</table>
</asp:Content>

