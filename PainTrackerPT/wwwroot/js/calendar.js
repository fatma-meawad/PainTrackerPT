$(document).ready(function () {
    console.log("init calendar loaded");
    
    $('input[type="checkbox"][id="eventType"]').click(function () {
        if ($(this).is(":checked")) {
            if ($(this).val() == "typePD") {

            } else if ($(this).val() == "typeMI") {

            } else if ($(this).val() == "typeFU") {

            } else {

            }

        }
        else if ($(this).is(":not(:checked)")) {
            alert("Checkbox is unchecked.");
        }
    });


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
            url: 'https://localhost:5001/Events/get'

         }],
        eventRender: function (event, element) {
            console.log(event.module);
            // Follow up
            if (event.module == "typeFU") {
                element.find('.fc-time').prepend('<i class="fas fa-notes-medical"></i> ');
            }
            // Pain Diary
            if (event.module == "typePD") {
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

    var calendar = $('#calendar').fullCalendar('getCalendar');;
    // Get selected date in day view
    calendar.on('dayClick', function (date, jsEvent, view) {
        console.log(new Date(date) + " is clicked");
    });

});