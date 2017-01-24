/**
 * Created by ADMIN on 24.1.2017 г..
 */
function flowershop([magnolia,hyacinths,roses,cactus,price]){

    [magnolia,hyacinths,roses,cactus,price]=[magnolia,hyacinths,roses,cactus,price].map(Number);

    let totalPrice=3.25*magnolia+4*hyacinths+3.5*roses+8*cactus;
    totalPrice*=0.95;
    if(totalPrice>=price)
    {
        console.log(`She is left with ${Math.floor(totalPrice-price)} leva.`)
    }
    else
    {
        console.log(`She will have to borrow ${Math.ceil(price-totalPrice)} leva.`);
    }

}
//flowershop(['2','3','5','1','50'])
//flowershop(['15','7','5','10','100'])