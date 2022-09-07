import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'MiniStore',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44344', // IdentityServer url
    clientId: 'MiniStore_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'offline_access MiniStore',
  },
  apis: {
    default: {
      url: 'https://localhost:44344',
      rootNamespace: 'MiniStore',
    },
  },
} as Environment;
