import { Component, OnInit, AfterViewInit } from '@angular/core';

import * as $ from 'jquery';
import 'datatables.net'

@Component({
  selector: 'projeto-admin-tables-net',
  templateUrl: './tables-net.component.html',
  styleUrls: ['./tables-net.component.css']
})
export class TablesNetComponent implements OnInit , AfterViewInit {


  ngAfterViewInit(): void {
    
  }
  constructor() { }

  ngOnInit() {
  }

}
