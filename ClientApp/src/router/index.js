import { createRouter, createWebHistory } from "vue-router";
import Home from "../views/Home.vue";
import advancedSearch from "../views/advSearch.vue";
import foreignTradeCorrections from "../views/foreignTradeCorrections.vue";
import foreignTradeNew from "../views/foreignTradeNew.vue";
import newTrade from "../views/newTrade.vue";
import NYSEsales from "../views/NYSEsales.vue";
import status from "../views/status.vue";
import tradeCorrections from "../views/tradeCorrections.vue";
import unsettledTrades from "../views/unsettledTrades.vue";
import userActivity from "../views/userActivity.vue";
import accessControl from "../views/accessControl.vue";

const routes = [
  {
    path: "/",
    name: "Home",
    component: Home,
  },
  {
    path: "/advSearch",
    name: "Advanced Search",
    component: advancedSearch,
  },
  {
    path: "/foreignTradeCorrections",
    name: "Foreign Trade Corrections ",
    component: foreignTradeCorrections,
  },
  {
    path: "/foreignTradeNew",
    name: "New Foreign Trade",
    component: foreignTradeNew,
  },
  {
    path: "/newTrade",
    name: "New Trade",
    component: newTrade,
  },
  {
    path: "/NYSEsales",
    name: "NYSE Short Sales",
    component: NYSEsales,
  },
  {
    path: "/status",
    name: "Status",
    component: status,
  },
  {
    path: "/tradeCorrections",
    name: "Trade Corrections",
    component: tradeCorrections,
    props: true,
  },
  {
    path: "/unsettledTrades",
    name: "Unsettled Trades",
    component: unsettledTrades,
  },
  {
    path: "/userActivity",
    name: "Users Activity",
    component: userActivity,
  },
  {
    path: "/accessControl",
    name: "Access Control",
    component: accessControl,
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
