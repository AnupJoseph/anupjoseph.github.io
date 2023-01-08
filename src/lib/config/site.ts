import type { SiteConfig } from '$lib/types/site'

export const site: SiteConfig = {
  protocol: 'https://',
  domain: import.meta.env.URARA_SITE_DOMAIN ?? 'https://anupjoseph.github.io/',
  title: 'Anup Joseph',
  subtitle: 'Personal site covering all the blogs and projects I do',
  lang: 'en-US',
  description: 'Powered by SvelteKit/Urara',
  author: {
    name: 'Anup Joseph',
    status: '😃',
    bio: 'ML Engineer. Curious. Fantasy, Scifi nerd. Fierce Man United Fan'
  },
  themeColor: '#3D4451'
}
