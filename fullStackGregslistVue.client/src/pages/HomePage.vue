<template>
  <section class="row">

    <div class="col-4 p-2" v-for="car in cars">

      <CarCard :car="car" />


    </div>

  </section>
</template>

<script>
import Pop from '../utils/Pop.js';
import { computed, onMounted } from 'vue';
import { carsService } from '../services/CarsService.js'
import { logger } from '../utils/Logger.js';
import { AppState } from '../AppState.js';
import CarCard from '../components/CarCard.vue';

export default {
  setup() {
    onMounted(() => {
      getCars();
    });
    async function getCars() {
      try {
        await carsService.getCars();
      }
      catch (error) {
        Pop.error(error);
      }
    }
    return {
      cars: computed(() => AppState.cars)
    };
  },
  components: { CarCard }
}
</script>

<style scoped lang="scss"></style>
