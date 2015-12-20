define(['angular', 'angularRoute'], function (angular) {
    var app = angular.module('myApp', ['ngRoute']);

    app.init = function() {
        angular.bootstrap(document, ['myApp']);
    };

    app.addControllerPath = function($q,$rootScope,path) {
        var defer = $q.defer();
        require([path], function () {
            $rootScope.$apply(function () {
                defer.resolve(app);
            });
            
        })
        return defer.promise;

    }

    app.config(['$controllerProvider','$compileProvider', '$filterProvider', '$provide', function($controllerProvider,$compileProvider,$filterProvider,$provide) {
        app.controller = $controllerProvider.register;
        app.directive = $compileProvider.directive;
        app.filter = $filterProvider.register;
        app.factory = $provide.factory;
        app.service = $provide.service;
    }]);
    
    app.config(['$httpProvider', function ($httpProvider) {
        $httpProvider.interceptors.push('MyLoggingInterceptor');
    }]);



   return app;
});