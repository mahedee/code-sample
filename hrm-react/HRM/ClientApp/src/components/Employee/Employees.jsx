import React, {Component} from 'react';
import axios from 'axios';

// export keyword is a new feature in ES6 let export your functions , 
// variables so you can get access to them in other js files

export class Employees extends Component
{
    constructor(props){
        super(props);

        this.state = {
            employees: [],
            loading: true,
            failed: false,
            error: ''
        }
    }

    /*Lifecycle Method: The componentDidMount() method runs after 
    the component output has been rendered to the DOM.*/

    componentDidMount(){
        this.populateEmployeesData();
    }

    populateEmployeesData(){
        axios.get("api/Employees/GetEmployees").then(result => {
            const response = result.data;
            this.setState({employees: response, loading: false, error: ""});
        }).catch(error => {
            this.setState({employees: [], loading: false, failed: true, error: "Employess could not be loaded!"});
        });
    }

    renderAllEmployeeTable(employees){
        return(
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Designation</th>
                        <th>Father's Name</th>
                        <th>Mother's Name</th>
                        <th>Date of Birth</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        employees.map(employee => (
                            <tr key={employee.id}>
                                <td>{employee.name}</td>
                                <td>{employee.designation}</td>
                                <td>{employee.fathersName}</td>
                                <td>{employee.mothersName}</td>
                                <td>{ new Date(employee.dateOfBirth).toISOString().slice(0,10)}</td>
                                <td>---</td>
                            </tr>
                        ))
                    }
                </tbody>
            </table>
        );
    }

    render(){

        let content = this.state.loading ? (
            <p>
                <em>Loading...</em>
            </p>
        ):(
            this.renderAllEmployeeTable(this.state.employees)
        )

        return(
            <div>
                <h1>All Employees</h1>
                {content}
            </div>
        );
    }

}