﻿using System.Collections.Generic;
using System.Net;
using System.Text.Json;
namespace Cloth.Application
{
    public class ReadJsonFromUrl
    {
        private readonly string _sampleDataFromUrl;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };
        public ReadJsonFromUrl(string sampleJsonFilePath)
        {
            _sampleDataFromUrl = sampleJsonFilePath;
        }

        /// <summary>
        /// Creates a request to get the data and deserializes the response to create a list of items
        /// </summary>
        /// <returns></returns>
        public List<Domain.Cloth> UseReadJson()
        {
            WebRequest request = HttpWebRequest.Create(_sampleDataFromUrl);

            WebResponse response = request.GetResponse();

            var cloths = JsonSerializer.Deserialize<List<Domain.Cloth>>(response.GetResponseStream(), _options);
            return cloths;
        }
    }
}
