import { Directive } from '@angular/core';

@Directive({
  selector: '[projetoAdminCpfCnpjFormat]'
})
export class CpfCnpjFormatDirective {

  private el: HTMLInputElement;
  constructor() { }

}
