import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CnpjFormatPipe } from './cnpj-format.pipe';
import { CpfFormatPipe } from './cpf-format.pipe';
import { CpfCnpjFormatPipe } from './cpf-cnpj-format.pipe';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [CnpjFormatPipe, CpfFormatPipe, CpfCnpjFormatPipe]
})
export class PipesModule { }
