/**
 * Created by ADMIN on 31.1.2017 г..
 */
function lowestPricesInCities(input){

    let productTowns=new Map();

    for(let line of input){

        let [town,product,price]=line.split('|').map(x=>x.trim());

      // console.log(town+product+price)


        if (!productTowns.has(product)) {
            productTowns.set(product, new Map());
            productTowns.get(product).set(town,Number(price));
            continue;
        }

        else
        {
             productTowns.get(product).set(town,Number(price));
        }

    }


    for(let [product,towns] of productTowns){

        //let line=product;
        let line='';

        for(let [town,price] of new Map([...towns.entries()].sort((x,y)=>x[1]>y[1]))){
            line+=`${product} -> `+price+` (${town})`;
            break;
        }

        console.log(line);

    }


}
/*
lowestPricesInCities(   ['Sample Town | Sample Product | 1000',
                        'Sample Town | Orange | 2',
                        'Sample Town | Peach | 1',
                        'Sofia | Orange | 3',
                        'Sofia | Peach | 2',
                        'New York | Sample Product | 1000.1',
                        'New York | Burger | 10']
)
*/
/*
lowestPricesInCities( [ 'Sofia City | Audi | 100000',
                       'Sofia City | BMW | 100000',
                       'Sofia City | Mitsubishi | 10000',
                       'Sofia City | Mercedes | 100000',
                       'Sofia City | NoOffenseToCarLovers | 0',
                       'Mexico City | Audi | 1000',
                       'Mexico City | BMW | 99999',
                       'New York City | Mitsubishi | 10000',
                       'New York City | Mitsubishi | 1000',
                       'Mexico City | Audi | 100000',
                       'Washington City | Mercedes | 1000']
)
    */