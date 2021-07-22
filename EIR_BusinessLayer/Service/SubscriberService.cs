using EIR_BusinessLayer.Interface;
using EIR_DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EIR_BusinessLayer.Service
{
    public class SubscriberService : ISubscriberService
    {
        private readonly ISubscriberRepository _subscriberRepository;

        public SubscriberService(ISubscriberRepository subscriberRepository)
        {
            _subscriberRepository = subscriberRepository;
        }
        public async Task<bool> CheckMSISDN(string IMEI, string IMSI)
        {
            return await _subscriberRepository.CheckMSISDN(IMEI, IMSI);
        }
    }
}
