<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register src="controls/ListPicker.ascx" tagname="ListPicker" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Moving items between listboxes in vb.net</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:ListPicker ID="picker" runat="server" />
    </div>
    <asp:Button ID="btnSubmit" runat="server" Text="Go" />
    </form>
</body>
</html>
