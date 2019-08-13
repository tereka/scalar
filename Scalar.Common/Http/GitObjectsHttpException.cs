using System;
using System.Net;

namespace Scalar.Common.Http
{
    public class GitObjectsHttpException : Exception
    {
        public GitObjectsHttpException(HttpStatusCode statusCode, string ex) : base(ex)
        {
            this.StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; }
    }
}
