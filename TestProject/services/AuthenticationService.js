define(['app'], function (app) {
    app.factory('AuthenticationService', [function () {
        var service = {};
        service.authenticate = function () {
            return true;

        };
        service.deviceId = "";

        return service;
    }]);
})