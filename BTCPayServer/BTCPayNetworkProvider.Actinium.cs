using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTCPayServer.Services.Rates;
using NBitcoin;
using NBXplorer;

namespace BTCPayServer
{
    public partial class BTCPayNetworkProvider
    {
        public void InitActinium()
        {
            var nbxplorerNetwork = NBXplorerNetworkProvider.GetFromCryptoCode("ACM");
            Add(new BTCPayNetwork()
            {
                CryptoCode = nbxplorerNetwork.CryptoCode,
                DisplayName = "Actinium",
                BlockExplorerLink = NetworkType == NetworkType.Mainnet ? "https://explorer.actinium.org/tx/{0}/" : "https://test-explorer.actinium.org/tx/{0}",
                NBitcoinNetwork = nbxplorerNetwork.NBitcoinNetwork,
                NBXplorerNetwork = nbxplorerNetwork,
                UriScheme = "Actinium",
                CryptoImagePath = "imlegacy/actinium.svg",
                LightningImagePath = "imlegacy/actinium-lightning.svg",
                DefaultSettings = BTCPayDefaultSettings.GetDefaultSettings(NetworkType),
                CoinType = NetworkType == NetworkType.Mainnet ? new KeyPath("2'") : new KeyPath("1'")
            });
        }
    }
}