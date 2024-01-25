<script setup lang="ts">
import axios from '../Helpers/AxiosInstance'
import { ref } from 'vue'
import TestComponent from '@/components/UtilizatorComponent.vue'

interface IUtilizator {
  nume: string
  id: string
}

// ======== TEST FETCHING ========
const utilizatori = ref<IUtilizator[]>([])
const areUtilizatoriLoaded = ref<boolean>(false)
const routeNameUtilizator = 'Utilizator'

const fetchUtilizatori = async () => {
  try {
    let response = await axios.get(`${routeNameUtilizator}/all`)
    utilizatori.value = response.data
    areUtilizatoriLoaded.value = true
  } catch (error) {
    console.error(error)
  }
}
// ===============================
</script>

<template>
  <button
    class="border border-purple-700 p-2 hover:cursor-pointer rounded-lg hover:backdrop-brightness-200"
    @click="fetchUtilizatori" >Afiseaza Utilizatori</button>
  <div v-if="areUtilizatoriLoaded">
    <TestComponent
      class="mb-2 border-b border-white p-2"
      v-for="item in utilizatori" :key="item.id" :id="item.id" :name="item.nume" />
  </div>

  <FormKit>
    <FormKit type="text" />
  </FormKit>
</template>
