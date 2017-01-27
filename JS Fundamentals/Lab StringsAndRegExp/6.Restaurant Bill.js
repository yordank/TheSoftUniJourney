/**
 * Created by ADMIN on 27.1.2017 г..
 */
function restaurantBill(input){

    console.log(`You purchased ${input.filter((x,y)=>y%2==0).join(', ')} for a total sum of ${input.filter((x,y)=>y%2==1).reduce((a,b)=>Number(a)+Number(b))}`)

}

//restaurantBill(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']);