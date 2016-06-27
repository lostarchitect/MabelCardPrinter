﻿using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Drawing;
using System.Web;

namespace MabelCardPrinter
{
    public class MabelResponse
    {
        public int code;
        public string message;
        public bool isError;
        public JToken results;
    }

    public class MabelRequest
    {
        private String _baseAddress;
        private String apiKey;
        public String modFunc;
        public Object please;
        public MabelRequest(String modFunc, Object please)
        {
            this.apiKey = Properties.Settings.Default.APIKey;
            this._baseAddress = Properties.Settings.Default.apiBaseUrl;
            this.modFunc = modFunc;
            this.please = please;
        }

        public String buildURL()
        {
            string jsonParameters = JsonConvert.SerializeObject(this.please);
            jsonParameters = WebUtility.UrlEncode(jsonParameters);
            return _baseAddress + "?apiKey=" + this.apiKey + "&modFunc=cardPrinter." + this.modFunc + "&please=" + jsonParameters;
        }
    }

    public class MabelPrinterRegister
    {
        public String printer_id;
        public String name;
        public String location;
        public String model;
        public MabelPrinterRegister(String printer_id,String name, String location, String model)
        {
            this.printer_id = printer_id;
            this.name = name;
            this.location = location;
            this.model = model;
        }
    }
    public class MabelPrinterUnregister
    {
        public String printer_id;

        public MabelPrinterUnregister(String printer_id)
        {
            this.printer_id = printer_id;
        }
    }

    public class MabelEventArgs : EventArgs
    {
        public String URL;
        public MabelResponse response;
        public MabelEventArgs(String URL, MabelResponse response)
        {
            this.URL = URL;
            this.response = response;
        }
    }

    public delegate void MabelEventHandler(object sender, MabelEventArgs e);
    /// <summary>
    /// Represents a card as generated in Mabel
    /// </summary>
    public class MabelCard
    {
        public int card_id;
        public int member_id;
        public string mag_token;
        public string rfid_token;
        public string card_front_image_encoded; // base64 encoded
        public delegate void PrinterEventHander(object sender, PrinterEventArgs e);


        /// <summary>
        /// Gets the front image of the card
        /// </summary>
        /// <returns>Image object</returns>
        public Image GetCardFrontImage()
        {
            if (card_front_image_encoded == null)
            {
                return null;
            }
            byte[] bytes = Convert.FromBase64String(card_front_image_encoded);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }
        public string card_back_image_encoded; // base64 encoded
        public Image GetCardBackImage()
        {
            if (card_back_image_encoded == null)
            {
                return null;
            }
            byte[] bytes = Convert.FromBase64String(card_back_image_encoded);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }

    }

    public class MabelAPI
    {

        public event MabelEventHandler Debug;
        
        protected virtual void OnDebug(MabelEventArgs e)
        {
            Debug?.Invoke(this, e);
        }

        private MabelResponse MakeRequest (String method, Object parameters)
        {
            ServicePointManager.ServerCertificateValidationCallback = (s, cert, chain, ssl) => true;
            MabelRequest mabelRequest = new MabelRequest(method, parameters);
            String url = mabelRequest.buildURL();
            OnDebug(new MabelEventArgs(url, null));
            WebRequest request = HttpWebRequest.Create(url);
            //request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.MutualAuthRequested;
            //request.Credentials = new NetworkCredential(Properties.Settings.Default.Username, Properties.Settings.Default.Password, Properties.Settings.Default.Domain);
            //request.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
            //Console.WriteLine(request.ToString);
            // Get the response.

            MabelResponse mabelResponse = new MabelResponse();

            try { 
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                // Clean up the streams and the response.
                reader.Close();
                response.Close();

                // Get the stream containing content returned by the server.
                //Console.WriteLine(responseFromServer); // debugging?
                JObject o = JObject.Parse(responseFromServer);

                mabelResponse.code = (int)o["meta"]["status"];
                mabelResponse.message = (string)o["meta"]["msg"];
                //OnDebug(new MabelEventArgs(url, mabelResponse));
                if (mabelResponse.code != 200)
                {
                    // it's an error, return it now, don't bother looking for results
                    mabelResponse.isError = true;
                    return mabelResponse;
                }
                // otherwise, hand back the results :)
                mabelResponse.isError = false;
                // JToken result = o["result"];
                if (o["result"].Type != JTokenType.Null)
                {
                    mabelResponse.results = o["result"];
                }
                else
                {
                    mabelResponse.results = null;
                }
            }
            catch (Exception ex)
            {
                mabelResponse.isError = true;
                mabelResponse.message = "EXCEPTION:" + ex.Message;
                OnDebug(new MabelEventArgs(url, mabelResponse));
            }
            return mabelResponse;
        }
        /// <summary>
        /// Registers the printer
        /// </summary>
        /// <param name="printerId">The printer ID to register</param>
        /// <param name="printerName">The "name" of the printer</param>
        /// <param name="printerLocation">The location of the printer</param>
        /// <param name="printerModel">The model of the printer</param>
        /// <returns></returns>
        public MabelResponse RegisterPrinter(int printerId, string printerName, string printerLocation, string printerModel)
        {
            MabelResponse response = MakeRequest("register", new MabelPrinterRegister( printerId.ToString() ,printerName ,printerLocation,printerModel));
            return response;
        }

        /// <summary>
        /// Unregisters a printer
        /// </summary>
        /// <param name="printerId">The printer's ID</param>
        /// <returns></returns>
        public MabelResponse UnregisterPrinter(int printerId)
        {
            MabelResponse response = MakeRequest("unregister", "printer_id=" + printerId);
            return response;
        }

        public MabelResponse SetPrinterStatus(int printerId, string status)
        {
            MabelResponse response = MakeRequest("printerSetStatus", "printer_id=" + printerId + "&status=" + status);
            return response;
        }

        public MabelResponse SetCardStatus(int printerId, MabelCard card, string status)
        {
            MabelResponse response = MakeRequest("cardSetStatus", "printer_id=" + printerId + "&card_id=" + card.card_id + "&status=" + status);
            return response;
        }

        public MabelResponse SetCardRfid(int printerId, MabelCard card, string rfid)
        {
            MabelResponse response = MakeRequest("cardSetStatus", "printer_id=" + printerId + "&card_id=" + card.card_id + "&rfid_token=" + rfid);
            return response;
        }

        public MabelResponse SetCardPrinted(int printerId, MabelCard card)
        {
            MabelResponse response = MakeRequest("cardPrinted", "printer_id=" + printerId + "&card_id=" + card.card_id);
            return response;
        }

        public MabelCard GetNextJob(int printerId)
        {
            MabelResponse response = MakeRequest("printerGetNextJob", "printer_id=" + printerId);
            if (response.code == 200)
            {
                if (response.results == null)
                {
                    // The API is OK, there's just no cards to print :)
                    return null;
                }
            } else
            {
                //Something has gone wrong, best ignore and hope for the best, but exit out this time around
                return null;
            } 
            // otherwise...
            MabelCard card = new MabelCard();
            card.card_id = (int) response.results.SelectToken("card_id");
            card.member_id = (int) response.results.SelectToken("member_id");
            card.mag_token = (string)response.results.SelectToken("card_mag_token");
            card.rfid_token = (string)response.results.SelectToken("card_rfid_token");
            card.card_front_image_encoded = (string)response.results.SelectToken("card_image_front");
            card.card_back_image_encoded = (string)response.results.SelectToken("card_image_back");
            return card;
        }

    }
}
