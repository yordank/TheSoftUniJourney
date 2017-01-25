/**
 * Created by ADMIN on 25.1.2017 г..
 */

function modifyAverage([num]){

    let len=num.length;

    let sum=0;

    sum=Array.from(num).map(Number).reduce((a,b)=>a+b,0);

    let average=sum/len;

    while(average<=5){

        num=num+'9';

        sum=Array.from(num).map(Number).reduce((a,b)=>a+b,0);
        len++;
        average=sum/len;

    }

    console.log(num);


}

//modifyAverage(['0'])



