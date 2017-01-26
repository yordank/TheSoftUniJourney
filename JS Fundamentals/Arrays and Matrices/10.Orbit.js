/**
 * Created by ADMIN on 26.1.2017 г..
 */
function orbit([dim,coordinates]){

    dim=dim.split(' ').map(Number);
    coordinates=coordinates.split(' ').map(Number);

    let rows=dim[0];
    let cols=dim[1];

    let x=coordinates[0];
    let y=coordinates[1];

    let matrix=[[]];

    for (let i = 0; i < rows; i++) {
        matrix[i]=[];
    }

    for(let i=0;i<rows;i++){

        for(let j=0;j<cols;j++){

            let distX=Math.abs(i-x);
            let distY=Math.abs(j-y);

            let value=Math.max(distX,distY);

            matrix[i][j]=value+1;

        }

    }


    matrix.forEach(x=>console.log(x.join(' ')))




}
//orbit(['3 3','2 2'])