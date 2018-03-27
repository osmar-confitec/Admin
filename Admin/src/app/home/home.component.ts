import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'projeto-admin-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  CPFCNPJ:string = '21371885893';

  constructor() { }

  ngOnInit() {
  }

}
