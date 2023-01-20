using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPK._1
{
    public partial class InvisibleEdit : TextBox
    {
        public InvisibleEdit()
        {
            InitializeComponent(); 
        }

        public InvisibleEdit(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Visible = false;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Visible = true;

        }
    }
}
