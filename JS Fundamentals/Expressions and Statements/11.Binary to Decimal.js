/**
 * Created by ADMIN on 19.1.2017 г..
 */
function binaryToDecimal([binaryNum]){

    let index=0;
    let result=0;
    for(let i of binaryNum){
        if(Number(i)==1)
        result+=Math.pow(2,7-index);
        index++;
    }
    console.log(result);
}

