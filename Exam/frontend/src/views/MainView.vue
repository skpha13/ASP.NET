<script setup lang="ts">
import axios from '../Helpers/AxiosInstance'
import { ref } from 'vue'
import UtilizatorComponent from '@/components/UtilizatorComponent.vue'
import ComandaComponent from '@/components/ComandaComponent.vue'

interface IUtilizator {
  nume: string
  id: string
}

interface IComanda {
  id: string
  favorita: boolean
}

// ======== USER FETCHING ========
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
// ==================================

// ======== USER CREATE ========
const createUser = async (payload: any) => {
  try {
    await axios.post(`${routeNameUtilizator}/create`, payload);
  } catch (e) {
    console.error(e);
  }

  areUtilizatoriLoaded.value = false;
  await fetchUtilizatori();
  areUtilizatoriLoaded.value = true;
}
// =============================

// ======== USER UPDATE ========
const updateUser = async (payload: any) => {
  try {
    await axios.patch(`${routeNameUtilizator}/update`, payload);
  } catch (e) {
    console.error(e);
  }

  areUtilizatoriLoaded.value = false;
  await fetchUtilizatori();
  areUtilizatoriLoaded.value = true;
}
// =============================

// ======== USER DELETE ========
const deleteUser = async (payload: any) => {
  try {
    await axios.delete(`${routeNameUtilizator}/delete/${payload.id}`);
  } catch (e) {
    console.error(e);
  }

  areUtilizatoriLoaded.value = false;
  await fetchUtilizatori();
  areUtilizatoriLoaded.value = true;
}
// =============================




// ======== COMENZI FETCHING ========
const comenzi = ref<IComanda[]>([])
const areComenziLoaded = ref<boolean>(false)
const routeNameComanda = 'Comanda'

const fetchComenzi = async () => {
  try {
    let response = await axios.get(`${routeNameComanda}/all`)
    comenzi.value = response.data
    areComenziLoaded.value = true
  } catch (error) {
    console.error(error)
  }
}
// ===============================

// ======== COMENZI CREATE ========
const createComanda = async (payload: any) => {
  try {
    await axios.post(`${routeNameComanda}/create`, payload);
  } catch (e) {
    console.error(e);
  }

  areComenziLoaded.value = false;
  await fetchComenzi();
  areComenziLoaded.value = true;
}
// =============================

// ======== COMENZI UPDATE ========
const updateComanda = async (payload: any) => {
  try {
    await axios.patch(`${routeNameComanda}/update`, payload);
  } catch (e) {
    console.error(e);
  }

  areComenziLoaded.value = false;
  await fetchComenzi();
  areComenziLoaded.value = true;
}
// =============================

// ======== COMENZI DELETE ========
const deleteComanda = async (payload: any) => {
  try {
    await axios.delete(`${routeNameComanda}/delete/${payload.id}`);
  } catch (e) {
    console.error(e);
  }

  areComenziLoaded.value = false;
  await fetchComenzi();
  areComenziLoaded.value = true;
}
// =============================
</script>

<template>
<!--  UTLIZATOR -->
  <h1 class="text-5xl mb-4 text-white">UTILIZATORI</h1>
  <button
    class="mb-4 border border-purple-700 p-2 hover:cursor-pointer rounded-lg hover:backdrop-brightness-200"
    @click="fetchUtilizatori" >Afiseaza Utilizatori</button>
  <div v-if="areUtilizatoriLoaded">
    <UtilizatorComponent
      class="mb-2 border-b border-white p-2"
      v-for="item in utilizatori" :key="item.id" :id="item.id" :name="item.nume" />
  </div>

  <h1 class="text-lg mb-2 mt-12">Creeaza Utilizator</h1>
  <FormKit type="form" @submit="createUser" submit-label="Create">
    <FormKit type="text" name="nume" placeholder="nume" />
    <FormKit type="text" name="Utilizator ID"
             placeholder="5f679df0-dcab-499b-afc8-3288185f6976"
             validation="required"
             validation-visibilty="live"
    />
  </FormKit>

  <h1 class="text-lg mb-2 mt-12">Updateaza Utilizator</h1>
  <FormKit type="form" @submit="updateUser" submit-label="Update">
    <FormKit type="text" name="nume" placeholder="nume" />
    <FormKit type="text" name="id"
             placeholder="5f679df0-dcab-499b-afc8-3288185f6976"
             validation="required"
             validation-visibilty="live"
    />
  </FormKit>

  <h1 class="text-lg mb-2 mt-12">Sterge Utilizator</h1>
  <FormKit type="form" @submit="deleteUser" submit-label="Sterge">
    <FormKit type="text" name="id"
             placeholder="5f679df0-dcab-499b-afc8-3288185f6976"
             validation="required"
             validation-visibilty="live"
    />
  </FormKit>

<!--  COMENZI-->
  <h1 class="text-5xl mt-20 mb-4 text-white">COMENZI</h1>
  <button
    class="mb-4 border border-purple-700 p-2 hover:cursor-pointer rounded-lg hover:backdrop-brightness-200"
    @click="fetchComenzi" >Afiseaza Comenzi</button>
  <div v-if="areComenziLoaded">
    <ComandaComponent
      class="mb-2 border-b border-white p-2"
      v-for="item in comenzi" :key="item.id" :id="item.id" :favorita="item.favorita" />
  </div>

  <h1 class="text-lg mb-2 mt-12">Creeaza Comenzi</h1>
  <FormKit type="form" @submit="createComanda" submit-label="Create">
    <FormKit type="text" name="Favorita" placeholder="true/false" />
    <FormKit type="text" name="id"
             placeholder="5f679df0-dcab-499b-afc8-3288185f6976"
             validation="required"
             validation-visibilty="live"
    />
  </FormKit>

  <h1 class="text-lg mb-2 mt-12">Updateaza Comenzi</h1>
  <FormKit type="form" @submit="deleteComanda" submit-label="Update">
    <FormKit type="text" name="Favorita" placeholder="true/false" />
    <FormKit type="text" name="id"
             placeholder="5f679df0-dcab-499b-afc8-3288185f6976"
             validation="required"
             validation-visibilty="live"
    />
  </FormKit>

  <h1 class="text-lg mb-2 mt-12">Sterge Comanda</h1>
  <FormKit type="form" @submit="deleteComanda" submit-label="Sterge">
    <FormKit type="text" name="id"
             placeholder="5f679df0-dcab-499b-afc8-3288185f6976"
             validation="required"
             validation-visibilty="live"
    />
  </FormKit>
</template>
