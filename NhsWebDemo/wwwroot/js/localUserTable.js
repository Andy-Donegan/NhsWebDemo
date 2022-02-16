$(document).ready(function () {

    var rowHeader = 0;

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
                },
                // Change Daily alert level cell styling 
                {
                    //Late
                    "targets": [9],
                    "createdCell": function (td, cellData, rowData, row, col) {
                        if (cellData >= 6) {
                            $(td).addClass('fw-bolder');
                            $(td).addClass('text-danger');
                            rowHeader += 100;
                        } else
                            if (cellData >= 4) {
                                $(td).addClass('fw-bolder');
                                $(td).addClass('text-warning');
                                rowHeader += 10;
                            } else
                                if (cellData >= 2) {
                                    $(td).addClass('fw-bolder');
                                    $(td).addClass('text-info');
                                    rowHeader += 1;
                                }
                    }
                },
                {
                    // Alerts
                    "targets": [10],
                    "createdCell": function (td, cellData, rowData, row, col) {
                        if (cellData > 1) {
                            $(td).addClass('fw-bolder');
                            $(td).addClass('text-danger');
                            rowHeader += 100;
                        } else
                            if (cellData == 1) {
                                $(td).addClass('fw-bolder');
                                $(td).addClass('text-warning');
                                rowHeader += 10;
                            }
                    }
                },
                {
                    //Missing
                    "targets": [11],
                    "createdCell": function (td, cellData, rowData, row, col) {
                        if (cellData >= 7) {
                            $(td).addClass('fw-bolder');
                            $(td).addClass('text-danger');
                            rowHeader += 100;
                        } else
                            if (cellData >= 5) {
                                $(td).addClass('fw-bolder');
                                $(td).addClass('text-warning');
                                rowHeader += 10;
                            } else
                                if (cellData >= 3) {
                                    $(td).addClass('fw-bolder');
                                    $(td).addClass('text-info');
                                    rowHeader += 1;
                                }
                    }
                },
                // Change Weekly alert level cell styling 
                {
                    //Late
                    "targets": [16],
                    "createdCell": function (td, cellData, rowData, row, col) {
                        if (cellData >= 12) {
                            $(td).addClass('fw-bolder');
                            $(td).addClass('text-danger');
                            //rowHeader += 100;
                        } else
                            if (cellData >= 8) {
                                $(td).addClass('fw-bolder');
                                $(td).addClass('text-warning');
                                //rowHeader += 10;
                            } else
                                if (cellData >= 5) {
                                    $(td).addClass('fw-bolder');
                                    $(td).addClass('text-info');
                                    //rowHeader += 1;
                                }
                    }
                },
                {
                    //Alerts
                    "targets": [17],
                    "createdCell": function (td, cellData, rowData, row, col) {
                        if (cellData > 4) {
                            $(td).addClass('fw-bolder');
                            $(td).addClass('text-danger');
                            //rowHeader += 100;
                        } else
                            if (cellData > 2) {
                                $(td).addClass('fw-bolder');
                                $(td).addClass('text-warning');
                                //rowHeader += 10;
                            } else
                                if (cellData == 2) {
                                    $(td).addClass('fw-bolder');
                                    $(td).addClass('text-info');
                                    //rowHeader += 1;
                                }
                    }
                },
                {
                    //Missing
                    "targets": [18],
                    "createdCell": function (td, cellData, rowData, row, col) {
                        if (cellData >= 12) {
                            $(td).addClass('fw-bolder');
                            $(td).addClass('text-danger');
                            //rowHeader += 100;
                        } else
                            if (cellData >= 8) {
                                $(td).addClass('fw-bolder');
                                $(td).addClass('text-warning');
                                //rowHeader += 10;
                            } else
                                if (cellData >= 5) {
                                    $(td).addClass('fw-bolder');
                                    $(td).addClass('text-info');
                                    //rowHeader += 1;
                                }
                    }
                },
                // Change Monthly alert level cell styling 
                {
                    //Late
                    "targets": [23],
                    "createdCell": function (td, cellData, rowData, row, col) {
                        if (cellData >= 28) {
                            $(td).addClass('fw-bolder');
                            $(td).addClass('text-danger');
                            //rowHeader += 100;
                        } else
                            if (cellData >= 23) {
                                $(td).addClass('fw-bolder');
                                $(td).addClass('text-warning');
                                //rowHeader += 10;
                            } else
                                if (cellData >= 17) {
                                    $(td).addClass('fw-bolder');
                                    $(td).addClass('text-info');
                                    //rowHeader += 1;
                                }
                    }
                },
                {
                    //Alerts
                    "targets": [24],
                    "createdCell": function (td, cellData, rowData, row, col) {
                        if (cellData > 7) {
                            $(td).addClass('fw-bolder');
                            $(td).addClass('text-danger');
                            rowHeader += 100;
                        } else
                            if (cellData > 6) {
                                $(td).addClass('fw-bolder');
                                $(td).addClass('text-warning');
                                rowHeader += 10;
                            } else
                                if (cellData > 4) {
                                    $(td).addClass('fw-bolder');
                                    $(td).addClass('text-info');
                                    rowHeader += 1;
                                }
                    }
                },
                {
                    //Missing
                    "targets": [25],
                    "createdCell": function (td, cellData, rowData, row, col) {
                        if (cellData >= 28) {
                            $(td).addClass('fw-bolder');
                            $(td).addClass('text-danger');
                            //rowHeader += 100;
                        } else
                            if (cellData >= 23) {
                                $(td).addClass('fw-bolder');
                                $(td).addClass('text-warning');
                                //rowHeader += 10;
                            } else
                                if (cellData >= 17) {
                                    $(td).addClass('fw-bolder');
                                    $(td).addClass('text-info');
                                    //rowHeader += 1;
                                }
                    }
                },
                // Change Name column styling based on highest alert level
                {
                    "targets": [1],
                    "createdCell": function (td, cellData, rowData, row, col) {
                        if (rowHeader >= 100) {
                            $(td).addClass('fw-bolder');
                            $(td).addClass('text-white');
                            $(td).addClass('bg-danger');
                            rowHeader += 100;
                        } else
                            if (rowHeader >= 10) {
                                $(td).addClass('fw-bolder');
                                $(td).addClass('bg-warning');
                                rowHeader += 10;
                            } else
                                if (rowHeader > 0) {
                                    $(td).addClass('fw-bolder');
                                    $(td).addClass('bg-info');
                                    rowHeader += 1;
                                }
                        rowHeader = 0;
                    }
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
                    "render": function (data, type, full, meta) { return '<a class="btn btn-primary" href="/Local/Details/' + full.iD + '">Details</a>'; }
                },
            ]

    });
    $('#showDaily').on('click', function () {
        // Show Daily Data columns and hide others
        //Daily Columns
        localTable.columns([5, 6, 7, 8, 9, 10, 11]).visible(true);
        //Weekly columns
        localTable.columns([12, 13, 14, 15, 16, 17, 18]).visible(false);
        //Monthly columns
        localTable.columns([19, 20, 21, 22, 23, 24, 25]).visible(false);
    });
    $('#showWeekly').on('click', function () {
        // show weekly columns and hide others
        //Daily Columns
        localTable.columns([5, 6, 7, 8, 9, 10, 11]).visible(false);
        //Weekly columns
        localTable.columns([12, 13, 14, 15, 16, 17, 18]).visible(true);
        //Monthly columns
        localTable.columns([19, 20, 21, 22, 23, 24, 25]).visible(false);
    });
    $('#showMonthly').on('click', function () {
        // show monthly columns and hide others
        //Daily Columns
        localTable.columns([5, 6, 7, 8, 9, 10, 11]).visible(false);
        //Weekly columns
        localTable.columns([12, 13, 14, 15, 16, 17, 18]).visible(false);
        //Monthly columns
        localTable.columns([19, 20, 21, 22, 23, 24, 25]).visible(true);
    });
});
