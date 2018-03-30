import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EnderecoComponent } from './endereco/endereco.component';
import { UtilService } from './services/util.service';


@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [EnderecoComponent],
  providers:[UtilService]
})
export class UtilityModule { }
