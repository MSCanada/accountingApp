define(['app'], function (app) {
    app.directive('inputInteger', [function () {
        var obj = {
            template: '<input ng-model="ngModel" ng-change=ngChange() ng-disabled="ngDisabled()" ng-blur="ngBlur()" ng-click="ngClick()"></input>' + '<div ng-transclude></div>',
            restrict: 'AE',
            require: '^inputString',
            transclude:true,
            //Directive can share controllers only in two cases. One is that you have one parent directive and other is its child  <input-String><input-Integer></<input-Integer></input-String>
            //Second is if you have both directives on same element like <div input-String input-Integer></div>. In this case only one directive can have template and scope defined

            scope: {
                ngModel: '=',
                ngChange: '&',
                ngDisabled: '&',
                ngBlur: '&',
                ngClick: '&'


            },
            link: function ($scope, $element, $attrs,stringController) {
                $scope.click = function () {
                    var output = $scope;
                    $scope.ngChange();
                }

                if ($attrs.msuhail = "true") {
                    val = 12;
                }

                $scope.attack = function () {
                    $scope.ngChange();
                }



            }
        };
        return obj;
    }]);
});