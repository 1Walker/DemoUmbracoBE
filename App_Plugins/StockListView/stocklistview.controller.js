var app = angular.module("umbraco");

app.controller("StockListView.Controller", function ($scope, $http, listViewHelper, $location, mediaResource, mediaHelper) {    
    $scope.stock = [];

    // Make request to stock endpoint and render items
    function init() {
        $http({
            url: "/umbraco/surface/stock/GetCurrentStock",
            method: "POST"

            // Data here could pass search terms to returned a filtered list of products
            //data: {
                //url: $scope.searchUrl
            //}
        }).success(function (response, status) {
            console.log(response);

            // Process response and add stock to screen
            for (stockIndex = 0; stockIndex < response.Stock.length; stockIndex++){
                console.log(response.Stock[stockIndex]);
                $scope.stock.push(response.Stock[stockIndex]);
            }       
        }).error(function () {
            alert("An error has occured retrieving products");
        });
    }
            
    init();
});