using System;
using Microsoft.WindowsAzure.Storage.Table;


namespace AzureTableApp
{
    public class Product:TableEntity
    {
            public int ProdId { get; set; }
            public String ProdName { get; set; }
            public double Price { get; set; }
    }
}
