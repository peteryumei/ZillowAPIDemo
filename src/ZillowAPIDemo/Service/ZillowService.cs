using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZillowAPIDemo.Models;

namespace ZillowAPIDemo.Service
{
    public class ZillowService: IZillowService
    {
        public ZillowService()
        {

        }

        SearchResult HomeSearch(HomeAddress address)
        {
            return new SearchResult();
        }
    }
}
