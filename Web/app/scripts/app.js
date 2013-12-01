'use strict';

angular.module('SpeakOut', [])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'views/main.html',
        controller: 'MainController',
        title: 'Home'
      })
      .when('/docs', {
        templateUrl: 'views/docs.html',
        controller: 'DocsController',
        title: 'Docs'

      })
      .when('/apiview', {
        templateUrl: 'views/apiview.html',
        controller: 'ApiController',
        title: 'API'
      })
      .when('/admin', {
        templateUrl: 'views/admin.html',
        controller: 'AdminController',
        title: 'Admin'
      })
      .otherwise({
        redirectTo: '/'
      });
  });
