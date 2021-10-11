<template>
  <nav class="side-nav">
    <ul class="menu">
      <li><router-link class="event-link" to="/">Homepage</router-link></li>
      <li>
        <router-link class="event-link" to="/advSearch"
          >Advanced Search</router-link
        >
      </li>
      <li>
        <router-link class="event-link" to="/newTrade">New Trade</router-link>
      </li>
      <li>
        <router-link class="event-link" to="/tradeCorrections"
          >Trade Corrections</router-link
        >
      </li>
      <li>
        <router-link class="event-link" to="/foreignTradeCorrections"
          >Foreign Trade Corrections</router-link
        >
      </li>
      <li>
        <router-link class="event-link" to="/NYSEsales"
          >NYSE Short Sales</router-link
        >
      </li>
      <li>
        <router-link class="event-link" to="/foreignTradeNew"
          >New Foreign Trade</router-link
        >
      </li>
      <li>
        <router-link class="event-link" to="/status"
          >Activity Status</router-link
        >
      </li>
      <li>
        <router-link class="event-link" to="/userActivity"
          >Users' Activity</router-link
        >
      </li>
      <li>
        <router-link class="event-link" to="/unsettledTrades"
          >Unsettled Trades</router-link
        >
      </li>
      <li>
        <router-link class="event-link" to="/accessControl"
          >Access Control</router-link
        >
      </li>
    </ul>
  </nav>
  <div class="container">
    <router-view />
  </div>
</template>

<style>
.modal-mask {
  position: fixed;
  z-index: 9998;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.5);
  display: table;
  transition: opacity 0.3s ease;
}

.modal-wrapper {
  display: table-cell;
  vertical-align: middle;
}

.modal-container {
  width: 300px;
  margin: 0px auto;
  padding: 20px 30px;
  background-color: #fff;
  border-radius: 2px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
  transition: all 0.3s ease;
  font-family: Helvetica, Arial, sans-serif;
}

.modal-header h3 {
  margin-top: 0;
  color: #42b983;
}

.modal-body {
  margin: 20px 0;
}

.modal-default-button {
  display: block;
  margin-top: 1rem;
}

.modal-enter {
  opacity: 0;
}

.modal-leave-active {
  opacity: 0;
}

.modal-enter .modal-container,
.modal-leave-active .modal-container {
  -webkit-transform: scale(1.1);
  transform: scale(1.1);
}

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

ul.menu {
  list-style-type: none;
  text-decoration: none;
}

nav {
  background-color: lightgray;
}

.side-nav {
  height: 100%;
  width: 200px;
  position: fixed;
  z-index: 1;
  top: 0;
  left: 0;
  overflow-x: hidden;
}

.event-link {
  text-decoration: none;
}

li {
  height: 35px;
  padding-bottom: 5px;
  padding-top: 5px;
}
</style>
