/**
 * Created by ADMIN on 26.1.2017 г..
 */
function diagonals(matrixRows){

    let matrix=matrixRows.map(x=>x.split(' ').map(Number));

    let sum=0;
    let sum2=0;
    matrix.forEach((x,y)=>x.forEach((c,z)=>(y==z)?sum+=c:1));
    matrix.forEach((x,y)=>x.forEach((c,z)=>(y==matrix.length-z-1)?sum2+=c:1));

    console.log(sum+' '+sum2);



}

//diagonals(['20 40','10 60'])