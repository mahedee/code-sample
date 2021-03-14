import React, {Component} from 'react';

// export keyword is a new feature in ES6 let export your functions , 
// variables so you can get access to them in other js files

export class Employees extends Component
{
    constructor(props){
        super(props);

        this.state = {
            employees: [],
            loading: false
        }
    }

    renderAllEmployeeTable(employees){
        return(
            <table className="table table-striped">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Designation</th>
                        <th>Father Name</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>a</td>
                        <td>a</td>
                        <td>a</td>
                    </tr>
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
                <p>Here you can see all trips</p>
                {content}
            </div>
        );
    }

}