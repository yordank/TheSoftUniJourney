/**
 * Created by ADMIN on 17.1.2017 г..
 */
function triangleArea([a,b,c]){

    let p=(Number(a)+Number(b)+Number(c))/2;
    return Math.sqrt(p*(p-a)*(p-b)*(p-c));
}

