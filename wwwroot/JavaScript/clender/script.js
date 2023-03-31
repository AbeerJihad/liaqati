
  //  Description
var eventslst = [
    { EventId: 1, Title: 'يوغا', startDate: '2023-03-01', endDate:'' },
    { EventId: 2, Title: 'تدريبات الارتفاع', startDate: '2023-03-06', endDate:'' },
    { EventId: 3, Title: 'تمرين ضغط الدمبل الواقف', startDate: '2023-03-06', endDate:'' },
    { EventId: 4, Title: 'تمرين ضغط الدمبل الواقف', startDate: '2023-04-01', endDate:'2023-04-02' },
    { EventId: 5, Title: 'تمرين ضغط الدمبل الواقف', startDate: '2023-03-03', endDate:'2023-03-05' },
  
];





var exModel = document.getElementById('eventModal');

document.addEventListener('DOMContentLoaded', function () {
   draw(eventslst.map(obj => {
       return {
           id: obj.EventId,
            title: obj.Title,
            start: obj.startDate,
            end: obj.endDate
        }
   }) )

});

function draw(data) {
    var calendarEl = document.getElementById('calendar');
    var calendar = new FullCalendar.Calendar(calendarEl, {
        //    defaultView: 'month',

        headerToolbar: {
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,timeGridDay,listMonth'
        },
        initialDate: new Date(), //current data //alaa
        navLinks: true, // can click day/week names to navigate views    alaa //view events for each date 
        businessHours: true, // display business hours
        editable: true,
        selectable: true,
        locale: 'ar',
        direction: 'rtl',
        buttonText: {
            today: 'اليوم',
            month: 'الشهر',
            week: 'الأسبوع',
            day: 'اليوم',
            list: 'لائحة'

        },

        //events: '/Home/GetCalendarEvents',
        eventClick: ShowModelEvent


            ////Sweet Alert
        //function (info) {
        //    //var eventd = calendar.getEventById(event.id)
        //    //alert(eventd);
        //    info.jsEvent.preventDefault();

        //    console.log(info.event)
        //    console.log(info.event.title)
        //    console.log(info.event.id)
        //    Swal.fire({
        //        title: info.event.title ,
        //        text: 'Id :'+ info.event.id,
        //        imageUrl: 'https://unsplash.it/400/200',
        //        imageWidth: 400,
        //        imageHeight: 200,
        //        imageAlt: 'Custom image',
        //    })
        //    }

     
        ,
        selectable: true,
        select: addEventdd,
        events: data,
    


        //      [
        //  {
        //      title: 'Meeting Alaa Yass',
        //      start: '2023-03-06',
        //      end:'2023-03-09',
        //        color: 'red',


        //    },
        //    {
        //      title: 'تمرين  1',
        //      start: '2023-03-06',


        //    },
        //  {
        //    title: 'Business Lunch',
        //    start: '2023-03-03T13:00:00',
        //   // end:
        //    constraint: 'businessHours'
        //  },
        //  {
        //    title: 'Meeting',
        //    start: '2023-03-13T11:00:00',
        //    constraint: 'availableForMeeting', // defined below
        //    color: '#257e4a'
        //  },
        //  {
        //    title: 'Conference',
        //    start: '2023-03-18',
        //    end: '2023-03-20'
        //  },
        //  {
        //    title: 'Party',
        //    start: '2023-03-29T20:00:00'
        //  },

        //  // areas where "Meeting" must be dropped
        //  {
        //    groupId: 'availableForMeeting',
        //    start: '2020-09-11T10:00:00',
        //    end: '2020-09-11T16:00:00',
        //    display: 'background'
        //  },
        //  {
        //    groupId: 'availableForMeeting',
        //    start: '2020-09-13T10:00:00',
        //    end: '2020-09-13T16:00:00',
        //    display: 'background'
        //  },

        //  // red areas where no events can be dropped
        //  {
        //    start: '2020-09-24',
        //    end: '2020-09-28',
        //    overlap: false,
        //    display: 'background',
        //    color: '#ff9f89'
        //  },
        //  {
        //    start: '2020-09-06',
        //    end: '2020-09-08',
        //    overlap: false,
        //    display: 'background',
        //    color: '#ff9f89'
        //  }
        //]
    });

    calendar.render();
}

var eventid = document.getElementById('eventId');
//var exerciseID = document.getElementById('eventModal');
var title = document.getElementById('EventTitle');
var startDate = document.getElementById('StartTime');

function ShowModelEvent(info) {
    let modelElm = document.getElementById('eventModel');
    var myModal = new bootstrap.Modal(modelElm, {
        keyboard: false
    })
          console.log(info.event)
          console.log(info.event.title)
    console.log(info.event.id)
    eventid.textContent = info.event.id;
    title.textContent = info.event.title;

    myModal.toggle()
}
/**
 * Calendar Methods
 **/
function addEventdd(start, end) {
    alert('here');
    var selctedDay = [];
    console.log(start);
    for (let i = 0; i < eventslst.length; i++) {
        if (eventslst[i].startDate == start.startStr) {
            console.log('==')
            selctedDay.push(eventslst[i]);

        }
    }
   
   //console.log(event);
    console.log(end);
    console.log(selctedDay);

}







//function updateEvent(event, element) {
//    currentEvent = event;

//    if ($(this).data("qtip")) $(this).qtip("hide");

//    $('#eventModalLabel').html('Edit Event');
//    $('#eventModalSave').html('Update Event');
//    $('#EventTitle').val(event.title);
//    $('#Description').val(event.description);
//    $('#isNewEvent').val(false);

//    const start = formatDate(event.start);
//    const end = formatDate(event.end);

//    fpStartTime.setDate(start);
//    fpEndTime.setDate(end);

//    $('#StartTime').val(start);
//    $('#EndTime').val(end);

//    if (event.allDay) {
//        $('#AllDay').prop('checked', 'checked');
//    } else {
//        $('#AllDay')[0].checked = false;
//    }

//    $('#eventModal').modal('show');
//}

//function addEvent(start, end) {
//    //$('#eventForm')[0].reset();

//    //$('#eventModalLabel').html('Add Event');
//    //$('#eventModalSave').html('Create Event');
//    //$('#isNewEvent').val(true);

//    //start = formatDate(start);
//    //end = formatDate(end);

//    //fpStartTime.setDate(start);
//    //fpEndTime.setDate(end);

//    /*   $('#eventModal').modal('show');*/
//    var myModal = new bootstrap.Modal(exModel, {
//        keyboard: false
//    })
//    console.log(start);
//    console.log(end);
//}





