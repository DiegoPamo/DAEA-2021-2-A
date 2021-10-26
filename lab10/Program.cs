using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwndDataContext context = new NorthwndDataContext();

            //Creacion de consulta

            //Consulta inicial
            //var query = from p in context.Products
            //            select p;

            //Consulta de Categorias con nombre
            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Beverages"
            //            select p;

            //Consulta precios por unidad < 20
            //var query = from p in context.Products
            //            where p.UnitPrice < 20
            //            select p;

            //Consulta nombre incluye palabra Queso
            //var query = from p in context.Products
            //            where p.ProductName.Contains("Queso")
            //            select p;

            //Consulta productos cuya presentacion de paquetes es pkg o pkgs
            //var query = from p in context.Products
            //            where p.QuantityPerUnit.Contains("pkg") ||
            //            p.QuantityPerUnit.Contains("pkgs")
            //            select p;

            //Consulta de productos que empiecen con la letra A
            //var query = from p in context.Products
            //            where p.ProductName.StartsWith("A")
            //            select p;

            //Consulta productos sin Stock
            //var query = from p in context.Products
            //            where p.UnitsInStock == 0
            //            select p;

            //Consulta si son productos descontinuados
            //var query = from p in context.Products
            //            where p.Discontinued == true
            //            select p;


            //TAREA LABORATORIO
            //Consulta listar ID, nombre de producto, nombre del proveedor (Suppliers/CompanyName)
            //productos de los productos de la categoría “Dairy Products”
            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Dairy Products"
            //            select p;

            //Consulta productos proveedores ubicados en USA
            var query = from p in context.Products
                        where p.Suppliers.Country == "USA"
                        select p;

            //Ejecucion de la consulta
            foreach (var prod in query)
            {
                Console.WriteLine("Productos={0,-35} \t Nombre Proveedor={1,-25} \t Pais={2}",
                    prod.ProductName, prod.Suppliers.CompanyName, prod.Suppliers.Country);
            }

            ////INSERCION DATOS TABLA PRODUCTOS
            //Products p = new Products();
            //p.ProductName = "Peruvian Coffee";
            //p.SupplierID = 20;
            //p.CategoryID = 1;
            //p.QuantityPerUnit = "10 pkgs";
            //p.UnitPrice = 25;

            ////Ejecución de consulta INSERCION
            //context.Products.InsertOnSubmit(p);
            //context.SubmitChanges();


            ////INSERCION DATOS TABLA CATEGORIAS
            //Categories c = new Categories();
            //c.CategoryName = "Tecnologia";
            //c.Description = "Play Station 5 - Edicion Coleccionista";

            //////Ejecución de consulta INSERCION
            //context.Categories.InsertOnSubmit(c);
            //context.SubmitChanges();

            ////MODIFICACION DATO PRODUCTO
            //var product = (from p in context.Products
            //               where p.ProductName == "Tofu"
            //              select p).FirstOrDefault();

            //product.UnitPrice = 100;
            //product.UnitsInStock = 15;
            //product.Discontinued = true;

            ////Ejecución de consulta
            //context.SubmitChanges();

            ////ELIMINACION REGISTRO
            //var product = (from p in context.Products
            //               where p.ProductID == 78
            //              select p).FirstOrDefault();

            ////Ejecución de consulta
            //context.Products.DeleteOnSubmit(product);
            //context.SubmitChanges();

            Console.ReadKey();

            


            
        }
    }
}
