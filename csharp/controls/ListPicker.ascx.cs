using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class ListPicker : System.Web.UI.UserControl
{
    private XmlDocument _xmlDocument = new XmlDocument();

    public ListBox fromListBox
    {
        get
        {
            return lstFrom;
        }
    }

    public ListBox toListBox
    {
        get
        {
            return lstTo;
        }
    }

    private void PopulateListBox(ListBox listBox)
    {
        listBox.Items.Clear();
        XmlNodeList nodes = _xmlDocument.SelectNodes("listboxes/" + listBox.ClientID + "/option");
        foreach (XmlNode node in nodes)
        {
            listBox.Items.Add(new ListItem(HttpUtility.UrlDecode(node["key"].InnerText), HttpUtility.UrlDecode(node["value"].InnerText)));
        }
    }

    private void PopulateListBoxes()
    {        
        _xmlDocument.LoadXml(HttpUtility.UrlDecode(hdnDropdowns.Value));
        PopulateListBox(lstFrom);
        PopulateListBox(lstTo);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterClientScriptInclude("listboxjs", Page.ResolveClientUrl("~/js/listbox.js"));

        if (!IsPostBack)
        {
            String movejs = "move('{0}','{1}','{2}')";
            String unselectjs = "unselect('{0}')";
            lstFrom.Attributes["onclick"] = String.Format(unselectjs, lstTo.ClientID);
            lstTo.Attributes["onclick"] = String.Format(unselectjs, lstFrom.ClientID);
            btnTo.Attributes["onclick"] = String.Format(movejs, lstFrom.ClientID, lstTo.ClientID, hdnDropdowns.ClientID);
            btnFrom.Attributes["onclick"] = String.Format(movejs, lstTo.ClientID, lstFrom.ClientID, hdnDropdowns.ClientID);
        }
        else
        {
            if (!(String.IsNullOrEmpty(hdnDropdowns.Value)))
            {
                PopulateListBoxes();
            }
        }
    }
}