using System;
using System.Collections.Generic;
using System.Text;

namespace EIR_DomainModels
{
    public class Subscriber
    {
        public long id { get; set; }
        public string imei { get; set; }
        public string msisdn { get; set; }
        public string imsi { get; set; }
        public string nid_number { get; set; }
        public string passport_number { get; set; }
        public long white_list_id { get; set; }
        public long grey_list_id { get; set; }
        public long black_list_id { get; set; }
        public long vip_list_id { get; set; }
        public long lost_or_stolen_list_id { get; set; }
        public long roaming_list_id { get; set; }
        public string device_id { get; set; }
        public byte corporate_flag { get; set; }
        public DateTime created_at { get; set; }
        public string created_by { get; set; }
        public DateTime updated_at { get; set; }
        public string updated_by { get; set; }
    }
}
