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
        <div class="col-lg-4">
          <button @click="addNew()">New</button>
        </div>
        <div class="col-lg-4">
          <button @click="update()">Update</button>
        </div>
        <div class="col-lg-4">
          <button @click="deleteUser()">Delete</button>
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
                <input id="userId" type="text" v-model="currentUserId"  />
              </td>
            </tr>
            <tr>
              <td>
                <label for="lastName">Last Name</label>
              </td>
              <td>
                <input id="lastName" type="text" v-model="currentLastName" />
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
                  v-model="currentFirstName"
                />
              </td>
            </tr>
            <tr>
              <td>
                <label for="department">Department</label>
              </td>
              <td>
                <input id="department" type="text" v-model="currentDepartment" />
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
              <td @click="displayUser(user.userId)">{{user.userId}}</td>
              <td @click="displayUser(user.userId)">{{user.lastName}}</td>
              <td @click="displayUser(user.userId)">{{user.firstName}}</td>
              <td @click="displayUser(user.userId)">{{user.department}}</td>
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
      currentUserId: '',
      currentLastName: '',
      currentFirstName: '',
      currentDepartment: '',
      users: [],
    };
  },
  created(){
    this.search()
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
    addNew() {
      axios
        .post(
          "UserAccess/AddUser", {
            UserId: this.currentUserId,
            LastName: this.currentLastName,
            FirstName: this.currentFirstName,
            Department: this.currentDepartment
          }
        )
        .catch((error) => {
          console.error(error);
        });
    },
    displayUser(ID){
      let user = {};
      for (var i = 0; i < this.users.length; i++){
        var item = this.users[i];
        if (item.userId === ID){
          user = item;
          break;
        }
      }
      this.currentUserId = user.userId;
      this.currentLastName = user.lastName;
      this.currentFirstName = user.firstName;
      this.currentDepartment = user.department;
      
    },
    deleteUser(){
      axios
        .delete("UserAccess/DeleteUser/" + this.currentUserId)
        .catch((error) => {
          console.error(error);
        });
    },
    update() {
      axios
        .post("UserAccess/UpdateUser/" + this.currentUserId, {
            UserId: this.currentUserId,
            LastName: this.currentLastName,
            FirstName: this.currentFirstName,
            Department: this.currentDepartment
          }
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
