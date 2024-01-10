import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { EthComponent } from './components/eth.component';
import { EthRoutingModule } from './eth-routing.module';

@NgModule({
  declarations: [EthComponent],
  imports: [CoreModule, ThemeSharedModule, EthRoutingModule],
  exports: [EthComponent],
})
export class EthModule {
  static forChild(): ModuleWithProviders<EthModule> {
    return {
      ngModule: EthModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<EthModule> {
    return new LazyModuleFactory(EthModule.forChild());
  }
}
