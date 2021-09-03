'use strict';

registrationModule.controller("TrainingsController", function ($scope, registrationData) {
    $scope.trainings = registrationData.trainings;
});