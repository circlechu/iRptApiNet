using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iRpt.Data.Entities;

namespace iRpt.Data.QueryProcessors
{
    public interface IFundQueryProcessor
    {
        void AddClient(Fund fund);

        Fund GetClient(long fundId);

        void UpdateClient(Fund fund);
    }
}
