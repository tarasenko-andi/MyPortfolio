using System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using RestSharp;
using ClassLibrary;
using TestOrderGenerator;
using JSONnamespace;
using OrderAddnamespace;
using System.Linq;

namespace OrderParser
{
    public class Program
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        public static void Main(string[] args)
        {
            //Initialization your website
            string siteForCheckOrder = "https://YourWebsiteDomain/api.php/v2/orders/"; // - url site for request
            RestSharp.Method methodrequest = Method.GET; // - method request
            string keyForAutorization = "Basic Key"; // - key for autorization(take in Postman)
            string siteForCheckCustomer = "https://YourWebsiteDomain/api.php/v2/customers"; // - url site for request
            //Initialization information at JSON whith your site
            JSONClass initOrder = new JSONClass(siteForCheckOrder, methodrequest, keyForAutorization);
            initOrder.JSONInitialize<Order>(out List<Order> Orders);
            JSONClass initCustomer = new JSONClass(siteForCheckCustomer, methodrequest, keyForAutorization);
            initCustomer.JSONInitialize<Customer>(out List<Customer> Customers);
            JSONClass initOrderIn = new JSONClass(siteForCheckOrder, methodrequest, keyForAutorization);
            //-------------------------------------------------------------------------->
            //Initialization Google Sheets
            string ApplicationName = "YourApplication";
            string sheet = "SheetName"; //take in Sheet Document
            string SpreadsheetId = "SheetId"; //take in url Sheet Document
            string client_secret = "client_secret JSON File; //path for your client secret, take in google account
            GoogleSheets googleSheets = new GoogleSheets(ApplicationName, sheet, SpreadsheetId, client_secret);
            googleSheets.Init(out SheetsService sheetsService);
            //--------------------------------------------------------------------------> 
            ChangeDate(out int numberDate, out int month, out int year);
            OrderAdd.allOrderForDate(sheetsService, Orders, Customers, month, year, numberDate, initOrderIn, googleSheets);
        }
        public static void ChangeDate(out int numberDate, out int month, out int year)
        {
            restart:
            Console.WriteLine("Change date for start parsing:\nnn\nmm\nyyyy");
            try
            {
                numberDate = Int32.Parse(Console.ReadLine());
                if (numberDate < 0 || numberDate > 32){
                    throw new Exception("Month goes beyond: 1-12");
                }
                month = Int32.Parse(Console.ReadLine());
                if (month < 0 || month > 13) {
                    throw new Exception("Month goes beyond: 1-12");
                }
                year = Int32.Parse(Console.ReadLine());
                if (year < 1990 || year > 2100) {
                    throw new Exception("Year goes beyond: 1900-2100");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                goto restart;
            }
        }
    }
}