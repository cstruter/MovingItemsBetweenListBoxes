<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ListPicker.ascx.vb" Inherits="ListPicker" %>
<table>
    <tr>
        <td>
            <asp:ListBox ID="lstFrom" runat="server" SelectionMode="Multiple" Width="200px">
            </asp:ListBox>
        </td>
        <td>
            <input id="btnTo" runat="server" type="button" value=">>" />
                <br />
            <input id="btnFrom" runat="server" type="button" value="<<" />
        </td>
        <td>
            <asp:ListBox ID="lstTo" runat="server" SelectionMode="Multiple" Width="200px">
            </asp:ListBox>
        </td>
    </tr>
</table>
<asp:HiddenField ID="hdnDropdowns" runat="server" />