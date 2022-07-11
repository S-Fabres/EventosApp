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
    public partial class Default : System.Web.UI.Page
    {
        private IAsistentesDAL asistentesDAL = new AsistentesDALDB();
        private IRegionesDAL regionesDAL = new RegionesDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Region> regiones = regionesDAL.ObtenerRegiones();
                this.regionDdl.DataSource = regiones;
                this.regionDdl.DataTextField = "Nombre";
                this.regionDdl.DataValueField = "Id";
                this.regionDdl.DataBind();
            }

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            string rut = this.rutTxt.Text.Trim();
            string nombre = this.nombreTxt.Text.Trim();
            string apellido = this.apellidoTxt.Text.Trim();
            int edad = Convert.ToInt32(this.edadTxt.Text.Trim());
            string empresa = this.empresaTxt.Text.Trim();
            string estado = this.estadoTxt.Text.Trim();

            List<Region> regiones = regionesDAL.ObtenerRegiones();
            Region region = regiones.Find(r => r.Nombre == this.regionDdl.SelectedItem.Value);

            Asistente asistente = new Asistente()
            {
                Rut = rut,
                Nombre = nombre,
                Apellido = apellido,
                Edad = edad,
                Empresa = empresa,
                Estado = estado,
                IdRegion = region.Id
            };
            asistentesDAL.AgregarAsistente(asistente);
            this.mensajesLbl.Text = "Asistente Ingresado";
            Response.Redirect("VerAsistentes.aspx");
        }
    }
}