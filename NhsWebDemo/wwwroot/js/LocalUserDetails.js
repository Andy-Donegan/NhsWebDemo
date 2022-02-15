$(document).ready(function () {
    // Daily Checks
    let dailyHeader = 0;

    if (modelData.dailySafetyAlerts > 1) {
        document.getElementById("dailyAlert").classList.add("bg-danger");
        document.getElementById("dailyAlert").classList.add("text-white");
        dailyHeader += 100;
    }
    else if (modelData.dailySafetyAlerts == 1) {
        document.getElementById("dailyAlert").classList.add("bg-warning");
        dailyHeader += 10;
    }

    if (modelData.dailyMissingData >= 7) {
        document.getElementById("dailyMissing").classList.add("bg-danger");
        document.getElementById("dailyMissing").classList.add("text-white");
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
        document.getElementById("dailyLate").classList.add("text-white");
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

    if (modelData.weeklySafetyAlerts > 4) {
        document.getElementById("weeklyAlert").classList.add("bg-danger");
        document.getElementById("weeklyAlert").classList.add("text-white");
        weeklyHeader += 100;
    }
    else if (modelData.weeklySafetyAlerts > 2) {
        document.getElementById("weeklyAlert").classList.add("bg-warning");
        weeklyHeader += 10;
    }
    else if (modelData.weeklySafetyAlerts == 2) {
        document.getElementById("weeklyAlert").classList.add("bg-info");
        weeklyHeader += 11;
    }

    if (modelData.weeklyMissingData >= 12) {
        document.getElementById("weeklyMissing").classList.add("bg-danger");
        document.getElementById("weeklyMissing").classList.add("text-white");
        weeklyHeader += 100;
    }
    else if (modelData.weeklyMissingData >= 8) {
        document.getElementById("weeklyMissing").classList.add("bg-warning");
        weeklyHeader += 10;
    }
    else if (modelData.weeklyMissingData >= 5) {
        document.getElementById("weeklyMissing").classList.add("bg-info");
        weeklyHeader += 1;
    }

    if (modelData.weeklyLate >= 12) {
        document.getElementById("weeklyLate").classList.add("bg-danger");
        document.getElementById("weeklyLate").classList.add("text-white");
        weeklyHeader += 100;
    }
    else if (modelData.weeklyLate >= 8) {
        document.getElementById("weeklyLate").classList.add("bg-warning");
        weeklyHeader += 10;
    }
    else if (modelData.weeklyLate >= 5) {
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

    let monthlyHeader = 0;

    if (modelData.monthlySafetyAlerts > 7) {
        document.getElementById("monthlyAlert").classList.add("bg-danger");
        document.getElementById("monthlyAlert").classList.add("text-white");
        monthlyHeader += 100;
    }
    else if (modelData.monthlySafetyAlerts > 6) {
        document.getElementById("monthlyAlert").classList.add("bg-warning");
        monthlyHeader += 10;
    }
    else if (modelData.monthlySafetyAlerts > 4) {
        document.getElementById("monthlyAlert").classList.add("bg-info");
        monthlyHeader += 11;
    }

    if (modelData.monthlyMissingData >= 28) {
        document.getElementById("monthlyMissing").classList.add("bg-danger");
        document.getElementById("monthlyMissing").classList.add("text-white");
        monthlyHeader += 100;
    }
    else if (modelData.monthlyMissingData >= 23) {
        document.getElementById("monthlyMissing").classList.add("bg-warning");
        monthlyHeader += 10;
    }
    else if (modelData.monthlyMissingData >= 17) {
        document.getElementById("monthlyMissing").classList.add("bg-info");
        monthlyHeader += 1;
    }

    if (modelData.monthlyLate >= 28) {
        document.getElementById("monthlyLate").classList.add("bg-danger");
        document.getElementById("monthlyLate").classList.add("text-white");
        monthlyHeader += 100;
    }
    else if (modelData.monthlyLate >= 23) {
        document.getElementById("monthlyLate").classList.add("bg-warning");
        monthlyHeader += 10;
    }
    else if (modelData.monthlyLate >= 18) {
        document.getElementById("monthlyLate").classList.add("bg-info");
        monthlyHeader += 1;
    }

    // check what type of warnings we had and set header to identify issues.
    if (monthlyHeader >= 100) {
        document.getElementById("monthlyHeader").classList.add("bg-danger");
    }
    else if (monthlyHeader >= 10) {
        document.getElementById("monthlyHeader").classList.add("bg-warning");
    }
    else if (monthlyHeader >= 1) {
        document.getElementById("monthlyHeader").classList.add("bg-info");
    }


});
