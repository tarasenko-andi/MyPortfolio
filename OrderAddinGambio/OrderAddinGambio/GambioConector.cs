using System;
using System.Collections.Generic;
using RestSharp;

namespace ConnectGambio
{

    public class GambioConector
    {
        public GambioConector(string site, RestSharp.Method method, string key)
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
        public void post(string postObject)
        {
            //input information for conection
            var client = new RestClient(_site);
            var request = new RestRequest(_method);
            request.AddHeader("authorization", _key);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("accept", "application/json");
            request.AddParameter("application/json", $"{postObject}", ParameterType.RequestBody);

            IRestResponse response1 = client.Execute(request);
            Console.WriteLine(response1.StatusCode);
            Console.WriteLine(response1.Content);
            //get JSON information, whith @request for @client1 in List<T>
        }
        public void get<T>(out List<T> list)
        {
            //input information about conection
            var client = new RestClient(_site);
            var request = new RestRequest(_method);
            request.AddHeader("authorization", _key);
            request.AddHeader("content-type", "application/json");
            IRestResponse response1 = client.Execute(request);
            Console.WriteLine(response1.StatusCode);
            //Console.WriteLine(response1.Content);
            //get JSON information, whith @request for @client1 in List<T>
            list = client.Execute<List<T>>(request).Data;
        }
    }
}

