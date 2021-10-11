<template>
  <form submit="submit">
    <div>
      <label for="firstName"> First Name</label>
      <input type="text" v-model="firstName" />
    </div>
    <div>
      <label for="lastName"> Last Name</label>
      <input type="text" v-model="lastName" />
    </div>
    <div>
      <label for="password"> Password</label>
      <input type="password" v-model="password" />
    </div>
    <div>
      <label for="date">Date</label>
      <input type="date" v-model="date" />
    </div>
    <div>
      <button class="btn-primary" @click="submit">Submit</button>
      <!-- <input type="submit"> -->
    </div>
    <div>
      firstName: {{ firstName }}, lastName: {{ lastName }}, password:
      {{ password }}, date: {{ date }},
    </div>
  </form>
</template>

<script>
export default {
  data() {
    return {
      firstName: "",
      lastName: "",
      password: "",
      date: "8/12/2021",
    };
  },
  methods: {
    submit() {
      alert(`First Name: ${this.firstName},Last Name: ${this.lastName}`);
    },
  },
};
</script>

<style></style>
