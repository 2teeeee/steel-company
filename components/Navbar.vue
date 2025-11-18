<template>
  <header
      :class="[
      'fixed top-0 left-0 w-full bg-white shadow z-50',
      isRtl ? 'direction-rtl' : 'direction-ltr'
    ]"
  >
    <div class="container mx-auto flex items-center justify-between py-3 px-4 md:px-6">

      <!-- لوگو -->
      <NuxtLink to="/" class="flex items-center space-x-2 space-x-reverse">
        <img src="/logo.png" alt="Logo" class="h-10 w-auto" />
        <span class="font-bold text-xl text-gray-800">Steel Co</span>
      </NuxtLink>

      <!-- منوی دسکتاپ -->
      <nav class="hidden md:flex space-x-6 space-x-reverse">
        <div class="relative group">
          <button class="font-semibold text-gray-700 hover:text-blue-600 transition">
            {{ t('menu.products') }}
          </button>

          <!-- مگا منو RTL/LTR -->
          <div
              :class="[
              'absolute hidden group-hover:grid grid-cols-3 gap-6 bg-white shadow-lg rounded-lg p-6 w-[600px] border border-gray-100',
              isRtl ? 'right-0 text-right' : 'left-0 text-left'
            ]"
          >
            <div>
              <h4 class="font-semibold mb-2 text-gray-700">{{ t('products.steel') }}</h4>
              <ul class="space-y-1 text-gray-600">
                <li><NuxtLink to="/products/rebar">{{ t('products.rebar') }}</NuxtLink></li>
                <li><NuxtLink to="/products/sheet">{{ t('products.sheet') }}</NuxtLink></li>
                <li><NuxtLink to="/products/profile">{{ t('products.profile') }}</NuxtLink></li>
              </ul>
            </div>

            <div>
              <h4 class="font-semibold mb-2 text-gray-700">{{ t('services.title') }}</h4>
              <ul class="space-y-1 text-gray-600">
                <li><NuxtLink to="/services/cutting">{{ t('services.cutting') }}</NuxtLink></li>
                <li><NuxtLink to="/services/shaping">{{ t('services.shaping') }}</NuxtLink></li>
              </ul>
            </div>

            <div>
              <h4 class="font-semibold mb-2 text-gray-700">{{ t('company.title') }}</h4>
              <ul class="space-y-1 text-gray-600">
                <li><NuxtLink to="/about/company">{{ t('company.about') }}</NuxtLink></li>
                <li><NuxtLink to="/about/team">{{ t('company.team') }}</NuxtLink></li>
              </ul>
            </div>
          </div>
        </div>

        <NuxtLink to="/news" class="font-semibold text-gray-700 hover:text-blue-600">
          {{ t('menu.news') }}
        </NuxtLink>

        <NuxtLink to="/contact" class="font-semibold text-gray-700 hover:text-blue-600">
          {{ t('menu.contact') }}
        </NuxtLink>
      </nav>

      <!-- آیکون‌ها + زبان + منوی موبایل -->
      <div class="flex items-center space-x-4 space-x-reverse">
        <div class="hidden md:flex space-x-3 space-x-reverse">
          <a href="#" aria-label="Instagram" class="text-gray-500 hover:text-pink-600">
            <i class="fab fa-instagram text-xl"></i>
          </a>
          <a href="#" aria-label="LinkedIn" class="text-gray-500 hover:text-blue-700">
            <i class="fab fa-linkedin text-xl"></i>
          </a>
        </div>

        <LanguageSwitcher />

        <button @click="toggleMenu" class="md:hidden text-gray-700 text-2xl">
          <i :class="menuOpen ? 'fa-solid fa-xmark' : 'fa-solid fa-bars'"></i>
        </button>
      </div>
    </div>

    <!-- منوی موبایل -->
    <transition name="slide-fade">
      <nav
          v-if="menuOpen"
          :class="[
          'md:hidden bg-white shadow-inner px-6 py-4 space-y-3 border-t border-gray-200',
          isRtl ? 'text-right' : 'text-left'
        ]"
      >
        <details>
          <summary class="font-semibold text-gray-700 cursor-pointer">
            {{ t('menu.products') }}
          </summary>

          <ul class="mt-2 text-gray-600 space-y-1" :class="isRtl ? 'pr-4' : 'pl-4'">
            <li><NuxtLink to="/products/rebar">{{ t('products.rebar') }}</NuxtLink></li>
            <li><NuxtLink to="/products/sheet">{{ t('products.sheet') }}</NuxtLink></li>
            <li><NuxtLink to="/products/profile">{{ t('products.profile') }}</NuxtLink></li>
          </ul>
        </details>

        <NuxtLink to="/news" class="block font-semibold text-gray-700">{{ t('menu.news') }}</NuxtLink>
        <NuxtLink to="/contact" class="block font-semibold text-gray-700">{{ t('menu.contact') }}</NuxtLink>
      </nav>
    </transition>
  </header>
</template>

<script setup lang="ts">
import { ref, computed } from 'vue'
import { useI18n } from 'vue-i18n'
import LanguageSwitcher from './LanguageSwitcher.vue'

const { locale, t } = useI18n()

const isRtl = computed(() => locale.value === 'fa')

const menuOpen = ref(false)
const toggleMenu = () => (menuOpen.value = !menuOpen.value)
</script>

<style>
/* فعال‌سازی RTL/LTR */
.direction-rtl {
  direction: rtl;
}
.direction-ltr {
  direction: ltr;
}

/* مگا منو */
.group:hover .group-hover\:grid {
  display: grid;
}

/* انیمیشن باز شدن منوی موبایل */
.slide-fade-enter-active,
.slide-fade-leave-active {
  transition: all 0.3s ease;
}
.slide-fade-enter-from,
.slide-fade-leave-to {
  opacity: 0;
  transform: translateY(-10px);
}
</style>
