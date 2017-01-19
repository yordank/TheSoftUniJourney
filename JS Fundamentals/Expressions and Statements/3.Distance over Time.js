/**
 * Created by ADMIN on 19.1.2017 г..
 */
function distance([v1,v2,time]){

     [v1,v2,time]=[v1,v2,time].map(Number);
     let distance= Math.abs(v1-v2)*time/3600;

    console.log(distance*1000);
}

