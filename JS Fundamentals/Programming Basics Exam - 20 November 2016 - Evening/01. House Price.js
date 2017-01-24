/**
 * Created by ADMIN on 23.1.2017 г..
 */
function func([kitchen,smallroom,price]){

    [kitchen,smallroom,price]=[kitchen,smallroom,price].map(Number);

    let bathroom=kitchen/2;
    let secondroom=kitchen*1.1;
    let thirdroom=secondroom*1.1;

    let totalarea=kitchen+smallroom+bathroom+secondroom+thirdroom;

    totalarea=totalarea*1.05;

    let totalPrice=totalarea*price;

    console.log(totalPrice.toFixed(2));

}

//func(['20','10','699.99'])