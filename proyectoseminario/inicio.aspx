<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="proyectoseminario.WebForm2" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="codigo" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="codigo" HeaderText="codigo" InsertVisible="False" ReadOnly="True" SortExpression="codigo" />
            <asp:BoundField DataField="nombrepersona" HeaderText="Nombre Persona " SortExpression="nombrepersona" />
            <asp:BoundField DataField="recomendacion" HeaderText="recomendacion" SortExpression="recomendacion" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:seminarioproyectoConnectionString2 %>" SelectCommand="SELECT * FROM [recomendaciones]"></asp:SqlDataSource>
</asp:Content>

