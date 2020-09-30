using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace fileuplode
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnuplode_Click(object sender, EventArgs e)
        {
            string filename, filepath, fileext;
            filename = "";
            filepath = "dhruvin/";
            fileext = "";
            if (FileUpload1.HasFile)
            {
                filename = FileUpload1.FileName;
                fileext = Path.GetExtension(filename);
                if ((fileext == ".jpg") || (fileext == ".gif") || (fileext == ".png"))
                {
                    FileUpload1.SaveAs(Server.MapPath(filepath) + filename);
                    lbluplode.Text = "image is uploded succesfully your file size is:" + FileUpload1.FileBytes.Length.ToString();
                }
                else
                {
                    lbluplode.Text = "you dont have a correct file formate";
                }
            }
            else
            {
                lbluplode.Text = "file uploded success!!";
            }
            //Console.ReadKey();
        }
    }
}