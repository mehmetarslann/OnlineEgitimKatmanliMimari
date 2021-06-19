using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message):this(success)
        {
            Message = message;
            Succcess = success;
        }
        public Result(bool success)
        {
            Succcess = success;
        }

        public bool Succcess { get; }

        public string Message { get; }
    }
}
