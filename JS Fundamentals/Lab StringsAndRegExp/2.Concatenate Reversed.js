/**
 * Created by ADMIN on 27.1.2017 г..
 */
function concatenateReversed(input){

    input=input.reduce((a,b)=>a+b);
    input=Array.from(input).reverse();
    console.log(input.join(''));

}

//concatenateReversed(['i','am','student'])