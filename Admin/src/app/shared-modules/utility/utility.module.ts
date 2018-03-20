import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EnderecoComponent } from './endereco/endereco.component';
import { UtilService } from './services/util.service';
import { FormataCpfDirective } from './directives/formata-cpf.directive';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [EnderecoComponent, FormataCpfDirective],
  providers:[UtilService]
})
export class UtilityModule { }
