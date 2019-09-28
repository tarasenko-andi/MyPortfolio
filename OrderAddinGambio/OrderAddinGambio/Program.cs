using RestSharp;
using System;
using ClassLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ConnectGambio;
using Customers;
using System.Collections.Generic;

namespace OrderAddinGambio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization your website
            string siteForCheckOrder = "https://YourWebsiteDomain/api.php/v2/orders"; // - url site for request
            RestSharp.Method methodPOST = Method.POST; // - method request
            RestSharp.Method methodGET = Method.GET; // - method request
            string keyForAutorization = "Basic YourKey"; // - key for autorization(take in Postman)
            string siteForCheckCustomer = "https://YourWebsiteDomain/api.php/v2/customers"; // - url site for request
            //-------------------------------------------------------------------------->
            //Initialization information at JSON whith your site
            GambioConector orderAddConector = new GambioConector(siteForCheckOrder, methodPOST, keyForAutorization);
            GambioConector customerAddConector = new GambioConector(siteForCheckCustomer, methodPOST, keyForAutorization);
            GambioConector orderGetConector = new GambioConector(siteForCheckOrder, methodGET, keyForAutorization);
            GambioConector customerGetConector = new GambioConector(siteForCheckCustomer, methodGET, keyForAutorization);
            //-------------------------------------------------------------------------->
            CreateCheckOrder.createOrder4(out Order order3);
            CreateCheckCustomer.createCheckCustomer(out Customer customer);
            //-------------------------------------------------------------------------->
            Serializator.serialize(customer, out string jsoncustomer);
            Serializator.serialize(order3, out string jsonorder2);
            //-------------------------------------------------------------------------->
            //Console.WriteLine(jsonorder2);
            //-------------------------------------------------------------------------->
            //orderAddConector.post(jsonorder2);
            //customerAddConector.post(jsonorder2);
            orderGetConector.get<OrderCheck>(out List<OrderCheck> orders);
            Console.WriteLine(orders.Count);
            //-------------------------------------------------------------------------->
        }
    }
}
