import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'MiniStore',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44344',
    redirectUri: baseUrl,
    clientId: 'MiniStore_App',
    responseType: 'code',
    scope: 'offline_access MiniStore',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44344',
      rootNamespace: 'MiniStore',
    },
  },
} as Environment;
