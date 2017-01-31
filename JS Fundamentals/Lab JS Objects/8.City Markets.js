/**
 * Created by ADMIN on 30.1.2017 г..
 */
function cityMarket(input){


        let townsWithProducts = new Map();
        for (let sale of input) {
            let [town, product, quantityPrice] = sale.split(/\s*->\s*/);
            let [quantity, price] = quantityPrice.split(/\s*:\s*/);
            if (!townsWithProducts.has(town))
                townsWithProducts.set(town, new Map());
            let income = quantity * price;
            let oldIncome = townsWithProducts.get(town).get(product);
            if (oldIncome) income += oldIncome;
            townsWithProducts.get(town).set(product, income);
        }

        for(let town of townsWithProducts.keys() ){

            console.log(`Town - ${town}`);

            let t=townsWithProducts.get(town).keys();

            for(let s of t){
                console.log('$$$'+s+' : '+townsWithProducts.get(town).get(s))
            }


        }

}
/*
cityMarket([' Sofia -> Laptops HP -> 200 : 2000',
           ' Sofia -> Raspberry -> 200000 : 1500',
           ' Sofia -> Audi Q7 -> 200 : 100000',
           ' Montana -> Portokals -> 200000 : 1',
           ' Montana -> Qgodas -> 20000 : 0.2',
           ' Montana -> Chereshas -> 1000 : 0.3']
)
    */