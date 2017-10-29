using System;

namespace iRpt.Common.Adapters
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
        DateTime Now { get; }
    }
}