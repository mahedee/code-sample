'use strict';

registrationModule.controller("TrainersController", function ($scope, registrationData) {
    $scope.trainers = registrationData.trainers;
});
