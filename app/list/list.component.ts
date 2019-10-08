import { EmployeeService } from './../employee.service';
import { Employee } from './../employee';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {
  updateDisplay = false;
  emplist: Employee[];
  employee: Employee;
  constructor(private empService: EmployeeService) { 
    this.emplist = empService.show();
  }
  ngOnInit() {
  }
  edit(index: number){
    this.updateDisplay = true;
    this.employee = this.emplist[index];
    this.empService.update(this.employee,index);
  }
  delete(index: number){
    this.updateDisplay = false;
    this.empService.clear(index);
  }
  update(){
    this.updateDisplay = false;
  }
}
