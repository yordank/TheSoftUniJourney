/**
 * Created by ADMIN on 25.1.2017 г..
 */
function roadRadar([speed,area]){

    let limit=getLimit(area);

    let output=getInfraction(speed,limit)

    if(output){
       console.log(output);
    }


    function getLimit(zone){

        switch(zone){
            case 'motorway':return 130;
            case 'city':return 50;
            case 'interstate':return 90;
            case 'residential':return 20;
        }
    }

    function getInfraction(speed,limit){

        if(speed<=limit)
            return false;
        else
        {
            if(speed-limit<=20)
                return 'speeding';
            if(speed-limit<=40)
                return 'excessive speeding';
            else
                return 'reckless driving'
        }


    }

}
//roadRadar(['40','residential'])