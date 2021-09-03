var registrationModule = angular.module("registrationModule", [])
    .config(function ($routeProvider, $locationProvider) {
        //alert("Routing");
        $routeProvider.when('/Registration/Trainings', {
            templateUrl: '/templates/trainings.html',
            controller: 'TrainingsController'
        });

        $routeProvider.when('/Registration/Trainers', {
            templateUrl: '/templates/trainers.html',
            controller: 'TrainersController'
        });

        $locationProvider.html5Mode(true);
    });