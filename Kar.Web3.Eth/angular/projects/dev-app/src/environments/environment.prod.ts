import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'Eth',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44331/',
    redirectUri: baseUrl,
    clientId: 'Eth_App',
    responseType: 'code',
    scope: 'offline_access Eth',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44331',
      rootNamespace: 'Kar.Web3.Eth',
    },
    Eth: {
      url: 'https://localhost:44378',
      rootNamespace: 'Kar.Web3.Eth',
    },
  },
} as Environment;
