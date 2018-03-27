import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CpfFormatDirective } from './cpf-format.directive';
import { CnpjFormatDirective } from './cnpj-format.directive';
import { CpfCnpjFormatDirective } from './cpf-cnpj-format.directive';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [CpfFormatDirective, CnpjFormatDirective, CpfCnpjFormatDirective],
  exports:[CpfFormatDirective, CnpjFormatDirective, CpfCnpjFormatDirective]
})
export class DirectivesModule { }
