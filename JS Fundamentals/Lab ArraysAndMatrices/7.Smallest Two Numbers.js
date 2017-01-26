/**
 * Created by ADMIN on 26.1.2017 г..
 */
function smallestTwoNumbers(arr){

    arr=arr.sort((a,b)=>a-b);

    console.log(arr.slice(0,2).join(' '));

}

//smallestTwoNumbers(['30', '15', '50', '5'])
//smallestTwoNumbers(['30'])