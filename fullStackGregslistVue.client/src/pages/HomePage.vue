<template>
  Hello Home Page
</template>

<script>
import Pop from '../utils/Pop.js';
import { onMounted } from 'vue';
import { carsService } from '../services/CarsService.js'
import { logger } from '../utils/Logger.js';

export default {
  setup() {

    onMounted(() => {
      getCars()
    })

    async function getCars() {
      try {
        await carsService.getCars()
      } catch (error) {
        Pop.error(error);
      }
    }

    return {}
  }
}
</script>

<style scoped lang="scss"></style>
