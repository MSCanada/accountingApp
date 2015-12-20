define(['app'], function (app) {
    app.filter('LowerCaseConverter', [function () {
        var converter = function (input,input1) {
            return input.toLowerCase();
        }
        return converter;

    }]);
})