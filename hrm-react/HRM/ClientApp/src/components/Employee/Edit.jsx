import axios from "axios";
import React, { Component } from "react";

export class Edit extends Component {
    constructor(props) {
        super(props);

        this.state = {
            name: '',
            designation: '',
            fathersName: '',
            mothersName: '',
            //This is date time object
            dateOfBirth: null 
        }
    }

    componentDidMount(){
        const {id} = this.props.match.params;
        axios.get("api/Employees/Employee/" + id).then(employee =>{
            const response = employee.data;
            this.setState({
                name: response.name,
                designation: response.designation,
                fathersName: response.fathersName,
                mothersName: response.mothersName,
                dateOfBirth: new Date(response.dateOfBirth).toISOString().slice(0,10)
            })
        })
        //alert(id);
    }

    onChangeName(e) {
        this.setState({
            name: e.target.value
        })
    }

    onChangeDesignation(e) {
        this.setState({
            designation: e.target.value
        })
    }

    onChangeFathersName(e) {
        this.setState({
            fathersName: e.target.value
        })

    }

    onChangeMothersName(e) {
        this.setState({
            mothersName: e.target.value
        })

    }

    onChangeDOB(e) {
        this.setState({
            dateOfBirth: e.target.value
        })
    }


    onUpdateCancel(){
        const {history} = this.props;
        history.push('/employees');
    }

    render() {
        return (
            <div className="row">
                <div className="col-md-4">
                    <h3>Edit Employee</h3>
                    <form onSubmit={this.onSubmit}>
                        <div className="form-group">
                            <label className="control-label">Name: </label>
                            <input className="form-control" type="text" value={this.state.name} onChange={this.onChangeName}></input>
                        </div>

                        <div className="form-group">
                            <label className="control-label">Designation: </label>
                            <input className="form-control" type="text" value={this.state.designation} onChange={this.onChangeDesignation}></input>
                        </div>

                        <div className="form-group">
                            <label className="control-label">Father's Name: </label>
                            <input className="form-control" type="text" value={this.state.fathersName} onChange={this.onChangeFathersName}></input>
                        </div>

                        <div className="form-group">
                            <label className="control-label">Mother's Name: </label>
                            <input className="form-control" type="text" value={this.state.mothersName} onChange={this.onChangeMothersName}></input>
                        </div>

                        <div className="form-group">
                            <label className="control-label">Date of Birth: </label>
                            <input className="form-control" type="date" value={this.state.dateOfBirth} onChange={this.onChangeDOB}></input>
                        </div>

                        <div className="form-group">
                            <button onClick={this.onUpdateCancel} className="btn btn-default">Cancel</button>
                            <input type="submit" value="Edit" className="btn btn-primary"></input>
                        </div>

                    </form>

                </div>
            </div>
        )
    }
}