// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class bigone : Exchange
{
    public bigone (object args = null): base(args) {}

    public async Task<object> publicGetPing (object parameters = null)
    {
        return await this.callAsync ("publicGetPing",parameters);
    }

    public async Task<object> publicGetAssetPairs (object parameters = null)
    {
        return await this.callAsync ("publicGetAssetPairs",parameters);
    }

    public async Task<object> publicGetAssetPairsAssetPairNameDepth (object parameters = null)
    {
        return await this.callAsync ("publicGetAssetPairsAssetPairNameDepth",parameters);
    }

    public async Task<object> publicGetAssetPairsAssetPairNameTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetAssetPairsAssetPairNameTrades",parameters);
    }

    public async Task<object> publicGetAssetPairsAssetPairNameTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetAssetPairsAssetPairNameTicker",parameters);
    }

    public async Task<object> publicGetAssetPairsAssetPairNameCandles (object parameters = null)
    {
        return await this.callAsync ("publicGetAssetPairsAssetPairNameCandles",parameters);
    }

    public async Task<object> publicGetAssetPairsTickers (object parameters = null)
    {
        return await this.callAsync ("publicGetAssetPairsTickers",parameters);
    }

    public async Task<object> privateGetAccounts (object parameters = null)
    {
        return await this.callAsync ("privateGetAccounts",parameters);
    }

    public async Task<object> privateGetFundAccounts (object parameters = null)
    {
        return await this.callAsync ("privateGetFundAccounts",parameters);
    }

    public async Task<object> privateGetAssetsAssetSymbolAddress (object parameters = null)
    {
        return await this.callAsync ("privateGetAssetsAssetSymbolAddress",parameters);
    }

    public async Task<object> privateGetOrders (object parameters = null)
    {
        return await this.callAsync ("privateGetOrders",parameters);
    }

    public async Task<object> privateGetOrdersId (object parameters = null)
    {
        return await this.callAsync ("privateGetOrdersId",parameters);
    }

    public async Task<object> privateGetOrdersMulti (object parameters = null)
    {
        return await this.callAsync ("privateGetOrdersMulti",parameters);
    }

    public async Task<object> privateGetTrades (object parameters = null)
    {
        return await this.callAsync ("privateGetTrades",parameters);
    }

    public async Task<object> privateGetWithdrawals (object parameters = null)
    {
        return await this.callAsync ("privateGetWithdrawals",parameters);
    }

    public async Task<object> privateGetDeposits (object parameters = null)
    {
        return await this.callAsync ("privateGetDeposits",parameters);
    }

    public async Task<object> privatePostOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostOrders",parameters);
    }

    public async Task<object> privatePostOrdersIdCancel (object parameters = null)
    {
        return await this.callAsync ("privatePostOrdersIdCancel",parameters);
    }

    public async Task<object> privatePostOrdersCancel (object parameters = null)
    {
        return await this.callAsync ("privatePostOrdersCancel",parameters);
    }

    public async Task<object> privatePostWithdrawals (object parameters = null)
    {
        return await this.callAsync ("privatePostWithdrawals",parameters);
    }

    public async Task<object> privatePostTransfer (object parameters = null)
    {
        return await this.callAsync ("privatePostTransfer",parameters);
    }

    public async Task<object> contractPublicGetSymbols (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetSymbols",parameters);
    }

    public async Task<object> contractPublicGetInstruments (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetInstruments",parameters);
    }

    public async Task<object> contractPublicGetDepthSymbolSnapshot (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetDepthSymbolSnapshot",parameters);
    }

    public async Task<object> contractPublicGetInstrumentsDifference (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetInstrumentsDifference",parameters);
    }

    public async Task<object> contractPublicGetInstrumentsPrices (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetInstrumentsPrices",parameters);
    }

    public async Task<object> contractPrivateGetAccounts (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetAccounts",parameters);
    }

    public async Task<object> contractPrivateGetOrdersId (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetOrdersId",parameters);
    }

    public async Task<object> contractPrivateGetOrders (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetOrders",parameters);
    }

    public async Task<object> contractPrivateGetOrdersOpening (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetOrdersOpening",parameters);
    }

    public async Task<object> contractPrivateGetOrdersCount (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetOrdersCount",parameters);
    }

    public async Task<object> contractPrivateGetOrdersOpeningCount (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetOrdersOpeningCount",parameters);
    }

    public async Task<object> contractPrivateGetTrades (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetTrades",parameters);
    }

    public async Task<object> contractPrivateGetTradesCount (object parameters = null)
    {
        return await this.callAsync ("contractPrivateGetTradesCount",parameters);
    }

    public async Task<object> contractPrivatePostOrders (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostOrders",parameters);
    }

    public async Task<object> contractPrivatePostOrdersBatch (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePostOrdersBatch",parameters);
    }

    public async Task<object> contractPrivatePutPositionsSymbolMargin (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePutPositionsSymbolMargin",parameters);
    }

    public async Task<object> contractPrivatePutPositionsSymbolRiskLimit (object parameters = null)
    {
        return await this.callAsync ("contractPrivatePutPositionsSymbolRiskLimit",parameters);
    }

    public async Task<object> contractPrivateDeleteOrdersId (object parameters = null)
    {
        return await this.callAsync ("contractPrivateDeleteOrdersId",parameters);
    }

    public async Task<object> contractPrivateDeleteOrdersBatch (object parameters = null)
    {
        return await this.callAsync ("contractPrivateDeleteOrdersBatch",parameters);
    }

    public async Task<object> webExchangeGetV3Assets (object parameters = null)
    {
        return await this.callAsync ("webExchangeGetV3Assets",parameters);
    }

}