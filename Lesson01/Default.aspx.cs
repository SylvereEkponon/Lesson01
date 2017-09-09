using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*Name: Sylvere Ekponon
 *Date: September 5, 2017
 *Version 1: Page_Load method created
 */ 

namespace Lesson01
{
    public partial class _Default : Page
    {
        /// <summary>
        /// This is a Page_Load method displays the today's date and time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            myTimeLabel.Text = DateTime.Now.ToString();
        }
    }
}