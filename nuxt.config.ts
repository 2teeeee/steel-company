export default defineNuxtConfig({
  compatibilityDate: '2025-07-15',
  devtools: { enabled: true },
  runtimeConfig: {
    public: {
      apiBase: 'http://localhost:5279'
    }
  },
  modules: [
    '@nuxtjs/i18n',
    '@nuxtjs/tailwindcss'
  ],
  i18n: {
    locales: [
      { code: 'fa', language: 'fa-IR' },
      { code: 'en', language: 'en-US' },
    ],
    defaultLocale: 'fa',
  },
  css: ['~/assets/fonts/iranYekan/style.css'],
  tailwindcss: {
    exposeConfig: true,
    viewer: true,
  }
})