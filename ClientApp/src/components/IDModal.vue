<template>
  >
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h4 class="modal-title">Details</h4>
        <button type="button" class="close">
          <span aria-hidden="true" @click="closeModal">&times;</span>
        </button>
      </div>
      <div class="modal-body">Trade ID: {{ id }}</div>
    </div>
  </div>
</template>

<script>
export default {
  name: "IDModal",
  props: ["id"],
  methods: {
    closeModal() {
      this.$emit("myClose", true);
    },
  },
};
</script>
