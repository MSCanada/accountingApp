define(['app'], function (app) {
    'use strict';
    return app.config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/Login', {
            templateUrl: 'Views/Login.html',
            resolve: {
                path: function ($q, $rootScope) {
                    return  app.addControllerPath($q,$rootScope, 'Controller/Login')
                }  
                     }

        });

        $routeProvider.when('/AddDetails', {
            templateUrl: 'Views/Details.html',
            resolve: {
                path: function ($q, $rootScope) {
                    return app.addControllerPath($q, $rootScope, 'Controller/Details')
                }
            }

        });

        $routeProvider.when('/Register', {
            templateUrl: 'Views/Register.html',
            resolve: {
                path: function ($q, $rootScope) {
                    return app.addControllerPath($q, $rootScope, 'Controller/Register')
                }
            }

        });
        
        $routeProvider.otherwise({
            redirectTo: '/Login'
        });
    }]);
});