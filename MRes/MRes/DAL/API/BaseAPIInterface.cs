using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRes.DAL.API
{
    interface BaseAPIInterface
    {
        string All(string url, NameValueCollection table, string Method);
        string Get(string url);
    }
}
