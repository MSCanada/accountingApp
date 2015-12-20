'use strict';
define(['app'], function (app) {
   
    app.controller('loginlogic', ['AuthenticationService', 'LowerCaseConverterFilter','$http','$location', function (AuthenticationService, LowerCaseConverterFilter,$http,$location) {
        var self = this;
        self.username = "";
        self.password = "";
       self.checkValidation = function () {
           
           if(self.username=="" || self.password=="")
               return true
           else
               return false

       }

       self.login = function () {
           $http({
               url: 'http://msuhail-001-site5.btempurl.com/api/Login/',
               method: "POST",
               data: {
                   
                       Username: self.username,
                       Password:self.password
                   
               }
           })
       .then(function (response) {
           var res = response;
           AuthenticationService.deviceId = response.data;
           $location.path("/AddDetails");
       },
       function (response) { // optional
           // failed
       });

       }

    }])

  

   


   

});