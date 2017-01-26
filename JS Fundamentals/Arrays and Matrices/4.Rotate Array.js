/**
 * Created by ADMIN on 26.1.2017 г..
 */
function rotate(input){

    let rotateCount=Number(input[input.length-1])%(input.length-1);

    input=input.slice(0,input.length-1);

    for (let i = 0; i < rotateCount; i++) {

        input.unshift(input.pop());
    }

    console.log(input.join(' '))

}

//rotate(['1','2','3','4','5','2'])
//rotate(['Banana','Orange','Coconut','Apple','15'])