<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="controls/ListPicker.ascx" TagName="ListPicker" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Moving items between listboxes in C#</title>
    <meta http-equiv="content-type" content="text/html; charset=UTF-8" />
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
