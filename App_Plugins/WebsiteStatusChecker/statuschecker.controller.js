var app = angular.module("umbraco");

app.controller("utilities.WebsiteChecker", function ($http, $scope, $routeParams, notificationsService, navigationService, $route) {
    
    $scope.output = {
        type: "failure",
        message: "",
        class: "",

        // Clear the current error message
        show: function () {
            $scope.output.class = "visible";
        },

        hide: function () {
            $scope.output.class = "";
        }
    };
    $scope.searchUrl = "http://";

    // Makes a request to a specified URL and returns its response
    $scope.checkStatus = function () {
        // Confirm that a valid URL has been entered
        if (!isUrl($scope.searchUrl)) {
            alert("Please enter a valid URL");
            return;
        }

        // Here, I am making the request through a surface controller instead of directly. 
        // In this case, this prevents any Access-Control-Allow-Origin Header issues when running IIS Express
        $http({
            url: "/umbraco/surface/http/GetWebsiteStatusCode",
            method: "POST",
            data: {
                url: $scope.searchUrl
            }
        }).success(function (response, status) {

            // Check whether the response was a success code and output result
            if (response == -1 || response >= 400) {
                $scope.output.type = "failure";
                $scope.output.message = "Failed to make a connection to provided URL.";
            }
            else {
                $scope.output.type = "success";
                $scope.output.message = "URL Responded with succes code " + status;
            }
            $scope.output.show();

            // After a delay, hide the output
            setTimeout(function () {
                $scope.output.hide();
            }, 2000);
        }).error(function () {
            $scope.output.type = "failure";
            $scope.output.message = "An unknown error has occured";
            $scope.output.show();
        });
    };
    
    // Validates a given string against a URL matching expression
    isUrl = function (url) {
        var urlMatchingPattern = /(http|https):\/\/(\w+:{0,1}\w*)?(\S+)(:[0-9]+)?(\/|\/([\w#!:.?+=&%!\-\/]))?/;
        console.log(url);
        console.log(urlMatchingPattern.test(url));
        return urlMatchingPattern.test(url);
    };
});