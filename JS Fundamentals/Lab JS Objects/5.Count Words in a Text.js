/**
 * Created by ADMIN on 30.1.2017 г..
 */
function countWordsInText([input]) {

    let words=input.split(/[^A-Za-z0-9_]+/g);

    let result={};

    for(let word of words){
        if (word=='')continue;
        if(result[word])
            result[word]++;
        else
            result[word]=1;
    }

    console.log(JSON.stringify(result));

}

countWordsInText(['Far too slow, you\'re far too slow.'])