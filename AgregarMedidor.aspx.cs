using Eva4Model;
using Eva4Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eva4

public partial class AgregarMedidor : System.Web.UI.Page
{
    private IMedidorDAL medidorDAL = new MedidorDALDB();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.medidorDDL.DataSource = this.medidorDAL.ObtenerMedidor();    
            this.medidorDDL.DataValueField = "Id";
            this.medidorDDL.DataTextField = "Nombre";
            this.medidorDDL.DataTextField = "Contraseña";
            this.medidorDDL.DataTextField = "Correo";
            this.medidorDDL.DataBind();
        }
    }

    protected void ingresaBtn_Click(object sender, EventArgs e)
    {
        Medidor medidor = new Medidor();
        medidor.Rut = this.rutTXT.Text.Trim();
        medidor.Nombre = this.nombreTXT.Text.Trim();
        medidor.Contraseña = this.apellidoTXT.Text.Trim();
        medidor.Correo = this.correoTXT.Text.Trim();
        medidor.IdUsuario = Convert.ToInt32(this.medidorDDL.SelectedItem.Value);

        this.medidorDAL.AgregarMedidor(medidor);
        Response.Redirect("VerMedidor.aspx");

    }
}