/**
 * Created by ADMIN on 22.1.2017 г..
 */
function aggregate(arr){

    arr=arr.map(Number);
    let sum=arr.reduce((a,b)=>a+b);
    let sum1=arr.reduce((a,b)=>a+1/b);
    sum1=sum1-arr[0]+1/arr[0];
    let concat=arr.join('');

    console.log(sum);
    console.log(sum1);
    console.log(concat);

}


