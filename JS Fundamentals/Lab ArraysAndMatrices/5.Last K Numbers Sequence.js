/**
 * Created by ADMIN on 25.1.2017 г..
 */
function lastKNumbersSequence(input){

    let n=Number(input[0]);
    let k=Number(input[1]);

    let array=[1];

    for (let i = 0; i < n-1; i++) {

        let p=array.slice(array.length-k,array.length);

        if(array.length<k)
            p=array.slice(0,array.length);

       let sum=p.reduce((a,b)=>a+b,0);
        array.push(sum);

    }

    console.log(array.join(' '));

}

//lastKNumbersSequence(['6','3'])