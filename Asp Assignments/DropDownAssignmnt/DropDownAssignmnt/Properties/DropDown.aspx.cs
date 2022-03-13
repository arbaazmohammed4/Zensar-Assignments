using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownAssignmnt.Properties
{
    public partial class DropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {


                string[] str = new string[] { "Choose", "Karnataka", "Maharashtra", "Tamil Nadu", "West Bengal" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/pics/" + str + ".jpg";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Karnataka")
            {
                TextBox1.Text = "Bengaluru";
            }
            else if (DropDownList1.SelectedValue == "Maharashtra")
            {
                TextBox1.Text = "Mumbai";
            }
            else if (DropDownList1.SelectedValue == "Tamil Nadu")
            {
                TextBox1.Text = "Chennai";
            }
            else if (DropDownList1.SelectedValue == "West Bengal")
            {
                TextBox1.Text = "Kolkatta";
            }
        }
    }
}