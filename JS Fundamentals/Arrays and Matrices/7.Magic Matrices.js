/**
 * Created by ADMIN on 26.1.2017 г..
 */
function magicMatrices(matrixRows){

    let matrix=matrixRows.map(x=>x.split(' ').map(Number));



    let res=matrix.map(function(row, i) {
        return matrix.map(function(row) {
            return row[i]; }
        ).reduce(function(a, b) {
            return a+b;
        }, 0);
    });



    res=res.concat(
    matrix.map( function(row){
        return row.reduce(function(a,b){ return a + b; }, 0);
    }));

    if(res.filter(x=>x==res[0]).length==res.length)
        console.log(true)
    else
        console.log(false)



}

/*
magicMatrices(['4 5 6',
    '6 5 4',
    '5 5 5']
)
    */