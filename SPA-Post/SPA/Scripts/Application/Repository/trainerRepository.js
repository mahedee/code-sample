'use strict';

//Repository for trainer information
registrationModule.factory('trainerRepository', function ($resource) {

    return {
        get: function () {
            return $resource('/api/Trainers').query();
        },

        getById: function (id) {
            return $resource('/api/Trainers/:Id', { Id: id }).get();
        },

        save: function (trainer) {
            return $resource('/api/Trainers').save(trainer);
        },

        put: function (trainer) {
            return $resource('/api/Trainers', { Id: trainer.id },
                {
                    update: { method: 'PUT' }
                }).update(trainer);
        },

        remove: function (id) {
            return $resource('/api/Trainers').remove({ Id: id });
        }
    };

});
