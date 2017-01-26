/**
 * Created by ADMIN on 26.1.2017 г..
 */
function diagonalAttack(matrixRows){

    let matrix=matrixRows.map(x=>x.split(' ').map(Number));

    let sum1=0;
    let sum2=0;

    matrix.forEach((x,y)=>x.forEach((c,z)=>(y==z)?sum1+=c:1));
    matrix.forEach((x,y)=>x.forEach((c,z)=>(y==matrix.length-z-1)?sum2+=c:1));

    if(sum1==sum2){

        for(let i=0;i<matrix.length;i++){
            for(let j=0;j<matrix.length;j++){

                if(i!=j && matrix.length-1-j!=i){
                    matrix[i][j]=sum1;
                }

            }
        }

    }

    matrix.forEach(x=>console.log(x.join(' ')))


}

/*
diagonalAttack(['5 3 12 3 1',
    '11 4 23 2 5',
    '101 12 3 21 10',
    '1 4 5 2 2',
    '5 22 33 11 1']
)
*/