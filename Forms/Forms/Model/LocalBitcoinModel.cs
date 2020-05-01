using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forms.Model
{

    public partial class LCB
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("receiving_address")]
        public string ReceivingAddress { get; set; }

        [JsonProperty("received_transactions_30d")]
        public Transactions30_D[] ReceivedTransactions30D { get; set; }

        [JsonProperty("old_address_list")]
        public OldAddressList[] OldAddressList { get; set; }

        [JsonProperty("sent_transactions_30d")]
        public Transactions30_D[] SentTransactions30D { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("total")]
        public Total Total { get; set; }
    }

    public partial class OldAddressList
    {
        [JsonProperty("received")]
        public string Received { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public partial class Transactions30_D
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tx_type")]
        public long TxType { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("txid")]
        public object Txid { get; set; }
    }

    public partial class Total
    {
        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("sendable")]
        public string Sendable { get; set; }
    }
}
