define(['app'], function (app) {
    app.directive('inputString',[function() {
        var obj = {
            template: function (element, attr) {
             return '<input type='+attr.type+' ng-model=ngModel ng-change=ngChange() ng-disabled="ngDisabled()" ng-blur="ngBlur()" ng-click="ngClick()"></input>'
            },
            restrict: 'AE',
           
            scope: {
                ngModel:'=',
                ngChange: '&',
                ngDisabled: '&',
                ngBlur: '&',
                ngClick: '&'
               

                
            },
            link: function ($scope, $element, $attrs) {
                ////http://radify.io/blog/understanding-ngmodelcontroller-by-example-part-1/
               

              


              

            

            },
            transclude:true,
            controller: function ($scope) {
                this.stringClick = function () {
                    var num = 12;
                }

            }
        };
        return obj;
    }]);
});