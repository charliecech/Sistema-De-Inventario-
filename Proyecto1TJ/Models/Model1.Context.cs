﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto1TJ.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProyectoFinalTJEntities1 : DbContext
    {
        public ProyectoFinalTJEntities1()
            : base("name=ProyectoFinalTJEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<DataBodega> DataBodega { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFactura { get; set; }
        public virtual DbSet<DetalleInOut> DetalleInOut { get; set; }
        public virtual DbSet<DetalleInOutP> DetalleInOutP { get; set; }
        public virtual DbSet<EmployeeBodega> EmployeeBodega { get; set; }
        public virtual DbSet<estadoFacturas> estadoFacturas { get; set; }
        public virtual DbSet<estadoProductos> estadoProductos { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<InOut> InOut { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tipoInOut> tipoInOut { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    
        [DbFunction("ProyectoFinalTJEntities1", "fnTableColumnInfo")]
        public virtual IQueryable<fnTableColumnInfo_Result> fnTableColumnInfo(string sTableName)
        {
            var sTableNameParameter = sTableName != null ?
                new ObjectParameter("sTableName", sTableName) :
                new ObjectParameter("sTableName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnTableColumnInfo_Result>("[ProyectoFinalTJEntities1].[fnTableColumnInfo](@sTableName)", sTableNameParameter);
        }
    
        [DbFunction("ProyectoFinalTJEntities1", "GetEmpList")]
        public virtual IQueryable<GetEmpList_Result> GetEmpList(Nullable<int> superior)
        {
            var superiorParameter = superior.HasValue ?
                new ObjectParameter("superior", superior) :
                new ObjectParameter("superior", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetEmpList_Result>("[ProyectoFinalTJEntities1].[GetEmpList](@superior)", superiorParameter);
        }
    
        [DbFunction("ProyectoFinalTJEntities1", "GetIdRol")]
        public virtual IQueryable<GetIdRol_Result> GetIdRol(string rol)
        {
            var rolParameter = rol != null ?
                new ObjectParameter("Rol", rol) :
                new ObjectParameter("Rol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetIdRol_Result>("[ProyectoFinalTJEntities1].[GetIdRol](@Rol)", rolParameter);
        }
    
        [DbFunction("ProyectoFinalTJEntities1", "GetIdUser")]
        public virtual IQueryable<GetIdUser_Result> GetIdUser(string userid)
        {
            var useridParameter = userid != null ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetIdUser_Result>("[ProyectoFinalTJEntities1].[GetIdUser](@Userid)", useridParameter);
        }
    
        [DbFunction("ProyectoFinalTJEntities1", "GetRol")]
        public virtual IQueryable<GetRol_Result> GetRol(string userid)
        {
            var useridParameter = userid != null ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetRol_Result>("[ProyectoFinalTJEntities1].[GetRol](@Userid)", useridParameter);
        }
    
        [DbFunction("ProyectoFinalTJEntities1", "ManagerBodegaUser")]
        public virtual IQueryable<ManagerBodegaUser_Result> ManagerBodegaUser()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ManagerBodegaUser_Result>("[ProyectoFinalTJEntities1].[ManagerBodegaUser]()");
        }
    
        public virtual int addRoleUser(string userid, string roleid)
        {
            var useridParameter = userid != null ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(string));
    
            var roleidParameter = roleid != null ?
                new ObjectParameter("Roleid", roleid) :
                new ObjectParameter("Roleid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addRoleUser", useridParameter, roleidParameter);
        }
    
        public virtual int Delete_Cliente(string nit)
        {
            var nitParameter = nit != null ?
                new ObjectParameter("nit", nit) :
                new ObjectParameter("nit", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Cliente", nitParameter);
        }
    
        public virtual int Insert_Cliente(string nit, string nombre, string direccion)
        {
            var nitParameter = nit != null ?
                new ObjectParameter("nit", nit) :
                new ObjectParameter("nit", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_Cliente", nitParameter, nombreParameter, direccionParameter);
        }
    
        public virtual int InsertarBodega(string nombre, string dir, Nullable<int> admin)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var dirParameter = dir != null ?
                new ObjectParameter("dir", dir) :
                new ObjectParameter("dir", typeof(string));
    
            var adminParameter = admin.HasValue ?
                new ObjectParameter("admin", admin) :
                new ObjectParameter("admin", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarBodega", nombreParameter, dirParameter, adminParameter);
        }
    
        public virtual int InsertarClientes(string nombre, string apellido, string nit, string dpi, Nullable<int> edad, string numeroTelefono, string email, Nullable<bool> sexo)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var nitParameter = nit != null ?
                new ObjectParameter("nit", nit) :
                new ObjectParameter("nit", typeof(string));
    
            var dpiParameter = dpi != null ?
                new ObjectParameter("dpi", dpi) :
                new ObjectParameter("dpi", typeof(string));
    
            var edadParameter = edad.HasValue ?
                new ObjectParameter("edad", edad) :
                new ObjectParameter("edad", typeof(int));
    
            var numeroTelefonoParameter = numeroTelefono != null ?
                new ObjectParameter("numeroTelefono", numeroTelefono) :
                new ObjectParameter("numeroTelefono", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var sexoParameter = sexo.HasValue ?
                new ObjectParameter("sexo", sexo) :
                new ObjectParameter("sexo", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarClientes", nombreParameter, apellidoParameter, nitParameter, dpiParameter, edadParameter, numeroTelefonoParameter, emailParameter, sexoParameter);
        }
    
        public virtual int InsertarDetalleFactura(Nullable<int> codigoFactura, Nullable<int> codigoInventario, Nullable<decimal> precio)
        {
            var codigoFacturaParameter = codigoFactura.HasValue ?
                new ObjectParameter("codigoFactura", codigoFactura) :
                new ObjectParameter("codigoFactura", typeof(int));
    
            var codigoInventarioParameter = codigoInventario.HasValue ?
                new ObjectParameter("codigoInventario", codigoInventario) :
                new ObjectParameter("codigoInventario", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarDetalleFactura", codigoFacturaParameter, codigoInventarioParameter, precioParameter);
        }
    
        public virtual int InsertarDetalleInOut(Nullable<int> coidgoInOut, Nullable<int> codigoProducto, Nullable<int> cantidad)
        {
            var coidgoInOutParameter = coidgoInOut.HasValue ?
                new ObjectParameter("coidgoInOut", coidgoInOut) :
                new ObjectParameter("coidgoInOut", typeof(int));
    
            var codigoProductoParameter = codigoProducto.HasValue ?
                new ObjectParameter("codigoProducto", codigoProducto) :
                new ObjectParameter("codigoProducto", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarDetalleInOut", coidgoInOutParameter, codigoProductoParameter, cantidadParameter);
        }
    
        public virtual int InsertarDetalleInOutP(Nullable<int> coidgoInOut, Nullable<int> codigoProducto, Nullable<int> cantidad)
        {
            var coidgoInOutParameter = coidgoInOut.HasValue ?
                new ObjectParameter("coidgoInOut", coidgoInOut) :
                new ObjectParameter("coidgoInOut", typeof(int));
    
            var codigoProductoParameter = codigoProducto.HasValue ?
                new ObjectParameter("codigoProducto", codigoProducto) :
                new ObjectParameter("codigoProducto", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarDetalleInOutP", coidgoInOutParameter, codigoProductoParameter, cantidadParameter);
        }
    
        public virtual int InsertarestadoFacturas(string nombreEstado, string descripcionEstado)
        {
            var nombreEstadoParameter = nombreEstado != null ?
                new ObjectParameter("nombreEstado", nombreEstado) :
                new ObjectParameter("nombreEstado", typeof(string));
    
            var descripcionEstadoParameter = descripcionEstado != null ?
                new ObjectParameter("descripcionEstado", descripcionEstado) :
                new ObjectParameter("descripcionEstado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarestadoFacturas", nombreEstadoParameter, descripcionEstadoParameter);
        }
    
        public virtual int InsertarFactura(string numeroSerie, string numeroFactura, string nitFactura, string nombreFactura, string direccionFacutra, Nullable<System.DateTime> fechaFactura, Nullable<int> estadoFactura, Nullable<decimal> totalFactura, Nullable<int> cliente, Nullable<int> vendedor)
        {
            var numeroSerieParameter = numeroSerie != null ?
                new ObjectParameter("numeroSerie", numeroSerie) :
                new ObjectParameter("numeroSerie", typeof(string));
    
            var numeroFacturaParameter = numeroFactura != null ?
                new ObjectParameter("numeroFactura", numeroFactura) :
                new ObjectParameter("numeroFactura", typeof(string));
    
            var nitFacturaParameter = nitFactura != null ?
                new ObjectParameter("nitFactura", nitFactura) :
                new ObjectParameter("nitFactura", typeof(string));
    
            var nombreFacturaParameter = nombreFactura != null ?
                new ObjectParameter("nombreFactura", nombreFactura) :
                new ObjectParameter("nombreFactura", typeof(string));
    
            var direccionFacutraParameter = direccionFacutra != null ?
                new ObjectParameter("direccionFacutra", direccionFacutra) :
                new ObjectParameter("direccionFacutra", typeof(string));
    
            var fechaFacturaParameter = fechaFactura.HasValue ?
                new ObjectParameter("fechaFactura", fechaFactura) :
                new ObjectParameter("fechaFactura", typeof(System.DateTime));
    
            var estadoFacturaParameter = estadoFactura.HasValue ?
                new ObjectParameter("estadoFactura", estadoFactura) :
                new ObjectParameter("estadoFactura", typeof(int));
    
            var totalFacturaParameter = totalFactura.HasValue ?
                new ObjectParameter("totalFactura", totalFactura) :
                new ObjectParameter("totalFactura", typeof(decimal));
    
            var clienteParameter = cliente.HasValue ?
                new ObjectParameter("cliente", cliente) :
                new ObjectParameter("cliente", typeof(int));
    
            var vendedorParameter = vendedor.HasValue ?
                new ObjectParameter("vendedor", vendedor) :
                new ObjectParameter("vendedor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarFactura", numeroSerieParameter, numeroFacturaParameter, nitFacturaParameter, nombreFacturaParameter, direccionFacutraParameter, fechaFacturaParameter, estadoFacturaParameter, totalFacturaParameter, clienteParameter, vendedorParameter);
        }
    
        public virtual int InsertarInOut(string descripcion, Nullable<System.DateTime> fechaInOut, Nullable<int> tipoInOut, Nullable<int> cantidadInOut, Nullable<int> ubicacionInOut)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var fechaInOutParameter = fechaInOut.HasValue ?
                new ObjectParameter("fechaInOut", fechaInOut) :
                new ObjectParameter("fechaInOut", typeof(System.DateTime));
    
            var tipoInOutParameter = tipoInOut.HasValue ?
                new ObjectParameter("tipoInOut", tipoInOut) :
                new ObjectParameter("tipoInOut", typeof(int));
    
            var cantidadInOutParameter = cantidadInOut.HasValue ?
                new ObjectParameter("cantidadInOut", cantidadInOut) :
                new ObjectParameter("cantidadInOut", typeof(int));
    
            var ubicacionInOutParameter = ubicacionInOut.HasValue ?
                new ObjectParameter("ubicacionInOut", ubicacionInOut) :
                new ObjectParameter("ubicacionInOut", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarInOut", descripcionParameter, fechaInOutParameter, tipoInOutParameter, cantidadInOutParameter, ubicacionInOutParameter);
        }
    
        public virtual int InsertarInventario(Nullable<int> codigoProducto, Nullable<int> estadoProducto, Nullable<int> ubicacionProducto, Nullable<decimal> precioVenta)
        {
            var codigoProductoParameter = codigoProducto.HasValue ?
                new ObjectParameter("codigoProducto", codigoProducto) :
                new ObjectParameter("codigoProducto", typeof(int));
    
            var estadoProductoParameter = estadoProducto.HasValue ?
                new ObjectParameter("estadoProducto", estadoProducto) :
                new ObjectParameter("estadoProducto", typeof(int));
    
            var ubicacionProductoParameter = ubicacionProducto.HasValue ?
                new ObjectParameter("ubicacionProducto", ubicacionProducto) :
                new ObjectParameter("ubicacionProducto", typeof(int));
    
            var precioVentaParameter = precioVenta.HasValue ?
                new ObjectParameter("precioVenta", precioVenta) :
                new ObjectParameter("precioVenta", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarInventario", codigoProductoParameter, estadoProductoParameter, ubicacionProductoParameter, precioVentaParameter);
        }
    
        public virtual int InsertarProductos(string nombreProducto, string descripcionProducto, Nullable<decimal> costoProducto, Nullable<int> existenciaTotal)
        {
            var nombreProductoParameter = nombreProducto != null ?
                new ObjectParameter("nombreProducto", nombreProducto) :
                new ObjectParameter("nombreProducto", typeof(string));
    
            var descripcionProductoParameter = descripcionProducto != null ?
                new ObjectParameter("descripcionProducto", descripcionProducto) :
                new ObjectParameter("descripcionProducto", typeof(string));
    
            var costoProductoParameter = costoProducto.HasValue ?
                new ObjectParameter("costoProducto", costoProducto) :
                new ObjectParameter("costoProducto", typeof(decimal));
    
            var existenciaTotalParameter = existenciaTotal.HasValue ?
                new ObjectParameter("existenciaTotal", existenciaTotal) :
                new ObjectParameter("existenciaTotal", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarProductos", nombreProductoParameter, descripcionProductoParameter, costoProductoParameter, existenciaTotalParameter);
        }
    
        public virtual int InsertarRoles(string nombreRol, string descripcion)
        {
            var nombreRolParameter = nombreRol != null ?
                new ObjectParameter("nombreRol", nombreRol) :
                new ObjectParameter("nombreRol", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarRoles", nombreRolParameter, descripcionParameter);
        }
    
        public virtual int InsertarUsuarios(string nombre, string apellido, string user, string pass, Nullable<int> edad, string numeroTelefono, string email, Nullable<int> rol, Nullable<int> superior, Nullable<bool> sexo)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var edadParameter = edad.HasValue ?
                new ObjectParameter("edad", edad) :
                new ObjectParameter("edad", typeof(int));
    
            var numeroTelefonoParameter = numeroTelefono != null ?
                new ObjectParameter("numeroTelefono", numeroTelefono) :
                new ObjectParameter("numeroTelefono", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var rolParameter = rol.HasValue ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(int));
    
            var superiorParameter = superior.HasValue ?
                new ObjectParameter("superior", superior) :
                new ObjectParameter("superior", typeof(int));
    
            var sexoParameter = sexo.HasValue ?
                new ObjectParameter("sexo", sexo) :
                new ObjectParameter("sexo", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarUsuarios", nombreParameter, apellidoParameter, userParameter, passParameter, edadParameter, numeroTelefonoParameter, emailParameter, rolParameter, superiorParameter, sexoParameter);
        }
    
        public virtual int inveVendido(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("inveVendido", idParameter);
        }
    
        public virtual int pr__SYS_MakeDeleteRecordProc(string sTableName, Nullable<bool> bExecute)
        {
            var sTableNameParameter = sTableName != null ?
                new ObjectParameter("sTableName", sTableName) :
                new ObjectParameter("sTableName", typeof(string));
    
            var bExecuteParameter = bExecute.HasValue ?
                new ObjectParameter("bExecute", bExecute) :
                new ObjectParameter("bExecute", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr__SYS_MakeDeleteRecordProc", sTableNameParameter, bExecuteParameter);
        }
    
        public virtual int pr__SYS_MakeInsertRecordProc(string sTableName, Nullable<bool> bExecute)
        {
            var sTableNameParameter = sTableName != null ?
                new ObjectParameter("sTableName", sTableName) :
                new ObjectParameter("sTableName", typeof(string));
    
            var bExecuteParameter = bExecute.HasValue ?
                new ObjectParameter("bExecute", bExecute) :
                new ObjectParameter("bExecute", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr__SYS_MakeInsertRecordProc", sTableNameParameter, bExecuteParameter);
        }
    
        public virtual int pr__SYS_MakeSelectRecordProc(string sTableName, Nullable<bool> bExecute)
        {
            var sTableNameParameter = sTableName != null ?
                new ObjectParameter("sTableName", sTableName) :
                new ObjectParameter("sTableName", typeof(string));
    
            var bExecuteParameter = bExecute.HasValue ?
                new ObjectParameter("bExecute", bExecute) :
                new ObjectParameter("bExecute", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr__SYS_MakeSelectRecordProc", sTableNameParameter, bExecuteParameter);
        }
    
        public virtual int pr__SYS_MakeUpdateRecordProc(string sTableName, Nullable<bool> bExecute)
        {
            var sTableNameParameter = sTableName != null ?
                new ObjectParameter("sTableName", sTableName) :
                new ObjectParameter("sTableName", typeof(string));
    
            var bExecuteParameter = bExecute.HasValue ?
                new ObjectParameter("bExecute", bExecute) :
                new ObjectParameter("bExecute", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr__SYS_MakeUpdateRecordProc", sTableNameParameter, bExecuteParameter);
        }
    
        public virtual int prApp_DetalleInOutP_Delete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("prApp_DetalleInOutP_Delete", idParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
