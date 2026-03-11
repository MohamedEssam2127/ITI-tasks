using BLL.Entities;
using BLL.EntityLists;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL.EntityManagers
{
    public static  class ProductManager
    {
        static DBManager Manager = new();
        public static ProductList SelectALLProducts ()
        {
            try
            {
                return DataTableToProductList(
                Manager.ExecuteDataTable("SelectALLProducts"));
            }
            catch
            {

            }
            return new();
        }

        public static bool UpdateProductPrice (int ProductID , decimal UnitPrice)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@ProductID"] = ProductID,
                    ["@UnitPrice"] = UnitPrice
                };
                return Manager.ExecuteNonQuery("UpdateProductPrice" , Parameters) > 0;
                    
            }
            catch
            {

            }
            return false;
        }

        #region Mapping Functions
        internal static ProductList DataTableToProductList(DataTable dt)
        {
            ProductList Prds = new ProductList();
            try
            {
                foreach (DataRow item in dt.Rows)
                {
                    Prds.Add(DataRowToProduct(item));
                }
            }
            catch
            {

            }
            return Prds;
        }

        internal static Product DataRowToProduct(DataRow Dr)
        {
            Product P = new() { ProductName = String.Empty };
            try
            {
                P.ProductID = Dr.Field<int>("ProductID");
                P.ProductName = Dr["ProductName"]?.ToString() ?? "NA";

                if (int.TryParse(Dr["SupplierID"].ToString(), out int TempInt))
                    P.SupplierID = TempInt;
                else
                    P.SupplierID = null;

                if (int.TryParse(Dr["CategoryID"].ToString(), out TempInt))
                    P.CategoryID = TempInt;
                else
                    P.CategoryID = null;

                P.ReorderLevel = Dr.Field<short?>("ReorderLevel");
                P.UnitsInStock = Dr.Field<short?>("UnitsInStock");
                P.UnitsOnOrder = Dr.Field<short?>("UnitsOnOrder");

                P.UnitPrice = Dr.Field<decimal?>("UnitPrice");

                P.Discontinued = Dr.Field<bool>("Discontinued");

                P.QuantityPerUnit = Dr.Field<string>("QuantityPerUnit");

                P.State = EntitySate.UnChanged;

            }
            catch
            {

            }
            return P;

        }

        #endregion
    }
}
