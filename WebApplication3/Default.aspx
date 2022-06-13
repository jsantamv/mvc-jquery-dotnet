<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">

        <div class="col-md-4">
            <asp:Button ID="Button1" runat="server" Text="Data" Width="102px" class="btn btn-primary btn-lg" OnClick="Button1_Click" />
        </div>
      
        <br />

        <div class="col-md-4">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="AddressID" HeaderText="AddressID" />
                    <asp:BoundField DataField="AddressLine1" HeaderText="AddressLine1" />
                    <asp:BoundField DataField="AddressLine2" HeaderText="AddressLine2" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                    <asp:BoundField DataField="StateProvinceID" HeaderText="StateProvinceID" />
                    <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" />
                    <asp:BoundField DataField="SpatialLocation" HeaderText="SpatialLocation" />
                    <asp:BoundField DataField="rowguid" HeaderText="rowguid" />
                    <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" />
                    <asp:TemplateField>
                       <ItemTemplate>
                           <asp:LinkButton ID="lnkSelect" Text="Select" runat="server" CommandArgument='<%# Eval("AddressID") %>' OnClick="lnkSelect_Click"/>
                       </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>            
        </div>
    </div>


    <div class="row">

    </div>

</asp:Content>
