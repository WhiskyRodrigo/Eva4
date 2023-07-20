using Eva4Model;
using Eva4Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eva4
{
    public partial class MostrarMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALDB();

        private void cargaGrilla(List<Medidor> medidor)
        {
            this.grillaMedidor.DataSource = medidor;
            this.grillaMedidor.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargaGrilla(this.medidorDAL.ObtenerMedidor());
            }
        }

        protected void estadoDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = this.estadoDDL.SelectedValue;
            List<Medidor> medidor = this.medidorDAL.ObtenerMedidor(estado);
            this.cargaGrilla(medidor);

        }
    }
}