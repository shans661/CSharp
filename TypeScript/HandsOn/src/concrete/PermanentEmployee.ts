import { EmployeeType } from "../enums/EmployeeType";
import { IEmployee } from "../interfaces/IEmployee";

export class PermanenetEmployee implements IEmployee
{
    constructor(public name: string, 
        public age: number, 
        public empType: EmployeeType)
    {

    }

    GetSalary(basic: number) {
        return basic * 1.5;
    }
    
}