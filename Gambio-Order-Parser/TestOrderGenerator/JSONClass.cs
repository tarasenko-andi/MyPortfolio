using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using RestSharp;
using ClassLibrary;
using TestOrderGenerator;

namespace JSONnamespace
{

    public class JSONClass
    {
        public JSONClass(string site, RestSharp.Method method, string key)
        {
            this._site = site;
            this._method = method;
            this._key = key;
        }
        //<------------------------------------------------------------->
        public string _site { get; set; }       // - it's site page, wher we take the information for reading at format JSON
        RestSharp.Method _method { get; set; } // -  it's string where we check method request with your page(GET, PATH and other)
        string _key { get; set; }
        //<------------------------------------------------------------->
        public void JSONInitialize<T>(out List<T> list)
        {
            //input information about conection
            var client = new RestClient(_site);
            var request = new RestRequest(_method);
            request.AddHeader("authorization", _key);
            request.AddHeader("content-type", "application/json");
            IRestResponse response1 = client.Execute(request);
            //get JSON information, whith @request for @client1 in List<T>
            list = client.Execute<List<T>>(request).Data;
        }
        public void JSONInitialize<T>(int orderId, out List<T>  OrderIns) {
            var request = new RestRequest(_method);
            request.AddHeader("authorization", _key);
            request.AddHeader("content-type", "application/json");
            var client3 = new RestClient($"{_site}{orderId}");
            IRestResponse response3 = client3.Execute(request);
            OrderIns = client3.Execute<List<T>>(request).Data;
        }

    }
}

