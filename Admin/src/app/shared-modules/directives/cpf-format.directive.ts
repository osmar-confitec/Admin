import { Directive, Renderer, ElementRef } from '@angular/core';
import { CpfFormatPipe } from '../pipes/cpf-format.pipe';

@Directive({
  selector: 'input[type="text"][projetoAdminCpfFormat]'
})
export class CpfFormatDirective {
  private el: HTMLInputElement;
  private valorFormatado: string;


  ngOnInit() {
    this.renderer.listen(this.elementRef.nativeElement, 'keyup', (event) => {
      if (this.elementRef.nativeElement.value !== undefined) {
        this.valorFormatado = this.cpfFormatPipe.transform(this.elementRef.nativeElement.value);
        this.renderer.setElementProperty(this.elementRef.nativeElement, 'value', this.valorFormatado);
      }
    });
  }


  constructor(private cpfFormatPipe: CpfFormatPipe,
    private renderer: Renderer,
    private elementRef: ElementRef) {
    this.el = this.elementRef.nativeElement;
  }

}
