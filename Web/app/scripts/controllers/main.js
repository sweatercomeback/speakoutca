'use strict';

angular.module('SpeakOut')
  .controller('MainController', function ($scope) {
   	$scope.page = 0;
  })
  .controller('DocsController', function ($scope) {
    $scope.page = 1;
  })
  .controller('ApiController', function ($scope) {
    $scope.page = 2;
  });
