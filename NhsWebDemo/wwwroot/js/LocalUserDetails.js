$(document).ready(function () {
    // Daily Checks
    let dailyHeader = 0;

    if (modelData.dailySafetyAlerts > 1) {
        document.getElementById("dailyAlert").classList.add("bg-danger");
        dailyHeader += 100;
    }
    else if (modelData.dailySafetyAlerts == 1) {
        document.getElementById("dailyAlert").classList.add("bg-warning");
        dailyHeader += 10;
    }

    if (modelData.dailyMissingData >= 7) {
        document.getElementById("dailyMissing").classList.add("bg-danger");
        dailyHeader += 100;
    }
    else if (modelData.dailyMissingData >= 5) {
        document.getElementById("dailyMissing").classList.add("bg-warning");
        dailyHeader += 10;
    }
    else if (modelData.dailyMissingData >= 3) {
        document.getElementById("dailyMissing").classList.add("bg-info");
        dailyHeader += 1;
    }

    if (modelData.dailyLate >= 6) {
        document.getElementById("dailyLate").classList.add("bg-danger");
        dailyHeader += 100;
    }
    else if (modelData.dailyLate >= 4) {
        document.getElementById("dailyLate").classList.add("bg-warning");
        dailyHeader += 10;
    }
    else if (modelData.dailyLate >= 2) {
        document.getElementById("dailyLate").classList.add("bg-info");
        dailyHeader += 1;
    }



    // check what type of warnings we had and set header to identify issues.
    if (dailyHeader >= 100) {
        document.getElementById("dailyHeader").classList.add("bg-danger");
    }
    else if (dailyHeader >= 10) {
        document.getElementById("dailyHeader").classList.add("bg-warning");
    }
    else if (dailyHeader >= 1) {
        document.getElementById("dailyHeader").classList.add("bg-info");
    }


    // Weekly Checks
    let weeklyHeader = 0;

    if (modelData.weeklySafetyAlerts > 1) {
        document.getElementById("weeklyAlert").classList.add("bg-danger");
        weeklyHeader += 100;
    }
    else if (modelData.weeklySafetyAlerts == 1) {
        document.getElementById("weeklyAlert").classList.add("bg-warning");
        weeklyHeader += 10;
    }

    if (modelData.weeklyMissingData >= 7) {
        document.getElementById("weeklyMissing").classList.add("bg-danger");
        weeklyHeader += 100;
    }
    else if (modelData.weeklyMissingData >= 5) {
        document.getElementById("weeklyMissing").classList.add("bg-warning");
        weeklyHeader += 10;
    }
    else if (modelData.weeklyMissingData >= 3) {
        document.getElementById("weeklyMissing").classList.add("bg-info");
        weeklyHeader += 1;
    }

    if (modelData.weeklyLate >= 6) {
        document.getElementById("weeklyLate").classList.add("bg-danger");
        weeklyHeader += 100;
    }
    else if (modelData.weeklyLate >= 4) {
        document.getElementById("weeklyLate").classList.add("bg-warning");
        weeklyHeader += 10;
    }
    else if (modelData.weeklyLate >= 2) {
        document.getElementById("weeklyLate").classList.add("bg-info");
        weeklyHeader += 1;
    }

    // check what type of warnings we had and set header to identify issues.
    if (weeklyHeader >= 100) {
        document.getElementById("weeklyHeader").classList.add("bg-danger");
    }
    else if (weeklyHeader >= 10) {
        document.getElementById("weeklyHeader").classList.add("bg-warning");
    }
    else if (weeklyHeader >= 1) {
        document.getElementById("weeklyHeader").classList.add("bg-info");
    }



    // Monthly Checks




});
