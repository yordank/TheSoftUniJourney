/**
 * Created by ADMIN on 26.1.2017 г..
 */
function spiral([rows,cols]){

    [rows,cols]=[rows,cols].map(Number);

    let count=rows*cols;

    let m=Math.min(rows,cols);

    m=(m%2==0)?m=m/2:m=(m+1)/2;

    let curRow=0;
    let curCol=rows-1;


    


    let value=1;

    for (let i = 0; i <= m-1; i++) {

        for (let j  = 0; j < cols-i; j++) {

            matrix[curRow][j]=value;
            value++;

        }

        for (let j  = 1; j < rows-i; j++) {
            matrix[j][curCol]=value;
            value++;

        }

        for (let j  = cols-2; j >=i; j--) {
            matrix[rows-1-curRow][j]=value;
            value++;

        }

        for (let j  = rows-2; j >=i+1; j--) {
            matrix[j][cols-1-curCol]=value;
            value++;

        }

        curRow++;
        curCol--;

    }
let a=5;
}

spiral(['4','4'])