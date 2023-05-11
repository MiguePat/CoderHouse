//Primeros pasos proyecto final
//Alumno Miguel Patrón
// por lo que se entiende de la letra hay algunos campos que se podrian heredar de una clase a otra por ejemplo idUsuario y idProducto
//pero como no pide aplicar herencia repeti el campo
public class Usuario
{
    private int iIdUsuario;
    private string sNombre;
    private string sApellido;
    private string sNombredeusuario;
    private string sContraseña;
    private string sMail;


    //constructor de la clase
    public Usuario(int iIdUsuario, string sNombre, string sApellido, string sNombredeusuario, string sContraseña, string sMail)
    {
        this.iIdUsuario = iIdUsuario;
        this.sNombre = sNombre;
        this.sApellido = sApellido;
        this.sNombredeusuario = sNombredeusuario;
        this.sContraseña = sContraseña;
        this.sMail = sMail; 
    }
}
public class Producto
{

    private int iIdProducto;
    private string sDescripcion;
    private int iCosto;
    private int iPrecioVenta;
    private int iStock;
    private int iIdusuario;

    //constructor de la clase
    public Producto(int iIdProducto, string sDescripcion, int iCosto, int iPrecioVenta, int iStock, int iIdusuario)
    {
        this.iIdProducto = iIdProducto;
        this.sDescripcion = sDescripcion;
        this.iCosto = iCosto;
        this.iPrecioVenta = iPrecioVenta;
        this.iStock = iStock;
        this.iIdusuario = iIdusuario;
    }
}
public class ProductoVendido
{
    
        

    private int iIdUsuario;
    private int iIdProducto;
    private int iStock;
    private int iIdVenta;


    //constructor de la clase
    public ProductoVendido(int iIdUsuario, int iIdProducto, int iStock, int iIdVenta)
    {
        this.iIdUsuario = iIdUsuario;
        this.iIdProducto = iIdProducto;
        this.iStock = iStock;
        this.iIdVenta = iIdVenta;
    }


}

public class Venta
{

    private int iIdUsuario;
    private int iIdProducto;
    private string sComentarios;

    //constructor de la clase
    public Venta(int iIdUsuario,int iIdProducto, string sComentarios)
    {
        this.iIdUsuario= iIdUsuario;
        this.iIdProducto= iIdProducto;
        this.sComentarios= sComentarios;
    }

}


