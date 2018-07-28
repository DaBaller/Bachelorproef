﻿using RiotSharp.Misc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RiotSharp.Http.Interfaces
{
    public interface IRequester
    {
        /// <summary>
        /// Create a get request and send it asynchronously to the server.
        /// </summary>
        /// <param name="relativeUrl"></param>
        /// <param name="region"></param>
        /// <param name="queryParameters"></param>
        /// <param name="useHttps"></param>
        /// <returns>The content of the response.</returns>
        /// <exception cref="RiotSharpException">
        /// Thrown if an Http error occurs. 
        /// Contains the Http error code and error message.
        /// </exception>
        Task<string> CreateGetRequestAsync(string relativeUrl, Region region,
            List<string> queryParameters = null, bool useHttps = true);

        /// <summary>
        ///  Create a get request and send it asynchronously to the server.
        /// </summary>
        /// <param name="absoluteUrl"></param>
        /// <returns></returns>
        Task<string> CreateGetRequestAsync(string host, string relativeUrl,
            List<string> queryParameters = null, bool useHttps = true);
    }
}
