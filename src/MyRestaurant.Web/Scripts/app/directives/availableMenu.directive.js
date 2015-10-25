(function (app) {
	'use strict';

	app.directive('availableMenu', availableMenu);

	function availableMenu() {
		return {
			restrict: 'E',
			templateUrl: "/Scripts/app/directives/availableMenu.html",
			link: function ($scope, $element, $attrs) {
				$scope.getAvailableClass = function () {
					if ($attrs.isAvailable === 'true')
						return 'label label-success'
					else
						return 'label label-danger'
				};
				$scope.getAvailability = function () {
					if ($attrs.isAvailable === 'true')
						return 'Available!'
					else
						return 'Not Available'
				};
			}
		}
	}

})(angular.module('common.ui'));