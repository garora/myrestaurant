﻿using System.Web.Optimization;

namespace MyRestaurant.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/Vendors/modernizr.js"));

            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                "~/Scripts/Vendors/jquery.js",
                "~/Scripts/Vendors/bootstrap.js",
                "~/Scripts/Vendors/toastr.js",
                "~/Scripts/Vendors/jquery.raty.js",
                "~/Scripts/Vendors/respond.src.js",
                "~/Scripts/Vendors/angular.js",
                "~/Scripts/Vendors/angular-route.js",
                "~/Scripts/Vendors/angular-cookies.js",
                "~/Scripts/Vendors/angular-validator.js",
                "~/Scripts/Vendors/angular-base64.js",
                "~/Scripts/Vendors/angular-file-upload.js",
                "~/Scripts/Vendors/angucomplete-alt.min.js",
                "~/Scripts/Vendors/ui-bootstrap-tpls-0.13.1.js",
                "~/Scripts/Vendors/underscore.js",
                "~/Scripts/Vendors/raphael.js",
                "~/Scripts/Vendors/morris.js",
                "~/Scripts/Vendors/jquery.fancybox.js",
                "~/Scripts/Vendors/jquery.fancybox-media.js",
                "~/Scripts/Vendors/loading-bar.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app/modules/common.core.js",
                "~/Scripts/app/modules/common.ui.js",
                "~/Scripts/app/app.js",
                "~/Scripts/app/services/apiService.js",
                "~/Scripts/app/services/notificationService.js",
                "~/Scripts/app/services/membershipService.js",
                "~/Scripts/app/services/fileUploadService.js",
                "~/Scripts/app/layout/topBar.directive.js",
                "~/Scripts/app/layout/sideBar.directive.js",
                "~/Scripts/app/layout/customPager.directive.js",
                "~/Scripts/app/directives/rating.directive.js",
                "~/Scripts/app/directives/availableMovie.directive.js",
                "~/Scripts/app/account/loginCtrl.js",
                "~/Scripts/app/account/registerCtrl.js",
                "~/Scripts/app/home/rootCtrl.js",
                "~/Scripts/app/home/indexCtrl.js",
                "~/Scripts/app/customers/customersCtrl.js",
                "~/Scripts/app/customers/customersRegCtrl.js",
                "~/Scripts/app/customers/customerEditCtrl.js",
                "~/Scripts/app/menu/menuCtrl.js",
                "~/Scripts/app/menu/menuAddCtrl.js",
                "~/Scripts/app/menu/menuDetailsCtrl.js",
                "~/Scripts/app/menu/menuEditCtrl.js",
                "~/Scripts/app/controllers/rentalCtrl.js",
                "~/Scripts/app/rental/rentMovieCtrl.js",
                "~/Scripts/app/rental/rentStatsCtrl.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/content/css/site.css",
                "~/content/css/bootstrap.css",
                "~/content/css/bootstrap-theme.css",
                 "~/content/css/font-awesome.css",
                "~/content/css/morris.css",
                "~/content/css/toastr.css",
                "~/content/css/jquery.fancybox.css",
                "~/content/css/loading-bar.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}