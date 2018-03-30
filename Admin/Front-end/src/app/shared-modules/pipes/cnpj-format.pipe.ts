import { Pipe, PipeTransform, Injectable } from '@angular/core';


@Pipe({
  name: 'cnpjFormat'
})

@Injectable()
export class CnpjFormatPipe implements PipeTransform {


  CNPJ(cnpj: string) {
    cnpj = cnpj.replace(/\D/g, "")
    cnpj = cnpj.replace(/^(\d{2})(\d)/, "$1.$2")
    cnpj = cnpj.replace(/^(\d{2})\.(\d{3})(\d)/, "$1.$2.$3")
    cnpj = cnpj.replace(/\.(\d{3})(\d)/, ".$1/$2")
    cnpj = cnpj.replace(/(\d{4})(\d)/, "$1-$2")
    return cnpj
  }

  transform(value: any, args?: any): any {
    if (value !== undefined)
      return this.CNPJ(value);
    else
      return value;
  }

}
