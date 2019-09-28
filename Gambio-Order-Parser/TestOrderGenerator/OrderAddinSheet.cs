using ClassLibrary;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestOrderGenerator;
using JSONnamespace;

namespace OrderAddnamespace
{
    public class OrderAdd
    {
        //Test Method allOrderAdd for parse all @Orders
        public static void allOrderAdd(SheetsService sheetsService, GoogleSheets googleSheets, List<Order> Orders )
        {
            int k = 1;
            foreach (var Id in Orders)
            {
                var oblist = new List<object>() {
                    Id.PurchaseDate,
                    Id.Id,
                    Id.PaymentType.Title,
                    Id.StatusName,
                    Id.TotalSum,
                    Id.CustomerName
                };
                googleSheets.AddRow(sheetsService, $"A{k++}:D", oblist);
                Console.WriteLine(
                    $"{ Id.PurchaseDate}, " +
                    $"{ Id.Id}, " +
                    $"{ Id.PaymentType.Title}, " +
                    $"{ Id.StatusName}, " +
                    $"{ Id.TotalSum}, " +
                    $"{ Id.CustomerName}");
            }
        }
        //<-------------------------------------------------------------------------->
        public static void allOrderForDate(
            SheetsService sheetsService,  //conection with Google Sheets
            List<Order> Orders, //check the @Orders
            List<Customer> Customers,  //check the @Customers
            int month, 
            int year,
            int numberDate,
            JSONClass initOrderIn,  //class for connection with @OrderIn
            GoogleSheets googleSheets
            )
        {
            int k = 1;
            foreach (var Id in Orders)            // foreach all @Orders at website
            {
                DateTime date = new DateTime(year, month, numberDate);
                if (Id.PurchaseDate > date)       //check date for start foreach @Orders
                {
                    initOrderIn.JSONInitialize<OrderIn>(Id.Id, out List<OrderIn> OrderDate); //connection to the order through @id 
                    string itemsstring = "";
                    //check Items in Order with @id
                    foreach (var item in OrderDate[0].Items)
                    {
                        itemsstring += $"{item.Name}\n";
                    }
                    var oblist = new List<object>() {  //change properties @Order fo parse
                    Id.PurchaseDate,
                    Id.Id,
                    Id.PaymentType.Title,
                    Id.StatusName,
                    Id.TotalSum.Replace(" EUR", ""), //remove string " EUR" with @Sum
                    Id.CustomerName,
                    Customers[Id.CustomerId].VatNumber,
                    Customers[Id.CustomerId].VatNumberStatus,
                    $"{itemsstring}"
                };
                    googleSheets.AddRow(sheetsService, $"A{k++}:J", oblist);
                        Console.WriteLine(
                            $"{ Id.PurchaseDate}, " +
                            $"{ Id.Id}, " +
                            $"{ Id.PaymentType.Title}, " +
                            $"{ Id.StatusName}, " +
                            $"{ Id.TotalSum}, " +
                            $"{ Id.CustomerName}," +
                            $"{Customers[Id.CustomerId].VatNumber}" +
                            $"{Customers[Id.CustomerId].VatNumberStatus}" +
                            $"{itemsstring}");
                    }

                }
            }
        }
    }

