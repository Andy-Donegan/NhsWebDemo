$(document).ready(function () {
    //enable popovers
    $('[data-toggle="popover"]').popover();

    $.ajax({
        url: '/Local/GetMapMarker',
        type: 'GET',
        success: function (data) {
            //create a blank array
            var markers = [];

            //loop the list of addresses returned from Ajax request
            $.each(data, function (index, item) {
                //create a blank array of address
                var marker = {};

                //fill data
                marker["title"] = item.title;
                marker["lat"] = item.lat;
                marker["lng"] = item.long;
                marker["description"] = item.title + " - " + item.pointTime;
                marker["isComplete"] = item.isComplete;
                marker["isLate"] = item.isLate;
                marker["isTravel"] = item.isTravel;
                marker["lastLocation"] = item.lastLocation;
                marker["zIndex"] = item.zIndex;

                //push the current marker details in markers array
                markers.push(marker);
            })

            //call Map function with all markers passed as list of arrays
            initializeMap(markers);

        }
    });

    function initializeMap(markers) {
    //Set the Default Latitude and Longitude of the Map  
    var myAddress = new google.maps.LatLng(53.829721, -1.778213);

    //Create Options or set different Characteristics of Google Map  
    var mapOptions = {
        center: myAddress,
        zoom: 15,
        mapTypeId: 'hybrid',
        gestureHandling: "greedy",
        mapTypeControl: false,
        zoomControl: false,
        keyboardControl: false,
    };

    //Display the Google map in the div control with the defined Options  
    var infoWindow = new google.maps.InfoWindow();
    var map = new google.maps.Map(document.getElementById("mapDiv"), mapOptions);
    var marker;

        //loop through each marker data
        for (i = 0; i < markers.length; i++) {
            var data = markers[i]

            //set lat long of marker
            var myLatlng = new google.maps.LatLng(data.lat, data.lng);

            // set standard Marker Icon as Travel
            var iconUrl = "http://maps.google.com/mapfiles/kml/pal4/icon62.png";
            // Check location state and change Icon accordingly
            if (!data.isTravel) {
                if (data.isComplete) {
                    // Appointment Complete
                    iconUrl = "http://maps.google.com/mapfiles/ms/icons/grn-pushpin.png";
                }
                else if (data.isLate) {
                    // Appointment is Late
                    iconUrl = "http://maps.google.com/mapfiles/ms/icons/red-pushpin.png";
                }
                else {
                    // Appointment is outstanding
                    iconUrl = "http://maps.google.com/mapfiles/ms/icons/blue-pushpin.png";
                }
            }
            
            // Create new marker
            marker = new google.maps.Marker({
                position: myLatlng,
                map: map,
                title: data.title,
                icon: iconUrl,
                zIndex: data.zIndex,
            });

            (function (marker, data) {
                // add a on marker click event
                google.maps.event.addListener(marker, "click", function (e) {
                    //show description
                    infoWindow.setContent(data.description);
                    infoWindow.open(map, marker);
                });
            })(marker, data);
            // Set last location to bounce.
            if (data.lastLocation) {
                marker.setAnimation(google.maps.Animation.BOUNCE);
                map.setCenter(new google.maps.LatLng(myLatlng), 15);
            }
        }

    }
});

    // Car Icon "http://maps.google.com/mapfiles/kml/pal4/icon62.png"
    // Blue dot "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
    // Green dot "http://maps.google.com/mapfiles/ms/icons/green-dot.png"
    // Red dot "http://maps.google.com/mapfiles/ms/icons/red-dot.png"
    // Yellow PushPin "http://maps.google.com/mapfiles/ms/icons/ylw-pushpin.png"
    // Blue PushPin "http://maps.google.com/mapfiles/ms/icons/blue-pushpin.png"
    // Green PushPin "http://maps.google.com/mapfiles/ms/icons/grn-pushpin.png"
    // Pink Pushpin "http://maps.google.com/mapfiles/ms/icons/pink-pushpin.png"
    // Purple Pushpin "http://maps.google.com/mapfiles/ms/icons/purple-pushpin.png"
    // Red Pushpin "http://maps.google.com/mapfiles/ms/icons/red-pushpin.png"