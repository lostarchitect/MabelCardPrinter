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

    public class MabelPrinterInfo
    {
        public String model;
        public int modelId;
        public bool connected;
        public String printerSerial;
        public String printHeadSerial;
        public String PCBSerial;
        public String firmwareVersion;
        public int esDensity;
        public int handFeed;
        public int cardsPrinted;
        public int cardsOnPrintHead;
        public int dyePanelsPrinted;
        public int cleansSinceShipped;
        public int dyePanelsSinceCleaned;
        public int cardsSinceCleaned;
        public int cardsBetweenCleans;
        public int printHeadPosition;
        public int imageStartPosition;
        public int imageEndPosition;
        public String tagUID;
        public int shotsOnFilm;
        public int shotsUsed;
        public String filmType;
        public int colourLength;
        public int resinLength;
        public int overcoatLength;
        public int dyeFlags;
        public int dob;
        public int dyeFilmMfrId;
        public int dyeFilmProgId;
        public String lastMessage;
        private String StripString(String input)
        {
            String output;
            int pos = input.IndexOf('\0');
            if (pos >= 0)
                output = input.Substring(0, pos);
            else
                output = input;
            return output;
        }
        public MabelPrinterInfo(PrinterInfo _info)
        {
            model = StripString(new String(_info.sModel).TrimEnd('\0'));
            modelId = _info.eModel;
            connected = _info.bPrinterConnected;
            printerSerial = StripString(new String(_info.sPrinterSerial));
            printHeadSerial = StripString(new String(_info.sPrintheadSerial));
            PCBSerial = StripString(new String(_info.sPCBSerial));
            firmwareVersion = StripString(new String(_info.sFirmwareVersion));
            esDensity = _info.iES_Density;
            handFeed = _info.iHandFeed;
            cardsPrinted = _info.iCardsPrinted;
            cardsOnPrintHead = _info.iCardsOnPrinthead;
            dyePanelsPrinted =  _info.iDyePanelsPrinted;
            cleansSinceShipped =  _info.iCleansSinceShipped;
            dyePanelsSinceCleaned =  _info.iDyePanelsSinceClean;
            cardsSinceCleaned = _info.iCardsSinceClean;
            cardsBetweenCleans =  _info.iCardsBetweenCleans;
            printHeadPosition = _info.iPrintHeadPosn;
            imageStartPosition =  _info.iImageStartPosn;
            imageEndPosition =  _info.iImageEndPosn;
            tagUID = StripString(new String(_info.sTagUID));
            shotsOnFilm =  _info.iShotsOnFilm;
            shotsUsed =  _info.iShotsUsed;
            filmType = StripString(new String(_info.sDyeFilmType));
            colourLength = _info.iColourLength;
            resinLength =_info.iResinLength;
            overcoatLength =  _info.iOvercoatLength;
            dyeFlags = _info.eDyeFlags;
            dob = _info.iDOB;
            dyeFilmMfrId =  _info.eDyeFilmManuf;
            dyeFilmProgId = _info.eDyeFilmProg;
            if (_info.LastEnduroMessage != null)
                lastMessage = StripString(_info.LastEnduroMessage);
        }
    }

    public delegate void MabelEventHandler(object sender, MabelEventArgs e);

    public class MabelEventArgs : EventArgs
    {
        public String URL;
        public MabelResponse response;
        public MabelRequest request;
        public MabelEventArgs(String URL, MabelRequest request, MabelResponse response)
        {
            this.URL = URL;
            this.request = request;
            this.response = response;
        }
    }

    public class MabelResponse
    {
        public int code;
        public string message;
        public bool isError;
        public int count;
        public JToken results;
        public String _raw;
    }

    public class MabelRequest
    {
        private String _baseAddress;
        public String apiKey;
        public String modFunc;
        public MabelRequestParams param;
        public MabelRequest(MabelAPI api,String modFunc, MabelRequestParams param)
        {
            this.apiKey = Properties.Settings.Default.APIKey;
            this._baseAddress = api.getBaseUrl();
            this.modFunc = modFunc;
            this.param = param;
        }

        public String buildURL()
        {
            string jsonParameters = JsonConvert.SerializeObject(this);
            //jsonParameters = WebUtility.UrlEncode(jsonParameters);
            return _baseAddress + "?please=" + jsonParameters;
        }
    }
    public abstract class MabelRequestParams { };

    public class MabelPrinterRegisterParams : MabelRequestParams
    {
        public int printerId;
        public String name;
        public String location;
        public MabelPrinterInfo info;
        public MabelPrinterRegisterParams(int printerId,String name, String location, MabelPrinterInfo info)
        {
            this.printerId = printerId;
            this.name = name;
            this.location = location;
            this.info = info;
        }
    }

    public class MabelPrinterUnregisterParams : MabelRequestParams
    {
        public int printerId;

        public MabelPrinterUnregisterParams(int printerId)
        {
            this.printerId = printerId;
        }
    }

    public class MabelPrinterCheckVersionParams : MabelRequestParams
    {
        public int printerId;
        public MabelPrinterCheckVersionParams(int printerId)
        {
            this.printerId = printerId;
        }
    }

    public class MabelPrinterSetStatus : MabelRequestParams
    {
        public int printerId;
        public String status;
        public MabelPrinterSetStatus(int printerId,String status)
        {
            this.printerId = printerId;
            this.status = status;
        }

    }

    public class MabelSetCardStatusParams : MabelRequestParams {
        public int cardId;
        public String status;
        public MabelSetCardStatusParams(int cardId, String status)
        {
            this.cardId = cardId;
            this.status = status;
        }
    }

    public class MabelSetCardRfidParams : MabelRequestParams
    {
        public int printerId;
        public int cardId;
        public String rfid;
        public MabelSetCardRfidParams(int printerId, int cardId, String rfid)
        {
            this.printerId = printerId;
            this.cardId = cardId;
            this.rfid = rfid;
        }
    }

    public class MabelSetCardPrinterParams : MabelRequestParams
    {
        public int cardId;

        public MabelSetCardPrinterParams( int cardId)
        {
            this.cardId = cardId;
        }
    }

    public class MabelGetNextJobParams : MabelRequestParams
    {
        public int printerId;
        public MabelGetNextJobParams(int printerId)
        {
            this.printerId = printerId;
        }
    }

    public class MabelSetTokenParams : MabelRequestParams
    {
        public String token;
        public int printerId;
        public MabelSetTokenParams(String token,  int printerId)
        {
            this.token = token;
            this.printerId = printerId;
        }
    }

    public class MabelGetPendingPrints : MabelRequestParams
    {
        public int printerId;
        public MabelGetPendingPrints(int printerId)
        {
            this.printerId = printerId;
        }
    }
        
    /// <summary>
    /// Represents a card as generated in Mabel
    /// </summary>
    public class MabelCard
    {
        public int card_id;
        public String member_id;
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
        public String _baseUrl = "";
        public event MabelEventHandler Debug;
        public event MabelEventHandler Error;
        public MabelRequest lastRequest;
        public MabelResponse lastResponse;
        
        /// <summary>
        /// Gets the current base URL for this instance of the Mabel API. Defaults to the value in "settings" 
        /// if base url isn't specified - so if you have updated that Setting and want start using the new URL, you 
        /// need to create a new instance of Mabel API or use the setBaseUrl method to set the new base point.
        /// </summary>
        /// <returns></returns>
        public String getBaseUrl()
        {
            if (_baseUrl.Equals(""))
            {
                return Properties.Settings.Default.apiBaseUrl;
            } else
            {
                return this._baseUrl;
            }
        }

        /// <summary>
        /// Sets the base URL to use for this instance of the Mabel API (e.g. for testing connections)
        /// </summary>
        /// <param name="baseUrl"></param>
        public void setBaseUrl(String baseUrl)
        {
            this._baseUrl = baseUrl;
        }

        // event handlers
        protected virtual void OnDebug(MabelEventArgs e)
        {
            Debug?.Invoke(this, e);
        }

        protected virtual void OnError(MabelEventArgs e)
        {
            Error?.Invoke(this, e);
        }

        /// <summary>
        /// Makess a request to the Mabel API, using the specified request object
        /// </summary>
        /// <param name="mabelRequest">A build MabelRequest object with the desired params for the function call.</param>
        /// <returns></returns>
        private MabelResponse MakeRequest ( MabelRequest mabelRequest)
        {
            ServicePointManager.ServerCertificateValidationCallback = (s, cert, chain, ssl) => true;
            String url = mabelRequest.buildURL();
            WebRequest request = WebRequest.Create(url);
            request.Timeout = 3000;
            //request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.MutualAuthRequested;
            //request.Credentials = new NetworkCredential(Properties.Settings.Default.Username, Properties.Settings.Default.Password, Properties.Settings.Default.Domain);
            //request.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials;
            // Get the response.
            lastRequest = mabelRequest;
            MabelResponse mabelResponse = new MabelResponse();
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                lastResponse = mabelResponse;
            }
            catch (Exception ex)
            {
                mabelResponse.isError = true;
                mabelResponse.message = "HTTP EXCEPTION:" + ex.Message;
                // this may be overridden later... ?
            }
            if (response != null)
            { 
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                // Clean up the streams and the response.
                reader.Close();
                response.Close();
                mabelResponse._raw = responseFromServer;
            } else
            {
                // if there's no content, then the HTTP exception is as good as we're going to get
                OnDebug(new MabelEventArgs(url, mabelRequest, mabelResponse));
                return mabelResponse;
            }

            // Get the stream containing content returned by the server.
            JObject o;
            try { 
                o = JObject.Parse(mabelResponse._raw);
            } catch (Exception ex)
            {
                mabelResponse.isError = true;
                mabelResponse.message = "JSON Exception: " + ex.Message;
                OnDebug(new MabelEventArgs(url, mabelRequest, mabelResponse));
                return mabelResponse;
            }

            try { 
                mabelResponse.code = (int)o["meta"]["status"];
                mabelResponse.message = (string)o["meta"]["msg"];
                mabelResponse.count = (int)o["meta"]["count"];
            } catch (Exception ex2)
            {
                mabelResponse.isError = true;
                mabelResponse.message = "JSON Exception: meta fields: " + ex2.Message;
                OnDebug(new MabelEventArgs(url, mabelRequest, mabelResponse));
                return mabelResponse;
            }
            if (mabelResponse.code != 200)
            {
                // it's an error, return it now, don't bother looking for results
                mabelResponse.isError = true;
                OnError(new MabelEventArgs(url, mabelRequest, mabelResponse));
            }
            else
            {
                mabelResponse.isError = false;
            }
            // otherwise, hand back the results :)
            
            if (o["result"].Type != JTokenType.Null)
            {
                mabelResponse.results = o["result"];
            }
            else
            {
                mabelResponse.results = null;
            }
            
            OnDebug(new MabelEventArgs(url, mabelRequest, mabelResponse));
            
            return mabelResponse;
        }

        // API Functions  //

        /// <summary>
        /// Registers the printer
        /// </summary>
        /// <param name="printerId">The printer ID to register</param>
        /// <param name="printerName">The "name" of the printer (as in windows)</param>
        /// <param name="printerLocation">The location of the printer</param>
        /// <param name="printerModel">The model of the printer</param>
        /// <returns></returns>
        public MabelResponse RegisterPrinter(int printerId, string printerName, string printerLocation, PrinterInfo info)
        {
            MabelResponse response = MakeRequest(
                new MabelRequest(
                    this,
                    "cardPrinter.register", 
                    new MabelPrinterRegisterParams( printerId ,printerName ,printerLocation,new MabelPrinterInfo(info))
                 )
            );
            return response;
        }

        public MabelResponse MabelSays()
        {
            MabelResponse response = MakeRequest(
                new MabelRequest(
                    this,
                    "mabelSays",
                    null));
            return response;
        }

        /// <summary>
        /// Unregisters a printer
        /// </summary>
        /// <param name="printerId">The printer's ID</param>
        /// <returns></returns>
        public MabelResponse UnregisterPrinter(int printerId)
        {
            MabelResponse response = MakeRequest(
                new MabelRequest(
                    this,
                    "cardPrinter.unregister", 
                    new MabelPrinterUnregisterParams(printerId)
                   )
            );
            return response;
        }
        /// <summary>
        /// Checks the version of the API (not implemented)
        /// </summary>
        /// <returns></returns>
        public MabelResponse CheckVersion()
        {
            MabelResponse response = 
                MakeRequest(
                    new MabelRequest(
                        this,
                        "cardPrinter.checkVersion", 
                        null)
                 );
            return response;
        }
        /// <summary>
        /// Sets the status of a printer.
        /// </summary>
        /// <param name="printerId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public MabelResponse SetPrinterStatus(int printerId, string status)
        {
            MabelResponse response = 
                MakeRequest(new MabelRequest(
                    this,
                    "cardPrinter.printerSetStatus",
                    new MabelPrinterSetStatus(printerId,status)
                    )
                );
            return response;
        }

        /// <summary>
        /// Sets the status of a card via the API
        /// </summary>
        /// <param name="printerId"></param>
        /// <param name="card"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public MabelResponse SetCardStatus(int printerId, MabelCard card, string status)
        {
            MabelResponse response = MakeRequest(
                new MabelRequest(
                    this,
                    "cardHandler.setStatus",
                new MabelSetCardStatusParams(card.card_id, status)
                )
            );
            return response;

        }

        /// <summary>
        /// Sets a card's RFID via the API (deprecated)
        /// </summary>
        /// <param name="printerId"></param>
        /// <param name="card"></param>
        /// <param name="rfid"></param>
        /// <returns></returns>
        public MabelResponse SetCardRfid(int printerId, MabelCard card, String rfid)
        {
            MabelResponse response = MakeRequest(
                new MabelRequest(
                    this,
                    "cardPrinter.setStatus",
                    new MabelSetCardRfidParams( printerId, card.card_id, rfid)
                )
                );
            return response;
        }

        /// <summary>
        /// Sets a card's status to printed via the API.
        /// </summary>
        /// <param name="printerId"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        public MabelResponse SetCardPrinted(int printerId, MabelCard card)
        {
            MabelResponse response = MakeRequest(new MabelRequest(this,"cardHandler.setPrinted", 
                new MabelSetCardPrinterParams( card.card_id)
                ));
            return response;

        }

        /// <summary>
        /// Gets an array of cards pending to be printed.
        /// </summary>
        /// <param name="printerId"></param>
        /// <returns></returns>
        public MabelResponse GetPendingPrints(int printerId)
        {
            MabelResponse response = MakeRequest(new MabelRequest(this, "cardHandler.getPendingPrints", new
                MabelGetPendingPrints(printerId)));
            return response;
        }

        /// <summary>
        /// Sets the token on the last card that a printer requested.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="printerId"></param>
        /// <returns></returns>
        public MabelResponse SetToken(String token, int printerId)
        {
            MabelResponse response = MakeRequest(new MabelRequest(this, "cardHandler.capturedRFID",
                new MabelSetTokenParams(token,printerId)));
            return response;
        }

        /// <summary>
        /// Gets the next card enqueued to be printed
        /// </summary>
        /// <param name="printerId">The ID of the printer who is requesting the card</param>
        /// <returns></returns>
        public MabelCard GetNextJob(int printerId)
        {
            MabelRequest request = new MabelRequest(this, "cardHandler.getNextPrintJob", new MabelGetNextJobParams(printerId));
            MabelResponse response = MakeRequest(request);
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
                // throw an exception probably?
                throw new Exception("Problem with request to API: " + response.message);
             } 
             // otherwise...
             MabelCard card = new MabelCard();
             card.card_id = (int) response.results.SelectToken("cardId");
             card.member_id = response.results.SelectToken("memberId").ToString();

             card.card_front_image_encoded = (string)response.results.SelectToken("imageFront");
             card.card_back_image_encoded = (string)response.results.SelectToken("imageBack");
             return card;
        }

    }
}
