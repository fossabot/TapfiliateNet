using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace TapfiliateNet.Model
{
    public class TapfiliateException : ApplicationException
    {
        public TapfiliateException(TapfiliateError tapfiliateError, string jsonPayLoad) : base(tapfiliateError.Error)
        {
            Json = jsonPayLoad;
            TapfiliateError = tapfiliateError;
        }

        public TapfiliateException(TapfiliateError tapfiliateError, string jsonPayLoad, Exception innerException) : base(tapfiliateError.Error, innerException)
        {
            Json = jsonPayLoad;
            TapfiliateError = tapfiliateError;
        }

        public string Json { get; set; }
        public TapfiliateError TapfiliateError { get; set; }
    }

    public class TapfiliateError
    {
        public int Code { get; set; }

        public string Error
        {
            get { return ValidationError != null && ValidationError.Any() ? ValidationError.First().Message : null; }
        }

        [JsonProperty("errors")]
        public IList<ValidationError> ValidationError { get; set; }
    }

    public class ValidationError
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}