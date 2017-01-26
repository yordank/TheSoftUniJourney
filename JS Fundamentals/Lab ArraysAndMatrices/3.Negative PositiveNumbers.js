/**
 * Created by ADMIN on 25.1.2017 г..
 */
function negativePositive(input){

    input=input.map(Number);

    let result=[];

    for(let item of input){

        if(item<0)
            result.unshift(item);
        else
            result.push(item);

    }

    console.log(result.join('\n'));

}
//negativePositive(['3','2','-1'])