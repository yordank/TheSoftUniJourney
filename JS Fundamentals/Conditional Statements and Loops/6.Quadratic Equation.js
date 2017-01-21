/**
 * Created by ADMIN on 21.1.2017 г..
 */
function QuadraticEquation([a,b,c]){

    [a,b,c]=[a,b,c].map(Number);

    let d=Math.pow(b,2)-4*a*c;

    if(d<0)
        console.log('No');

    if(d==0){
         console.log(-b/(2*a));
        }

    if(d>0){
        console.log((-b-Math.sqrt(d))/(2*a));
        console.log((-b+Math.sqrt(d))/(2*a));
    }


}

