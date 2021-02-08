import { EmployeeType } from "../enums/EmployeeType";

export interface IEmployee
{
    name: string;
    age: number;
    empType: EmployeeType;

    GetSalary(basic: number): number;
}