import { ModuleWithProviders, NgModule } from '@angular/core';
import { ETH_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class EthConfigModule {
  static forRoot(): ModuleWithProviders<EthConfigModule> {
    return {
      ngModule: EthConfigModule,
      providers: [ETH_ROUTE_PROVIDERS],
    };
  }
}
