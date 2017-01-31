/**
 * Created by ADMIN on 31.1.2017 г..
 */
function usernames(input){

    let set=new Set();

    for(let name of input){
            set.add(name);
    }

    let map=new Map();
    map=set.values();

    let f1=function (a,b){

        if( a.length<b.length)
        {
            return -1;
        }

        if(a.length==b.length){

            return a.localeCompare(b);
        }

        else{
            return 1;
        }


    }

    console.log([...set].sort(f1).join('\n'))


}
/*
usernames(
[
    'Ashton',
    'Kutcher',
    'Ariel',
    'Lilly',
    'Keyden',
    'Aizen',
    'Billy',
    'Braston'
]
)
    */

/*
usernames(
    [
        'Denise',
        'Ignatius',
        'Iris',
        'Isacc',
        'Indie',
        'Dean',
        'Donatello',
        'Enfuego',
        'Benjamin',
        'Biser',
        'Bounty',
        'Renard',
        'Rot'

    ]

)
 */