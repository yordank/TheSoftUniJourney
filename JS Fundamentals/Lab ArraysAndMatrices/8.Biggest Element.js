/**
 * Created by ADMIN on 26.1.2017 г..
 */
function biggestElements(matrixRows){

    let matrix=matrixRows.map(rows=>rows.split(' ').map(Number))
    let biggest=Number.NEGATIVE_INFINITY;

    matrix.forEach(x=>x.forEach(c=>biggest=Math.max(biggest,c)));

    console.log(biggest);


}

//biggestElements(['20 50 10','8 33 145'])

