import { Employee } from './employee';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  employeelist: Employee[] = [
    {did: 1, name: 'Engineering', group: 'Research and Development', modifiedDate: new Date()},
    {did: 2, name: 'Tool Design', group: 'Research and Development', modifiedDate: new Date()},
    {did: 3, name: 'Sales', group: 'Sales and Marketing', modifiedDate: new Date()},
    {did: 4, name: 'Marketing', group: 'Sales and Marketing', modifiedDate: new Date()},
    {did: 5, name: 'Purchasing', group: 'Inventory Management', modifiedDate: new Date()}
  ];
  constructor() { }
  show(){
    return this.employeelist;
  }
  update(employee: Employee, index: number){
    this.employeelist[index] = employee;
    this.employeelist[index].modifiedDate = new Date();
  }
  clear(index:number){
    this.employeelist.splice(index, 1);
  }
  add(new_employee: Employee){
    console.log(new_employee);
    new_employee.modifiedDate = new Date();
    this.employeelist.push(new_employee);
  }
}
