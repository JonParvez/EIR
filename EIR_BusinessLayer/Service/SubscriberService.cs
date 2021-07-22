using EIR_BusinessLayer.Interface;
using EIR_BusinessLayer.Utility;
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
        private readonly CommunicationService communicationService;

        public SubscriberService(ISubscriberRepository subscriberRepository)
        {
            _subscriberRepository = subscriberRepository;
            communicationService = new CommunicationService();
        }
        public async Task<bool> CheckMSISDN(string IMEI, string IMSI)
        {
            return await _subscriberRepository.CheckMSISDN(IMEI, IMSI);
        }

        public dynamic GetHandsetStatus()
        {
            dynamic requestObj = new object();
            return communicationService.GetRequest<dynamic>("http://sdf.com");
        }
    }
}
