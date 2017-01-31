/**
 * Created by ADMIN on 31.1.2017 г..
 */
function storeCatalogue(input){

    let letters=new Map();
    let products=new Map();

    for(let line of input){

        let [product,price]=line.split(':').map(x=>x.trim())

        let letter=product[0];

        if(!letters.has(letter)){

            letters.set(letter,new Map());
        }
        letters.get(letter).set(product,price);

    }

    let f=function (a, b) {
        return a[0].toLowerCase().localeCompare(b[0].toLowerCase())
    }

    for(let letter of Array.from(letters.keys()).sort(f)){
        console.log(letter);
        for(let [key,value] of [...letters.get(letter)].sort(f
           ))
        {
            console.log(`  ${key}: ${Number(value)}`)
        }
    }


}
/*
storeCatalogue(
    [
        'Appricot : 20.4',
        'Fridge : 1500',
        'TV : 1499',
        'Deodorant : 10',
        'Boiler : 300',
        'Apple : 1.25',
        'Anti-Bug Spray : 15',
        'T-Shirt : 10'

]
)*/
/*
storeCatalogue(
    [
        'Banana : 2',
        'Rubic\'s Cube : 5',
        'Raspberry 1pb1 : 4999',
        'Raspberry Pa : 4999',
        'Rolex : 100000',
        'Rollon : 10',
        'Rali Car : 2000000',
        'Pesho : 0.000001',
        'Barrel : 10',
        'Raspberry p : 4999',

]
)
 */