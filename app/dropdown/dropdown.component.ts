import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dropdown',
  templateUrl: './dropdown.component.html',
  styleUrls: ['./dropdown.component.css']
})
export class DropdownComponent implements OnInit {

  countries = ['India','US','Australia','China','Japan'];
  statelist = [['Tamil Nadu','Karnataka','Kerala'],['Texas','Florida','New York'],['Victoria','Queensland','Tasmania'],['Shangai','Beijing','Gansu'],['Hiroshima','Fukushima','Kyoto']];
  states;
  constructor() { 
  }

  onChange(event){
    this.states = this.statelist[event.target.selectedIndex];
  }
  ngOnInit() {
  }

}
