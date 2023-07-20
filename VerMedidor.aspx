<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidor.aspx.cs" Inherits="Eva4.VerMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <div class="row mt-5">
        <asp:GridView ID="grillaMedidor" 
            AutoGenerateColumns="false" 
            ShowHeaderWhenEmpty="true"
            CssClass="table table-hover table-bordered"
            EmptyDataText="No hay Registros" 
            runat="server">
            <Columns>
                <asp:BoundField HeaderText="Rut" DataField="Rut" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Contraseña" DataField="Contraseña" />
                <asp:BoundField HeaderText="Correo" DataField="Correo" />
                <asp:BoundField HeaderText="Id" DataField="Id" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>