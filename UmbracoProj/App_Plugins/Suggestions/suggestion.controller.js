angular.module("umbraco")    .controller("SuggestionPluginController",
// Scope object is the main object which is used to pass information from the controller to the view.
    function ($scope, $http, umbRequestHelper) {
        // The controller assigns the behavior to scope as defined by the getSuggestion method, which is invoked when the user clicks on the 'Give me Suggestions!' button.
        $scope.getSuggestion = function () {
            return umbRequestHelper.resourcePromise(
                $http.post("https://localhost:44351/umbraco/api/ai/GetRecipe", {text : $scope.model.value}),
                "Failed to get recipe"
            );
        }
    });