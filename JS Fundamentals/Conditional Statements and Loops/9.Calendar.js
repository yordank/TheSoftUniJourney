/**
 * Created by ADMIN on 22.1.2017 г..
 */
function Calendar([day,month,year]){

    
    let date=new Date(year+'-'+month+'-'+day);

    date.setDate(date.getDate());

    let lastDay=date;

    let currentMonth=date.getMonth();

    while(lastDay.getMonth()==currentMonth){

        lastDay.setDate(lastDay.getDate()+1);

    }

    lastDay.setDate(lastDay.getDate()-1);

    lastDay.setDate(lastDay.getDate()+6-lastDay.getDay());



    let firstDay=new Date(year+'-'+month+'-'+1);

    firstDay.setDate(firstDay.getDate()-firstDay.getDay())

    let prevMonth;

    prevMonth=firstDay.getMonth();

    let nextMonth=lastDay.getMonth();

    let iterDay=firstDay;

    let count=0;

    let html='<table>\n';

    html+='<tr><th>Sun</th><th>Mon</th><th>Tue</th><th>Wed</th><th>Thu</th><th>Fri</th><th>Sat</th></tr>\n';

    while(iterDay.getTime()<=lastDay.getTime()){

        if(count==0)
            html+='<tr>';

        let str='';



        if(Number(iterDay.getMonth())===Number(prevMonth) && Number(prevMonth)!=Number(currentMonth) )
            str=' class="prev-month"';



        if(Number(iterDay.getMonth())===Number(nextMonth) && Number(nextMonth)!=Number(currentMonth) )
            str=' class="next-month"';

        if(day==Number(iterDay.getDate()) && currentMonth == Number(iterDay.getMonth()))
            str=' class="today"';


        html+='<td'+`${str}`+'>'+iterDay.getDate()+'</td>';

        count++;

        if(count==7)
        {
            count=0;
            html+='</tr>\n';
        }

        iterDay.setDate(iterDay.getDate()+1);

    }
    html+='</table>';
    console.log(html);


}

