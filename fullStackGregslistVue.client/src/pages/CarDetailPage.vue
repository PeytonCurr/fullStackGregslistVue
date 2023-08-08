<template>
  <section class="row">
    <img :src="car?.imgUrl" class="col-6 hero elevation-3 p-0">
    <div class="col-6 elevation-3 p-2 bg-info d-flex flex-column justify-content-between">

      <div class="top">
        <h1 class="text-dark text-s">{{ car?.make }} | {{ car?.model }} | {{ car?.body }}</h1>
        <h3 class="text-start">${{ car?.price }}</h3>

        <br>

        <h6>{{ car?.description }}</h6>
      </div>

      <div class="d-flex justify-content-center p-3">
        <button class="btn btn-primary mx-3">Delete</button>

        <button class="btn btn-primary mx-3">Edit Car</button>
      </div>

    </div>
  </section>
</template>


<script lang="ts">
import { computed, onMounted } from 'vue';
import Pop from '../utils/Pop';
import { carsService } from '../services/CarsService';
import { useRoute } from 'vue-router';
import { AppState } from '../AppState';

export default {
  setup() {

    const route = useRoute();

    onMounted(() => {
      getOneCar()
    })

    async function getOneCar() {
      try {
        await carsService.getOneCar(route.params.carId)
      } catch (error) {
        Pop.error(error);
      }
    }

    return {

      car: computed(() => AppState.car)

    }
  }
}
</script>


<style lang="scss" scoped>
.hero {
  height: auto;
  object-fit: cover;
  object-position: center;
}

.top {
  height: 80%;
}
</style>