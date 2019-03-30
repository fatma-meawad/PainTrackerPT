$(document).ready(function () {
    console.log("init calendar loaded");
    function addEventFromCalendar(eventUrl) {
        $('#calendar').fullCalendar('addEventSource', eventUrl);
        $('#calendar').fullCalendar('rerenderEvents');
        $('#calendar').fullCalendar('refetchEvents');
    }

    function removeEventFromCalendar(eventUrl) {
        $('#calendar').fullCalendar('removeEventSource', eventUrl);
        $('#calendar').fullCalendar('rerenderEvents');
        $('#calendar').fullCalendar('refetchEvents');
    }

    $("#calendar").fullCalendar({
        // put your options and callbacks here
        header: {
            left: 'prev,next today',
            center: 'title',
            right: 'month,agendaWeek,agendaDay,list'
        },
        eventLimit: true, // when too many events in a day, show the popover
        nowIndicator: true,
        eventSources: [{
            //url: 'data/events.json', // use the `url` property

        }],
        eventRender: function (event, element) {
            // Follow up
            if (event.type == "typeFU") {
                element.find('.fc-time').prepend('<i class="fas fa-notes-medical"></i> ');
            }

            // Medicine Intake
            if (event.type == "typeMI") {
                element.find('.fc-time').prepend('<i class="fas fa-medkit"></i> ');
            }

            // Pain Diary
            if (event.type == "typePD") {
                if (event.painLevel == 0) {
                    element.find('.fc-time').prepend('<i class="fas fa-smile" style="color:olivedrab"></i> ');
                }
                if (event.painLevel == 1 || event.painLevel == 2) {
                    element.find('.fc-time').prepend('<i class="fas fa-meh" style="color:yellowgreen"></i> ');
                }
                else if (event.painLevel == 3 || event.painLevel == 4) {
                    element.find('.fc-time').prepend('<i class="fas fa-frown" style="color:gold"></i> ');
                }
                else if (event.painLevel == 5 || event.painLevel == 6) {
                    element.find('.fc-time').prepend('<i class="fas fa-tired" style="color:darkorange"></i> ');
                }
                else if (event.painLevel == 7 || event.painLevel == 8) {
                    element.find('.fc-time').prepend('<i class="fas fa-sad-tear" style="color:salmon"></i> ');
                }
                else if (event.painLevel == 9 || event.painLevel == 10) {
                    element.find('.fc-time').prepend('<i class="fas fa-sad-cry" style="color:darkred"></i> ');
                }
            }

        }

    });

    var calendar = $('#calendar').fullCalendar('getCalendar');
    // Get selected date in day view
    calendar.on('dayClick', function (date, jsEvent, view) {
        console.log(new Date(date) + " is clicked");
    });

    $('#calendar').fullCalendar('addEventSource', 'https://localhost:5001/events/getpaindairy');
    $('#calendar').fullCalendar('addEventSource', 'https://localhost:5001/events/getmedicineintake');
    $('#calendar').fullCalendar('addEventSource', 'https://localhost:5001/events/getfollowup');
    $('#calendar').fullCalendar('rerenderEvents');

    $('input[type="checkbox"][id="eventType"]').click(function () {
        if ($(this).is(":checked")) {
            if ($(this).val() == "typePD") {
                addEventFromCalendar('https://localhost:5001/events/getpaindairy');
            }
            else if ($(this).val() == "typeMI") {
                addEventFromCalendar('https://localhost:5001/events/getmedicineintake');
            }
            else if ($(this).val() == "typeFU") {
                addEventFromCalendar('https://localhost:5001/events/getfollowup');
            }
        }
        else if ($(this).is(":not(:checked)")) {
            if ($(this).val() == "typePD") {
                removeEventFromCalendar('https://localhost:5001/events/getpaindairy');
            }
            else if ($(this).val() == "typeMI") {
                removeEventFromCalendar('https://localhost:5001/events/getmedicineintake');
            }
            else if ($(this).val() == "typeFU") {
                removeEventFromCalendar('https://localhost:5001/events/getfollowup');
            }
        }
    });

    // Act on clicks to a elements
    $("#exportCSV").on('click', function (e) {
        // prevent the default action, in this case the following of a link
        e.preventDefault();
        // capture the href attribute of the a element
        var url = $(this).attr('href');
        // perform a get request using ajax to the captured href value
        $.get(url, function () {
            alert("CSV exported successfully to desktop.")
            document.location.reload();
        });
    });
    
});