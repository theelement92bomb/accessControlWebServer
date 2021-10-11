<template>
  <div class="container-fluid advSearch">
    <!-- <form submit="search"> -->
    <div class="panel panel-primary" style="margin-top: 10px">
      <div class="panel-body">
        <div class="row">
          <div class="col-lg-8">
            <!-- <input type="submit" @click="search"> -->
            <button class="btn-primary" @click="search">Search</button>
          </div>
        </div>
      </div>
    </div>

    <div class="panel panel-primary" style="margin-top: 10px">
      <div class="panel-body">
        <div class="row">
          <div class="col-lg-4">
            <label for="account">Account </label>
            <input
              id="account"
              type="text"
              v-model="account"
              size="10"
              maxlength="10"
            />
          </div>
          <div class="col-lg-4">
            <label for="order">Order</label>
            <input id="order" type="text" v-model="order" />
          </div>
          <div class="col-lg-4">
            <label for="cusip">CUSIP</label>
            <input id="cusip" type="text" v-model="cusip" />
          </div>
        </div>
        <div class="row">
          <div class="col-lg-4">
            <label for="RR">RR </label>
            <input id="RR" type="text" v-model="RR" size="4" maxlength="4" />
          </div>
          <div class="col-lg-4">
            <label for="side">Side</label>
            <select name="side" id="side" v-model="side">
              <option value="">Select</option>
              <option value="buy">Buy</option>
              <option value="sell">Sell</option>
            </select>
          </div>
          <div class="col-lg-4">
            <label for="price">Price</label>
            <input id="price" type="text" v-model="price" />
          </div>
        </div>
        <div class="row">
          <div class="col-lg-4">
            <label for="blotter">Blotter </label>
            <input id="blotter" type="text" v-model="blotter" />
          </div>
          <div class="col-lg-4">
            <label for="tradeDate">Trade date</label>
            <input id="tradeDate" type="date" v-model="tradeDate" />
          </div>
          <div class="col-lg-4">
            <label for="settleDate">Settle Date</label>
            <input id="settleDate" type="date" v-model="settleDate" />
          </div>
        </div>
        <div class="row">
          <div class="col-lg-4">
            <label for="wIssue">W/ Issue </label>
            <select name="wIssue" id="wIssue" v-model="wIssue">
              <option value="null">Select</option>
              <option value="trueIssue">True</option>
              <option value="falseIssue">False</option>
            </select>
          </div>
          <div class="col-lg-4">
            <label for="cBroker">c/ Broker</label>
            <input id="cBroker" type="text" v-model="cBroker" />
          </div>
          <div class="col-lg-4"></div>
        </div>
      </div>
      <!-- </form> -->
      <table border="1">
        <tr>
          <th>Display Details</th>
          <th>Trade Number</th>
          <th>T/Date</th>
          <th>S/Date</th>
          <th>Side</th>
          <th>Blotter</th>
          <th>CUSIP</th>
          <th>Qty</th>
          <th>Price</th>
          <th>Account</th>
          <th>RR</th>
          <th>C/Broker</th>
          <th>Display ID</th>
        </tr>
        <tr v-for="(trade, id) in trades" :key="id">
          <td><button @click="viewTrade(trade.id)">Details</button></td>
          <td>{{ trade.tradeNumber }}</td>
          <td>{{ trade.tradeDate }}</td>
          <td>{{ trade.settleDate }}</td>
          <td>{{ trade.Side }}</td>
          <td>{{ trade.blotter }}</td>
          <td>{{ trade.cusip }}</td>
          <td>{{ trade.quantity }}</td>
          <td>{{ trade.price }}</td>
          <td>{{ trade.account }}</td>
          <td>{{ trade.rr }}</td>
          <td>{{ trade.contraBroker }}</td>
          <td><button @click="displayID(trade.id)">ID</button></td>
        </tr>
      </table>
    </div>
    <div v-if="myModal">
      <transition name="modal">
        <div class="modal-mask">
          <div class="modal-wrapper">
            <IDModal :id="idNum" @myClose="myModal = false"></IDModal>
          </div>
        </div>
      </transition>
    </div>
  </div>
</template>

<script>
import axios from "axios";
import IDModal from "@/components/IDModal.vue";

export default {
  data() {
    return {
      account: "",
      order: "",
      cusip: "",
      rr: "",
      Side: "",
      price: "",
      blotter: "",
      tradeDate: "",
      settleDate: "",
      wIssue: "",
      contraBroker: "",
      quantity: "",
      tradeNumber: "",
      trades: [],
      myModal: false,
      idNum: "",
    };
  },
  methods: {
    search() {
      axios
        .get(
          "https://my-json-server.typicode.com/alvinyin/tradeCorrections/trades"
        )
        .then((res) => {
          console.log(JSON.stringify(res.data));
          this.trades = res.data;
        })
        .catch((error) => {
          console.error(error);
        });
    },
    displayID(id) {
      this.myModal = true;
      this.idNum = id;
    },
    viewTrade(id) {
      this.$router.push({
        name: "Trade Corrections",
        params: { id: id.toString() },
      });
    },
  },
  components: {
    IDModal,
  },
};
</script>

<style scoped>
.section {
  text-align: left;
}
</style>
