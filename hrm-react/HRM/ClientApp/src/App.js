import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';

import './custom.css'

import {Employees} from './components/Employee/Employees';
import { Create } from './components/Employee/Create';
import { Edit } from './components/Employee/Edit';
import { Delete } from './components/Employee/Delete';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/employees' component={Employees} />
        <Route path='/create' component = {Create}></Route>
        <Route path='/Edit/:id' component = {Edit}></Route>
        <Route path='/Delete/:id' component = {Delete}></Route>
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data' component={FetchData} />
      </Layout>
    );
  }
}
