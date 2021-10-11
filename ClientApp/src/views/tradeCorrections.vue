<template>
  <div class="tradeCorrections">
    <div class="container-fluid">
      <div class="row">
        <div class="col-lg-7 bg-light" style="border: 2px solid black">
          <div class="row row-height">
            <div class="col-lg-3">
              <label for="tradeNumber">Trade #</label>
              <input
                id="tradeNumber"
                type="text"
                size="12"
                v-model="tradeNumber"
              />
            </div>
            <div class="col-lg-3">
              <label for="correctionNumber">Correction #</label>
              <input
                id="correctionNumber"
                type="text"
                size="2"
                v-model="correctionNumber"
              />
            </div>
            <div class="col-lg-2">
              <label for="Side">Side</label>
              <br />
              <select name="Side" id="Side" v-model="Side">
                <option value="null"></option>
                <option value="Buy">Buy</option>
                <option value="Sell">Sell</option>
              </select>
            </div>
            <div class="col-lg-4">
              <label for="quantity">Quantity</label>
              <input id="quantity" type="text" size="15" v-model="quantity" />
            </div>
          </div>
          <div class="row row-height">
            <div class="col-lg-3">
              <label for="accountNumber">Account #</label>
              <input
                id="accountNumber"
                type="text"
                size="12"
                v-model="accountNumber"
              />
            </div>
            <div class="col-lg-3">
              <label for="accountType">Account Type</label>
              <input
                id="accountType"
                type="text"
                size="2"
                v-model="accountType"
              />
            </div>
            <div class="col-lg-3">
              <label for="cusip">CUSIP</label>
              <input id="cusip" type="text" size="12" v-model="cusip" />
            </div>
            <div class="col-lg-3">
              <label for="symbol">Symbol</label>
              <input id="symbol" type="text" size="10" v-model="symbol" />
            </div>
          </div>
          <div class="row row-height">
            <div class="col-lg-3">
              <label for="whenIssue">When Issue</label>
              <br />
              <input id="whenIssue" type="checkbox" v-model="whenIssue" />
            </div>
            <div class="col-lg-2">
              <label for="price">Price</label>
              <input id="price" type="text" size="8" v-model="price" />
            </div>
            <div class="col-lg-3">
              <label for="tradeDate">Trade Date</label>
              <input id="tradeDate" type="date" v-model="tradeDate" />
            </div>
            <div class="col-lg-3">
              <label for="settleDate">Settle Date</label>
              <input id="settleDate" type="date" v-model="settleDate" />
            </div>
          </div>
          <div class="row row-height">
            <div class="col-lg-2">
              <label for="contraBroker">C.Broker</label>
              <input
                id="contraBroker"
                type="text"
                size="3"
                v-model="contraBroker"
              />
            </div>
            <div class="col-lg-4">
              <label for="commissionCode">Com. Concesion Code</label>
              <input id="commissionCode" type="text" v-model="commissionCode" />
            </div>
            <div class="col-lg-6">
              <label for="comissionConcessionSelection"
                >Com. Concession [More than 5%]</label
              >
              <br />
              <select
                name="commissionType"
                id="commissionType"
                v-model="commissionType"
              >
                <option value="null">?</option>
              </select>
              <label for="commissionAmount"></label>
              <input
                id="commissionAmount"
                type="text"
                v-model="commissionAmount"
              />
            </div>
          </div>
          <div class="row row-height">
            <div class="col-lg-2">
              <label for="regRep">RR</label>
              <input id="regRep" type="text" size="3" v-model="regRep" />
            </div>
            <div class="col-lg-4">
              <label for="largeTraderId">Large Trader ID</label>
              <input id="largeTraderId" type="text" v-model="largeTraderId" />
            </div>
            <div class="col-lg-6">
              <label for="rrCommInd">RR Comp. Type Comp.[More than 5%]</label>
              <br />
              <select name="rrCommInd" id="rrCommInd" v-model="rrCommInd">
                <option value="null">?</option>
              </select>
              <label for="rrCommIndValue"></label>
              <input id="rrCommIndValue" type="text" v-model="rrCommIndValue" />
            </div>
          </div>
          <div class="row row-height">
            <div class="col-lg-2">
              <label for="blotter">Blotter</label>
              <input id="blotter" type="text" size="2" v-model="blotter" />
            </div>
            <div class="col-lg-4">
              <label for="tradeType">Trade Type (SUDNT)</label>
              <br />
              <select name="tradeType" id="tradeType" v-model="tradeType">
                <option value="null">?</option>
              </select>
            </div>
            <div class="col-lg-3">
              <label for="prospectus">Prospectus</label>
              <br />
              <input id="prospectus" type="checkbox" v-model="prospectus" />
            </div>
            <div class="col-lg-3">Option Class</div>
          </div>
        </div>
        <div class="col-lg-5 bg-light" style="border: 2px solid black">
          <div class="row">
            <div class="col-lg-6">
              <label for="capacity"> Acting as... [Capacity] </label>
              <select name="capacity" id="capacity" v-model="capacity">
                <option value="agent">1 - We acted as your agent</option>
              </select>
            </div>
            <div class="col-lg-6">
              <label for="outsideTradeIndicator">Outisde Trade Ind.</label>
              <br />
              <select
                name="outsideTradeIndicator"
                id="outsideTradeIndicator"
                v-model="outsideTradeIndicator"
              >
                <option value="null">?</option>
              </select>
            </div>
          </div>
          <div><br /></div>
          <div class="row">
            <div class="col-lg-3">
              <label for="shortIndicator"> Short Ind. </label>
              <select
                name="shortIndicator"
                id="shortIndicator"
                v-model="shortInd"
              >
                <option value="null">?</option>
              </select>
            </div>
            <div class="col-lg-3">
              <label for="transactionType">Trans. Type</label>
              <input
                id="transactionType"
                type="checkbox"
                v-model="transactionType"
              />
            </div>
            <div class="col-lg-6">
              <label for="confirmation">Confirmation</label>
              <select
                name="confirmation"
                id="confirmation"
                v-model="confirmation"
              >
                <option value="null">_________</option>
              </select>
            </div>
          </div>
          <div><br /></div>
          <div class="row">
            <div class="col-lg-4">
              <div><br /></div>
              <div>Interface Codes</div>
              <div>
                <label for="interfaceCodes"></label>
                <input
                  id="interfaceCodes"
                  type="text"
                  class="side-input"
                  v-model="interfaceCodes"
                />
              </div>
              <div><br /></div>
              <div>Maturity Yield</div>
              <div>
                <label for="maturityYield"></label>
                <input
                  id="maturityYield"
                  type="text"
                  class="side-input"
                  v-model="maturityYield"
                />
              </div>
              <div><br /></div>
              <div>Worst Yield</div>
              <div>
                <label for="worstYield"></label>
                <input
                  id="worstYield"
                  type="text"
                  class="side-input"
                  v-model="worstYield"
                />
              </div>
              <div><br /></div>
              <div>To-Call Yield</div>
              <div>
                <label for="toCallYield"></label>
                <input
                  id="toCallYield"
                  type="text"
                  class="side-input"
                  v-model="toCallYield"
                />
              </div>
            </div>
            <div class="col-lg-8">
              <table
                class="table-align bg-table"
                style="border: 2px sold black"
              >
                <tr>
                  <td>Principal</td>
                  <td>
                    <label for="principal"></label>
                    <input
                      id="principal"
                      type="text"
                      class="table-input"
                      v-model="principal"
                    />
                  </td>
                </tr>
                <tr>
                  <td class="table-align">Interest</td>
                  <td>
                    <label for="interest"></label>
                    <input
                      id="interest"
                      type="text"
                      class="table-input"
                      v-model="interest"
                    />
                  </td>
                </tr>
                <tr>
                  <td class="table-align">Comission</td>
                  <td>
                    <label for="commission"></label>
                    <input
                      id="commission"
                      type="text"
                      class="table-input"
                      v-model="commission"
                    />
                  </td>
                </tr>
                <tr>
                  <td class="table-align">Sec Fee</td>
                  <td>
                    <label for="secFee"></label>
                    <input
                      id="secFee"
                      type="text"
                      class="table-input"
                      v-model="secFee"
                    />
                  </td>
                </tr>
                <tr>
                  <td class="table-align">Serv.Charge</td>
                  <td>
                    <label for="serviceCharge"></label>
                    <input
                      id="serviceCharge"
                      type="text"
                      class="table-input"
                      v-model="serviceCharge"
                    />
                  </td>
                </tr>
                <tr>
                  <td class="table-align">Fin.Tran.Tax</td>
                  <td>
                    <label for="finTranTax"></label>
                    <input
                      id="finTranTax"
                      type="text"
                      class="table-input"
                      v-model="finTranTax"
                    />
                  </td>
                </tr>
                <tr>
                  <td class="table-align">Net</td>
                  <td>
                    <label for="net"></label>
                    <input
                      id="net"
                      type="text"
                      class="table-input"
                      v-model="net"
                    />
                  </td>
                </tr>
                <tr>
                  <td class="table-align">Prefigured</td>
                  <td>
                    <label for="prefigured"></label>
                    <input
                      id="prefigured"
                      type="checkbox"
                      v-model="prefigured"
                    />
                  </td>
                </tr>
              </table>
              <div>
                Riskless Principal
                <label for="risklessPrincipal"></label>
                <input
                  id="risklessPrincipal"
                  type="checkbox"
                  v-model="risklessPrincipal"
                />
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-1">
          <label for="syndicateIndex">Synd.Ind.</label>
          <select
            name="syndicateIndex"
            id="syndicateIndex"
            v-model="syndicateIndex"
          >
            <option value="null">?</option>
          </select>
        </div>
        <div class="col-lg-1">
          <label for="priceIndex">PriceInd.</label>
          <select name="priceIndex" id="priceIndex" v-model="priceIndex">
            <option value="null">?</option>
          </select>
        </div>
        <div class="col-lg-1">
          <label for="donotCollapse">DoNotColl.</label>
          <input type="checkbox" name="donotCollapse" v-model="donotCollapse" />
        </div>
        <div class="col-lg-1">
          <label for="singleMultiExec">Exec.Ind</label>
          <select
            name="singleMultiExec"
            id="singleMultiExec"
            v-model="singleMultiExec"
          >
            <option value="null">?</option>
          </select>
        </div>
        <div class="col-lg-1">
          <label for="destExchange">Dest.Exch</label>
          <input
            type="text"
            id="destExchange"
            v-model="destExchange"
            class="input-small"
          />
        </div>
        <div class="col-lg-1">
          <label for="badge">Badge</label>
          <input type="text" id="badge" v-model="badge" class="input-small" />
        </div>
        <div class="col-lg-2">
          <label for="orderExecTime">Order Exec.Time</label>
          <input
            id="orderExecTime"
            type="text"
            v-model="orderExecTime"
            class="input-small"
          />
        </div>
        <div class="col-lg-2">
          <label for="orderDestination">Order Destination</label>
          <input
            id="orderDestination"
            type="text"
            v-model="orderDestination"
            class="input-small"
          />
        </div>
        <div class="col-lg-2">
          <label for="originalOrderNumber">Org. Order Number</label>
          <input
            id="originalOrderNumber"
            type="text"
            v-model="originalOrderNumber"
            class="input-small"
          />
        </div>
      </div>
      <div class="row">
        <div class="col-lg-1">
          <label for="euroClear">EuroClear</label>
          <input
            id="euroClear"
            type="text"
            v-model="euroClear"
            class="input-small"
          />
        </div>
        <div class="col-lg-1">
          <label for="frnPriceCurrencyCode">Currency</label>
          <input
            type="text"
            id="frnPriceCurrencyCode"
            v-model="frnPriceCurrencyCode"
            class="input-small"
          />
        </div>
        <div class="col-lg-1">
          <label for="securityAgent">Sec.Agent</label>
          <select
            name="securityAgent"
            id="securityAgent"
            v-model="securityAgent"
          >
            <option value="null">?</option>
          </select>
        </div>
        <div class="col-lg-1">
          <label for="moneyAgent">MoneyAgent</label>
          <select name="moneyAgent" id="moneyAgent" v-model="moneyAgent">
            <option value="null">?</option>
          </select>
        </div>
        <div class="col-lg-1">
          <label for="execBroker">Exec.Brok</label>
          <input
            type="text"
            id="execBroker"
            v-model="execBroker"
            class="input-small"
          />
        </div>
        <div class="col-lg-1">
          <label for="tradeSynonym">TradeSyn</label>
          <input
            type="text"
            id="tradeSynonym"
            v-model="tradeSynonym"
            class="input-small"
          />
        </div>
        <div class="col-lg-2">
          <label for="autoTrailer">Auto Trailer</label>
          <br />
          <input type="checkbox" id="autoTrailer" v-model="autoTrailer" />
        </div>
        <div class="col-lg-2">
          <label for="correctionDateTime">Correction Date/Time</label>
          <input
            type="text"
            id="correctionDateTime"
            v-model="correctionDateTime"
            class="input-small"
          />
        </div>
        <div class="col-lg-2">
          <label for="obligationWarehouseId">Obligation Warehouse</label>
          <input
            type="text"
            id="obligationWarehouseId"
            v-model="obligationWarehouseId"
            class="input-small"
          />
        </div>
      </div>
      <div class="row">
        <div class="col-lg-3">
          <label for="trailer1">Trailer 1</label>
          <input type="text" name="trailer1" id="trailer1" v-model="trailer1" />
        </div>
        <div class="col-lg-3">
          <label for="trailer1">Trailer 2</label>
          <input type="text" name="trailer2" id="trailer2" v-model="trailer2" />
        </div>
        <div class="col-lg-3">
          <label for="trailer1">Trailer 3</label>
          <input type="text" name="trailer3" id="trailer3" v-model="trailer3" />
        </div>
        <div class="col-lg-3">
          <label for="trailer1">Trailer 4</label>
          <input type="text" name="trailer4" id="trailer4" v-model="trailer4" />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  props: {
    id: String,
  },
  data() {
    return {
      tradeNumber: "",
      correctionNumber: "",
      Side: "",
      quantity: "",
      accountNumber: "",
      accountType: "",
      cusip: "",
      symbol: "",
      isOptionSymbol: false,
      optionSymbol: "",
      whenIssue: false,
      price: "",
      tradeDate: "",
      settleDate: "",
      contraBroker: "",
      commissionCode: "",
      commissionType: "",
      commissionAmount: "",
      regRep: "",
      largeTraderId: "",
      rrCommInd: "",
      rrCommIndValue: "",
      blotter: "",
      tradeType: "",
      prospectus: false,
      capacity: "",
      outsideTradeIndicator: "",
      shortIndicator: "",
      transactionType: "",
      confirmation: "",
      interfaceCodes: "",
      maturityYield: "",
      worstYield: "",
      toCallYield: "",
      principal: "",
      interest: "",
      commission: "",
      secFee: "",
      serviceCharge: "",
      finTranTax: "",
      net: "",
      prefigured: false,
      risklessPrincipal: false,
      syndicateIndex: "",
      priceIndex: "",
      donotCollapse: false,
      singleMultiExec: "",
      destExchange: "",
      badge: "",
      orderExecTime: "",
      orderDestination: "",
      originalOrderNumber: "",
      euroClear: "",
      frnPriceCurrencyCode: "",
      securityAgent: "",
      moneyAgent: "",
      execBroker: "",
      tradeSynonym: "",
      autoTrailer: "",
      correctionDateTime: "",
      obligationWarehouseId: "",
      trailer1: "",
      trailer2: "",
      trailer3: "",
      trailer4: "",
    };
  },
  created() {
    axios
      .get(
        "https://my-json-server.typicode.com/alvinyin/tradeCorrections/trades/" +
          this.id
      )
      .then((res) => {
        let tc = res.data;
        this.tradeNumber = tc.tradeNumber;
        this.tradeDate = this.changeDate(tc.tradeDate);
        this.settleDate = this.changeDate(tc.settleDate);
        this.Side = tc.Side;
        this.blotter = tc.blotter;
        this.cusip = tc.cusip;
        this.symbol = tc.symbol;
        this.quantity = tc.quantity;
        this.price = tc.price;
        this.account = tc.account;
        this.rr = tc.rr;
        this.principal = tc.principal;
        this.net = tc.net;
        this.contraBroker = tc.contraBroker;
        this.frnPriceCurrencyCode = tc.currency;
        this.status = tc.status;
        console.log(this.id);
      })
      .catch((error) => {
        console.error(error);
      });
  },
  methods: {
    changeDate(prevDate) {
      let tempDate = "";
      tempDate =
        prevDate.slice(6, 10) +
        "-" +
        prevDate.slice(0, 2) +
        "-" +
        prevDate.slice(3, 5);
      return tempDate;
    },
  },
};
</script>

<style scoped>
.input-middle {
  width: 150px;
}
.row-height {
  height: 80px;
}
.table-input {
  width: 160px;
}
.side-input {
  width: 80px;
}
.table-align {
  text-align: right;
}
.bg-table {
  background-color: lightslategray;
}
.input-small {
  width: 60px;
}
</style>
