<template>
  <header class="flex justify-between items-center p-4 border-b">
    <NuxtLink to="/" class="text-xl font-bold">شرکت فولاد</NuxtLink>
    <div class="flex items-center gap-3">
      <LanguageSwitcher />
    </div>
  </header>
</template>

<script setup>
  import LanguageSwitcher from './LanguageSwitcher.vue';
</script>
