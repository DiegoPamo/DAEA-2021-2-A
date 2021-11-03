using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;


namespace Lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {

            //using (AdventureWorks2017Entities AWEntities = new AdventureWorks2017Entities())
            //{
            //1.	Sintaxis de expresiones de consulta
            //var products = AWEntities.Product;

            //IQueryable<string> productNames = from p in products
            //                                  select p.Name;

            //Console.WriteLine("Productos");
            //foreach(var productName in productNames)
            //{
            //    Console.WriteLine(productName);
            //}

            //2.	Sintaxis de consultas basadas en métodos
            //var products = AWEntities.Product;
            //IQueryable<string> productNames = products.Select(p => p.Name);

            //Console.WriteLine("Productos: ");
            //foreach (var producName in productNames)
            //{
            //    Console.WriteLine(producName);
            //}

            //3.	La primera consulta devuelve todos los productos, la segunda amplia la primera usando Where
            //      para devolver todos los productos de tamaño “L”:
            //var products = AWEntities.Product;
            //IQueryable<Product> productsQuery = from p in products
            //                                    select p;
            //IQueryable<Product> largeProducts = productsQuery.Where(p => p.Size == "L");

            //Console.WriteLine("Productos de tamaño 'L': ");
            //foreach (var product in largeProducts)
            //{
            //    Console.WriteLine(product.Name);
            //}
            //}

            //using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            //{
            //4.  Usa el método Select para devolver todas las filas de la tabla Product
            //y mostrar los nombres de producto

            //IQueryable<Product> productsQuery = from product in context.Product
            //                                    select product;
            //Console.WriteLine("Productos: ");
            //foreach (var prod in productsQuery)
            //{
            //    Console.WriteLine(prod.Name);
            //}

            //5.	Usa el método Select para proyectar las propiedades Product.Name
            //y Product.ProductID en una secuencia de tipos anónimos
            //var query = from product in context.Product
            //            select new
            //            {
            //                ProductId = product.ProductID,
            //                ProductName = product.Name
            //            };
            //Console.WriteLine("Informacion de productos: ");
            //foreach (var productInfo in query)
            //{
            //    Console.WriteLine("Producto Id: {0}, Producto Name: {1}",
            //        productInfo.ProductId, productInfo.ProductName);
            //}
            //}
            //8.Se devuelven los pedidos en los que la cantidad de pedido es superior a 2 e inferior a 6
            //int orderQtyMin = 2;
            //int orderQtyMax = 6;

            //using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            //{
            //    var query = from order in context.SalesOrderDetail
            //                where order.OrderQty > orderQtyMin
            //                && order.OrderQty < orderQtyMax
            //                select new
            //                {
            //                    SalesOrderId = order.SalesOrderID,
            //                    OrderQty = order.OrderQty
            //                };
            //    foreach(var order in query)
            //    {
            //        Console.WriteLine("Order ID: {0} Order quantity: {1}",
            //            order.SalesOrderId, order.OrderQty);
            //    }
            //    Console.ReadKey();
            //}

            //9.	Se devuelven todos los productos de color rojo
            //String color = "Red";

            //using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            //{
            //    var query = from product in context.Product
            //                where product.Color == color
            //                select new
            //                {
            //                    Name = product.Name,
            //                    ProductNumber = product.ProductNumber,
            //                    ListPrice = product.ListPrice
            //                };
            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Name: {0}", product.Name);
            //        Console.WriteLine("Product Number: {0}", product.ProductNumber);
            //        Console.WriteLine("List Price: ${0}", product.ListPrice);
            //        Console.WriteLine("");

            //    }
            //    Console.ReadKey();
            //}

            //10.	Usa una matriz como parte de una cláusula Where…Contains para encontrar todos los
            //productos que tienen un ProductModelID que coincide con un valor de la matriz
            //using (AdventureWorks2017Entities AWEntities = new AdventureWorks2017Entities())
            //{
            //    int?[] productModelIds = { 19, 26, 118 };
            //    var products = from p in AWEntities.Product
            //                   where productModelIds.Contains(p.ProductModelID)
            //                   select p;

            //    foreach (var product in products)
            //    {
            //        Console.WriteLine("{0}: {1}",
            //            product.ProductModelID, product.ProductID);
            //    }
            //    Console.ReadKey();
            //}

            //12.	Utiliza orderby… descending, que es equivalente al método OrderByDescending,
            //para ordenar el precio de venta de mayor a menor
            //using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            //{
            //    IQueryable<Decimal> sortedPrices = from p in context.Product
            //                                       orderby p.ListPrice descending
            //                                       select p.ListPrice;
            //    Console.WriteLine("Lista de precios desde el más alto al más bajo:");
            //    foreach (Decimal price in sortedPrices)
            //    {
            //        Console.WriteLine(price);
            //    }
            //    Console.ReadKey();
            //}

            //14.	Usa el método Average para encontrar el precio de venta
            //promedio de los productos de cada estilo
            //using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            //{
            //    var products = context.Product;
            //    var query = from product in products
            //                group product by product.Style into g
            //                select new
            //                {
            //                    Style = g.Key,
            //                    AverageListPrice = g.Average(product => product.ListPrice)
            //                };
            //    foreach (var product in query)
            //    {
            //        Console.WriteLine("Estilo: {0} Precio promedio: {1}",
            //            product.Style, product.AverageListPrice);
            //    }
            //    Console.ReadKey();
            //}

            //15.	Se agrupan los productos por colores y se utiliza Count
            //para devolver el número de productos de cada grupo de color
            using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            {
                var products = context.Product;
                var query = from product in products
                            group product by product.Color into g
                            select new
                            {
                                Color = g.Key,
                                ProductCount = g.Count()
                            };
                foreach (var product in query)
                {
                    Console.WriteLine("Color = {0} \t Cantidad = {1}",
                        product.Color, product.ProductCount);
                }
                Console.ReadKey();
            }
        }

    }
}
