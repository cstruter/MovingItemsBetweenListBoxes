using System;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {            
            PopulateListBoxes();
        }        
    }

    protected void PopulateListBoxes()
    {
        Dictionary<string, string> left = new Dictionary<string, string>();
        left.Add("Trüter", "Trüter");
        left.Add("C#", "csharp");
        left.Add("VB.NET", "vbnet");
        left.Add("PHP 5", "php");

        picker.fromListBox.DataSource = left;
        picker.fromListBox.DataTextField = "key";
        picker.fromListBox.DataValueField = "value";
        picker.fromListBox.DataBind();

        Dictionary<string, string> right = new Dictionary<string, string>();
        right.Add("MySQL", "mysql");
        right.Add("SQL", "mssql");

        picker.toListBox.DataSource = right;
        picker.toListBox.DataTextField = "key";
        picker.toListBox.DataValueField = "value";
        picker.toListBox.DataBind();
    }
}
