<script setup lang="ts">
const props = defineProps<{
  id: string
  favorita: string
}>()
</script>

<template>
  <div class="flex flex-col justify-between">
    <h1>FAVORITA: {{props.favorita }}</h1>
    <p>ID: {{ props.id }}</p>
  </div>
</template>