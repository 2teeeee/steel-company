<template>
  <div>
    <button v-for="loc in locales" :key="loc.code" @click="change(loc.code)" class="mx-1">
      {{ loc.code }}
    </button>
  </div>
</template>

<script setup>
  const { locales, locale } = useI18n();
  const change = (code) => locale.value = code;
</script>
