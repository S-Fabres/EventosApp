using EventosDBModel;
using EventosDBModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosWEB
{
    public partial class VerAsistentes : System.Web.UI.Page
    {
        private IRegionesDAL regionesDAL = new RegionesDALDB();
        private IAsistentesDAL asistentesDAL = new AsistentesDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
            }
        }

        private void cargarGrilla()
        {
            List<Region> regiones = regionesDAL.ObtenerRegiones();
            this.grillaAsistentes.DataSource = regiones;
            this.grillaAsistentes.DataBind();
        }
        protected void grillaAsistentes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                //significa que el usuario apreto el boton eliminar
                //por tanto, tengo que eliminar el cliente
                int id = Convert.ToInt32(e.CommandArgument);
                asistentesDAL.EliminarAsistente(id);
                cargarGrilla();
            }
        }
    }
}