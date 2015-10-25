(function () {
    'use strict';

    angular.module('myRestaurant', ['common.core', 'common.ui'])
        .config(config)
        .run(run);

    config.$inject = ['$routeProvider'];
    function config($routeProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "scripts/app/home/index.html",
                controller: "indexCtrl"
            })
            .when("/login", {
                templateUrl: "scripts/app/account/login.html",
                controller: "loginCtrl"
            })
            .when("/register", {
                templateUrl: "scripts/app/account/register.html",
                controller: "registerCtrl"
            })
            .when("/customers", {
                templateUrl: "scripts/app/customers/customers.html",
                controller: "customersCtrl"
            })
            .when("/customers/register", {
                templateUrl: "scripts/app/customers/register.html",
                controller: "customersRegCtrl",
                resolve: { isAuthenticated: isAuthenticated }
            })
            .when("/menu", {
                templateUrl: "scripts/app/menu/movies.html",
                controller: "menuCtrl"
            })
            .when("/menu/add", {
                templateUrl: "scripts/app/menu/add.html",
                controller: "menuAddCtrl",
                resolve: { isAuthenticated: isAuthenticated }
            })
            .when("/menu/:id", {
                templateUrl: "scripts/app/menu/details.html",
                controller: "menuDetailsCtrl",
                resolve: { isAuthenticated: isAuthenticated }
            })
            .when("/menu/edit/:id", {
                templateUrl: "scripts/app/menu/edit.html",
                controller: "menuEditCtrl"
            })
            .when("/rental", {
                templateUrl: "scripts/app/rental/rental.html",
                controller: "rentStatsCtrl"
            }).otherwise({ redirectTo: "/" });
    }

    run.$inject = ['$rootScope', '$location', '$cookieStore', '$http'];

    function run($rootScope, $location, $cookieStore, $http) {
        // handle page refreshes
        $rootScope.repository = $cookieStore.get('repository') || {};
        if ($rootScope.repository.loggedUser) {
            $http.defaults.headers.common['Authorization'] = $rootScope.repository.loggedUser.authdata;
        }

        $(document).ready(function () {
            $(".fancybox").fancybox({
                openEffect: 'none',
                closeEffect: 'none'
            });

            $('.fancybox-media').fancybox({
                openEffect: 'none',
                closeEffect: 'none',
                helpers: {
                    media: {}
                }
            });

            $('[data-toggle=offcanvas]').click(function () {
                $('.row-offcanvas').toggleClass('active');
            });
        });
    }

    isAuthenticated.$inject = ['membershipService', '$rootScope', '$location'];

    function isAuthenticated(membershipService, $rootScope, $location) {
        if (!membershipService.isUserLoggedIn()) {
            $rootScope.previousState = $location.path();
            $location.path('/login');
        }
    }

})();