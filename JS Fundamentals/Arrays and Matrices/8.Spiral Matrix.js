/**
 * Created by ADMIN on 26.1.2017 г..
 */
function spiral([rowscols]){

    let [rows,cols]=rowscols.split(' ').map(Number);

    let count=rows*cols;

    let m=Math.min(rows,cols);

    m=(m%2==0)?m=m/2:m=(m+1)/2;

    let curRow=0;
    let curCol=rows-1;

    let matrix=[[]];


    for (let i = 0; i < rows; i++) {
        matrix[i]=[];

    }


    let value=1;

    for (let i = 0; i <= m-1; i++) {

        for (let j  = i; j < cols-i; j++) {

            matrix[curRow][j]=value;
            value++;

        }

        for (let j  = 1+i; j < rows-i; j++) {
            matrix[j][curCol]=value;
            value++;

        }

        for (let j  = cols-2-i; j >=i; j--) {
            matrix[rows-1-curRow][j]=value;
            value++;

        }

        for (let j  = rows-2-i; j >=i+1; j--) {
            matrix[j][cols-1-curCol]=value;
            value++;

        }

        curRow++;
        curCol--;

    }
    matrix.forEach(x=>console.log(x.join(' ')))
}

//spiral(['3 3'])