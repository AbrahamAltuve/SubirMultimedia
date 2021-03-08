using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SubirMultimedia
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectFile.HasFiles)
                {
                    string fileName = selectFile.FileName;
                    string ext = System.IO.Path.GetExtension(fileName).ToLower();
                    
                    
                    if (ext == ".mp4")
                    {
                        
                        selectFile.SaveAs(Server.MapPath("/media/" + fileName));
                        string link = "/media/" + fileName;
                        link = "<video width=600 Controls><Source src=" + link + " type=video/mp4></video>";
                        videoLiteral.Text = link;
                        Response.Write("Se subio el archivo MP4 " + fileName);

                    }

                }
                else
                {
                    Response.Write("Seleccione un archivo");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}