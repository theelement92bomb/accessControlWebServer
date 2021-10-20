<template>
  <div class="accessControl">
    <h1>Access Control</h1>
    <div class="container-fluid">
      <div class="row">
        <div class="col-lg-6">
          <h2>User</h2>
        </div>
        <div class="col-lg-6">
          <h2>Role-Blotters</h2>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-6">
          <button @click="addNew()">New</button>
        </div>
        <div class="col-lg-6">
          <button @click="update()">Update</button>
        </div>
      </div>
      <div class="row">
        <div class="col-lg-4">
          <table>
            <tr>
              <td>
                <label for="userId">User Id</label>
              </td>
              <td>
                <input id="userId" type="text" v-model="currentUser.UserId"  />
              </td>
            </tr>
            <tr>
              <td>
                <label for="lastName">Last Name</label>
              </td>
              <td>
                <input id="lastName" type="text" v-model="currentUser.LastName" />
              </td>
            </tr>
            <tr>
              <td>
                <label for="firstName">First Name</label>
              </td>
              <td>
                <input
                  id="firstName"
                  type="text"
                  v-model="currentUser.FirstName"
                />
              </td>
            </tr>
            <tr>
              <td>
                <label for="department">Department</label>
              </td>
              <td>
                <input id="department" type="text" v-model="currentUser.Department" />
              </td>
            </tr>
          </table>
        </div>
        <div class="col-lg-8">
          <h3>TCS Users</h3>
          <button @click="search">Refresh</button>
          <table border="1" class="dataTable">
            <tr>
              <th>User Id</th>
              <th>Last Name</th>
              <th>First Name</th>
              <th>Department</th>
            </tr>
            <tr v-for="user in users" :key="user.userId">
              <td>{{user.userId}}</td>
              <td>{{user.lastName}}</td>
              <td>{{user.firstName}}</td>
              <td>{{user.department}}</td>
            </tr>
          </table>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  data() {
    return {
      currentUser: {},
      users: [],
    };
  },
  methods: {
    search() {
      axios
        .get(
          "UserAccess/Users"
        )
        .then((res) => {
          this.users = res.data;
        })
        .catch((error) => {
          console.error(error);
        });
    },
    update() {
      return;
    },
    addNew() {
      // alert(`Add New User ${JSON.stringify(this.currentUser)}`);
      axios
        .post(
          "UserAccess/AddUser", this.currentUser
        )
        .catch((error) => {
          console.error(error);
        });
    },
  },
};
</script>

<style scoped>
.dataTable{
  width: 600px;
}
</style>
