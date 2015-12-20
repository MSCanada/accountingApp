'use strict';
define(['app'], function (app) {
   
    app.controller('details', ['AuthenticationService', 'LowerCaseConverterFilter','$http','$location', function (AuthenticationService, LowerCaseConverterFilter,$http,$location) {
        var self = this;
        self.contact = "";
        self.roleName = "";
        self.location = "";
        self.checkValidationAddress = function () {
           
            if (self.contact == "" || self.location == "")
               return true
           else
               return false

       }

        self.checkValidationRole = function () {

            if (self.roleName== "")
                return true
            else
                return false

        }

        self.addAddress = function () {
           $http({
               url: 'http://msuhail-001-site5.btempurl.com/api/Address/',
               method: "POST",
               data: {
                   
                       contact: self.contact,
                       location:self.location
                   
               }
           })
       .then(function (response) {
           var res = response;
          
       },
       function (response) { // optional
           // failed
       });

        }

        self.logout = function () {
            $http({
                url: 'http://msuhail-001-site5.btempurl.com/api/LogOff/',
                method: "POST"
            })
         .then(function (response) {
             var res = response;
             AuthenticationService.deviceId = "";
             $location.path("/Login");

         },
         function (response) { // optional
             // failed
         });

        }

        self.addRole = function () {
            $http({
                url: 'http://msuhail-001-site5.btempurl.com/api/Roles/',
                method: "POST",
                data: {

                    RoleName: self.roleName
                  

                }
            })
        .then(function (response) {
            var res = response;

        },
        function (response) { // optional
            // failed
        });

        }








    }])

  

   


   

});