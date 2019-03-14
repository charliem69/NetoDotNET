﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetoDotNET
{
    class StoreController
    {
        private const string _baseEndpoint = @"/do/WS/NetoAPI";
        private readonly string _storeName;
        private readonly string _APIkey;
        private readonly string _username;

        public string StoreName => _storeName;
        public string APIkey => _APIkey;
        public string Username => _username;

        /// <summary>
        /// Create a new instance of <see cref="StoreController" />.
        /// </summary>
        /// <param name="storeName">The name of the Neto store https://www.*storeName*.com.au</param>
        /// <param name="APIKey">Your Neto API Secure Key (generate this in your Neto control panel).</param>
        /// <param name="username">Your Neto API username (managed under Staff Users in the Neto control panel). Not required if using a key.</param>
        public StoreController(string storeName, string APIKey, string username)
        {
            if (string.IsNullOrEmpty(storeName))
            {
                throw new ArgumentException("Missing Neto store name.", nameof(storeName));
            }

            if (string.IsNullOrEmpty(APIKey))
            {
                throw new ArgumentException("Missing Neto store API key.", nameof(APIKey));
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Missing Neto username", nameof(username));
            }

            this._storeName = storeName;
            this._APIkey = APIKey;
            this._username = username;
        }

       
    }
}
