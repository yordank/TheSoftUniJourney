/**
 * Created by ADMIN on 19.1.2017 г..
 */
function rounding([number,precision]){

    precision=precision>15?15:precision;
    let p=number.length-1-number.indexOf('.');
    console.log(Number(number).toFixed(Math.min(Number(precision),p)));

}
