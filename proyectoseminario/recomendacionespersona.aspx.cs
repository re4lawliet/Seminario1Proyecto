﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyectoseminario
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 cls = new Class1();
            bool r;
            r = cls.guardarrecomendacion(TextBox1.Text, TextBox2.Text);
            if(r==true){
                Response.Write("<script language =javascript>alert('Dato insertado');</script>");
            }else{
                Response.Write("<script language =javascript>alert('Dato no insertado');</script>");

            }
        }
    }
}