<template>
  <div class="card p-2 ">
    <h3 class="text-start">${{ car?.price }}</h3>

    <h5 class="text-dark text-start">{{ car?.make }} | {{ car?.model }} | {{ car?.body }}</h5>

    <img :src=car?.imgUrl alt="Car Pic" class="img-fluid carPic">

  </div>
</template>


<script lang="ts">
import { Car } from '../models/Car';

export default {
  props: {
    car: { type: Car, Required: true }
  },

  setup(props) {
    return {
    }
  }
}
</script>


<style lang="scss" scoped>
.carPic {
  height: 30vh;
  object-fit: cover;
}
</style>