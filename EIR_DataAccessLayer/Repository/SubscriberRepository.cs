using Dapper;
using EIR_DataAccessLayer.Interface;
using EIR_DomainModels;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace EIR_DataAccessLayer.Repository
{
    public class SubscriberRepository : BaseRepository, ISubscriberRepository
    {
        public SubscriberRepository(IConfiguration configuration)
            : base(configuration)
        { }
        public async Task<bool> CheckMSISDN(string IMEI, string IMSI)
        {
            try
            {
                var query = "SELECT * FROM subscriber WHERE imei = @imei AND imsi = @imsi";

                var parameters = new DynamicParameters();
                parameters.Add("imei", IMEI, DbType.String);
                parameters.Add("imsi", IMSI, DbType.String);

                using (var connection = CreateConnection())
                {
                    var subscriber = await connection.QueryFirstOrDefaultAsync<Subscriber>(query, parameters);
                    if (subscriber != null)
                    {
                        if (!string.IsNullOrEmpty(subscriber.msisdn))
                            return true;
                        else return false;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
