import { IEmployee } from '../src/interfaces/IEmployee';
import { PermanenetEmployee } from '../src/concrete/PermanentEmployee';
import { EmployeeType } from './enums/EmployeeType';


let permEmp = new PermanenetEmployee("Shiv", 25, EmployeeType.Permananet);

console.log(permEmp.GetSalary(19000))+"INR";