<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerAsistentes.aspx.cs" Inherits="EventosWEB.VerAsistentes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Asistentes</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-bordered"
                        OnRowCommand="grillaAsistentes_RowCommand"
                        AutoGenerateColumns="false"
                        runat="server" ID="grillaAsistentes">
                        <Columns>
                            <asp:BoundField DataField="Rut" HeaderText="Rut" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                            <asp:BoundField DataField="Edad" HeaderText="Edad" />
                            <asp:BoundField DataField="Empresa" HeaderText="Empresa" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
                            <asp:BoundField DataField="Region.Nombre" HeaderText="Region" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button
                                        CommandName="eliminar"
                                        CommandArgument='<%# Eval("Id") %>'
                                        runat="server" CssClass="btn btn-danger" Text="Eliminar" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                    </asp:GridView>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
