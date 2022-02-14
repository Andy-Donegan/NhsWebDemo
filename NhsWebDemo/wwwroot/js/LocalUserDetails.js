$(document).ready(function () {
    // Daily Checks
    let dailyHeader = 0;
    if (modelData.dailySafetyAlerts > 1) {
        document.getElementById("dailyAlert").classList.add("bg-danger");
        dailyHeader += 100;
    }
    else if (modelData.dailySafetyAlerts = 1) {
        document.getElementById("dailyAlert").classList.add("bg-warning");
        dailyHeader += 1;
    }




    // check what type of warnings we had and set header to identify issues.
    if (dailyHeader >= 100) {
        document.getElementById("dailyHeader").classList.add("bg-danger");
    } else if (dailyHeader > 0) {
        document.getElementById("dailyHeader").classList.add("bg-warning");
    }


    // Weekly Checks


    // Monthly Checks




});
