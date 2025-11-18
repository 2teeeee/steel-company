<template>
  <div>
    <Navbar />
    <main class="pt-20 container mx-auto py-6 px-4">
      <NuxtPage />
    </main>
  </div>
</template>

<script setup lang="ts">
import Navbar from '../components/Navbar.vue';
</script>
