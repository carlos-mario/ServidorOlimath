<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal2.Master" AutoEventWireup="true" CodeBehind="FrmRegionales.aspx.cs" Inherits="Vista.FrmRegionales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div class="container-fluid">
            <div class="row" >
                <div class="col-md-12">
                    <div class="panel panel-default"> 
                        <div class="panel-heading">
                            <h4><b>Gestión de Regionales</b></h4>
                        </div>
                        <div class="panel-body"> 
                            <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal"><i class="fa fa-plus"> Nuevo</i></button>
                            <br />
                            <br />
                            <div class="row" style="overflow-x: scroll;">
                                <div class="col-md-12">
                                    <asp:GridView ID="gvMostrarRegionales" runat="server" CssClass="table table-striped"
                    OnRowCancelingEdit="gvMostrarRegionales_RowCancelingEdit"
                    OnRowDeleting="gvMostrarRegionales_RowDeleting"
                    OnRowEditing="gvMostrarRegionales_RowEditing"
                    OnRowUpdating="gvMostrarRegionales_RowUpdating"
                    DataKeyNames="R_ID" OnPageIndexChanging="gvMostrarRegionales_PageIndexChanging"
                    PageSize="5" AllowPaging="True">
                    <Columns>
                                            <asp:CommandField ShowEditButton="True" EditText="">
                        <ControlStyle CssClass="btn btn-info fa fa-pencil" />
                        </asp:CommandField>
                                            <asp:CommandField ShowDeleteButton="True" DeleteText="">
                        <ControlStyle CssClass="btn btn-danger fa fa-trash" />
                        </asp:CommandField>
                    </Columns>
                </asp:GridView>
                        </div> 
        </div>
                    
        </div>
            </div>
                </div>
            </div>
            <div class="row">   
                <div class="col-md-12">
                    <!-- Modal -->
                    <div id="myModal" class="modal fade" role="dialog">
                        <div class="modal-dialog">
                            <!-- Modal content-->
                            <div class="modal-content">
                                <div class="modal-header">
                                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                                    <h4 class="modal-title">Crear Regional</h4>
                                </div>
                                <div class="modal-body">
                                    <div class="row">
                                        <div class="col-md-4">
                                            <asp:Label ID="Label2" runat="server" Text="Código" CssClass="control-label"></asp:Label>
                                            <asp:TextBox ID="txtCodigoReg" runat="server" CssClass="form-control">
                                            </asp:TextBox><%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtCodigoReg">*</asp:RequiredFieldValidator>--%>
                                        </div>
                                        <div class="col-md-4">
                                            <asp:Label ID="Label3" runat="server" Text="Nombre" CssClass="control-label"></asp:Label>
                                            <asp:TextBox ID="txtNombreReg" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-warning" data-dismiss="modal">Cerrar</button>
                                    <asp:Button ID="btnAgregar" runat="server" Text="Crear" OnClick="btnAgregar_Click" CssClass="btn btn-success" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
