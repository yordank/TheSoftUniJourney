/**
 * Created by ADMIN on 25.1.2017 г..
 */
function evenPosition(input){

    let arr=input.filter((x,y)=>y%2==0);

    console.log(arr.join(' '));

}

//evenPosition(['1','2','3','4'])