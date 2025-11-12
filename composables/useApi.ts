export const useApi = () => {
    const config = useRuntimeConfig()
    const base = config.public.apiBase
    const fetcher = <T>(path: string) => $fetch<T>(base + path)
    return { fetcher }
}
