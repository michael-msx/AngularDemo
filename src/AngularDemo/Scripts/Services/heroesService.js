(function () {
    'use strict';

    var heroesService = angular.factory('heroesService', ['ngResource']);

    heroesService.factory('Heroes', ['$resource',
        function ($resource) {
            return $resource('api/heroes', {}, {
                query: { method: 'GET', params: {}, isArray: true }
            });
        }

    ]);
})();