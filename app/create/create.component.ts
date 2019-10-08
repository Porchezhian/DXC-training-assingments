import { EmployeeService } from './../employee.service';
import { Employee } from './../employee';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent implements OnInit {

  new_employee = new Employee();
  constructor(private empService: EmployeeService, private Route: Router) { }

  ngOnInit() {
  }
  add(){
    this.empService.add(this.new_employee);
    this.Route.navigate(['list']);
  }

}
