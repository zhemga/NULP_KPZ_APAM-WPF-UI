using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAM_Client.Service
{
    public static class ApiRoutes
    {
        private const string BaseUrl = "https://localhost:44381/api/";

        public static class AutoPartCategories
        {
            public static string GetAll() => $"{BaseUrl}AutoPartCategories";
            public static string GetById(string id) => $"{BaseUrl}AutoPartCategories/{id}";
            public static string Create() => $"{BaseUrl}AutoPartCategories";
            public static string Update(string id) => $"{BaseUrl}AutoPartCategories/{id}";
            public static string Delete(string id) => $"{BaseUrl}AutoPartCategories/{id}";
        }

        public static class AutoPartManufacturers
        {
            public static string GetAll() => $"{BaseUrl}AutoPartManufacturers";
            public static string GetById(string id) => $"{BaseUrl}AutoPartManufacturers/{id}";
            public static string Create() => $"{BaseUrl}AutoPartManufacturers";
            public static string Update(string id) => $"{BaseUrl}AutoPartManufacturers/{id}";
            public static string Delete(string id) => $"{BaseUrl}AutoPartManufacturers/{id}";
        }

        public static class AutoParts
        {
            public static string GetAll() => $"{BaseUrl}AutoParts";
            public static string GetById(string id) => $"{BaseUrl}AutoParts/{id}";
            public static string Create() => $"{BaseUrl}AutoParts";
            public static string Update(string id) => $"{BaseUrl}AutoParts/{id}";
            public static string Delete(string id) => $"{BaseUrl}AutoParts/{id}";
        }

        public static class AutoPartSuppliers
        {
            public static string GetAll() => $"{BaseUrl}AutoPartSuppliers";
            public static string GetById(string id) => $"{BaseUrl}AutoPartSuppliers/{id}";
            public static string Create() => $"{BaseUrl}AutoPartSuppliers";
            public static string Update(string id) => $"{BaseUrl}AutoPartSuppliers/{id}";
            public static string Delete(string id) => $"{BaseUrl}AutoPartSuppliers/{id}";
        }

        public static class Customers
        {
            public static string GetAll() => $"{BaseUrl}Customers";
            public static string GetById(string id) => $"{BaseUrl}Customers/{id}";
            public static string Create() => $"{BaseUrl}Customers";
            public static string Update(string id) => $"{BaseUrl}Customers/{id}";
            public static string Delete(string id) => $"{BaseUrl}Customers/{id}";
        }

        public static class Deliveries
        {
            public static string GetAll() => $"{BaseUrl}Deliveries";
            public static string GetById(string id) => $"{BaseUrl}Deliveries/{id}";
            public static string Create() => $"{BaseUrl}Deliveries";
            public static string Update(string id) => $"{BaseUrl}Deliveries/{id}";
            public static string Delete(string id) => $"{BaseUrl}Deliveries/{id}";
        }

        public static class DeliveryStatus
        {
            public static string GetAll() => $"{BaseUrl}DeliveryStatus";
            public static string GetById(string id) => $"{BaseUrl}DeliveryStatus/{id}";
            public static string Create() => $"{BaseUrl}DeliveryStatus";
            public static string Update(string id) => $"{BaseUrl}DeliveryStatus/{id}";
            public static string Delete(string id) => $"{BaseUrl}DeliveryStatus/{id}";
        }

        public static class Orders
        {
            public static string GetAll() => $"{BaseUrl}Orders";
            public static string GetById(string id) => $"{BaseUrl}Orders/{id}";
            public static string Create() => $"{BaseUrl}Orders";
            public static string Update(string id) => $"{BaseUrl}Orders/{id}";
            public static string Delete(string id) => $"{BaseUrl}Orders/{id}";
        }

        public static class Sellers
        {
            public static string GetAll() => $"{BaseUrl}Sellers";
            public static string GetById(string id) => $"{BaseUrl}Sellers/{id}";
            public static string Create() => $"{BaseUrl}Sellers";
            public static string Update(string id) => $"{BaseUrl}Sellers/{id}";
            public static string Delete(string id) => $"{BaseUrl}Sellers/{id}";
        }
    }

}
