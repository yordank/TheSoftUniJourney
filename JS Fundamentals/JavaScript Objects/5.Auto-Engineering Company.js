/**
 * Created by ADMIN on 31.1.2017 г..
 */
function autoCompany(input){

    let carBrands=new Map();

    for(let line of input){

        let [carBrand,carModel,producedCars]=line.split('|').map(x=>x.trim());
        producedCars=Number(producedCars);

        if(!carBrands.has(carBrand)){

            carBrands.set(carBrand,new Map());
            carBrands.get(carBrand).set(carModel,producedCars);
        }

        else{

            if(carBrands.get(carBrand).has(carModel)){
                let currentProducedCars=carBrands.get(carBrand).get(carModel);
                carBrands.get(carBrand).set(carModel,producedCars+currentProducedCars);
            }

            else{
                carBrands.get(carBrand).set(carModel,producedCars);
            }

        }


    }

    for(let carBrand of carBrands.keys()){
        console.log(carBrand);

        for(let [carModel,producedCars]  of carBrands.get(carBrand)){
            console.log(`###${carModel} -> ${producedCars}`)
        }

    }


}
/*
autoCompany(
    [
       'Audi | Q7 | 1000',
       'Audi | Q6 | 100',
       'BMW | X5 | 1000',
       'BMW | X6 | 100',
       'Citroen | C4 | 123',
       'Volga | GAZ-24 | 1000000',
       'Lada | Niva | 1000000',
       'Lada | Jigula | 1000000',
       'Citroen | C4 | 22',
       'Citroen | C5 | 10'
    ]

)
*/