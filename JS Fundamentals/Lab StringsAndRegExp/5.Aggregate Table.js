/**
 * Created by ADMIN on 27.1.2017 г..
 */
function aggregateTable(input){

    let cities=[];
    let sum=0;
    for(let items of input){

        let item=items.split('|').map(x=>x.trim());
        cities.push(item[1]);
        sum+=Number(item[2]);
    }

    console.log(cities.join(', '))
    console.log(sum)

}

/*
aggregateTable(['| Sofia           | 300',
    '| Veliko Tarnovo  | 500',
    '| Yambol          | 275']
)
    */