require.config({

    baseUrl: "./",
       paths: {
           'angular': 'bower_components/angular/angular',             
           'angularRoute': '//ajax.googleapis.com/ajax/libs/angularjs/1.2.16/angular-route.min',
           'angularAMD': '//cdn.jsdelivr.net/angular.amd/0.2.0/angularAMD.min'   ,
           'domReady': 'bower_components/requirejs-domready/domReady',
           'AuthenticationService': 'services/AuthenticationService',
           'LowerCaseConverter': 'Filters/LowerCaseConverter',
           'inputstringdirective': 'directive/inputstringdirective',
           'inputintegerdirective': 'directive/inputintegerdirective',
           'requestresponseinterceptor': 'Interceptor/RequestResponseInterceptor',

    },
    // shim: makes external libraries reachable
    shim: {
        'angular': {
            exports: 'angular'
        },
        angularRoute: ['angular'],
    }  

  
});

// Angular Bootstrap 
require(['domReady!', 'angular', 'app','requestresponseinterceptor', 'routes', 'AuthenticationService', 'LowerCaseConverter', 'inputstringdirective', 'inputintegerdirective'], function (document, angular, app, routes) {
      
    app.init();
});