/**
 * Created by ADMIN on 30.1.2017 г..
 */
function population(input){
    let cities={};

    for(let line of input){

       let arr=line.split(/<->/g);
       let city=arr[0].trim();
       let population=arr[1].trim();

        if(cities[city]){
            cities[city]+=Number(population);
        }

        else
        {
            cities[city]=Number(population);
        }


    }

    for(let key of Object.keys(cities)){
        console.log(`${key} : ${cities[key]}`)
    }


}
/*
population(['Sofia <-> 1200000',
            'Montana <-> 20000',
            'New York <-> 10000000',
            'Washington <-> 2345000',
            'Las Vegas <-> 1000000'
])
    */