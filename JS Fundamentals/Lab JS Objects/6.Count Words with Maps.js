/**
 * Created by ADMIN on 30.1.2017 г..
 */
function countWordsWithMap([input]){

    let result=new Map();

    let words=input.split(/[^A-Za-z0-9_]+/g);

   for(let word of words.map(x=>x.toLowerCase())){

        if (word=='')continue;


       if(result.get(word)){
           result.set(word,result.get(word)+1)
       }
        else
            result.set(word,1);



    }

    for(let key of Array.from(result.keys()).sort()){
        console.log(`\'${key}\' -> ${result.get(key)} times`)
    }

}

//countWordsWithMap(['Far too slow, you\'re far too slow.'])
//countWordsWithMap(['JS devs use Node.js for server-side JS. JS devs use JS. -- JS for devs --'])