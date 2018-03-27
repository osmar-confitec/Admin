import { Directive, Renderer, ElementRef } from '@angular/core';
import { CnpjFormatPipe } from '../pipes/cnpj-format.pipe';

@Directive({
  selector: 'input[type="text"][projetoAdminCnpjFormat]',
  providers:[CnpjFormatPipe]
})
export class CnpjFormatDirective {
  private el: HTMLInputElement;
  private valorFormatado: string;

  constructor(private cnpjFormatPipe: CnpjFormatPipe,
    private renderer: Renderer,
    private elementRef: ElementRef) {
    this.el = this.elementRef.nativeElement;
  }


  ngOnInit() {
    this.renderer.listen(this.elementRef.nativeElement, 'keyup', (event) => {
      if (this.elementRef.nativeElement.value !== undefined) {
        this.valorFormatado = this.cnpjFormatPipe.transform(this.elementRef.nativeElement.value);
        this.renderer.setElementProperty(this.elementRef.nativeElement, 'value', this.valorFormatado);
      }
    });
  }

}
