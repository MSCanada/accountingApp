'use strict';
define(['app'], function (app) {
   
    app.controller('register', ['AuthenticationService', 'LowerCaseConverterFilter', '$http', '$location', function (AuthenticationService, LowerCaseConverterFilter, $http, $location) {
        var self = this;
        self.username = "";
        self.password = "";
        self.confirmpassword = "";
        self.checkValidationRegister = function () {
           
            if (self.password !== self.confirmpassword)
               return true
           else
               return false

       }


        self.Register = function () {
           $http({
               url: 'http://msuhail-001-site5.btempurl.com/api/Users/',
               method: "POST",
               data: {
                   
                       username: self.username,
                       password:self.password
                   
               }
           })
       .then(function (response) {
           var res = response;
           if (response.data == null)
               return;
           AuthenticationService.deviceId = response.data;
           $location.path("/Login");
          
       },
       function (response) { // optional
           // failed
       });

        }
    }])


});