using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp3.DataBase.DataAccess;

namespace WebApplication3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AdressDataAccess addressAccessConnect = new AdressDataAccess();
            DataTable dt = addressAccessConnect.AddressDataTable();

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void lnkSelect_Click(object sender, EventArgs e)
        {
            int addressId = Convert.ToInt32((sender as LinkButton).CommandArgument);
        }
    }
}