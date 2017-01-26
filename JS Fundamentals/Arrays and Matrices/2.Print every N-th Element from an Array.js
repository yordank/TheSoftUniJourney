/**
 * Created by ADMIN on 26.1.2017 г..
 */
function printEveryNthElement(input){

 console.log(input.slice(0,input.length-1).filter((x,y)=>y%Number(input[input.length-1])==0).join('\n'))

}

//printEveryNthElement(['1','2','3','4','5','6','7','8','9','10','3'])