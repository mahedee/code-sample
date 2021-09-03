'use strict';

//Controller to get list of trainers informaion
registrationModule.controller("listTrainersController", function ($scope, trainerRepository, $location) {
    $scope.trainers = trainerRepository.get();
});


//Controller to save trainer information
registrationModule.controller("addTrainersController", function ($scope, trainerRepository, $location) {
    $scope.save = function (trainer) {
        trainer.Id = 0;
        $scope.errors = [];
        trainerRepository.save(trainer).$promise.then(
            function () { $location.url('Registration/Trainers'); },
            function (response) { $scope.errors = response.data; });
    };
});


//Controller to modify trainer information
registrationModule.controller("editTrainersController", function ($scope,$routeParams, trainerRepository, $location) {
    $scope.trainer = trainerRepository.getById($routeParams.id);

    $scope.update = function (trainer) {
        $scope.errors = [];
        trainerRepository.put(trainer).$promise.then(
            function () { $location.url('Registration/Trainers'); },
            function (response) { $scope.errors = response.data; });
    };
});

//Controller to delete trainer information
registrationModule.controller("deleteTrainersController", function ($scope, $routeParams, trainerRepository, $location) {
        trainerRepository.remove($routeParams.id).$promise.then(
            function () { $location.url('Registration/Trainers'); },
            function (response) { $scope.errors = response.data; });
});
