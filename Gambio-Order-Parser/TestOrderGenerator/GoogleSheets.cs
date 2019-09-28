using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;

namespace TestOrderGenerator
{
    public class GoogleSheets
    {
        public GoogleSheets(string ApplicationName, string sheet, string SpreadsheetId, string client_secret)
        {
            this._ApplicationName = ApplicationName;
            this._sheet = sheet;
            this._SpreadsheetId = SpreadsheetId;
            this._client_secret = client_secret;
        }
        //<------------------------------------------------------------->
        public string _ApplicationName { get; set; }
        public string _sheet { get; set; }
        public string _SpreadsheetId { get; set; }
        public string _client_secret { get; set; }

        public void Init(out SheetsService service)
        {
            string[] Scopes = { SheetsService.Scope.Spreadsheets /*SheetsService.Scope.SpreadsheetsReadonly*/ };//if SheetsService.Scope.SpreadsheetsReadonly - don't writing
            UserCredential credential; 
            using (var stream =
                new FileStream(
                _client_secret, //file for conection whith Google Sheets
                FileMode.Open,
                FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Creating Google Sheets API service...
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = _ApplicationName,
            });
        }

        public void AddRow(SheetsService service, string rangeCell, List<object> oblist)
        {
            // Specifying Column Range for reading...
            var range = $"{_sheet}!{rangeCell}";
            var valueRange = new ValueRange();

            // Data for another Student...
            valueRange.Values = new List<IList<object>> { oblist };

            // Append the above record...
            var appendRequest = service.Spreadsheets.Values.Append(valueRange, _SpreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendReponse = appendRequest.Execute();
        }

        public void ReadSheet(string rangeStart, string rangeFinish)
        {
            //Specifying Column Range for reading...
            this.Init(out SheetsService service);
            var range = $"{_sheet}!{rangeStart}:{rangeFinish}";
           SpreadsheetsResource.ValuesResource.GetRequest request =
                   service.Spreadsheets.Values.Get(_SpreadsheetId, range);

            // Ecexuting Read Operation...
            var response = request.Execute();
            // Getting all records from Column A to E...
            IList<IList<object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    for (int i = 0; i < row.Count; i++)
                    {
                        // Writing Data on Console...
                        Console.Write($"{row[i]} | "/*, row[0], row[1], row[2], row[3], row[4]*/);
                    }
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }


        }

        public void UpdateCell(string rangeCell, IList<object> oblist)
        {
            this.Init(out SheetsService service);
            // Setting Cell Name...
            var range = $"{_sheet}!{rangeCell}";
            var valueRange = new ValueRange();

            // Setting Cell Value...
            valueRange.Values = new List<IList<object>> { oblist };

            // Performing Update Operation...
            var updateRequest = service.Spreadsheets.Values.Update(valueRange, _SpreadsheetId, range);
            updateRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
            var appendReponse = updateRequest.Execute();
        }

    }
}