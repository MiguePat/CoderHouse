//Primeros pasos proyecto final
//Alumno Miguel Patrón
// por lo que se entiende de la letra hay algunos campos que se podrian heredad de una clase a otra por ejemplo idUsuario y idProducto
//pero como no pide aplicar herencia repeti el campo
public class Usuario
{
    private int IIdUsuario;
    private string SNombre;
    private string SApellido;
    private string SNombredeusuario;
    private string sContraseña;
    private string SMail;
}
public class Producto
{

    private int iIdProducto;
    private string sDescripcion;
    private int iCosto;
    private int iPrecioVenta;
    private int iStock;
    private int iIdusuario;

}
public class ProductoVendido
{

    private int iIdUsuario;
    private int iIdProducto;
    private int iStock;
    private int iIdVenta;
   
}

public class Venta
{

    private int iIdUsuario;
    private int iIdProducto;
    private string sComentarios;
  

}


