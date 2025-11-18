<template>
  <select
      v-model="locale"
      @change="changeLang"
      class="border border-gray-300 rounded px-2 py-1 text-sm"
  >
    <option v-for="l in locales" :key="l.code" :value="l.code">
      {{ l.name }}
    </option>
  </select>
</template>

<script setup lang="ts">
const { locale, locales, setLocale } = useI18n();

function changeLang() {
  setLocale(locale.value);
}
</script>
