using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebClient cliente = new WebClient();
            string json = cliente.DownloadString("https://www.metaweather.com/api/location/search/?query=london");

            dynamic stuff = JsonConvert.DeserializeObject(json);

           

            Label1.Text += @"<div class='ui divided selection list'>";
            Label1.Text += @"<a class='item'><div class='ui black horizontal label'>Title</div> "+ stuff[0].title  + "</a>";
            Label1.Text += @"<a class='item'><div class='ui black horizontal label'>Location Type</div> "+ stuff[0].location_type  + "</a>";
            Label1.Text += @"<a class='item'><div class='ui black horizontal label'>Woeid</div> "+ stuff[0].woeid  + "</a>";
            Label1.Text += @"<a class='item'><div class='ui black horizontal label'>Latt Long</div> "+ stuff[0].latt_long  + "</a>";
            Label1.Text +=  "</div>";

        }
    }
}