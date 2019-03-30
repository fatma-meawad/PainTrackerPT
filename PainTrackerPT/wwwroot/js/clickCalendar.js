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

        id = event.id;
        start = event.start;
        end = event.end;
        type = event.type;
        desc = event.desc;
        title = event.title;

        document.getElementById('wrapContent').style.backgroundColor = "#e9faff";
        document.getElementById('title').innerHTML = "<h6>" + title + "</h6>";
        document.getElementById('edit').innerHTML = "</button><button class='btn col' onclick='editYou()' style='color: dimgray; font-weight: bold; margin-bottom: 10px;'><i class='far fa-edit' style='color: dimgray'></i> Edit description</button>";
        document.getElementById('date').innerHTML = "<h8><br>" + day + " " + month + " " + year + "</h8>";
        document.getElementById('description').innerHTML = "<h8>" + desc + "</h8>";
    });

    //when out of event, display blank
    $(document).mouseup(function (e) {
        var container = $(".fc-event-container");
        var editContainter = $("#wrapContent");

        // if the target of the click isn't the container nor a descendant of the container
        if (!container.is(e.target) && container.has(e.target).length === 0 && !editContainter.is(e.target) && editContainter.has(e.target).length === 0) {
            editContainter.hide();
        }
        else {
            editContainter.show();
        }
    });

});


