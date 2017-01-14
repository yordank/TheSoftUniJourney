/**
 * Created by ADMIN on 14.1.2017 г..
 */
function NextDay([year,month,day]){

    let date=new Date(year,month-1,day);
    let oneday=24*60*60*1000;
    let newDate=new Date(date.getTime()+oneday);

    console.log(newDate.getFullYear()+"-"+(newDate.getMonth()+1)+"-"+newDate.getDate());

}

