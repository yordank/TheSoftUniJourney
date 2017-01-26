/**
 * Created by ADMIN on 26.1.2017 г..
 */
function extract(input){

    input=input.map(Number);

    let current=input[0];

    let f=function(input) {
        let r = Number.NEGATIVE_INFINITY;
        input.forEach(x=>(x > r) ? r = x : 1);
        return r;
    }


    input=input.filter((x,y)=>x>=f(input.slice(0,y)));

    console.log(input.join('\n'))

}

//extract(['1','3','8','4','10','12','3','2','24'])

