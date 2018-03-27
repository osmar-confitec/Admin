import { Pipe, PipeTransform } from '@angular/core';
import { CnpjFormatPipe } from './cnpj-format.pipe';
import { CpfFormatPipe } from './cpf-format.pipe';

@Pipe({
  name: 'cpfCnpjFormat'
})
export class CpfCnpjFormatPipe implements PipeTransform {


  cnpjFormatPipe: CnpjFormatPipe = new CnpjFormatPipe();

  constructor(private cpf: CpfFormatPipe
    , private cnpj: CnpjFormatPipe) {

  }

  transform(value: any, args?: any): any {
    if (value !== undefined) {
      let valorFormatado = value.replace(/\D+/g, '');
      if (valorFormatado.lenght <= 11)
        return this.cpf.transform(valorFormatado);
      else
        return this.cnpj.transform(valorFormatado);
    } else
      return value;

  }

}
