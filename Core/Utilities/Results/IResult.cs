using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Base void method starter interface
    public interface IResult
    {
        bool Success { get; }
        string Message { get;}
    }
}
