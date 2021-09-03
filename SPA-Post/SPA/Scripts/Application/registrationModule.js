var registrationModule = angular.module("registrationModule", ['ngRoute', 'ngResource'])
    .config(function ($routeProvider, $locationProvider) {

        $routeProvider.when('/Registration/Trainers', {
            templateUrl: '/templates/trainers/all.html',
            controller: 'listTrainersController'
        });

        $routeProvider.when('/Registration/Trainers/:id', {
            templateUrl: '/templates/trainers/edit.html',
            controller: 'editTrainersController'
        });

        $routeProvider.when('/Registration/Trainers/add', {
            templateUrl: '/templates/trainers/add.html',
            controller: 'addTrainersController'
        });

        $routeProvider.when("/Registration/Trainers/delete/:id", {
            controller: "deleteTrainersController",
            templateUrl: "/templates/trainers/delete.html"
        });

        $locationProvider.html5Mode(true);
    });