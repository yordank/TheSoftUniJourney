/**
 * Created by ADMIN on 28.1.2017 г..
 */
function findOccurencesOfWord([sencence,word]){

    let pattern=new RegExp(`\\b${word.trim()}\\b`,'gi')

    let match=pattern.exec(sencence);
    let count=0;
    while(match){
        count++;
        match=pattern.exec(sencence);
    }

    console.log(count);
}

//findOccurencesOfWord(['The waterfall was so high, that the child couldn’t see its peak.','the'])
