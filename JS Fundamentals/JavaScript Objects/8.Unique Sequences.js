/**
 * Created by ADMIN on 31.1.2017 г..
 */

function func(input) {

    let set=new Set();

    for(let line of input){

        let JSONstring = function (a) {

            return  JSON.stringify(a.sort((a,b)=>-a+b));
        }

        let a=line.split(/[\[\]]/g)

        set.add(JSONstring(Array.from(a[1].split(',').map(x=>Number(x)))));


    }


    for(let s of [...set].sort((a,b)=>a.split(',').join('').length-b.split(',').join('').length)){

        console.log(s.split(',').join('').length+' '+s.split(',').join(', '))
    }

}
/*
func(
    [
        '[-3, -2, -1, 0, 1, 2, 3, 4]',
        '[10, 1, -170, 0, 2, 13]',
        '[4, -3, 3, -2, 2, -1, 1, 0]',

        '[7.14, 7.180, 7.339, 80.099]',
        '[7.339, 80.0990, 7.140000, 7.18]',
        '[7.339, 7.180, 7.14, 80.099]'

    ]
)
    */