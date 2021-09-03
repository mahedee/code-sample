(function () {
    angular.module('app', []);

    $(function () {
        $.connection.hub.logging = true;
        $.connection.hub.start();
    });


    $.connection.hub.error(function (err) {
        console.log('An error occurred: ' + err);
    });

    angular.module('app')
       .value('notification', $.connection.notification)
       .value('toastr', toastr);

})();