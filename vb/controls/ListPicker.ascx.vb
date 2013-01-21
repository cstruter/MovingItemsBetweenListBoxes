Imports System.Xml

Partial Class ListPicker
    Inherits System.Web.UI.UserControl

    Private _xmlDocument As New XmlDocument()

    Public ReadOnly Property fromListBox() As ListBox
        Get
            Return lstFrom
        End Get
    End Property

    Public ReadOnly Property toListBox() As ListBox
        Get
            Return lstTo
        End Get
    End Property

    Private Sub PopulateListBox(ByVal lstBox As ListBox)
        lstBox.Items.Clear()
        Dim nodes As XmlNodeList = _xmlDocument.SelectNodes("listboxes/" + lstBox.ClientID + "/option")
        For Each node As XmlNode In nodes
            lstBox.Items.Add(New ListItem(HttpUtility.UrlDecode(node.Item("key").InnerText), HttpUtility.UrlDecode(node.Item("value").InnerText)))
        Next
    End Sub

    Private Sub PopulateListBoxes()
        _xmlDocument.LoadXml(HttpUtility.UrlDecode(hdnDropdowns.Value))
        PopulateListBox(lstFrom)
        PopulateListBox(lstTo)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Page.ClientScript.RegisterClientScriptInclude("listboxjs", Page.ResolveClientUrl("~/js/listbox.js"))

        If Not IsPostBack Then
            Dim movejs As String = "move('{0}','{1}','{2}')"
            Dim unselectjs As String = "unselect('{0}')"

            lstFrom.Attributes("onclick") = String.Format(unselectjs, lstTo.ClientID)
            lstTo.Attributes("onclick") = String.Format(unselectjs, lstFrom.ClientID)
            btnTo.Attributes("onclick") = String.Format(movejs, lstFrom.ClientID, lstTo.ClientID, hdnDropdowns.ClientID)
            btnFrom.Attributes("onclick") = String.Format(movejs, lstTo.ClientID, lstFrom.ClientID, hdnDropdowns.ClientID)
        Else
            If Not String.IsNullOrEmpty(hdnDropdowns.Value) Then
                PopulateListBoxes()
            End If
        End If
    End Sub
End Class