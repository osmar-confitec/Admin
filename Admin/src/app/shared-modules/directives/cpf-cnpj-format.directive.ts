import { Directive, Renderer, ElementRef } from '@angular/core';
import { CpfFormatPipe } from '../pipes/cpf-format.pipe';
import { CnpjFormatPipe } from '../pipes/cnpj-format.pipe';

@Directive({
  selector: '[projetoAdminCpfCnpjFormat]'
})
export class CpfCnpjFormatDirective {

  private el: HTMLInputElement;
  private valorFormatado: string;


  ngOnInit() {
    this.renderer.listen(this.elementRef.nativeElement, 'keyup', (event) => {
      if (this.elementRef.nativeElement.value !== undefined) {
        let vlrFormatado = this.elementRef.nativeElement.value.replace(/\D+/g, '');
        if (vlrFormatado.lenght <= 11)
          this.valorFormatado = this.cpfFormatPipe.transform(this.elementRef.nativeElement.value);
        else
          this.valorFormatado = this.cnpjFormatPipe.transform(this.elementRef.nativeElement.value);
        this.renderer.setElementProperty(this.elementRef.nativeElement, 'value', this.valorFormatado);
      }
    });
  }

  constructor(
    private cnpjFormatPipe: CnpjFormatPipe,
    private cpfFormatPipe: CpfFormatPipe,
    private renderer: Renderer,
    private elementRef: ElementRef) {
    this.el = this.elementRef.nativeElement;
  }

}
