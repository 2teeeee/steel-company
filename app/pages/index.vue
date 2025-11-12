<template>
  <div class="container mx-auto p-6">
    <section class="mt-6">
      <h1 class="text-2xl font-bold">{{ $t('home') }}</h1>

      <div class="mt-6">
        <h2 class="text-xl">{{ $t('news') }}</h2>
        <div v-if="news.length === 0" class="mt-2">Loading...</div>
        <div class="grid grid-cols-1 md:grid-cols-3 gap-4 mt-4">
          <div v-for="item in news" :key="item.id" class="p-4 border rounded">
            <h3 class="font-semibold">{{ item.title }}</h3>
            <p class="text-sm mt-2">{{ excerpt(item.content) }}</p>
            <NuxtLink :to="`/news/${item.slug}`" class="text-blue-600 mt-3 inline-block">{{ $t('read_more') }}</NuxtLink>
          </div>
        </div>
      </div>

      <div class="mt-8">
        <h2 class="text-xl">{{ $t('related_links') }}</h2>
        <ul class="flex gap-3 flex-wrap mt-3">
          <li v-for="link in related" :key="link.id"><a :href="link.url" target="_blank" class="underline">{{ link.title }}</a></li>
        </ul>
      </div>
    </section>
  </div>
</template>

<script setup lang="ts">
import { ref, onMounted } from 'vue';
import {useApi} from "../../composables/useApi";

const { fetcher } = useApi();
const news = ref<any[]>([]);
const related = ref<any[]>([]);

onMounted(async () => {
  news.value = await fetcher('/api/news?lang=' + useI18n().locale.value)
  related.value = await fetcher('/api/relatedlink')
})

const excerpt = (text: string) => text ? (text.length > 120 ? text.slice(0,120)+'...' : text) : ''
</script>
