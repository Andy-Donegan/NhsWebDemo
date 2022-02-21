var pieChart = Highcharts.chart('pieChartContainer', {
    chart: {
        plotBackgroundColor: null,
        plotBorderWidth: null,
        plotShadow: false,
        type: 'pie'
    },
    title: {
        text: 'January 2021'
    },
    tooltip: {
        pointFormat: '{series.name}: <b>{point.y:.f}</b>'
    },
    accessibility: {
        point: {
            valueSuffix: '%'
        }
    },
    plotOptions: {
        pie: {
            allowPointSelect: true,
            cursor: 'pointer',
            dataLabels: {
                enabled: true,
                format: '<b>{point.name}</b>: {point.y:.f}'
            },
            showInLegend: true
        }
    },
    series: [{
        name: 'Appointments',
        colorByPoint: true,
        data: [{
            name: 'Appointments',
            y: Math.floor(Math.random() * (200 - 140 + 1)) + 140,
            sliced: true,
            selected: true
        }, {
            name: 'Attended',
            y: Math.floor(Math.random() * (160 - 120 + 1)) + 120
        }, {
            name: 'Cancelled',
            y: Math.floor(Math.random() * (30 - 5 + 1)) + 5
        }, {
            name: 'Non Compliance',
            y: Math.floor(Math.random() * (20 - 1 + 1)) + 1
        }, {
            name: 'Late',
            y: 6
        }, {
            name: 'Missing Data',
            y: Math.floor(Math.random() * (100 - 1 + 1)) + 1
        }, {
            name: 'Safety Alerts',
            y: Math.floor(Math.random() * (35 - 1 + 1)) + 1
        }]
    }]
});

// Drop down select list, just generates random new data every time a new month is selected.
const dropdown = document.querySelector("#dropdown");

dropdown.addEventListener('change', (event) => {
    let value = event.target.value, // not used but can be used for conditional data, currently generating complete random for each month.
        newData = [{
            name: 'Appointments',
            y: Math.floor(Math.random() * (200 - 140 + 1)) + 140,
        }, {
            name: 'Attended',
            y: Math.floor(Math.random() * (160 - 120 + 1)) + 120
        }, {
            name: 'Cancelled',
            y: Math.floor(Math.random() * (30 - 5 + 1)) + 5
        }, {
            name: 'Non Compliance',
            y: Math.floor(Math.random() * (20 - 1 + 1)) + 1
        }, {
            name: 'Late',
            y: 6
        }, {
            name: 'Missing Data',
            y: Math.floor(Math.random() * (100 - 1 + 1)) + 1
        }, {
            name: 'Safety Alerts',
            y: Math.floor(Math.random() * (35 - 1 + 1)) + 1
            }];
    pieChart.setTitle({ text: value + ' 2021' });
    pieChart.series[0].update({
        data: newData
    });

});

Highcharts.chart('barChartContainer', {
    chart: {
        type: 'column'
    },
    title: {
        text: '2021 Appointment Data'
    },
    xAxis: {
        categories: [
            'Jan',
            'Feb',
            'Mar',
            'Apr',
            'May',
            'Jun',
            'Jul',
            'Aug',
            'Sep',
            'Oct',
            'Nov',
            'Dec'
        ],
        crosshair: true
    },
    yAxis: {
        min: 0,
        title: {
            text: 'Monthly Totals'
        }
    },
    tooltip: {
        headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
        pointFormat: '<tr><td style="color:{series.color};padding:0">{series.name}: </td>' +
            '<td style="padding:0"><b>{point.y:.f}</b></td></tr>',
        footerFormat: '</table>',
        shared: true,
        useHTML: true
    },
    plotOptions: {
        column: {
            pointPadding: 0.2,
            borderWidth: 0
        }
    },
    // Generate Random array of numbers for Yearly figures.
    series: [{
        name: 'Appointments',
        data: Array.from({ length: 12 }, () => Math.floor(Math.random() * (200 - 140 + 1)) + 140)

    }, {
        name: 'Attended',
        data: Array.from({ length: 12 }, () => Math.floor(Math.random() * (160 - 120 + 1)) + 120)

    }, {
        name: 'Cancelled',
        data: Array.from({ length: 12 }, () => Math.floor(Math.random() * (30 - 5 + 1)) + 5)

    }, {
        name: 'Non Compliance',
        data: Array.from({ length: 12 }, () => Math.floor(Math.random() * (20 - 1 + 1)) + 1)

    }, {
        name: 'Missing Data',
        data: Array.from({ length: 12 }, () => Math.floor(Math.random() * (100 - 1 + 1)) + 1)

    }, {
        name: 'Alerts',
        data: Array.from({ length: 12 }, () => Math.floor(Math.random() * (35 - 1 + 1)) + 1)

    }
    ]
});
