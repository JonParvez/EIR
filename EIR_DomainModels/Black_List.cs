using System;
using System.Collections.Generic;
using System.Text;

namespace EIR_DomainModels
{
    public class Black_List
    {
        public int Id { get; set; }
        public long Subscriber_Id { get; set; }
        public DateTime? Created_At { get; set; }
        public string Created_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public string Updated_By { get; set; }
    }
}
