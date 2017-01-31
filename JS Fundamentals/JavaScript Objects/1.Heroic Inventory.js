/**
 * Created by ADMIN on 31.1.2017 г..
 */
function heroicInventory(input){

    let  result=[];

    for(let line of input){

        let [name,level,itemsOfHeroes]=line.split('/').map(x=>x.trim());

        let obj={
                 name:name.trim(),
                 level:Number(level),
                 items:[]
                }

                 let heroesArgs=line.split('/').map(x=>x.trim());

                if(heroesArgs.length>2)
                 obj.items=itemsOfHeroes.split(',').map(x=>x.trim());

        result.push(obj)
    }

    console.log(JSON.stringify(result))

}
/*
heroicInventory(['Isacc / 25 / Apple, GravityGun',
                'Derek / 12 / BarrelVest, DestructionSword',
                'Hes / 1 / Desolator, Sentinel, Antara']
)
*/

//heroicInventory(['w/21'])