Imports System.Collections.Generic

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            PopulateListBoxes()
        End If
    End Sub

    Private Sub PopulateListBoxes()
        Dim left As New Dictionary(Of String, String)
        left.Add("Trüter", "Trüter")
        left.Add("C#", "csharp")
        left.Add("VB.NET", "vbnet")
        left.Add("PHP 5", "php")

        picker.fromListBox.DataSource = left
        picker.fromListBox.DataTextField = "key"
        picker.fromListBox.DataValueField = "value"
        picker.fromListBox.DataBind()

        Dim right As New Dictionary(Of String, String)
        right.Add("MySQL", "mysql")
        right.Add("SQL", "mssql")

        picker.toListBox.DataSource = right
        picker.toListBox.DataTextField = "key"
        picker.toListBox.DataValueField = "value"
        picker.toListBox.DataBind()
    End Sub

End Class