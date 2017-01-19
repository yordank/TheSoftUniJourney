/**
 * Created by ADMIN on 19.1.2017 г..
 */
function compoundInterest([P,i,n,t]){

    [P,i,n,t]=[P,i,12/n,t].map(Number);


    console.log(P*Math.pow((1+i/(n*100)),(t*n)));

}

