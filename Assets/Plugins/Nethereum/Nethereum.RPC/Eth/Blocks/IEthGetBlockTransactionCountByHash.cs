﻿using System.Threading.Tasks;
using Nethereum.Hex.HexTypes;
using Nethereum.JsonRpc.Client;

namespace Nethereum.RPC.Eth.Blocks
{
    public interface IEthGetBlockTransactionCountByHash
    {
        RpcRequest BuildRequest(string hash, object id = null);
        Task<HexBigInteger> SendRequestAsync(string hash, object id = null);
    }
}