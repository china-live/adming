using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name");

            //dt.Rows.Add("ssssss");
            //dt.Rows.Add("ssssss");//取消这一行测试空模板项

            ServerControl1.DataSource = dt;
            ServerControl1.DataBind();
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                object s = sender;
                int i = e.Item.ItemIndex;
                Label Label1 = e.Item.FindControl("Label1") as Label;
                string text = Label1.Text;
            }
        }
    }
}