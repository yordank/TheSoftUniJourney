/**
 * Created by ADMIN on 22.1.2017 г..
 */
function calculator([num1,num2,op]){

    [num1,num2]=[num1,num2].map(Number);

    let add=((num1,num2)=>num1+num2);
    let div=((num1,num2)=>num1/num2);
    let mult=((num1,num2)=>num1*num2);
    let sub=((num1,num2)=>num1-num2);

    switch (op){
        case '+':console.log(add(num1,num2));break;
        case '/':console.log(div(num1,num2));break;
        case '*':console.log(mult(num1,num2));break;
        case '-':console.log(sub(num1,num2));break;
    }


}

