﻿// Copyright (c) 2014 George Kimionis
// Distributed under the GPLv3 software license, see the accompanying file LICENSE or http://opensource.org/licenses/GPL-3.0

using System;
using BitcoinLib.CoinParameters.Bitcoin;

namespace BitcoinLib.Services.Coins.Bitcoin
{
    public class BitcoinService : CoinService, IBitcoinService
    {
        public BitcoinService(Boolean useTestnet = false) : base(useTestnet)
        {
        }

        public BitcoinService(String daemonUrl, String rpcUsername, String rpcPassword, String walletPassword) 
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword)
        {
        }

        public BitcoinService(String daemonUrl, String rpcUsername, String rpcPassword, String walletPassword, Int16 rpcRequestTimeoutInSeconds)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword, rpcRequestTimeoutInSeconds)
        {
        }

        public BitcoinConstants.Constants Constants => BitcoinConstants.Constants.Instance;
    }
}