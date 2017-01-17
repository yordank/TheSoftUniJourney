/**
 * Created by ADMIN on 17.1.2017 г..
 */
function LeapYear([year]){

    if((year%4==0 && year%100!=0 )|| year % 400 == 0)
        console.log('yes');
    else
        console.log('no');
}
