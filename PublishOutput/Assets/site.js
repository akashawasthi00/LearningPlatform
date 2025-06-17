angular.module('tutorialApp', ['ngSanitize'])
    .controller('ContentController', function ($scope, $sce) {
        $scope.content = window.contentData || [];
        console.log('Content Data in AngularJS:', $scope.content);

        $scope.trustHtml = function (html) {
            return $sce.trustAsHtml(html);
        };

        if (!$scope.content || $scope.content.length === 0) {
            console.warn('No content data available');
        }
    });