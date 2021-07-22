using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EIR_DataAccessLayer.Interface
{
    public interface ISubscriberRepository
    {
        Task<bool> CheckMSISDN(string IMEI, string IMSI);
    }
}
