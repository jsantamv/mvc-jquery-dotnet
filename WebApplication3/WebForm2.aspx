<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<%@ Register Src="~/Control/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>
<%@ Register Src="~/Control/CustomDateTime.ascx" TagPrefix="uc1" TagName="CustomDateTime" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <uc1:WebUserControl1 runat="server" id="WebUserControl1" />

            <hr />

            <uc1:CustomDateTime runat="server" id="CustomDateTime" />

        </div>
    </form>
</body>
</html>
