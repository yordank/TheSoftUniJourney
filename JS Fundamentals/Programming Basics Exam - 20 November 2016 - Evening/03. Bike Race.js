/**
 * Created by ADMIN on 24.1.2017 г..
 */
function bikeRace([juniors,seniors,race]){

    [juniors,seniors]= [juniors,seniors].map(Number);

    let sum=0
    switch (race){
        case 'trail':sum=juniors*5.5+seniors*7;break;
        case 'cross-country':
               sum=juniors*8+seniors*9.5;
               if(juniors+seniors>=50)
                   sum=sum*0.75;
               break;
        case 'downhill':sum=juniors*12.25+seniors*13.75;break;
        case 'road':sum=juniors*20+seniors*21.5;break;

    }

    sum*=0.95;

    console.log(sum.toFixed(2));

}

//bikeRace(['20','25','cross-country'])