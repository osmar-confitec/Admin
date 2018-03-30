import { Pipe, PipeTransform, Injectable } from '@angular/core';

@Pipe({
  name: 'cpfFormat'
})

@Injectable()
export class CpfFormatPipe implements PipeTransform {

  CPF(cpf: string) {
    cpf = cpf.replace(/\D/g, "")
    cpf = cpf.replace(/(\d{3})(\d)/, "$1.$2")
    cpf = cpf.replace(/(\d{3})(\d)/, "$1.$2")
    cpf = cpf.replace(/(\d{3})(\d{1,2})$/, "$1-$2")
    return cpf
  }

  transform(value: any, args?: any): any {
    if (value !== undefined)
      return this.CPF(value);
    else
      return value;
  }

}
