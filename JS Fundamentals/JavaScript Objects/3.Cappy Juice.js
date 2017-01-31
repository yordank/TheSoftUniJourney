/**
 * Created by ADMIN on 31.1.2017 г..
 */
function cappyJuice(input){

    let map=new Map();
    let map2=new Map();

    for(let line of input){

        let [key,value]=line.split('=>').map(x=>x.trim());

        value=Number(value);

        if(map.has(key)){

            let newValue=map.get(key)+Number(value);

            map.set(key,newValue);

            if(newValue/1000>=1){
                map2.set(key,newValue/1000)
            }
        }

        else{

            map.set(key,value)

            if(value/1000>=1){
              map2.set(key,value/1000);
            }

        }

    }

    for(let key of map2.keys()){
        console.log(`${key} => ${Math.floor(map2.get(key))}`)
    }

}
/*
cappyJuice([ 'Orange => 2000',
            'Peach => 1432',
            'Banana => 450',
            'Peach => 600',
            'Strawberry => 549']
)
*/
/*
cappyJuice(
    [
        'Kiwi => 234',
        'Pear => 2345',
        'Watermelon => 3456',
        'Kiwi => 4567',
        'Pear => 5678',
        'Watermelon => 6789'

]
)
    */