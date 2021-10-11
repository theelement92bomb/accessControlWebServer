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
                <input id="userId" type="text" v-model="fieldUserId"  />
              </td>
            </tr>
            <tr>
              <td>
                <label for="lastName">Last Name</label>
              </td>
              <td>
                <input id="lastName" type="text" v-model="fieldLastName" />
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
                  v-model="fieldFirstName"
                />
              </td>
            </tr>
            <tr>
              <td>
                <label for="branch">Branch</label>
              </td>
              <td>
                <input id="branch" type="text" v-model="fieldBranch" />
              </td>
            </tr>
          </table>
        </div>
        <div class="col-lg-8">
          <table>
            <tr>
              <h3>TCS Users</h3>
              <button @click="search">Refresh</button>
            </tr>
            <tr>
              <th>User Id</th>
              <th>Last Name</th>
              <th>First Name</th>
              <th>Branch Code</th>
            </tr>
            <tr v-for="(user, userNum) in users" :key="userNum">
              <td>{{users.UserId}}</td>
              <td>{{users.LastName}}</td>
              <td>{{users.FirstName}}</td>
              <td>{{users.Department}}</td>
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
      userId: "",
      lastName: "",
      firstName: "",
      branch: "",
      fieldUserId: "",
      fieldLastName: "",
      fieldFirstName: "",
      fieldBranch: "",
      users: [],
    };
  },
  methods: {
    search() {
      axios
        .get(
          "http://localhost:44325/UserAccess/Users"
        )
        .then((res) => {
          console.log(JSON.stringify(res.data));
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
      return;
    },
  },
};
</script>
