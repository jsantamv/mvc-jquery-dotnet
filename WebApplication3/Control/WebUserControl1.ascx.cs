using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebApp3.DataBase.DataAccess;

namespace WebApplication3.Control
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var algo = 1;
            }


            AdressDataAccess addressAccessConnect = new AdressDataAccess();
            DataTable dt = addressAccessConnect.AddressDataTable();                    
            
            grdData.DataSource = dt;
            grdData.DataBind();

        }
    }
}