using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EIR_BusinessLayer.Interface
{
    public interface ISubscriberService
    {
        Task<bool> CheckMSISDN(string IMEI, string IMSI);
    }
}
