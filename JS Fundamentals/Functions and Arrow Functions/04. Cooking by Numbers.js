/**
 * Created by ADMIN on 25.1.2017 г..
 */
function cookingByNumbers(input){

    let number=Number(input[0]);

    for(let i=1;i<=5;i++){
        number=func(number,input[i]);
        console.log(number);
    }



    function func(number,op){
         switch (op){
             case 'chop':return number/2;
             case 'dice':return Math.sqrt(number);
             case 'spice':return number+1;
             case 'bake':return 3*number;
             case 'fillet':return number*0.8;
         }
    }

}

//cookingByNumbers(['32', 'chop', 'chop', 'chop', 'chop', 'chop'])
//cookingByNumbers(['9', 'dice', 'spice', 'chop', 'bake', 'fillet'])