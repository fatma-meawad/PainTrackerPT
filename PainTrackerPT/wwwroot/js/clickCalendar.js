$(document).ready(function () {
    console.log("click event loaded");

    var calendar = $('#calendar').fullCalendar('getCalendar');;
    // Get selected date in day view
    calendar.on('eventClick', function (event, jsEvent, view) {
        console.log(event);
        title = event.title;
        //Change date format for display
        date = event.start.toDate();
        var month = new Array();
        month[0] = "January";
        month[1] = "February";
        month[2] = "March";
        month[3] = "April";
        month[4] = "May";
        month[5] = "June";
        month[6] = "July";
        month[7] = "August";
        month[8] = "September";
        month[9] = "October";
        month[10] = "November";
        month[11] = "December";
        var month = month[date.getUTCMonth()];
        var day = date.getUTCDate();
        var year = date.getUTCFullYear();
        document.getElementById('wrapContent').style.backgroundColor = "#e9faff";
        document.getElementById('title').innerHTML = "<h4>" + title + "</h4>";
        document.getElementById('date').innerHTML = "<h5>" + day + " " + month + " " + year + "</h5>";
        //document.getElementById('type').innerHTML = "<br><h5>" + "Type:" + " " + month + "</h5>";
    });
    //when out of event, display blank
    $(document).mouseup(function (e) {
        var container = $("fc-event-container");
        var hideyou = $("wrapContent");

        // if the target of the click isn't the container nor a descendant of the container
        if (!container.is(e.target) && container.has(e.target).length === 0) {
            hideyou.hide();
        }
    });

});


