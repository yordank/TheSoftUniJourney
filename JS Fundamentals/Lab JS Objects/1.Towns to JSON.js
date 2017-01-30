/**
 * Created by ADMIN on 30.1.2017 г..
 */
function townToJSON(townLines){

    let result=[];

    for(let line of townLines.slice(1)){

        let [empty,town,lat,long]=line.split('|');

        let townObj={
            Town:town.trim(),
            Latitude:Number(lat),
            Longitude:Number(long)
        }

        result.push(townObj);


    }

    result=JSON.stringify(result)

    console.log(result);

}
/*
townToJSON(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']
)

    */