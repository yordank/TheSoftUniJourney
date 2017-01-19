/**
 * Created by ADMIN on 19.1.2017 г..
 */

function lastMonth([day,month,year]){

    let date=new Date(year,--month,++day);


    let d=date.getMonth();

    while(date.getMonth()==d)
    {
        date.setDate(date.getDate()-1);
    }
    console.log(date.getDate());

}

 