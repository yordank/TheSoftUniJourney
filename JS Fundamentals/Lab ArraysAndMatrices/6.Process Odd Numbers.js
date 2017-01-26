/**
 * Created by ADMIN on 25.1.2017 г..
 */
function processOddNumber(arr){

    let arr2=arr.map(Number).filter((x,y)=>y%2==1).reverse();

    console.log(arr2.map(x=>x*2).join(' '));

}

//processOddNumber(['10','15','20','25'])