using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZillowAPIDemo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace ZillowAPIDemo.Service
{
    class ZillowService: IZillowService
    {
        public ZillowService()
        {

        }

        public SearchResult HomeSearch(HomeAddress address)
        {
            SearchResult result = new SearchResult();
            result.zpid = "33333";
            result.returnCode = "0";
            result.returnMessgae = "Success";
            result.StreetAddress = address.StreetAddress;
            return result;
        }
    }
}
