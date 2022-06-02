//1
{
    // function deleted()
    // {
    //     var app = document.querySelectorAll('.time')
    //     if(app.length == 2)
    //     {
    //         app[0].remove()
    //         app[1].remove()
    //     }
    // }

    function getNowDate(){
        // deleted()
        now = new Date ();
        var hours,minutes;
        hours = now.getHours()
        minutes = now.getMinutes()
        document.writeln("Time: " + hours  + ":" + minutes + "<br>")
        document.write("Date: " + (now.getMonth() + 1) + "/" + now.getDate() + "/" + now.getYear() )
    }
    getNowDate()
    // var i = setInterval(getNowDate, 6000)
    // i
}

