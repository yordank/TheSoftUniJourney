/**
 * Created by ADMIN on 25.1.2017 г..
 */
function firstAndLastK(input){

        input=input.map(Number);

        let num=input[0];

        console.log(input.slice(1,num+1).join(' '));

        console.log(input.slice(input.length-num,input.length).join(' '));

}

//firstAndLastK(['3','2','3','4','5','6','7'])