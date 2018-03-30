import { Injectable } from '@angular/core';

@Injectable()
export class UtilService {

  constructor() { }

  Somar(n1:number,n2:number):number
  {
      return n1+n2;
  }


}
