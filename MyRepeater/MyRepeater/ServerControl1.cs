using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyRepeater
{
    public class MyRepeater1 : System.Web.UI.WebControls.Repeater
    {
        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);

            this.Controls.Clear();
            this.ClearChildViewState();

            this.CreateControlHierarchy(true);
            this.ChildControlsCreated = true;
        }
    }

    public class MyRepeater2 : System.Web.UI.WebControls.Repeater
    {
        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);
        }
    }

    public class MyRepeater3 : MyRepeater1
    {
        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);

            this.Controls.Clear();
            this.ClearChildViewState();

            this.CreateControlHierarchy(true);
            this.ChildControlsCreated = true;
        }
    }

    public class MyRepeater4 : System.Web.UI.WebControls.Repeater
    {
        [PersistenceMode(PersistenceMode.InnerProperty), Browsable(false), TemplateContainer(typeof(TemplateControl))]
        public ITemplate EmptyDataTemplate { get; set; }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);

            //this.Controls.Clear();
            //this.ClearChildViewState();

            //this.CreateControlHierarchy(true);
            //this.ChildControlsCreated = true;


            if (EmptyDataTemplate != null)
            {
                if (this.Items.Count == 0)
                {
                    EmptyDataTemplate.InstantiateIn(this);
                }
            }
        }


        protected override void RenderChildren(HtmlTextWriter output)
        {
            if (HasControls())
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    if (this.FooterTemplate != null && this.Items.Count == 0 && EmptyDataTemplate != null)
                    {
                        if (i == Controls.Count - 2)
                        {
                            Controls[i + 1].RenderControl(output);
                            continue;
                        }
                        if (i == Controls.Count - 1)
                        {
                            Controls[i - 1].RenderControl(output);
                            continue;
                        }
                    }
                    Controls[i].RenderControl(output);
                }
            }
        }

        protected override void Render(HtmlTextWriter output)
        {
            RenderChildren(output);
        }
    }
}
