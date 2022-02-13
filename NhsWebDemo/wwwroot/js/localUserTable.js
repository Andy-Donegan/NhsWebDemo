$(document).ready(function () {
    var localTable = $("#example").DataTable({
            "processing": true, // for show progress bar    
            "serverSide": true, // for process server side    
            "filter": true, // this is for disable filter (search box)    
            "ajax": {
                "url": "/Local/LoadUserData",
                "type": "POST",
                "datatype": "json"
            },
            "columnDefs": [{
                "targets": [0], // Hide iD Column
                "visible": false,
                "searchable": false
            },
                {
                    "targets": [26], // remove sortable from Details Button Column
                    "visible": true,
                    "sortable": false
                }
                ],
            "columns": [
                { "data": "iD", "name": "ID", "autoWidth": true },
                { "data": "name", "name": "Name", "autoWidth": true },
                { "data": "organisation", "name": "Organisation", "autoWidth": true },
                { "data": "service", "name": "service", "autoWidth": true },
                { "data": "location", "name": "location", "autoWidth": true },
                { "data": "dailyAppointments", "name": "dailyAppointments", "autoWidth": true },
                { "data": "dailyAttended", "name": "dailyAttended", "autoWidth": true },
                { "data": "dailyCancelled", "name": "dailyCancelled", "autoWidth": true },
                { "data": "dailyNonCompliance", "name": "dailyNonCompliance", "autoWidth": true },
                { "data": "dailyLate", "name": "dailyLate", "autoWidth": true },
                { "data": "dailySafetyAlerts", "name": "dailySafetyAlerts", "autoWidth": true },
                { "data": "dailyMissingData", "name": "dailyMissingData", "autoWidth": true },

                { "data": "weeklyAppointments", "name": "weeklyAppointments", "autoWidth": true, "visible": false },
                { "data": "weeklyAttended", "name": "weeklyAttended", "autoWidth": true, "visible": false },
                { "data": "weeklyCancelled", "name": "weeklyCancelled", "autoWidth": true, "visible": false },
                { "data": "weeklyNonCompliance", "name": "weeklyNonCompliance", "autoWidth": true, "visible": false },
                { "data": "weeklyLate", "name": "weeklyLate", "autoWidth": true, "visible": false },
                { "data": "weeklySafetyAlerts", "name": "weeklySafetyAlerts", "autoWidth": true, "visible": false },
                { "data": "weeklyMissingData", "name": "weeklyMissingData", "autoWidth": true, "visible": false },

                { "data": "monthlyAppointments", "name": "monthlyAppointments", "autoWidth": true, "visible": false },
                { "data": "monthlyAttended", "name": "monthlyAttended", "autoWidth": true, "visible": false },
                { "data": "monthlyCancelled", "name": "monthlyCancelled", "autoWidth": true, "visible": false },
                { "data": "monthlyNonCompliance", "name": "monthlyNonCompliance", "autoWidth": true, "visible": false },
                { "data": "monthlyLate", "name": "monthlyLate", "autoWidth": true, "visible": false },
                { "data": "monthlySafetyAlerts", "name": "monthlySafetyAlerts", "autoWidth": true, "visible": false },
                { "data": "monthlyMissingData", "name": "monthlyMissingData", "autoWidth": true, "visible": false },
                {
                    "render": function (data, type, full, meta) { return '<a class="btn btn-info" href="/Local/Details/' + full.iD + '">Details</a>'; }
                },
            ]

    });
    $('#showDaily').on('click', function () {
        // Show Daily Data columns and hide others
        //Daily Columns
        localTable.columns([3, 4, 5, 6, 7, 8, 9]).visible(true);
        //Weekly columns
        localTable.columns([10, 11, 12, 13, 14, 15, 16]).visible(false);
        //Monthly columns
        localTable.columns([17, 18, 19, 20, 21, 22, 23]).visible(false);
    });
    $('#showWeekly').on('click', function () {
        // show weekly columns and hide others
        //Daily Columns
        localTable.columns([3, 4, 5, 6, 7, 8, 9]).visible(false);
        //Weekly columns
        localTable.columns([10, 11, 12, 13, 14, 15, 16]).visible(true);
        //Monthly columns
        localTable.columns([17, 18, 19, 20, 21, 22, 23]).visible(false);
    });
    $('#showMonthly').on('click', function () {
        // show monthly columns and hide others
        //Daily Columns
        localTable.columns([3, 4, 5, 6, 7, 8, 9]).visible(false);
        //Weekly columns
        localTable.columns([10, 11, 12, 13, 14, 15, 16]).visible(false);
        //Monthly columns
        localTable.columns([17, 18, 19, 20, 21, 22, 23]).visible(true);
    });
});
