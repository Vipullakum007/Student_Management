﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Management
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
        protected void btnClicked(object sender, EventArgs e)
        {
            Response.Write(tbUsername.Text);
            Response.Write(tbPassword.Text);
        }
    }
}