/**
 * Created by ADMIN on 14.1.2017 г..
 */
function sumAndVat(arr){

    let sum=0;

    for(let input of arr)
    {
         sum = sum+ Number(input);
    }

    console.log(`sum = ${sum}`);
    console.log(`VAT = ${sum*0.2}`);
    console.log(`total = ${sum*1.20}`);

}

